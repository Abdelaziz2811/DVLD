using DVLD.User_Controls.Applications_Section;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.License_Classes;
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
    public partial class VisionTestAppointments : Form
    {
        clsLocalLicenseApplication_BLL LocalLicenseApplication;
        clsApplications_BLL Application;
        public VisionTestAppointments(clsLocalLicenseApplication_BLL LocalLicenseApplication)
        {
            InitializeComponent();
            
            this.LocalLicenseApplication = LocalLicenseApplication;
            this.Application = clsApplications_BLL.Find(clsLocalLicenseApplication_BLL.Find(LocalLicenseApplication.LocalDrivingLicenseApplicationID).ApplicationID);
        }

        private void VisionTestVisionTestAppointments_Load(object sender, EventArgs e)
        {
            LoadLocalLicenseApplicationInfo();
            LoadTestAppointments();
        }

        void LoadLocalLicenseApplicationInfo()
        {
            UC_LicenseApplicationInfo.LB_DLAppID.Text = LocalLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
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

        void LoadTestAppointments()
        {
            //DGV_TestAppointments.DataSource = clsTestAppointments.TestsAppointmentsRecords();
        }
    }
}
