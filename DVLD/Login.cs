using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            //if (TXTB_Username.Text == "User1" && TXTB_Password.Text == "1234")
            //{
                this.DialogResult = DialogResult.OK;
                this.Close();
            //}
            /*else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
