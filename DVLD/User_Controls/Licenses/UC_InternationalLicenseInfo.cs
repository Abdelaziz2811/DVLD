using DVLD_BLL;
using DVLD_BLL.Applications.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Applications_Section.International_Licenses
{
    public partial class UC_InternationalLicenseInfo : UserControl
    {
        public UC_InternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInternationalLicenseInfo(clsInternationalLicense_BLL InternationalLicense, clsPerson_BLL Person)
        {
            LB_Name.Text = Person.FirstName + ' ' + Person.SecondName + ' ' + Person.ThirdName + ' ' + Person.LastName;
            LB_ILicenseID.Text = InternationalLicense.InternationalLicenseID.ToString();
            LB_LLicenseID.Text = InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            LB_IssueDate.Text = InternationalLicense.IssueDate.ToString("d");
            LB_ExpirationDate.Text = InternationalLicense.ExpirationDate.ToString("d");
            LB_Active.Text = InternationalLicense.IsActive.ToString();
            LB_ApplicationID.Text = InternationalLicense.ApplicationID.ToString();
            LB_DriverID.Text = InternationalLicense.DriverID.ToString();
            LB_NationalNo.Text = Person.NationalNo;
            LB_Gender.Text = Person.Gender.ToString();
            LB_BirthDate.Text = Person.BirthDate.ToString("d");

            if (Person.ImagePath != null)
                if (File.Exists(Person.ImagePath))
                    PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
        }
    }
}
