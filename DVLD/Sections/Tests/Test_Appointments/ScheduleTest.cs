using DVLD.Properties;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments;
using DVLD.Sections.Applications.Manage_Applications.Local_License_Applications;
using DVLD.User_Controls.Applications_Section;
using DVLD.User_Controls.Applications_Section.Tests;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.LocalLicenseApplication;
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
        UC_LicenseApplicationInfo LicenseApplication;
        enTestType TestType;
        clsTestAppointment_BLL TestAppointments;
        public ScheduleTest(UC_LicenseApplicationInfo LicenseApplicationInfo, enTestType TestType, ref clsTestAppointment_BLL TestAppointments)
        {
            InitializeComponent();

            this.LicenseApplication = LicenseApplicationInfo;
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
            switch (TestType)
            {
                case enTestType.VisionTest:
                    UC_ScheduleTest.DTP_TestAppointment.MinDate = Convert.ToDateTime(LicenseApplication.LB_ApplicationDate.Text).AddDays(2);
                    break;
                case enTestType.WrittenTest:
                    UC_ScheduleTest.DTP_TestAppointment.MinDate = clsTestAppointment_BLL.TestAppointmentDate(Convert.ToInt32(LicenseApplication.LB_LDLAppID.Text), enTestType.VisionTest).AddDays(5);
                    break;
                case enTestType.StreetTest:
                    UC_ScheduleTest.DTP_TestAppointment.MinDate = clsTestAppointment_BLL.TestAppointmentDate(Convert.ToInt32(LicenseApplication.LB_LDLAppID.Text), enTestType.WrittenTest).AddDays(10);
                    break;
            }
        }

        void LoadTestAppointmentInfo()
        {
            UC_ScheduleTest.LB_DLAppID.Text = LicenseApplication.LB_LDLAppID.Text;
            UC_ScheduleTest.LB_LicenseClass.Text = LicenseApplication.LB_LicenseClass.Text;
            UC_ScheduleTest.LB_Name.Text = LicenseApplication.LB_ApplicantName.Text;
            UC_ScheduleTest.LB_Trial.Text = clsTestAppointment_BLL.TrialCount(TestType, Convert.ToInt32(LicenseApplication.LB_LDLAppID.Text)).ToString();
            UC_ScheduleTest.LB_Fees.Text = clsTestType_BLL.Find(Convert.ToInt32(TestType)).TestTypeFees.ToString();

            if (Convert.ToInt16(UC_ScheduleTest.LB_Trial.Text) > 0)
                UC_ScheduleTest.LB_RetakeAppFees.Text = clsApplicationType_BLL.Find("Retake Test").ApplicationFees.ToString();

            UC_ScheduleTest.LB_TotalFees.Text = (Convert.ToInt32(UC_ScheduleTest.LB_Fees.Text) + Convert.ToInt32(UC_ScheduleTest.LB_RetakeAppFees.Text)).ToString();
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
            if (Convert.ToInt32(UC_ScheduleTest.LB_Trial.Text) > 0)
            {
                UC_ScheduleTest.LB_Operation.Text = "Schedule Retake Test";
                UC_ScheduleTest.LB_Operation.Location = new Point(230, -4);
                UC_ScheduleTest.GB_RetakeTestInfo.Enabled = true;
            }

            if (TestAppointments.Mode == enTestAppointmentMode.Update && !TestAppointments.IsLocked)
            {
                UC_ScheduleTest.LB_Operation.Text = "Update Test Appointment";
                UC_ScheduleTest.LB_Operation.Location = new Point(212, -4);
                UC_ScheduleTest.DTP_TestAppointment.Value = TestAppointments.AppointmentDate;
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (clsTestAppointment_BLL.TrialCount(TestType, Convert.ToInt32(LicenseApplication.LB_LDLAppID.Text)) > 0)
            {
                clsApplication_BLL RetakeTestApplication = new clsApplication_BLL();
                SetRetakeTestApplicationInfo(ref RetakeTestApplication);
                
                if (!RetakeTestApplication.Save())
                    MessageBox.Show("The current applicant can't retake this test, Try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TestAppointments.RetakeTestApplicationID = RetakeTestApplication.ApplicationID;
            }

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

        void SetRetakeTestApplicationInfo(ref clsApplication_BLL RetakeTestApplication)
        {
            clsApplication_BLL Application = clsApplication_BLL.Find(Convert.ToInt32(LicenseApplication.LB_ApplicationID.Text));

            RetakeTestApplication.ApplicantPersonID = Application.ApplicantPersonID;

            RetakeTestApplication.ApplicationTypeID = 7;
            RetakeTestApplication.PaidFees = clsApplicationType_BLL.Find(7).ApplicationFees;
            RetakeTestApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void SetTestAppointmentsInfo()
        {
            TestAppointments.TestTypeID = (int)TestType;
            TestAppointments.LocalDrivingLicenseApplicationID = Convert.ToInt32(LicenseApplication.LB_LDLAppID.Text);
            TestAppointments.AppointmentDate = UC_ScheduleTest.DTP_TestAppointment.Value;
            TestAppointments.PaidFees = Convert.ToDecimal(UC_ScheduleTest.LB_TotalFees.Text);
            TestAppointments.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }
    }
}
