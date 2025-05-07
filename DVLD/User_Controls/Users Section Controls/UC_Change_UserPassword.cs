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
    public partial class UC_Change_UserPassword : UserControl
    {
        public UC_Change_UserPassword()
        {
            InitializeComponent();
        }

        private bool IsInputsValid(clsUsers_BLL User)
        {
            bool IsValid = true;
            EP_PasswordValidation.Clear();


            if (TB_CurrentPassword.Text != User.Password)
            {
                EP_PasswordValidation.SetError(TB_CurrentPassword, "Current Password is incorrect");
                IsValid = false;
            }

            if (TB_NewPassword.Text.Length < 4 || !TB_NewPassword.Text.All(char.IsDigit))
            {
                EP_PasswordValidation.SetError(TB_NewPassword, "Password must be at least 4 characters long and valid");
                IsValid = false;
            }

            if (TB_NewPassword.Text == User.Password)
            {
                EP_PasswordValidation.SetError(TB_NewPassword, "You're using this password, Please enter a new one");
                IsValid = false;
            }

            if (TB_ConfirmPassword.Text != TB_NewPassword.Text)
            {
                EP_PasswordValidation.SetError(TB_ConfirmPassword, "Passwords don't match");
                IsValid = false;
            }

            return IsValid;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            clsUsers_BLL User = clsUsers_BLL.Find(Convert.ToInt32(UserInfo.LB_UserID.Text));
            
            if (User != null)
            {
                if (IsInputsValid(User))
                {
                    User.Password = TB_NewPassword.Text;
                    if (User.Save())
                    {
                        MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (User.UserID == clsGlobalSettings.CurrentUser.UserID)
                            clsGlobalSettings.CurrentUser.Password = User.Password;
                        
                        this.Parent.FindForm().Close();
                    }
                    else
                        MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please correct the errors in the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
