using DVLD_BLL;
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
    public partial class LicenseInfo : Form
    {
        clsLicense_BLL License;
        clsPerson_BLL Person;
        clsLocalLicenseApplication_BLL LocalLicenseApplication;
        public LicenseInfo(clsLocalLicenseApplication_BLL LocalLicenseApplication)
        {
            InitializeComponent();

            this.LocalLicenseApplication = LocalLicenseApplication;
            License = clsLicense_BLL.Find(LocalLicenseApplication.ApplicationID);
            Person = clsPerson_BLL.Find(LocalLicenseApplication.NationalNo);
        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            LoadLicenseInfo();
        }

        void LoadLicenseInfo()
        {
            UC_LicenseInfo.LB_Class.Text = LocalLicenseApplication.ClassName;
            UC_LicenseInfo.LB_Name.Text = LocalLicenseApplication.FullName;
            UC_LicenseInfo.LB_IssueDate.Text = License.IssueDate.ToString("d");
            UC_LicenseInfo.LB_ExpirationDate.Text = License.ExpirationDate.ToString("d");
            UC_LicenseInfo.LB_LicenseID.Text = License.LicenseID.ToString();
            //UC_LicenseInfo.LB_Detained.Text = //...
            UC_LicenseInfo.LB_IssueReason.Text = License.IssueReason.ToString();

            if (License.Notes != null)
                UC_LicenseInfo.LB_Notes.Text = License.Notes;
            else
                UC_LicenseInfo.LB_Notes.Text = "No notes";

            UC_LicenseInfo.LB_DriverID.Text = License.DriverID.ToString();
            UC_LicenseInfo.LB_NationalNo.Text = Person.NationalNo;
            UC_LicenseInfo.LB_Gender.Text = Person.Gender.ToString();
            UC_LicenseInfo.LB_BirthDate.Text = Person.BirthDate.ToString("d");
            UC_LicenseInfo.LB_Active.Text = License.IsActive.ToString();

            if (Person.ImagePath != null)
                UC_LicenseInfo.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
        }
    }
}
