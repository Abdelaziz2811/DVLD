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
        clsUser_BLL User;
        public Add_UpdateUser(ref clsUser_BLL User)
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
                UC_Update_AddUser.Person_Selector.GB_Search.Enabled = false;
                LB_Opration.Text = "Update User";
                UC_Update_AddUser.GetUserInfoToUpdate(User);
                SetCurrentTapTo(UC_Update_AddUser.TP_LoginInfo);
            }
        }

        void SetCurrentTapTo(TabPage Tab)
        {
            UC_Update_AddUser.TC_UserInfo.SelectedTab = Tab;
        }

        private void Add_UpdateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UC_Update_AddUser.BTN_Save.Tag.ToString() == "Inputs are valid")
            {
                UC_Update_AddUser.SetUserInformation(User);
                if (User.Save())
                {
                    if (User.Mode == enUMode.Add)
                    {
                        UC_Update_AddUser.LB_UserID.Text = User.UserID.ToString();
                        MessageBox.Show($"User '{User.UserName}' added seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (clsGlobalSettings.CurrentUser.UserID == User.UserID)
                            clsGlobalSettings.CurrentUser = User;

                        MessageBox.Show($"User updated seccessfuly", "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                if ((MessageBox.Show("The operation you're making will be canceled, Are you sure you to leave this form ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
