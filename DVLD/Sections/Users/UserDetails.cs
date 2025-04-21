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
    public partial class UserDetails: Form
    {
        clsUsers_BLL User;
        public UserDetails(ref clsUsers_BLL User)
        {
            InitializeComponent();

            this.User = User;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            GetUserInfoToUpdate();
        }

        void GetUserInfoToUpdate()
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(User.PersonID);

            if (Person != null)
            {
                UserInfo.Person_Info.LB_PersonID.Text = Person.PersonID.ToString();
                UserInfo.Person_Info.LB_NationalNo.Text = Person.NationalNo;
                UserInfo.Person_Info.LB_Name.Text = Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName;
                UserInfo.Person_Info.LB_BirthDate.Text = Person.BirthDate.ToString("yyyy-MM-dd");
                UserInfo.Person_Info.LB_Gender.Text = Person.Gender.ToString();
                UserInfo.Person_Info.LB_Address.Text = Person.Address;
                UserInfo.Person_Info.LB_Email.Text = Person.Email;
                UserInfo.Person_Info.LB_Phone.Text = Person.Phone;
                UserInfo.Person_Info.LB_Country.Text = clsCountries_BLL.GetCountryName(Person.NationalityCountryID);
            }

            UserInfo.LB_UserID.Text = User.UserID.ToString();
            UserInfo.LB_UserName.Text = User.UserName.ToString();

            if (User.IsActive)
                UserInfo.LB_IsActive.Text = "Yes";
            else UserInfo.LB_IsActive.Text = "No";
        }
    }
}
