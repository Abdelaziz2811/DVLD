using DVLD.Properties;
using DVLD.User_Controls.Applications_Section;
using DVLD.User_Controls.Applications_Section.Tests;
using DVLD_BLL.Applications.TestAppointments;
using DVLD_BLL.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments
{
    public partial class TakeTest : Form
    {
        UC_LicenseApplicationInfo LicenseApplicationInfo;
        enTestType TestType; 
        clsTestAppointments_BLL TestAppointments;

        clsTests_BLL Test = new clsTests_BLL();

        public TakeTest(UC_LicenseApplicationInfo LicenseApplicationInfo, enTestType TestType, clsTestAppointments_BLL TestAppointments)
        {
            InitializeComponent();

            this.LicenseApplicationInfo = LicenseApplicationInfo;
            this.TestType = TestType;
            this.TestAppointments = TestAppointments;
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            LoadTestAppointmentInfo();
        }

        void LoadTestAppointmentInfo()
        {
            GetTestType();
            UC_TestDetails.LB_DLAppID.Text = LicenseApplicationInfo.LB_LDLAppID.Text;
            UC_TestDetails.LB_LicenseClass.Text = LicenseApplicationInfo.LB_LicenseClass.Text;
            UC_TestDetails.LB_Name.Text = LicenseApplicationInfo.LB_ApplicantName.Text;
            UC_TestDetails.LB_Trial.Text = clsTestAppointments_BLL.TrialCount(TestType, Convert.ToInt32(LicenseApplicationInfo.LB_LDLAppID.Text)).ToString();
            UC_TestDetails.LB_Fees.Text = TestAppointments.PaidFees.ToString("C2");
            UC_TestDetails.LB_AppointmentDate.Text = TestAppointments.AppointmentDate.ToString("d");
        }

        void GetTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    UC_TestDetails.GB_TestInfo.Text = "Vision Test";
                    UC_TestDetails.PB_TestImage.Image = Resources.VisionTest;
                    break;
                case enTestType.WrittenTest:
                    UC_TestDetails.GB_TestInfo.Text = "Written Test";
                    UC_TestDetails.PB_TestImage.Image = Resources.WrittenTest;
                    break;
                case enTestType.StreetTest:
                    UC_TestDetails.GB_TestInfo.Text = "Street Test";
                    UC_TestDetails.PB_TestImage.Image = Resources.StreetTest;
                    break;
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            SetTestInfo();
            SetTestAppointmentAsLocked();
            if (MessageBox.Show("Are you sure you want to save the test details", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (TestAppointments.Save() && Test.Save())
                {
                    MessageBox.Show("Test Detials has been saved seccessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Test Details hasn't been saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SetTestInfo()
        {
            Test.TestAppointmentID = TestAppointments.TestAppointmentID;
            
            if (RB_Pass.Checked)
                Test.TestResult = true;
            else Test.TestResult = false;

            Test.Notes = TB_Notes.Text;
            Test.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void SetTestAppointmentAsLocked()
        {
            TestAppointments.IsLocked = true;
        }
    }
}