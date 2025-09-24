using DVLD.Sections.Applications.Driving_Licenses_Services.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Applications_Section.Local_License
{
    public partial class UC_LicenseSelector : UserControl
    {
        public UC_LicenseSelector()
        {
            InitializeComponent();
        }

        private void BTN_FindLicense_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TXTB_SearchBox.Text, out int LicenseID))
            {
                UC_LicenseInfo.LoadLicenseInfo(LicenseID);
            }
        }

        private void BTN_LicenseHistory_Click(object sender, EventArgs e)
        {
            if (UC_LicenseInfo.LB_NationalNo.Text != "----")
            {
                LicenseHistory licenseHistory = new LicenseHistory(UC_LicenseInfo.LB_NationalNo.Text);
                licenseHistory.ShowDialog();
            }
        }

        public void FindLicense(string StrLicenseID)
        {
            TXTB_SearchBox.Text = StrLicenseID;
            if (int.TryParse(TXTB_SearchBox.Text, out int LicenseID))
            {
                UC_LicenseInfo.LoadLicenseInfo(LicenseID);
            }

            GB_Search.Enabled = false;
        }
    }
}
