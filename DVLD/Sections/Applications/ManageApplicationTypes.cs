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
    public partial class ManageApplicationTypes: Form
    {
        public ManageApplicationTypes()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        void LoadApplicationTypes()
        {
            DGV_ApplicationTypes.DataSource = clsApplicationTypes_BLL.GetApplicationTypes();
            DGV_ApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void TSMI_UpdateApplicationType_Click(object sender, EventArgs e)
        {
            UpdateApplication updateApplication = new UpdateApplication();
            updateApplication.ShowDialog();
        }
    }
}
