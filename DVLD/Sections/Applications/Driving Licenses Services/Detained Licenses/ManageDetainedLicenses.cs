using DVLD_BLL.Applications.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            DTDetainedLicenses = clsDetainedLicenses_BLL.LoadDetainedLicenses();
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
            if (string.IsNullOrWhiteSpace(TB_FilterationValue.Text))
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                RefreshDetainedLicenses();
                return;
            }

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
    }
}
