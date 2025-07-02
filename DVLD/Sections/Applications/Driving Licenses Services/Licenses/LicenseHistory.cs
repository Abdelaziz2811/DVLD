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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    public partial class LicenseHistory : Form
    {
        string NationalNo = string.Empty;
        public LicenseHistory(string NationalNo)
        {
            InitializeComponent();

            this.NationalNo = NationalNo;
        }

        private void LicenseHistory_Load(object sender, EventArgs e)
        {
            LoadPersonInfo();
            LoadPersonLicenseHistory();
            LicensesCount();
            CustomizeDGV_LocalLicenseHistoryColumns();
            CustomizeDGV_InternationalLicenseHistoryColumns();
        }

        void LoadPersonInfo()
        {
            UC_Person_Selector.CB_FindBy.SelectedItem = "NationalNo.";
            UC_Person_Selector.TXTB_SearchBox.Text = NationalNo;
            UC_Person_Selector.BTN_FindPerson.PerformClick();
        }

        void LoadPersonLicenseHistory()
        {
            int PersonID = clsPerson_BLL.Find(NationalNo).PersonID;
            UC_LicenseHistory.DGV_LocalLicenseHistory.DataSource = clsLicense_BLL.LoadLicensesHistory(PersonID);
            UC_LicenseHistory.DGV_InternationalLicenseHistory.DataSource = clsInternationalLicense_BLL.LoadInternationalLicenses(PersonID);
        }

        void LicensesCount()
        {
            UC_LicenseHistory.LB_RecordsCount.Text = UC_LicenseHistory.DGV_LocalLicenseHistory.RowCount.ToString();
        }

        void CustomizeDGV_LocalLicenseHistoryColumns()
        {
            //Customize Names
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["LicenseID"].HeaderText = "L.ID";
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["ApplicationID"].HeaderText = "App.ID";
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["ClassName"].HeaderText = "Class Name";
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["IssueDate"].HeaderText = "Issue Date";
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["IsActive"].HeaderText = "Is Active";

            //Customize Widths
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["LicenseID"].Width = 50;
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["ApplicationID"].Width = 50;
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["IssueDate"].Width = 100;
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["ExpirationDate"].Width = 100;
            UC_LicenseHistory.DGV_LocalLicenseHistory.Columns["IsActive"].Width = 80;
        }

        void CustomizeDGV_InternationalLicenseHistoryColumns()
        {
            //Customize Names
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["InternationalLicenseID"].HeaderText = "Inter.L.ID";
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["ApplicationID"].HeaderText = "App.ID";
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["IssuedUsingLocalLicenseID"].HeaderText = "Local.L.ID";
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["IssueDate"].HeaderText = "Issue Date";
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["ExpirationDate"].HeaderText = "Expiration Date";
            UC_LicenseHistory.DGV_InternationalLicenseHistory.Columns["IsActive"].HeaderText = "Is Active";
        }
    }
}
