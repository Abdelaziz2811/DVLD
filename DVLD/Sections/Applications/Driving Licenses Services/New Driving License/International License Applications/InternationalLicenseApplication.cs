using DVLD.Sections.Applications.Driving_Licenses_Services.Licenses;
using DVLD.User_Controls;
using DVLD.User_Controls.Applications_Section.Local_License;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.Licenses;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.International_License_Applications
{
    public partial class InternationalLicenseApplication : Form
    {
        clsApplications_BLL InternationalApplication;
        clsInternationalLicense_BLL InternationalLicense;
        clsPerson_BLL Person;
        public InternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text != "----")
                TC_InternationalLicenseApplication.SelectedIndex = 1;
        }

        private void TC_InternationalLicenseApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_InternationalLicenseApplication.SelectedTab.Text == "Application Info")
            {
                if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                {
                    TC_InternationalLicenseApplication.SelectedTab = TP_LocalLicenseInfo;
                    MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Create International Application
                    InternationalApplication = new clsApplications_BLL();
                    SetInternationalApplicationInfo();
                    
                    // Create International License
                    InternationalLicense = new clsInternationalLicense_BLL();
                    SetInternationalLicenseInfo_ToView();
                    LoadApplicationInfo();
                }
            }
        }

        void SetInternationalApplicationInfo()
        {
            Person = clsPerson_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_NationalNo.Text);
            InternationalApplication.ApplicantPersonID = Person.PersonID;
            InternationalApplication.ApplicationTypeID = 6;
            InternationalApplication.PaidFees = clsApplicationTypes_BLL.Find(6).ApplicationFees;
            InternationalApplication.ApplicationStatus = enApplicationStatus.Completed;
            InternationalApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        private void BTN_Issue_Click(object sender, EventArgs e)
        {
            if (!clsInternationalLicense_BLL.Exists(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text),
                clsLicenseClasses_BLL.GetLicenseClassID(UC_LicenseSelector.UC_LicenseInfo.LB_Class.Text)))
            {
                if (InternationalApplication.Save())
                {
                    SetInternationalLicenseInfo_ToSave();
                    if (InternationalLicense.Save())
                    {
                        MessageBox.Show("International License Saved successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInternationalLicenseInfo();
                        BTN_InternationalLicenseInfo.Enabled = true;
                    }
                }
            }
            else
                MessageBox.Show("The International License with the current class already exists", "I.License Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void SetInternationalLicenseInfo_ToView()
        {
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_Class.Text).DefaultValidityLength);
            InternationalLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void LoadApplicationInfo()
        {
            LB_ApplicationDate.Text = InternationalApplication.ApplicationDate.ToString("d");
            LB_IssueDate.Text = InternationalLicense.IssueDate.ToString("d");
            LB_ApplicationFees.Text = InternationalApplication.PaidFees.ToString();
            LB_LLicenseID.Text = UC_LicenseSelector.UC_LicenseInfo.License.LicenseID.ToString();
            LB_ExpirationDate.Text = InternationalLicense.ExpirationDate.ToString("d");
            LB_CreatedBy.Text = InternationalLicense.CreatedByUserID.ToString();
        }

        void SetInternationalLicenseInfo_ToSave()
        {
            InternationalLicense.ApplicationID = InternationalApplication.ApplicationID;
            InternationalLicense.DriverID = int.Parse(UC_LicenseSelector.UC_LicenseInfo.LB_DriverID.Text);
            InternationalLicense.IssuedUsingLocalLicenseID = int.Parse(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text);
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_Class.Text).DefaultValidityLength); ;
            InternationalLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void LoadInternationalLicenseInfo()
        {
            LB_ILAppID.Text = InternationalApplication.ApplicationID.ToString();
            LB_ILicenseID.Text = InternationalLicense.InternationalLicenseID.ToString(); 
        }

        private void BTN_InternationalLicenseInfo_Click(object sender, EventArgs e)
        {
            InternationalLicenseInfo internationalLicenseInfo = new InternationalLicenseInfo(InternationalLicense, Person);
            internationalLicenseInfo.ShowDialog();
        }
    }
}
