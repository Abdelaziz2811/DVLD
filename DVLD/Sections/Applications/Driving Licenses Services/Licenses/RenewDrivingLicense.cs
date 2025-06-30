using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    public partial class RenewDrivingLicense : Form
    {
        clsApplications_BLL RenewalApplication;
        clsLicense_BLL License;
        clsPerson_BLL Person;

        public RenewDrivingLicense()
        {
            InitializeComponent();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text != "----")
            {
                if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                {
                    TC_LicenseApplication.SelectedIndex = 1;
                }
                else
                    MessageBox.Show($"The current License didn't expired yet, The expiration date is {UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Please select a License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TC_LicenseApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_LicenseApplication.SelectedTab.Text == "Application Info")
            {
                if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) > DateTime.Now)
                    {
                        TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                        MessageBox.Show($"The current License didn't expired yet, The expiration date is {UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Create International Application
                        RenewalApplication = new clsApplications_BLL();
                        SetApplicationInfo();

                        // Create International License
                        License = new clsLicense_BLL();
                        SetLicenseInfo_ToView();
                        LoadApplicationInfo();
                    }
                }
            }
        }

        void SetApplicationInfo()
        {
            Person = clsPerson_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_NationalNo.Text);
            RenewalApplication.ApplicantPersonID = Person.PersonID;
            RenewalApplication.ApplicationTypeID = 2;
            RenewalApplication.PaidFees = clsApplicationTypes_BLL.Find(2).ApplicationFees;
            RenewalApplication.ApplicationStatus = enApplicationStatus.Completed;
            RenewalApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        private void BTN_Renew_Click(object sender, EventArgs e)
        {
            if (RenewalApplication.Save())
            {
                SetLicenseInfo_ToSave();
                if (License.Save())
                {
                    MessageBox.Show("License Renewed successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLicenseInfo();
                    DisactiveExpiredLicense();
                    BTN_LicenseInfo.Enabled = true;
                }
            }
        }

        void SetLicenseInfo_ToView()
        {
            clsLicenseClasses_BLL LicenseClass = clsLicenseClasses_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_Class.Text);
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            License.LicenseClass = LicenseClass.LicenseClassID;
            License.PaidFees = LicenseClass.ClassFees;
            License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void LoadApplicationInfo()
        {
            LB_ApplicationDate.Text = RenewalApplication.ApplicationDate.ToString("d");
            LB_IssueDate.Text = License.IssueDate.ToString("d");
            LB_ApplicationFees.Text = RenewalApplication.PaidFees.ToString();
            LB_LicenseFees.Text = License.PaidFees.ToString("F");
            LB_ExpiredLicenseID.Text = UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text;
            LB_ExpirationDate.Text = License.ExpirationDate.ToString("d");
            LB_CreatedBy.Text = License.CreatedByUserID.ToString();
            LB_TotalFees.Text = (RenewalApplication.PaidFees + License.PaidFees).ToString("F");
        }

        void SetLicenseInfo_ToSave()
        {
            License.ApplicationID = RenewalApplication.ApplicationID;
            License.DriverID = int.Parse(UC_LicenseSelector.UC_LicenseInfo.LB_DriverID.Text);
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_Class.Text).DefaultValidityLength); ;
            License.IsActive = true;
            License.IssueReason = enIssueReason.Renew;
            License.Notes = TB_Notes.Text;
        }

        void LoadLicenseInfo()
        {
            LB_RAppID.Text = RenewalApplication.ApplicationID.ToString();
            LB_RenewedLicenseID.Text = License.LicenseID.ToString();
        }

        void DisactiveExpiredLicense()
        {
            clsLicense_BLL ExpiredLicense = clsLicense_BLL.FindByLicenseID(Convert.ToInt32(LB_ExpiredLicenseID.Text));
            if (ExpiredLicense != null)
            {
                ExpiredLicense.IsActive = false;
                ExpiredLicense.Save();
            }
        }

        private void BTN_LicenseInfo_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(RenewalApplication.ApplicationID);
            LicenseInfo licenseInfo = new LicenseInfo(LocalLicenseApplication);
            licenseInfo.ShowDialog();
        }
    }
}
