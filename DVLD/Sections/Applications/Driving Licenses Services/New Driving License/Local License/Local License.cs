using DVLD.User_Controls.Users_Section_Controls;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    public partial class LocalLicense : Form
    {
        clsApplications_BLL Application;

        public LocalLicense()
        {
            InitializeComponent();
        }

        private void Local_License_Load(object sender, EventArgs e)
        {
            LoadLicenseClasses();
        }

        void LoadLicenseClasses()
        {
            DataTable DTLicenseClasses = clsLicenseClasses_BLL.GetLicenseClasses();
            foreach (DataRow Row in DTLicenseClasses.Rows)
                CB_LicenseClasses.Items.Add(Row["ClassName"]);
            CB_LicenseClasses.SelectedIndex = 0;
        }

        private void BTN_NextToApplicationInfo_Click(object sender, EventArgs e)
        {
            if (UC_Person_Selector.Person_Info.LB_PersonID.Text != "----")
                TC_NewLicenseApplication.SelectedIndex = 1;
        }
        
        private void TB_NewLicenseApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_NewLicenseApplication.SelectedTab.Text == "Application Info")
            {
                if (UC_Person_Selector.Person_Info.LB_PersonID.Text == "----")
                {
                    TC_NewLicenseApplication.SelectedTab = TP_PersonInfo;
                    MessageBox.Show("Please select a person first", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Application = new clsApplications_BLL();
                    SetApplicationInfo();
                    LaodNewApplicationInfo();
                }
            }
        }

        void SetApplicationInfo()
        {
            Application.ApplicantPersonID = Convert.ToInt32(UC_Person_Selector.Person_Info.LB_PersonID.Text);
            Application.ApplicationTypeID = 1;
            Application.ApplicationStatus = enApplicationStatus.New;
            Application.PaidFees = clsApplicationTypes_BLL.Find(Application.ApplicationTypeID).ApplicationFees;
            Application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
        }

        void LaodNewApplicationInfo()
        {
            LB_ApplicationDate.Text = Application.ApplicationDate.ToString("MM/dd/yyyy");
            LB_ApplicationFees.Text = Application.PaidFees.ToString("C2");
            LB_CreatedBy.Text = Application.CreatedByUserID.ToString();
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (!clsLocalLicenseApplication_BLL.IsLocalLicenseApplicationExists(Application.ApplicantPersonID,
                                        clsLicenseClasses_BLL.LicenseClassID(CB_LicenseClasses.SelectedItem.ToString())))
            {
                if (Application.Save())
                {
                    clsLocalLicenseApplication_BLL LocalLicenseApplication = new clsLocalLicenseApplication_BLL();
                    SetLocalLicenseApplicationInfo(ref LocalLicenseApplication);
                    if (LocalLicenseApplication.Save())
                    {
                        MessageBox.Show("Application added successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                }
                MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Choose another license class, The selected license class already has an active or complete application Link to the selected Person", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void SetLocalLicenseApplicationInfo(ref clsLocalLicenseApplication_BLL LocalLicenseApplication)
        {
            LocalLicenseApplication.ApplicationID = Application.ApplicationID;
            int ClassID = clsLicenseClasses_BLL.LicenseClassID(CB_LicenseClasses.SelectedItem.ToString());
            if (ClassID != 0)
                LocalLicenseApplication.LicenseClassID = ClassID;
            else
                MessageBox.Show("The selected class doesn't exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
