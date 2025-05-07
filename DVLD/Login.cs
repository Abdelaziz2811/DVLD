using DVLD_BLL.Users;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTB_Username.Text) && string.IsNullOrWhiteSpace(TXTB_Password.Text))
                GetRememberedUserCredentials();
        }

        private void BTN_Login_Click(object sender, EventArgs e)
        {
            clsUsers_BLL User = clsUsers_BLL.Find(TXTB_Username.Text);
            if (User != null)
            {
                if (User.IsActive)
                {
                    if (TXTB_Password.Text == User.Password)
                    {
                        if (CHB_Rememberme.Checked)
                        {
                            using (StreamWriter streamWriter = new StreamWriter("RememberedUsers.txt"))
                            {
                                streamWriter.WriteLine(User.UserName);
                                streamWriter.WriteLine(User.Password);
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Icorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("User isn't active please contact your admin", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
                MessageBox.Show("Please enter your login credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void GetRememberedUserCredentials()
        {
            string[] Data = new string[2];
            using (StreamReader streamReader = new StreamReader("RememberedUsers.txt"))
            {
                string DataLine;
                int i = 0;
                while ((DataLine = streamReader.ReadLine()) != null && i < Data.Length)
                {
                    Data[i] = DataLine;
                    i++;
                }
            }
            if (Data[0] != null && Data[1] != null)
            {
                TXTB_Username.Text = Data[0];
                TXTB_Password.Text = Data[1];
            }
        }
    }
}
