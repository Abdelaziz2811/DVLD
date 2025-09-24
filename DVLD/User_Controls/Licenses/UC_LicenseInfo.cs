using DVLD.Sections.Applications.Manage_Applications.Local_License_Applications;
using DVLD_BLL;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.Licenses;
using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.License_Classes;
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

namespace DVLD.User_Controls.Applications_Section.Local_License
{
    public partial class UC_LicenseInfo : UserControl
    {
        public clsApplication_BLL Application;
        public clsLicense_BLL License;

        public UC_LicenseInfo()
        {
            InitializeComponent();
        }

        private void BTN_PersonDetails_Click(object sender, EventArgs e)
        {
            if (LB_NationalNo.Text != "----")
            {
                clsPerson_BLL Person = clsPerson_BLL.Find(LB_NationalNo.Text);
                if (Person != null)
                {
                    PersonDetails personDetails = new PersonDetails(ref Person);
                    personDetails.LoadPersonInfo += LoadPersonInfo;
                    personDetails.ShowDialog();
                }
            }
        }

        void LoadPersonInfo(clsPerson_BLL Person)
        {
            clsPerson_BLL person = clsPerson_BLL.Find(Person.PersonID);
            LB_Name.Text = person.FirstName + ' ' + person.SecondName + ' ' + person.ThirdName + ' ' + person.LastName;
            LB_NationalNo.Text = person.NationalNo;
            LB_Gender.Text = person.Gender.ToString();
            LB_BirthDate.Text = person.BirthDate.ToString("d");
            if (person.ImagePath != null)
                if (File.Exists(Person.ImagePath))
                    PB_PersonImage.Image = Image.FromFile(person.ImagePath);
        }

        public void LoadLicenseInfo(clsLicense_BLL License, clsPerson_BLL Person)
        {
            LB_Class.Text = clsLicenseClass_BLL.GetClassName(License.LicenseClass);
            LB_Name.Text = Person.FirstName + ' ' + Person.SecondName + ' ' + Person.ThirdName+ ' ' + Person.LastName;
            LB_IssueDate.Text = License.IssueDate.ToString("d");
            LB_ExpirationDate.Text = License.ExpirationDate.ToString("d");
            LB_LicenseID.Text = License.LicenseID.ToString();
            LB_Detained.Text = clsDetainedLicense_BLL.IsDetained(License.LicenseID).ToString();
            LB_IssueReason.Text = License.IssueReason.ToString();

            if (License.Notes != null)
                LB_Notes.Text = License.Notes;
            else
                LB_Notes.Text = "No notes";

            LB_DriverID.Text = License.DriverID.ToString();
            LB_NationalNo.Text = Person.NationalNo;
            LB_Gender.Text = Person.Gender.ToString();
            LB_BirthDate.Text = Person.BirthDate.ToString("d");
            LB_Active.Text = License.IsActive.ToString();

            if (Person.ImagePath != null)
                if (File.Exists(Person.ImagePath))
                    PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            License = clsLicense_BLL.FindByLicenseID(LicenseID);
            if (License != null)
            {
                Application = clsApplication_BLL.Find(License.ApplicationID);
                clsPerson_BLL Person = clsPerson_BLL.Find(Application.ApplicantPersonID);

                LB_Class.Text = clsLicenseClass_BLL.GetClassName(License.LicenseClass);
                LB_Name.Text = Person.FirstName + ' ' + Person.SecondName + ' ' + Person.ThirdName + ' ' + Person.LastName;
                LB_IssueDate.Text = License.IssueDate.ToString("d");
                LB_ExpirationDate.Text = License.ExpirationDate.ToString("d");
                LB_LicenseID.Text = License.LicenseID.ToString();
                LB_Detained.Text = clsDetainedLicense_BLL.IsDetained(License.LicenseID).ToString();
                LB_IssueReason.Text = License.IssueReason.ToString();

                if (License.Notes != null)
                    LB_Notes.Text = License.Notes;
                else
                    LB_Notes.Text = "No notes";

                LB_DriverID.Text = License.DriverID.ToString();
                LB_NationalNo.Text = Person.NationalNo;
                LB_Gender.Text = Person.Gender.ToString();
                LB_BirthDate.Text = Person.BirthDate.ToString("d");
                LB_Active.Text = License.IsActive.ToString();

                if (Person.ImagePath != null)
                    if (File.Exists(Person.ImagePath))
                        PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            }
            else
                MessageBox.Show($"License with ID {LicenseID} Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
