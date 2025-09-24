using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    public partial class ReplaceDrivingLicense : Form
    {
        clsApplication_BLL ReplaceApplication;
        clsLicense_BLL License;
        clsPerson_BLL Person;

        public ReplaceDrivingLicense()
        {
            InitializeComponent();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                MessageBox.Show($"The current License cannot be replaced, It is expired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
                MessageBox.Show($"The current License cannot be replaced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                TC_LicenseApplication.SelectedIndex = 1;
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
                else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be replaced, It is expired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be replaced", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Create International Application
                    ReplaceApplication = new clsApplication_BLL();
                    SetApplicationInfo();

                    // Create International License
                    License = new clsLicense_BLL();
                    LoadApplicationInfo();

                    Enable_DisableButton(BTN_Replace, true);
                    Enable_DisableButton(BTN_LicenseInfo, false);
                }
            }
        }

        void SetApplicationInfo()
        {
            Person = clsPerson_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_NationalNo.Text);
            ReplaceApplication.ApplicantPersonID = Person.PersonID;

            if (RB_DamagedLicense.Checked)
            {
                ReplaceApplication.PaidFees = clsApplicationType_BLL.Find(4).ApplicationFees;
                ReplaceApplication.ApplicationTypeID = 4;
            }
            else
            {
                ReplaceApplication.PaidFees = clsApplicationType_BLL.Find(3).ApplicationFees;
                ReplaceApplication.ApplicationTypeID = 3;
            }
            ReplaceApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        private void BTN_Replace_Click(object sender, EventArgs e)
        {
            SetApplicationInfo_ToSave();
            if (ReplaceApplication.Save())
            {
                SetLicenseInfo();
                if (License.Save())
                {              
                    MessageBox.Show("License Replaced successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetControlsProperties();
                    LoadLicenseInfo();
                    DisactiveOldLicense();
                    UC_LicenseSelector.UC_LicenseInfo.LoadLicenseInfo(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text));
                }
            }
        }

        void SetApplicationInfo_ToSave()
        {
            ReplaceApplication.ApplicationStatus = enApplicationStatus.Completed;
        }

        void SetLicenseInfo()
        {
            License = clsLicense_BLL.FindByLicenseID(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text));
            License.ApplicationID = ReplaceApplication.ApplicationID;
            License.LicenseID = 0;

            if (RB_DamagedLicense.Checked)
                License.IssueReason = enIssueReason.Replace_For_Damaged;
            else
                License.IssueReason = enIssueReason.Replace_For_Lost;

            License.Mode = enLicenseMode.Add;
            if (License.Notes == null)
                License.Notes = string.Empty;

            License.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void SetControlsProperties()
        {
            Enable_DisableButton(BTN_Replace, false);
            Enable_DisableButton(BTN_LicenseInfo, true);
        }

        void Enable_DisableButton(Button ButtonName, bool EnabledValue)
        {
            ButtonName.Enabled = EnabledValue;
        }

        void LoadApplicationInfo()
        {
            LB_ApplicationDate.Text = ReplaceApplication.ApplicationDate.ToString("d");
            LB_ApplicationFees.Text = ReplaceApplication.PaidFees.ToString();
            LB_OldLicenseID.Text = UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text;
            LB_CreatedBy.Text = ReplaceApplication.CreatedByUserID.ToString();
        }

        void LoadLicenseInfo()
        {
            LB_RAppID.Text = ReplaceApplication.ApplicationID.ToString();
            LB_ReplacedLicenseID.Text = License.LicenseID.ToString();
        }

        void DisactiveOldLicense()
        {
            clsLicense_BLL OldLicense = clsLicense_BLL.FindByLicenseID(Convert.ToInt32(LB_OldLicenseID.Text));
            if (OldLicense != null)
            {
                OldLicense.IsActive = false;
                OldLicense.Save();
            }
        }

        private void RB_DamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_DamagedLicense.Checked)
                LB_Operation.Text = "Replace Driving License Application (Damaged License)";
            else
                LB_Operation.Text = "Replace Driving License Application (Lost License)";
        }

        private void BTN_LicenseInfo_Click(object sender, EventArgs e)
        {
            clsLicense_BLL License = clsLicense_BLL.FindByLicenseID(Convert.ToInt32(LB_ReplacedLicenseID.Text));
            LicenseInfo licenseInfo = new LicenseInfo(License);
            licenseInfo.ShowDialog();
        }
    }
}
