using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Users_Section_Controls
{
    public partial class UC_Change_UserPassword: UserControl
    {
        public UC_Change_UserPassword() // we must recive the boject of the user so we can make chages and set the new password
        {
            InitializeComponent();
        }

        private bool IsInputsValid()
        {
            bool IsValid = true;
            EP_PasswordValidation.Clear();


            if (TB_CurrentPassword.Text != "1234") // 1234 will be replace with CurrentUser.Password this is just for demo purpose
            {
                EP_PasswordValidation.SetError(TB_CurrentPassword, "Current Password is incorrect");
                IsValid = false;
            }

            if (TB_NewPassword.Text.Length < 4 || !TB_NewPassword.Text.All(char.IsDigit))
            {
                EP_PasswordValidation.SetError(TB_NewPassword, "Password must be at least 4 characters long and valid");
                IsValid = false;
            }

            if (TB_NewPassword.Text == TB_CurrentPassword.Text) // TB_CurrentPassword.Text will be replace with User.Password weather it is a current user or the user we selected this form seve both
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
            if (!IsInputsValid())
            {
                MessageBox.Show("Please correct the errors in the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Save the new password to the database
                // here we will set the current user password to the new one and save it to the database
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
