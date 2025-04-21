using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
using DVLD_BLL.Countries;

namespace DVLD.User_Controls
{
    public partial class UC_Person_Selector: UserControl
    {
        clsPerson_BLL Person;

        public UC_Person_Selector()
        {
            InitializeComponent();
        }

        private void UC_Person_Selector_Load(object sender, EventArgs e)
        {
            InitializeCB_FindBy();
        }

        void InitializeCB_FindBy()
        {
            CB_FindBy.SelectedIndex = 0;
        }

        private void BTN_AddPerson_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = new clsPerson_BLL();
            AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
            add_UpdatePerson.GetPersonID += GetNewAddedPersonInfo;
            add_UpdatePerson.ShowDialog();
        }

        private void BTN_FindPerson_Click(object sender, EventArgs e)
        {
            Person = new clsPerson_BLL();

            if (!string.IsNullOrWhiteSpace(TXTB_SearchBox.Text))
            {
                if (CB_FindBy.SelectedItem.ToString() == "PersonID")
                {
                    if (int.TryParse(TXTB_SearchBox.Text, out int ID))
                    {
                        Person = clsPerson_BLL.Find(ID);
                        if (Person != null)
                            GetPersonInfo();
                        else
                            MessageBox.Show($"No person found with this ID '{ID}'", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Please enter a valid ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CB_FindBy.SelectedItem.ToString() == "NationalNo.")
                {
                    Person = clsPerson_BLL.Find(TXTB_SearchBox.Text);
                    if (Person != null)
                        GetPersonInfo();
                    else
                        MessageBox.Show($"No person found with this NationalNo. '{TXTB_SearchBox.Text}'", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
                MessageBox.Show("Please enter a valid Input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void GetPersonInfo()
        {
            Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
            Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
            Person_Info.LB_NationalNo.Text = Person.NationalNo;
            Person_Info.LB_Gender.Text = Person.Gender.ToString();
            Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("dd/MM/yyyy");
            Person_Info.LB_Address.Text = Person.Address;
            Person_Info.LB_Phone.Text = Person.Phone;
            Person_Info.LB_Email.Text = Person.Email;
            Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

            if (Person.ImagePath != string.Empty)
                Person_Info.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            else Person_Info.PB_PersonImage.Image = null;
        }

        void GetNewAddedPersonInfo(int PersonID)
        {
            InitializeCB_FindBy();
            TXTB_SearchBox.Text = PersonID.ToString();
            BTN_FindPerson.PerformClick();
        }
    }
}
