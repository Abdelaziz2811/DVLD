using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Tests;
using DVLD.User_Controls.Applications_Section;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.Applications.TestAppointments;
using DVLD_BLL.License_Classes;
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
    public partial class TestAppointments : Form
    {
        clsLocalLicenseApplication_BLL LocalLicenseApplication;
        clsApplications_BLL Application;
        enTestType TestType;
        public TestAppointments(clsLocalLicenseApplication_BLL LocalLicenseApplication, enTestType TestType)
        {
            InitializeComponent();
            
            this.LocalLicenseApplication = LocalLicenseApplication;
            this.Application = clsApplications_BLL.Find(clsLocalLicenseApplication_BLL.Find(LocalLicenseApplication.LocalDrivingLicenseApplicationID).ApplicationID);
            this.TestType = TestType;
        }

        private void VisionTestVisionTestAppointments_Load(object sender, EventArgs e)
        {
            LoadLocalLicenseApplicationInfo();
            LoadTestAppointments();
            TestAppointmentsCount();
        }

        void LoadTestAppointments()
        {
            DGV_TestAppointments.DataSource = clsTestAppointments_BLL.LoadTestAppointments(enTestType.VisionTest, LocalLicenseApplication.LocalDrivingLicenseApplicationID);
        }

        void TestAppointmentsCount()
        {
            LB_RecordsCount.Text = DGV_TestAppointments.RowCount.ToString();
        }

        void RefreshTestAppointments()
        {
            LoadTestAppointments();
            TestAppointmentsCount();
        }

        void LoadLocalLicenseApplicationInfo()
        {
            SetTestType();

            UC_LicenseApplicationInfo.LB_LDLAppID.Text = LocalLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            UC_LicenseApplicationInfo.LB_PassedTest.Text = LocalLicenseApplication.PassedTestCount.ToString() + "/3";
            UC_LicenseApplicationInfo.LB_LicenseClass.Text = LocalLicenseApplication.ClassName;

            UC_LicenseApplicationInfo.LB_ApplicationID.Text = Application.ApplicationID.ToString();
            UC_LicenseApplicationInfo.LB_ApplicationStatus.Text = Application.ApplicationStatus.ToString();
            UC_LicenseApplicationInfo.LB_ApplicationFees.Text = Application.PaidFees.ToString();
            UC_LicenseApplicationInfo.LB_ApplicationType.Text = clsApplicationTypes_BLL.Find(Application.ApplicationTypeID).ApplicationTypeTitle;
            
            clsPerson_BLL Person = clsPerson_BLL.Find(Application.ApplicantPersonID);

            UC_LicenseApplicationInfo.LB_ApplicantName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            UC_LicenseApplicationInfo.LB_ApplicationDate.Text = Application.ApplicationDate.ToString("MM/dd/yyyy");
            UC_LicenseApplicationInfo.LB_LastStatusDate.Text = Application.LastStatusDate.ToString("MM/dd/yyyy");
            UC_LicenseApplicationInfo.LB_CreatedBy.Text = Application.CreatedByUserID.ToString();
        }

        void SetTestType()
        {
            switch (TestType)
            {
                case enTestType.VisionTest:
                    LB_TestType.Text = "Vision Test Appointments";
                    break;
                case enTestType.WrittenTest:
                    LB_TestType.Text = "Written Test Appointments";
                    break;
                case enTestType.StreetTest:
                    LB_TestType.Text = "Street Test Appointments";
                    break;
            }
        }

        private void BTN_ScheduleAppointment_Click(object sender, EventArgs e)
        {
            if (clsTestAppointments_BLL.Exists(TestType, LocalLicenseApplication.LocalDrivingLicenseApplicationID))
                MessageBox.Show("The current Driving License Application has an active Test Appointment, you can't schedule another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                clsTestAppointments_BLL TestAppointments = new clsTestAppointments_BLL();
                ScheduleTest scheduleTest = new ScheduleTest(UC_LicenseApplicationInfo, TestType, TestAppointments);
                scheduleTest.ShowDialog();
                RefreshTestAppointments();
            }
        }

        private void TSMI_UpdateTestAppointment_Click(object sender, EventArgs e)
        {
            clsTestAppointments_BLL TestAppointments = clsTestAppointments_BLL.Find(Convert.ToInt32(DGV_TestAppointments.CurrentRow.Cells[0].Value));
            if (TestAppointments != null)
            {
                if (TestAppointments.IsLocked)
                    MessageBox.Show("You can't update the current appointment it's locked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ScheduleTest scheduleTest = new ScheduleTest(UC_LicenseApplicationInfo, TestType, TestAppointments);
                    scheduleTest.ShowDialog();
                    RefreshTestAppointments();
                }
            }
            else
            {
                MessageBox.Show("Test appointment doesn't exists", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshTestAppointments();
            }
        }

        private void TSMI_TakeTest_Click(object sender, EventArgs e)
        {

        }
    }
}
