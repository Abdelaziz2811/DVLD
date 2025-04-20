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

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            GetPersonDetails();
        }

        public void GetPersonDetails()
        {
            Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
            Person_Info.LB_NationalNo.Text = Person.NationalNo;
            Person_Info.LB_Gender.Text = Person.Gender.ToString();
            Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("yyyy/MM/dd");
            Person_Info.LB_Email.Text = Person.Email;
            Person_Info.LB_Phone.Text = Person.Phone;
            Person_Info.LB_Address.Text = Person.Address;
            Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

            if (Person.ImagePath != string.Empty)
            {
                Person_Info.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            }
        }
    }
}
