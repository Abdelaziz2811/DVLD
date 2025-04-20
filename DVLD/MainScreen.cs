using DVLD.Sections.Users;
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
    public partial class MainScreen: Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void TSM_People_Click(object sender, EventArgs e)
        {
            ManagePeople managePeople = new ManagePeople();
            managePeople.ShowDialog();
        }

        private void TSM_Users_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }

        private void TSMI_CurrentUser_Click(object sender, EventArgs e)
        {
            UserDetails currentUser = new UserDetails();
            currentUser.ShowDialog();
        }

        private void TSMI_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangeUserPassword changeUserPassword = new ChangeUserPassword(); // we need to send here the current user
            changeUserPassword.ShowDialog();
        }
    }
}
