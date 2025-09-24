using DVLD.Sections.Applications.Driving_Licenses_Services.Licenses;
using DVLD_BLL;
using DVLD_BLL.Applications.Licenses;
using DVLD_BLL.Drivers;
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
    public partial class ManageInternationalLicenseApplications : Form
    {
        DataTable DTInternationalLicenseApplications;
        public ManageInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void ManageInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadInternationalLicenseApplications();
            RecordsCount();
            CustomizeDGVColumns();
            InitializeCB_FilterBy();
        }

        void LoadInternationalLicenseApplications()
        {
            DTInternationalLicenseApplications = clsInternationalLicense_BLL.LoadInternationalLicenses();
            DGV_InternationalLicenseApplications.DataSource = DTInternationalLicenseApplications;
        }

        void RecordsCount()
        {
            LB_RecordsCount.Text = DGV_InternationalLicenseApplications.RowCount.ToString();
        }

        void CustomizeDGVColumns()
        {
            DGV_InternationalLicenseApplications.Columns["InternationalLicenseID"].HeaderText = "I.License ID";
            DGV_InternationalLicenseApplications.Columns["ApplicationID"].HeaderText = "Application ID";
            DGV_InternationalLicenseApplications.Columns["DriverID"].HeaderText = "Driver ID";
            DGV_InternationalLicenseApplications.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
            DGV_InternationalLicenseApplications.Columns["IssueDate"].HeaderText = "Issue Date";
            DGV_InternationalLicenseApplications.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            DGV_InternationalLicenseApplications.Columns["IsActive"].HeaderText = "Active";
            DGV_InternationalLicenseApplications.Columns["CreatedByUserID"].HeaderText = "Created By User ID";
        }

        void InitializeCB_FilterBy()
        {
            CB_FilterBy.SelectedIndex = 0;
        }

        void RefreshInternationalLicenseApplications()
        {
            LoadInternationalLicenseApplications();
            RecordsCount();
        }

        private void BTN_AddInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            InternationalLicenseApplication internationalLicenseApplication = new InternationalLicenseApplication();
            internationalLicenseApplication.ShowDialog();
            RefreshInternationalLicenseApplications();
        }

        private void TSMI_PersonDetails_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver_BLL.FindByDriverID(Convert.ToInt32(DGV_InternationalLicenseApplications.CurrentRow.Cells[2].Value)).PersonID;
            if (PersonID != 0)
            {
                clsPerson_BLL Person = clsPerson_BLL.Find(PersonID);
                if (Person != null)
                {
                    PersonDetails personDetails = new PersonDetails(ref Person);
                    personDetails.ShowDialog();
                }
            }
            else
                MessageBox.Show("The person with the selected I.License is not found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_LicenseDetails_Click(object sender, EventArgs e)
        {
            clsInternationalLicense_BLL InternationalLicense = clsInternationalLicense_BLL.FindByInternationalLicenseID(Convert.ToInt32(DGV_InternationalLicenseApplications.CurrentRow.Cells[0].Value));
            int PersonID = clsDriver_BLL.FindByDriverID(Convert.ToInt32(DGV_InternationalLicenseApplications.CurrentRow.Cells[2].Value)).PersonID;
            clsPerson_BLL Person = clsPerson_BLL.Find(PersonID);
            if (InternationalLicense != null && Person != null)
            {
                InternationalLicenseInfo internationalLicenseInfo = new InternationalLicenseInfo(InternationalLicense, Person);
                internationalLicenseInfo.ShowDialog();
            }
        }

        private void TSMI_PersonLicenseHistory_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver_BLL.FindByDriverID(Convert.ToInt32(DGV_InternationalLicenseApplications.CurrentRow.Cells[2].Value)).PersonID;
            clsPerson_BLL Person = clsPerson_BLL.Find(PersonID);
            if (Person != null)
            {
                LicenseHistory licenseHistory = new LicenseHistory(Person.NationalNo);
                licenseHistory.ShowDialog();
            }
        }

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() == "None")
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                LoadInternationalLicenseApplications();
            }
            else
                TB_FilterationValue.Enabled = true;
        }

        void FilterBy(string FilterBy)
        {
            if (FilterBy == "InternationalLicenseID" || FilterBy == "ApplicationID" || FilterBy == "DriverID"
                || FilterBy == "IssuedUsingLocalLicenseID")
            {
                if (int.TryParse(TB_FilterationValue.Text, out int TargetField))
                    DTInternationalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = '{TargetField}'";
            }
            else if (FilterBy == "IsActive")
            {
                if (TB_FilterationValue.Text.ToLower() == "true")
                {
                    DTInternationalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = TRUE";
                }
                else if (TB_FilterationValue.Text.ToLower() == "false")
                    DTInternationalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = FALSE";
            }
        }

        private void TB_FilterationValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_FilterationValue.Text))
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                RefreshInternationalLicenseApplications();
                return;
            }

            switch (CB_FilterBy.SelectedItem.ToString())
            {
                case "I.License ID":

                    FilterBy("InternationalLicenseID");

                    break;

                case "Application ID":

                    FilterBy("ApplicationID");

                    break;

                case "Driver ID":

                    FilterBy("DriverID");

                    break;
                case "L.License ID":

                    FilterBy("IssuedUsingLocalLicenseID");

                    break;

                case "Active":

                    FilterBy("IsActive");

                    break;

                default:
                    break;
            }
        }
    }
}
