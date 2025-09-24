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
using System.IO;

namespace DVLD.Sections.Users
{
    public partial class UserDetails: Form
    {
        clsUser_BLL User;
        public UserDetails(ref clsUser_BLL User)
        {
            InitializeComponent();

            this.User = User;
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            UserInfo.GetUserInfo(User);
        }
    }
}
