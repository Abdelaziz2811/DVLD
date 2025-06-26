using DVLD.User_Controls;
using DVLD.User_Controls.Applications_Section.Local_License;
using DVLD_BLL.Applications.Applications;
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
        public InternationalLicenseApplication()
        {
            InitializeComponent();
        }
        private void BTN_Save_Click(object sender, EventArgs e)
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
                    LoadApplicationInfo();
                }
            }
        }

        void LoadApplicationInfo()
        {
            LB_ApplicationDate.Text = UC_LicenseSelector.UC_LicenseInfo.Application.ApplicationDate.ToString("d");
            LB_IssueDate.Text = UC_LicenseSelector.UC_LicenseInfo.License.IssueDate.ToString("d");
            LB_ApplicationFees.Text = UC_LicenseSelector.UC_LicenseInfo.Application.PaidFees.ToString();
            LB_LLicenseID.Text = UC_LicenseSelector.UC_LicenseInfo.License.LicenseID.ToString();
            LB_ExpirationDate.Text = UC_LicenseSelector.UC_LicenseInfo.License.ExpirationDate.ToString("d");
            LB_CreatedBy.Text = UC_LicenseSelector.UC_LicenseInfo.License.CreatedByUserID.ToString();
        }
    }
}
