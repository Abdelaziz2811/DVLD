using DVLD.Sections.Applications.Driving_Licenses_Services.Licenses;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
using DVLD_BLL;
using DVLD_BLL.Applications.Licenses;
using DVLD_BLL.Applications.LocalLicenseApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Driving_Licenses_Services.Detained_Licenses
{
    public partial class ManageDetainedLicenses : Form
    {
        DataTable DTDetainedLicenses;
        public ManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void ManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            LoadDetainedLicenses();
            LoadDetainedLicensesCount();
            RefreshDetainedLicenses();
            CustomizeDGV_DetainedLicenses();
            InitializeCB_FilterBy();
        }

        void LoadDetainedLicenses()
        {
            DTDetainedLicenses = clsDetainedLicense_BLL.LoadDetainedLicenses();
            DGV_DetainedLicenses.DataSource = DTDetainedLicenses;
        }

        void LoadDetainedLicensesCount()
        {
            LB_RecordsCount.Text = DGV_DetainedLicenses.RowCount.ToString();
        }

        void RefreshDetainedLicenses()
        {
            LoadDetainedLicenses();
            LoadDetainedLicensesCount();
        }

        void CustomizeDGV_DetainedLicenses()
        {
            DGV_DetainedLicenses.Columns["DetainID"].HeaderText = "Detain ID";
            DGV_DetainedLicenses.Columns["NationalNo"].HeaderText = "National No";
            DGV_DetainedLicenses.Columns["LicenseID"].HeaderText = "License ID";
            DGV_DetainedLicenses.Columns["DetainDate"].HeaderText = "Detain Date";
            DGV_DetainedLicenses.Columns["FineFees"].HeaderText = "Fine Fees";
            DGV_DetainedLicenses.Columns["CreatedByUserID"].HeaderText = "Created By User ID";
            DGV_DetainedLicenses.Columns["IsReleased"].HeaderText = "Is Released";
            DGV_DetainedLicenses.Columns["ReleaseDate"].HeaderText = "Release Date";
            DGV_DetainedLicenses.Columns["ReleasedByUserID"].HeaderText = "Released By User ID";
            DGV_DetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "Release App ID";
        }

        void InitializeCB_FilterBy()
        {
            CB_FilterBy.SelectedIndex = 0;
        }

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() == "None")
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                RefreshDetainedLicenses();
            }
            else
                TB_FilterationValue.Enabled = true;
        }

        private void TB_FilterationValue_TextChanged(object sender, EventArgs e)
        {
            switch (CB_FilterBy.SelectedItem.ToString())
            {
                case "License ID":
                    FilterBy("LicenseID");
                    break;

                case "Detain Date":
                    FilterBy("DetainDate");
                    break;

                case "Release Date":
                    FilterBy("ReleaseDate");
                    break;

                case "Is Released":
                    FilterBy("IsReleased");
                    break;

                case "Created By User ID":
                    FilterBy("CreatedByUserID");
                    break;

                case "Released By User ID":
                    FilterBy("ReleasedByUserID");
                    break;

                case "National No":
                    FilterBy("NationalNo");
                    break;

                default:
                    break;
            }
        }

        void FilterBy(string FilterBy)
        {
            if (FilterBy == "LicenseID" || FilterBy == "CreatedByUserID" || FilterBy == "ReleasedByUserID")
            {
                if (int.TryParse(TB_FilterationValue.Text, out int FeildID))
                    DTDetainedLicenses.DefaultView.RowFilter = $"{FilterBy} = '{FeildID}'";
            }
            else if (FilterBy == "IsReleased")
            {
                if (TB_FilterationValue.Text.ToLower() == "true")
                {
                    DTDetainedLicenses.DefaultView.RowFilter = $"{FilterBy} = TRUE";
                }
                else if (TB_FilterationValue.Text.ToLower() == "false")
                    DTDetainedLicenses.DefaultView.RowFilter = $"{FilterBy} = FALSE";
            }
            else
                DTDetainedLicenses.DefaultView.RowFilter = $"{FilterBy} = '{TB_FilterationValue.Text}'";
        }

        private void TSMI_PersonDetails_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(DGV_DetainedLicenses.CurrentRow.Cells[2].Value.ToString());
            PersonDetails personDetails = new PersonDetails(ref Person);
            personDetails.ShowDialog();
        }

        private void TSMI_LicenseDetails_Click(object sender, EventArgs e)
        {
            clsLicense_BLL License = clsLicense_BLL.FindByLicenseID(Convert.ToInt32(DGV_DetainedLicenses.CurrentRow.Cells[3].Value));
            LicenseInfo licenseInfo = new LicenseInfo(License);
            licenseInfo.ShowDialog();
        }

        private void TSMI_PersonLicenseHistory_Click(object sender, EventArgs e)
        {
            LicenseHistory licenseHistory = new LicenseHistory(DGV_DetainedLicenses.CurrentRow.Cells[2].Value.ToString());
            licenseHistory.ShowDialog();
        }

        private void CMS_DetainedLicensesActions_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(DGV_DetainedLicenses.CurrentRow.Cells[7].Value))
            {
                TSMI_ReleaseLicense.Enabled = false;
            }
            else TSMI_ReleaseLicense.Enabled = true;
        }

        private void TSMI_ReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseLicense releaseLicense = new ReleaseLicense();
            releaseLicense.UC_LicenseSelector.FindLicense(DGV_DetainedLicenses.CurrentRow.Cells[3].Value.ToString());
            releaseLicense.RefreshDetainedLicenses += RefreshDetainedLicenses;
            releaseLicense.Show();
        }

        private void BTN_DetainLicense_Click(object sender, EventArgs e)
        {
            DetainLicense detainLicense = new DetainLicense();
            detainLicense.ShowDialog();
        }

        private void BTN_ReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseLicense releaseLicense = new ReleaseLicense();
            releaseLicense.ShowDialog();
        }
    }
}
