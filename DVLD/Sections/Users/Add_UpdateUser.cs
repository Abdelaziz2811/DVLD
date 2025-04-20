using DVLD.User_Controls;
using DVLD_BLL;
using DVLD_BLL.Countries;
using DVLD_BLL.Users;
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
    public partial class Add_UpdateUser: Form
    {
        clsUsers_BLL User;
        public Add_UpdateUser(ref clsUsers_BLL User)
        {
            InitializeComponent();

            this.User = User;
        }

        private void Update_AddUser_Load(object sender, EventArgs e)
        {
            SetFormMode();
        }

        void SetFormMode()
        {
            if (User.Mode == enUMode.Add) LB_Opration.Text = "Add User";
            else
            {
                Update_AddUser.Person_Selector.GB_Search.Enabled = false;
                LB_Opration.Text = "Update User";
                GetUserInfoToUpdate();
                SetCurrentTapTo(Update_AddUser.TP_LoginInfo);
            }
        }

        void SetCurrentTapTo(TabPage Tab)
        {
            Update_AddUser.TC_UserInfo.SelectedTab = Tab;
        }

        public void GetUserInfoToUpdate()
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(User.PersonID);
            
            if (Person != null)
            {
                Update_AddUser.Person_Selector.Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
                Update_AddUser.Person_Selector.Person_Info.LB_NationalNo.Text = Person.NationalNo;
                Update_AddUser.Person_Selector.Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                Update_AddUser.Person_Selector.Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("yyyy-MM-dd");
                Update_AddUser.Person_Selector.Person_Info.LB_Gender.Text = Person.Gender.ToString();
                Update_AddUser.Person_Selector.Person_Info.LB_Address.Text = Person.Address;
                Update_AddUser.Person_Selector.Person_Info.LB_Email.Text = Person.Email;
                Update_AddUser.Person_Selector.Person_Info.LB_Phone.Text = Person.Phone;
                Update_AddUser.Person_Selector.Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);
            }
            
            Update_AddUser.LB_UserID.Text = User.UserID.ToString();
            Update_AddUser.TB_UserName.Text = User.UserName.ToString();
            Update_AddUser.TB_Password.Text = User.Password.ToString();
            Update_AddUser.CB_IsActive.Checked = User.IsActive;
        }

        private void Add_UpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Update_AddUser.BTN_Save.Tag.ToString() == "Inputs are valid")
            {
                SetUserInformation();
                if (User.Save())
                {
                    if (User.Mode == enUMode.Add)
                        MessageBox.Show($"User '{User.UserName}' added seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"User updated seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                if ((MessageBox.Show("The operation you're making will be canceled, Are you sure you to leave this form ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                e.Cancel = true;
        }

        void SetUserInformation()
        {
            User.UserName = Update_AddUser.TB_UserName.Text;
            User.Password = Update_AddUser.TB_Password.Text;

            if (User.Mode == enUMode.Add)
                User.PersonID = Convert.ToInt32(Update_AddUser.Person_Selector.Person_Info.LB_PersonID.Text);

            if (Update_AddUser.CB_IsActive.Checked) User.IsActive = true;
            else User.IsActive = false;
        }
    }
}
