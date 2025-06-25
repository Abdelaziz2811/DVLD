using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Applications_Section
{
    public partial class UC_LicenseApplicationInfo : UserControl
    {
        public UC_LicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void BTN_PersonInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LB_ApplicantName.Text) || LB_ApplicantName.Text != "--")
            {
                clsPerson_BLL Person = clsPerson_BLL.FindByName(LB_ApplicantName.Text);
                if (Person != null)
                {
                    PersonDetails personDetails = new PersonDetails(ref Person);
                    personDetails.ShowDialog();
                }
                else
                    MessageBox.Show("Person Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
