using DVLD_BLL;
using DVLD_BLL.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonDetails: Form
    {
        clsPerson_BLL Person;
        public PersonDetails(ref clsPerson_BLL Person)
        {
            InitializeComponent();

            this.Person = Person;
        }

        public delegate void LicenseDetails_LoadPersonInfo(clsPerson_BLL Person);
        public event LicenseDetails_LoadPersonInfo LoadPersonInfo;

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            GetPersonDetails();
        }

        public void GetPersonDetails()
        {
            UC_Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            UC_Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
            UC_Person_Info.LB_NationalNo.Text = Person.NationalNo;
            UC_Person_Info.LB_Gender.Text = Person.Gender.ToString();
            UC_Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("d");
            UC_Person_Info.LB_Email.Text = Person.Email;
            UC_Person_Info.LB_Phone.Text = Person.Phone;
            UC_Person_Info.LB_Address.Text = Person.Address;
            UC_Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

            if (Person.ImagePath != null)
                UC_Person_Info.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            else
                UC_Person_Info.PB_PersonImage.Image = null;
        }

        private void PersonDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadPersonInfo?.Invoke(Person);
        }
    }
}
