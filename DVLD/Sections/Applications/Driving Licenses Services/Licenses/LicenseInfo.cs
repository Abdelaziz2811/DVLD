using DVLD_BLL;
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
            License = clsLicense_BLL.FindByAppID(LocalLicenseApplication.ApplicationID);
            Person = clsPerson_BLL.Find(LocalLicenseApplication.NationalNo);
        }

        private void LicenseInfo_Load(object sender, EventArgs e)
        {
            UC_LicenseInfo.LoadLicenseInfo(License, Person, LocalLicenseApplication);
        }
    }
}
