using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL.Users;

namespace DVLD.User_Controls.Users_Section_Controls
{
    public partial class UC_Add_UpdateUser: UserControl
    {
        public UC_Add_UpdateUser()
        {
            InitializeComponent();
        }

        private void BTN_NextToLoginInfo_Click(object sender, EventArgs e)
        {
            if (Person_Selector.Person_Info.LB_PersonID.Text == "----")
            {
                MessageBox.Show("Please select a person first", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            TC_UserInfo.SelectedIndex = 1;
        }

        private void TB_Username_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TB_UserName.Text))
            {
                clsUsers_BLL User = clsUsers_BLL.Find(TB_UserName.Text);
                if (User != null)
                {
                    if (TB_UserName.Text == User.UserName)
                    {
                        if (int.TryParse(LB_UserID.Text, out int ID))
                            if (ID == User.UserID) return;

                        EP_UserLoginInfoValidation.SetError(TB_UserName, "Username already exists");
                        e.Cancel = true;
                    }
                    else EP_UserLoginInfoValidation.Clear();
                }
            }
        }

        bool IsInputsValid()
        {
            bool IsValid = true;
            EP_UserLoginInfoValidation.Clear();

            if (string.IsNullOrWhiteSpace(TB_UserName.Text) || !TB_UserName.Text.All(char.IsLetterOrDigit))
            {
                EP_UserLoginInfoValidation.SetError(TB_UserName, "Please enter valid username");
                IsValid = false;
            }

            if (TB_Password.Text.Length < 4 || !TB_Password.Text.All(char.IsDigit))
            {
                EP_UserLoginInfoValidation.SetError(TB_Password, "Password must be at least 4 characters long and valid");
                IsValid = false;
            }

            if (TB_ConfirmPassword.Text != TB_Password.Text)
            {
                EP_UserLoginInfoValidation.SetError(TB_ConfirmPassword, "Passwords don't match");
                IsValid = false;
            }
            return IsValid;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (!IsInputsValid())
            {
                MessageBox.Show("Please enter valid fields before save perform.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                BTN_Save.Tag = "Inputs are valid";
                this.Parent.FindForm().Close();
            }
        }

        private void TC_UserInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TC_UserInfo.SelectedTab.Text == "Login Info")
                if (Person_Selector.Person_Info.LB_PersonID.Text == "----")
                {
                    TC_UserInfo.SelectedTab = TP_PersonalInfo;
                    MessageBox.Show("Please select a person first", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
