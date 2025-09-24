using DVLD.Sections.Applications.Driving_Licenses_Services.Detained_Licenses;
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
    public partial class ReleaseLicense : Form
    {
        clsApplication_BLL ReleaseApplication;
        clsDetainedLicense_BLL DetainedLicense;

        public ReleaseLicense()
        {
            InitializeComponent();
        }

        public void BTN_Next_Click(object sender, EventArgs e)
        {
            if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
            {
                TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
            {
                TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                MessageBox.Show($"The current License cannot be released, It is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
            {
                TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                MessageBox.Show($"The current License cannot be released, It is expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!clsDetainedLicense_BLL.IsDetained(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text)))
            {
                TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                MessageBox.Show($"The License cannot be released, It is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                TC_ReleaseLicense.SelectedIndex = 1;
        }

        private void TC_ReleaseLicense_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_ReleaseLicense.SelectedTab.Text == "Release Info")
            {
                if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                {
                    TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                {
                    TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be released, It is expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
                {
                    TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be detain, It is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!clsDetainedLicense_BLL.IsDetained(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text)))
                {
                    TC_ReleaseLicense.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The License cannot be released, It is not detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ReleaseApplication = new clsApplication_BLL();
                    SetApplicationInfo();

                    DetainedLicense = clsDetainedLicense_BLL.Find(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text));
                    LoadDetainedLicenseInfo();

                    Enable_DisableButton(BTN_Release, true);
                }
            }
        }

        void SetApplicationInfo()
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(UC_LicenseSelector.UC_LicenseInfo.LB_NationalNo.Text);
            ReleaseApplication.ApplicantPersonID = Person.PersonID;
            ReleaseApplication.ApplicationTypeID = 5;
            ReleaseApplication.PaidFees = clsApplicationType_BLL.Find(5).ApplicationFees;
            ReleaseApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void LoadDetainedLicenseInfo()
        {
            LB_DetainID.Text = DetainedLicense.DetainID.ToString();
            LB_LicenseID.Text = DetainedLicense.LicenseID.ToString();
            LB_DetainDate.Text = DetainedLicense.DetainDate.ToString("d");
            LB_FineFees.Text = DetainedLicense.FineFees.ToString("F");
            LB_CreatedBy.Text = DetainedLicense.CreatedByUserID.ToString();

            LB_ApplicationFees.Text = ReleaseApplication.PaidFees.ToString("F");
            LB_TotalFees.Text = (ReleaseApplication.PaidFees + DetainedLicense.FineFees).ToString("F");
        }

        private void BTN_LicenseInfo_Click(object sender, EventArgs e)
        {
            clsLicense_BLL License = clsLicense_BLL.FindByLicenseID(DetainedLicense.LicenseID);
            LicenseInfo licenseInfo = new LicenseInfo(License);
            licenseInfo.ShowDialog();
        }

        public delegate void RefreshDetainedLicenses_DGV();
        public event RefreshDetainedLicenses_DGV RefreshDetainedLicenses;

        private void BTN_Release_Click(object sender, EventArgs e)
        {
            SetApplicationDates();
            if (ReleaseApplication.Save())
            {
                SetDetainedLicenseInfo();
                if (DetainedLicense.Save())
                {
                    MessageBox.Show("The License has been successfully Released.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Enable_DisableButton(BTN_Release, false);
                    UC_LicenseSelector.UC_LicenseInfo.LoadLicenseInfo(DetainedLicense.LicenseID);
                    RefreshDetainedLicenses?.Invoke();
                }
            }
        }

        void SetApplicationDates()
        {
            ReleaseApplication.ApplicationDate = DateTime.Now;
            ReleaseApplication.LastStatusDate = DateTime.Now;
            ReleaseApplication.ApplicationStatus = enApplicationStatus.Completed;
        }

        void SetDetainedLicenseInfo()
        {
            DetainedLicense.IsReleased = true;
            DetainedLicense.ReleaseDate = DateTime.Now;
            DetainedLicense.ReleasedByUserID  = clsGlobalSettings.CurrentUser.UserID;
            DetainedLicense.ReleaseApplicationID = ReleaseApplication.ApplicationID;
        }

        void Enable_DisableButton(Button ButtonName, bool EnabledValue)
        {
            ButtonName.Enabled = EnabledValue;
        }
    }
}
