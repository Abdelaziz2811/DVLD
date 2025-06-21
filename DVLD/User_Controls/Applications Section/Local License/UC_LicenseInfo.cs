using DVLD.Sections.Applications.Manage_Applications.Local_License_Applications;
using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Applications_Section.Local_License
{
    public partial class UC_LicenseInfo : UserControl
    {
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
                PB_PersonImage.Image = Image.FromFile(person.ImagePath);
        }
    }
}
