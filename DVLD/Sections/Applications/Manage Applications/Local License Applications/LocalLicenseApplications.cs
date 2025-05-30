using DVLD_BLL.Applications.LocalLicenseApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Manage_Applications.Local_License_Applications
{
    public partial class LocalLicenseApplications : Form
    {
        public LocalLicenseApplications()
        {
            InitializeComponent();
        }

        private void LocalLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadLocalLicensApplications();
        }

        void LoadLocalLicensApplications()
        {
            DGV_LocalLicenseApplications.DataSource = clsLocalLicenseApplication_BLL.GetLocalLicenseApplications();
        }
    }
}
