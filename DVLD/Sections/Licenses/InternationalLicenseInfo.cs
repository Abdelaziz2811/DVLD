using DVLD_BLL;
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

namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{  
    public partial class InternationalLicenseInfo : Form
    {
        clsInternationalLicense_BLL InternationalLicense;
        clsPerson_BLL Person;

        public InternationalLicenseInfo(clsInternationalLicense_BLL InternationalLicense, clsPerson_BLL Person)
        {
            InitializeComponent();

            this.InternationalLicense = InternationalLicense;
            this.Person = Person;
        }

        private void InternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            UC_InternationalLicenseInfo.LoadInternationalLicenseInfo(InternationalLicense, Person);
        }
    }
}
