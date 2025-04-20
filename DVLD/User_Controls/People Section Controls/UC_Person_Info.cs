using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DVLD.Properties;
using DVLD_BLL;

namespace DVLD.User_Controls
{
    public partial class UC_Person_Info: UserControl
    {
        public UC_Person_Info()
        {
            InitializeComponent();
        }

        private void BTN_EditPersonInfo_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(Convert.ToInt32(Convert.ToInt32(LB_PersonID.Text)));
            if (Person != null)
            {
                AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
                add_UpdatePerson.ShowDialog();

                this.Parent.FindForm().Close();
            }
            else
            {
                MessageBox.Show($"Person with ID '{LB_PersonID.Text} is not found'.", "No Person Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
