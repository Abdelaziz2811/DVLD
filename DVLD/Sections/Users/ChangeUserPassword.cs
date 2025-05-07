using DVLD_BLL.Countries;
using DVLD_BLL;
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

namespace DVLD.Sections.Users
{
    public partial class ChangeUserPassword: Form
    {
        clsUsers_BLL User;
        public ChangeUserPassword(ref clsUsers_BLL User)
        {
            InitializeComponent();

            this.User = User;
        }

        private void ChangeUserPassword_Load(object sender, EventArgs e)
        {
            GetUserInfoToUpdate();
        }

        void GetUserInfoToUpdate()
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(User.PersonID);

            if (Person != null)
            {
                Change_UserPassword.UserInfo.Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
                Change_UserPassword.UserInfo.Person_Info.LB_NationalNo.Text = Person.NationalNo;
                Change_UserPassword.UserInfo.Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                Change_UserPassword.UserInfo.Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("yyyy-MM-dd");
                Change_UserPassword.UserInfo.Person_Info.LB_Gender.Text = Person.Gender.ToString();
                Change_UserPassword.UserInfo.Person_Info.LB_Address.Text = Person.Address;
                Change_UserPassword.UserInfo.Person_Info.LB_Email.Text = Person.Email;
                Change_UserPassword.UserInfo.Person_Info.LB_Phone.Text = Person.Phone;
                Change_UserPassword.UserInfo.Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);

                if (Person.ImagePath != string.Empty)
                    Change_UserPassword.UserInfo.Person_Info.PB_PersonImage.Image = Image.FromFile(Person.ImagePath);
            }

            Change_UserPassword.UserInfo.LB_UserID.Text = User.UserID.ToString();
            Change_UserPassword.UserInfo.LB_UserName.Text = User.UserName.ToString();

            if (User.IsActive)
                Change_UserPassword.UserInfo.LB_IsActive.Text = "Yes";
            else Change_UserPassword.UserInfo.LB_IsActive.Text = "No";
        }
    }
}
