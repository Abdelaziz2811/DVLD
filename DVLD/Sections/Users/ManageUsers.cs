using DVLD.Sections.Users;
using DVLD_BLL;
using DVLD_BLL.Countries;
using DVLD_BLL.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD
{
    public partial class ManageUsers: Form
    {
        DataTable DTUsers;
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsersRecords();
            SetUsersRecordCount();
            InitializeCB_FilterBy();
        }

        void InitializeCB_FilterBy()
        {
            CB_FilterBy.SelectedItem = "None";
            TB_FilterationValue.Enabled = false;
        }


        void RefreshUsersRecords()
        {
            LoadUsersRecords();
            SetUsersRecordCount();
        }

        void LoadUsersRecords()
        {
            DTUsers = clsUsers_BLL.GetUsersRecords();
            DGV_Users.DataSource = DTUsers;
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
            clsUsers_BLL User = clsUsers_BLL.Find(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value));
            UserDetails currentUser = new UserDetails(ref User);
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
                MessageBox.Show("Failed to delete user, due to data connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void TSMI_ChangePassword_Click(object sender, EventArgs e)
        {
            clsUsers_BLL User = clsUsers_BLL.Find(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value));
            ChangeUserPassword changePassword = new ChangeUserPassword(ref User);
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

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() != "None")
                TB_FilterationValue.Enabled = true;
            else
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                LoadUsersRecords();
            }
        }

        bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(TB_FilterationValue.Text))
            {
                MessageBox.Show("Please enter a value to filter by.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        void FilterBy(string FilterBy)
        {
            if (FilterBy == "IsActive")
            {
                if (TB_FilterationValue.Text.ToLower() == "true")
                {
                    DTUsers.DefaultView.RowFilter = $"{FilterBy} = TRUE";
                }
                else if (TB_FilterationValue.Text.ToLower() == "false")
                    DTUsers.DefaultView.RowFilter = $"{FilterBy} = FALSE";
            }
            else
                DTUsers.DefaultView.RowFilter = $"{FilterBy} = '{TB_FilterationValue.Text}'";
        }

        private void TB_FilterationValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!IsInputValid()) return;

                switch (CB_FilterBy.SelectedItem.ToString())
                {
                    case "User ID":

                        FilterBy("UserID");

                        break;

                    case "National No.":

                        FilterBy("NationalNo");

                        break;

                    case "User Name":

                        FilterBy("UserName");

                        break;
                    case "Full Name":

                        FilterBy("FirstName  + ' ' +  SecondName  + ' ' +  ThirdName  + ' ' +  LastName");

                        break;

                    case "Is Active":

                        FilterBy("IsActive");

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
