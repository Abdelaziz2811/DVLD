using DVLD.Sections.Applications.Manage_Applications.Local_License_Applications;
using DVLD.User_Controls.Applications_Section;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.Drivers;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    public partial class IssueLicense_FirstTime : Form
    {
        clsLocalLicenseApplication_BLL LocalLicenseApplication;
        clsApplications_BLL Application;
        clsPerson_BLL Person;
        public IssueLicense_FirstTime(ref clsLocalLicenseApplication_BLL LocalLicenseApplication)
        {
            InitializeComponent();
            this.LocalLicenseApplication = LocalLicenseApplication;
            this.Application = clsApplications_BLL.Find(clsLocalLicenseApplication_BLL.Find(LocalLicenseApplication.LocalDrivingLicenseApplicationID).ApplicationID);
            this.Person = clsPerson_BLL.Find(Application.ApplicantPersonID);
        }

        private void IssueLicense_FirstTime_Load(object sender, EventArgs e)
        {
            LoadLocalLicenseApplicationInfo();
        }

        void LoadLocalLicenseApplicationInfo()
        {
            UC_LicenseApplicationInfo.LB_LDLAppID.Text = LocalLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            UC_LicenseApplicationInfo.LB_PassedTest.Text = LocalLicenseApplication.PassedTestCount.ToString() + "/3";
            UC_LicenseApplicationInfo.LB_LicenseClass.Text = LocalLicenseApplication.ClassName;

            UC_LicenseApplicationInfo.LB_ApplicationID.Text = Application.ApplicationID.ToString();
            UC_LicenseApplicationInfo.LB_ApplicationStatus.Text = Application.ApplicationStatus.ToString();
            UC_LicenseApplicationInfo.LB_ApplicationFees.Text = Application.PaidFees.ToString("C2");
            UC_LicenseApplicationInfo.LB_ApplicationType.Text = clsApplicationTypes_BLL.Find(Application.ApplicationTypeID).ApplicationTypeTitle;

            UC_LicenseApplicationInfo.LB_ApplicantName.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            UC_LicenseApplicationInfo.LB_ApplicationDate.Text = Application.ApplicationDate.ToString("MM/dd/yyyy");
            UC_LicenseApplicationInfo.LB_LastStatusDate.Text = Application.LastStatusDate.ToString("MM/dd/yyyy");
            UC_LicenseApplicationInfo.LB_CreatedBy.Text = Application.CreatedByUserID.ToString();
        }

        private void BTN_Issue_Click(object sender, EventArgs e)
        {
            clsDrivers_BLL Driver;
            if (!clsDrivers_BLL.IsExists(Person.PersonID))
            {
                Driver = new clsDrivers_BLL();
                SetDriverInfo(ref Driver);
                Driver.Save();
            }
            else
                Driver = clsDrivers_BLL.FindByPersonID(Person.PersonID);

            clsLicense_BLL License = new clsLicense_BLL();
            SetLicenseInfo(ref License, Driver);
            if (License.Save())
            {
                Application.ApplicationStatus = enApplicationStatus.Completed;
                Application.Save();

                MessageBox.Show($"The License is issued with LicenseID : {License.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        void SetDriverInfo(ref clsDrivers_BLL Driver)
        {
            Driver.PersonID = Application.ApplicantPersonID;
            Driver.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            Driver.CreatedDate = DateTime.Now;
        }

        void SetLicenseInfo(ref clsLicense_BLL License, clsDrivers_BLL Driver)
        {
            clsLicenseClasses_BLL LicenseClass = clsLicenseClasses_BLL.Find(UC_LicenseApplicationInfo.LB_LicenseClass.Text);
            License.ApplicationID = Application.ApplicationID;
            License.DriverID = Driver.DriverID;
            License.LicenseClass = (byte)LicenseClass.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            License.Notes = LB_Notes.Text;
            License.PaidFees = LicenseClass.ClassFees;
            License.IsActive = true;
            License.IssueReason = enIssueReason.First_Time;
            License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

    }
}
