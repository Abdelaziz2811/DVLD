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

namespace DVLD.Sections.Applications
{
    public partial class UpdateApplication: Form
    {
        clsApplicationType_BLL ApplicationType;
        public UpdateApplication(clsApplicationType_BLL ApplicationType)
        {
            InitializeComponent();

            this.ApplicationType = ApplicationType;
        }

        private void UpdateApplication_Load(object sender, EventArgs e)
        {
            GetApplicationTypeInfo();
        }

        void GetApplicationTypeInfo()
        {
            LB_ApplicationID.Text = ApplicationType.ApplicationTypeID.ToString();
            TB_ApplicationTitle.Text = ApplicationType.ApplicationTypeTitle;
            NUD_ApplicationFees.Value = ApplicationType.ApplicationFees;
        }

        void SetApplicationInfo()
        {
            ApplicationType.ApplicationTypeTitle = TB_ApplicationTitle.Text;
            ApplicationType.ApplicationFees = (short)NUD_ApplicationFees.Value;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (ApplicationType.ApplicationTypeTitle == TB_ApplicationTitle.Text
                && ApplicationType.ApplicationFees == NUD_ApplicationFees.Value)
            {
                MessageBox.Show("Please update application info", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (LB_ApplicationID.Text == string.Empty
                || TB_ApplicationTitle.Text == string.Empty)
            {
                MessageBox.Show("Invalid application info", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SetApplicationInfo();
                if (ApplicationType.Update())
                {
                    MessageBox.Show("Application updated succesfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Application hasn't been updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
