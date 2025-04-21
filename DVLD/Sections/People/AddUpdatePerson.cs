using DVLD.User_Controls;
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
    public partial class AddUpdatePerson: Form
    {
        clsPerson_BLL Person;
        public AddUpdatePerson(ref clsPerson_BLL Person)
        {
            InitializeComponent();

            this.Person = Person;
        }

        public delegate void GetPersonIDDelegate(int PersonID);
        public event GetPersonIDDelegate GetPersonID;

        public delegate void GetPersonInfoDelegate(clsPerson_BLL Person);
        public event GetPersonInfoDelegate GetPersonInfo;

        private void Update_AddPerson_Load(object sender, EventArgs e)
        {
            SetFormMode();
            SetFormTagToCurrentMode();
        }

        void SetFormTagToCurrentMode()
        {
            this.Tag = LB_Opration.Text;
        }

        void SetFormMode()
        {
            if (Person.Mode == enMode.Add) LB_Opration.Text = "Add Person Info";
            else
            {
                LB_Opration.Text = "Update Person Info";
                GetPersonInfoToUpdate();
            }
        }

        void GetPersonInfoToUpdate()
        {
            Add_UpdatePerson.TXTB_FirstName.Text = Person.FirstName;
            Add_UpdatePerson.TXTB_SecondName.Text = Person.SecondName;
            Add_UpdatePerson.TXTB_ThirdName.Text = Person.ThirdName;
            Add_UpdatePerson.TXTB_LastName.Text = Person.LastName;
            Add_UpdatePerson.DTP_BirthDate.Value = Person.BirthDate;

            if (Person.Gender == 'M') Add_UpdatePerson.RB_Male.Checked = true;
            else Add_UpdatePerson.RB_Female.Checked = true;

            Add_UpdatePerson.TXTB_Address.Text = Person.Address;
            Add_UpdatePerson.TXTB_Phone.Text = Person.Phone;
            Add_UpdatePerson.TXTB_Email.Text = Person.Email;

            Add_UpdatePerson.CB_Countries.SelectedItem = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

            if (Person.ImagePath != string.Empty)
                Add_UpdatePerson.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);

            Add_UpdatePerson.TXTB_NationalNo.Text = Person.NationalNo;
        }

        private void AddUpdatePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Add_UpdatePerson.BTN_Save.Tag.ToString() == "Inputs are valid")
            {
                SetPersonInformation();
                if (Person.Save())
                {
                    if (Person.Mode == enMode.Add)
                        MessageBox.Show($"Person '{Person.FirstName} {Person.LastName}' added seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Person updated seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int PersonID = clsPerson_BLL.GetPersonID(Add_UpdatePerson.TXTB_NationalNo.Text);
                    if (PersonID != -1)
                        GetPersonID?.Invoke(PersonID);

                    GetPersonInfo?.Invoke(Person);
                }
            }
            else
                if ((MessageBox.Show("The operation you're making will be canceled, Are you sure you to leave this form ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                    e.Cancel = true;
        }

        void SetPersonInformation()
        {
            Person.FirstName = Add_UpdatePerson.TXTB_FirstName.Text;
            Person.SecondName = Add_UpdatePerson.TXTB_SecondName.Text;
            Person.ThirdName = Add_UpdatePerson.TXTB_ThirdName.Text;
            Person.LastName = Add_UpdatePerson.TXTB_LastName.Text;
            Person.BirthDate = Add_UpdatePerson.DTP_BirthDate.Value;

            if (Add_UpdatePerson.RB_Male.Checked) Person.Gender = 'M';
            else Person.Gender = 'F';

            Person.Address = Add_UpdatePerson.TXTB_Address.Text;
            Person.Phone = Add_UpdatePerson.TXTB_Phone.Text;
            Person.Email = Add_UpdatePerson.TXTB_Email.Text;

            Person.NationalityCountryID = clsCountries_BLL.GetCountryID(Add_UpdatePerson.CB_Countries.SelectedItem.ToString());

            if (Add_UpdatePerson.ImagePath != string.Empty)
                Person.ImagePath = Add_UpdatePerson.ImagePath;

            Person.NationalNo = Add_UpdatePerson.TXTB_NationalNo.Text;
        }
    }
}
