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

namespace DVLD.User_Controls.Users_Section_Controls
{
    public partial class UC_UserInfo: UserControl
    {
        public UC_UserInfo()
        {
            InitializeComponent();
        }

        public void GetUserInfo(clsUser_BLL User)
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(User.PersonID);

            if (Person != null)
                Person_Info.GetPersonDetails(Person);

            LB_UserID.Text = User.UserID.ToString();
            LB_UserName.Text = User.UserName.ToString();

            if (User.IsActive)
                LB_IsActive.Text = "Yes";
            else LB_IsActive.Text = "No";
        }
    }
}
