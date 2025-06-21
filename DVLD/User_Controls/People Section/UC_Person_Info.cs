using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD.Properties;
using DVLD_BLL;
using DVLD_BLL.Countries;

namespace DVLD.User_Controls
{
    public partial class UC_Person_Info: UserControl
    {
        public UC_Person_Info()
        {
            InitializeComponent();
        }

        private void BTN_EditPersonInfo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(LB_PersonID.Text, out int PersonID))
            {
                MessageBox.Show("Please select a person first", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                clsPerson_BLL Person = clsPerson_BLL.Find(PersonID);
                if (Person != null)
                {
                    AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
                    add_UpdatePerson.GetPersonInfo += GetPersonDetails;
                    add_UpdatePerson.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Person with ID '{LB_PersonID.Text} is not found'.", "No Person Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        void GetPersonDetails(clsPerson_BLL Person)
        {
            LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            LB_PersonID.Text = Person.PersonID.ToString();
            LB_NationalNo.Text = Person.NationalNo;
            LB_Gender.Text = Person.Gender.ToString();
            LB_BirthDate.Text = Person.BirthDate.ToString("yyyy/MM/dd");
            LB_Email.Text = Person.Email;
            LB_Phone.Text = Person.Phone;
            LB_Address.Text = Person.Address;
            LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

            if (Person.ImagePath != string.Empty)
                PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            else
                PB_PersonImage.Image = null;
        }
    }
}
