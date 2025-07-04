using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.Licenses;
using DVLD_BLL.Applications.LocalLicenseApplication;
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
    public partial class DetainLicense : Form
    {
        clsDetainedLicenses_BLL DetainedLicense;

        public DetainLicense()
        {
            InitializeComponent();
        }

        private void BTN_Next_Click(object sender, EventArgs e)
        {
            if (LB_DetainID.Text != "??")
            {
                TC_LicenseApplication.SelectedTab = TP_ApplicationInfo;
                return;
            }

            if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
                MessageBox.Show($"The current License cannot be detain, It is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                MessageBox.Show($"The current License cannot be detained, It is expired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (clsDetainedLicenses_BLL.IsExists(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text)))
                MessageBox.Show($"The current License already detained", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                TC_LicenseApplication.SelectedIndex = 1;
        }

        private void TC_LicenseApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_LicenseApplication.SelectedTab.Text == "Application Info")
            {
                if (LB_DetainID.Text != "??")
                {
                    TC_LicenseApplication.SelectedTab = TP_ApplicationInfo;
                    return;
                }

                if (UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text == "----")
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show("Please select a Local License first", "No License Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Convert.ToDateTime(UC_LicenseSelector.UC_LicenseInfo.LB_ExpirationDate.Text) < DateTime.Now)
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be detained, It is expired", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (UC_LicenseSelector.UC_LicenseInfo.LB_Active.Text == "False")
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License cannot be detain, It is inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (clsDetainedLicenses_BLL.IsExists(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text)))
                {
                    TC_LicenseApplication.SelectedTab = TP_LicenseInfo;
                    MessageBox.Show($"The current License already detained", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DetainedLicense = new clsDetainedLicenses_BLL();
                    LoadDetainedLicenseInfo();
                }
            }
        }

        private void BTN_Detain_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TB_FineFees.Text))
            {
                SetDetainLicenseInfo();
                if (DetainedLicense.Save())
                {
                    MessageBox.Show("The selected License has been detained successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SetControlsProperties();
                    LoadDetainedLicenseInfo_ToView();
                }
            }
            else
                MessageBox.Show("Please enter fine fees amount!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void SetDetainLicenseInfo()
        {
            DetainedLicense.LicenseID = Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text);
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFees = Convert.ToDecimal(TB_FineFees.Text);
            DetainedLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }
        
        void SetControlsProperties()
        {
            Enable_DisableButton(BTN_Detain, false);
            Enable_DisableButton(BTN_LicenseInfo, true);
            UC_LicenseSelector.Enabled = false;
            TB_FineFees.ReadOnly = true;
        }

        void Enable_DisableButton(Button ButtonName, bool EnabledValue)
        {
            ButtonName.Enabled = EnabledValue;
        }


        void LoadDetainedLicenseInfo()
        {
            LB_DetainID.Text = DetainedLicense.DetainID.ToString();
            LB_LicenseID.Text = UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text;
            LB_DetainDate.Text = DateTime.Now.ToString("d");
            LB_CreatedBy.Text = clsGlobalSettings.CurrentUser.UserID.ToString();
        }

        void LoadDetainedLicenseInfo_ToView()
        {
            LB_DetainID.Text = DetainedLicense.DetainID.ToString();
            LB_LicenseID.Text = DetainedLicense.LicenseID.ToString();
            LB_DetainDate.Text = DetainedLicense.DetainDate.ToString("d");
            LB_CreatedBy.Text = clsGlobalSettings.CurrentUser.UserID.ToString();
        }

        private void TB_FineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void BTN_LicenseInfo_Click(object sender, EventArgs e)
        {
            LicenseInfo licenseInfo = new LicenseInfo(clsLicense_BLL.FindByLicenseID(Convert.ToInt32(UC_LicenseSelector.UC_LicenseInfo.LB_LicenseID.Text)));
            licenseInfo.ShowDialog();
        }
    }
}
