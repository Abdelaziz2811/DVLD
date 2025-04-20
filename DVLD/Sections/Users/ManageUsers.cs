using DVLD.Sections.Users;
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

namespace DVLD
{
    public partial class ManageUsers: Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsersRecords();
            SetUsersRecordCount();
        }

        void RefreshUsersRecords()
        {
            LoadUsersRecords();
            SetUsersRecordCount();
        }

        void LoadUsersRecords()
        {
            DGV_Users.DataSource = clsUsers_BLL.GetUsersRecords();
        }

        void SetUsersRecordCount()
        {
            LBL_RecordCount.Text = DGV_Users.Rows.Count.ToString();
        }

        private void BTN_AddUser_Click(object sender, EventArgs e)
        {
            clsUsers_BLL User = new clsUsers_BLL();
            Add_UpdateUser addUser = new Add_UpdateUser(ref User);
            addUser.ShowDialog();
            RefreshUsersRecords();
        }

        private void TSMI_ShowDetails_Click(object sender, EventArgs e)
        {
            UserDetails currentUser = new UserDetails();
            currentUser.ShowDialog();
            RefreshUsersRecords();
        }

        private void TSMI_AddUser_Click(object sender, EventArgs e)
        {
            BTN_AddUser.PerformClick();
        }

        private void TSMI_UpdateUser_Click(object sender, EventArgs e)
        {
            clsUsers_BLL User = clsUsers_BLL.Find(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value));
            Add_UpdateUser addUser = new Add_UpdateUser(ref User);
            addUser.ShowDialog();
            RefreshUsersRecords();
        }

        private void TSMI_DeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            if (clsUsers_BLL.Delete(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshUsersRecords();
            }
            else
            {
                MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TSMI_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangeUserPassword changePassword = new ChangeUserPassword(); // we need to send the selected user form DGV
            changePassword.ShowDialog();
        }

        private void TSMI_Refresh_Click(object sender, EventArgs e)
        {
            RefreshUsersRecords();
        }

        private void TSMI_SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
