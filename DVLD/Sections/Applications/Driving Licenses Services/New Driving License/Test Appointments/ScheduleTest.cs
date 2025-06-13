using DVLD.Properties;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments;
using DVLD.User_Controls.Applications_Section;
using DVLD.User_Controls.Applications_Section.Tests;
using DVLD_BLL;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Tests
{
    public partial class ScheduleTest : Form
    {
        UC_LicenseApplicationInfo LicenseApplicationInfo;
        enTestType TestType;
        clsTestAppointments_BLL TestAppointments;
        public ScheduleTest(UC_LicenseApplicationInfo LicenseApplicationInfo, enTestType TestType, clsTestAppointments_BLL TestAppointments)
        {
            InitializeComponent();

            this.LicenseApplicationInfo = LicenseApplicationInfo;
            this.TestType = TestType;
            this.TestAppointments = TestAppointments;
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            SetDTPMinDate();
            ApplyTestType();
            LoadTestAppointmentInfo();
            SetFormOperation();
        }

        void SetDTPMinDate()
        {
            UC_ScheduleTest.DTP_TestAppointment.MinDate = DateTime.Now;
        }

        void LoadTestAppointmentInfo()
        {
            UC_ScheduleTest.LB_DLAppID.Text = LicenseApplicationInfo.LB_LDLAppID.Text;
            UC_ScheduleTest.LB_LicenseClass.Text = LicenseApplicationInfo.LB_LicenseClass.Text;
            UC_ScheduleTest.LB_Name.Text = LicenseApplicationInfo.LB_ApplicantName.Text;
            UC_ScheduleTest.LB_Trial.Text = clsTestAppointments_BLL.TrialCount(TestType, Convert.ToInt32(LicenseApplicationInfo.LB_LDLAppID.Text)).ToString();
            UC_ScheduleTest.LB_Fees.Text = clsTestTypes_BLL.Find(Convert.ToInt32(TestType)).TestTypeFees.ToString();

            if (Convert.ToInt16(UC_ScheduleTest.LB_Trial.Text) > 0)
                UC_ScheduleTest.LB_RetakeAppFees.Text = clsApplicationTypes_BLL.Find("Retake Test").ApplicationFees.ToString();

            UC_ScheduleTest.LB_TotalFees.Text = (Convert.ToInt16(UC_ScheduleTest.LB_Fees.Text) + Convert.ToInt16(UC_ScheduleTest.LB_RetakeAppFees.Text)).ToString();
        }

        void ApplyTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    UC_ScheduleTest.GB_TestInfo.Text = "Vision Test";
                    UC_ScheduleTest.PB_TestImage.Image = Resources.VisionTest;
                    break;
                case enTestType.WrittenTest:
                    UC_ScheduleTest.GB_TestInfo.Text = "Written Test";
                    UC_ScheduleTest.PB_TestImage.Image = Resources.WrittenTest;
                    break;
                case enTestType.StreetTest:
                    UC_ScheduleTest.GB_TestInfo.Text = "Street Test";
                    UC_ScheduleTest.PB_TestImage.Image = Resources.StreetTest;
                    break;
            }
        }

        void SetFormOperation()
        {
            if (TestAppointments.Mode == enTestAppointmentMode.Add && Convert.ToInt32(UC_ScheduleTest.LB_Trial.Text) > 0)
            {
                UC_ScheduleTest.LB_Operation.Text = "Schedule Retake Test";
                UC_ScheduleTest.LB_Operation.Location = new Point(230, -4);
                UC_ScheduleTest.GB_RetakeTestInfo.Enabled = true;
            }

            if (TestAppointments.Mode == enTestAppointmentMode.Update && !TestAppointments.IsLocked)
            {
                UC_ScheduleTest.LB_Operation.Text = "Update Test Appointment";
                UC_ScheduleTest.LB_Operation.Location = new Point(212, -4);
            }

            if (TestAppointments.Mode == enTestAppointmentMode.Update && TestAppointments.IsLocked)
            {
                UC_ScheduleTest.LB_Operation.Text = "Scheduled Test";
                UC_ScheduleTest.LB_Operation.Location = new Point(212, -4);
                UC_ScheduleTest.DTP_TestAppointment.Enabled = false;
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            SetTestAppointmentsInfo();
            if (TestAppointments.Save())
            {
                if (TestAppointments.Mode == enTestAppointmentMode.Add)
                {
                    MessageBox.Show("Test appointment has been added successfully", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Test appointment has been updated successfully", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
                MessageBox.Show("Something went wrong, Test appointment hasn't been added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void SetTestAppointmentsInfo()
        {
            TestAppointments.TestTypeID = (int)TestType;
            TestAppointments.LocalDrivingLicenseApplicationID = Convert.ToInt32(LicenseApplicationInfo.LB_LDLAppID.Text);
            TestAppointments.AppointmentDate = UC_ScheduleTest.DTP_TestAppointment.Value;
            TestAppointments.PaidFees = Convert.ToDecimal(UC_ScheduleTest.LB_TotalFees.Text);
            TestAppointments.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }
    }
}
