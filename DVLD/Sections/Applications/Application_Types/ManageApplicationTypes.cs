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
            ApplicationTypesCount();
        }

        void LoadApplicationTypes()
        {
            DGV_ApplicationTypes.DataSource = clsApplicationType_BLL.GetApplicationTypes();
            DGV_ApplicationTypes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        void ApplicationTypesCount()
        {
            LB_RecordsCount.Text = DGV_ApplicationTypes.RowCount.ToString();
        }

        void RefreshApplicationTypes()
        {
            LoadApplicationTypes();
            ApplicationTypesCount();
        }

        private void TSMI_UpdateApplicationType_Click(object sender, EventArgs e)
        {
            clsApplicationType_BLL ApplicationType = clsApplicationType_BLL.Find(Convert.ToInt32(DGV_ApplicationTypes.CurrentRow.Cells[0].Value));
            if (ApplicationType != null)
            {
                UpdateApplication updateApplication = new UpdateApplication(ApplicationType);
                updateApplication.ShowDialog();
                RefreshApplicationTypes();
            }
            else
            {
                MessageBox.Show("Please select an application to update.", "No Application Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
