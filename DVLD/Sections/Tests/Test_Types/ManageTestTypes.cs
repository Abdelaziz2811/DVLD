using DVLD_BLL.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Tests
{
    public partial class ManageTestTypes : Form
    {
        public ManageTestTypes()
        {
            InitializeComponent();
        }

        private void ManageTestsTypes_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
            TestTypesCount();
        }
        
        void LoadTestTypes()
        {
            DGV_TestTypes.DataSource = clsTestType_BLL.GetTestTypes();
        }

        void TestTypesCount()
        {
            LB_RecordsCount.Text = DGV_TestTypes.RowCount.ToString();
        }

        void RefreshTestTypes()
        {
            LoadTestTypes();
            TestTypesCount();
        }

        private void TSMI_UpdateTestType_Click(object sender, EventArgs e)
        {
            clsTestType_BLL TestType = clsTestType_BLL.Find(Convert.ToInt32(DGV_TestTypes.CurrentRow.Cells[0].Value));
            if (TestType != null)
            {
                UpdateTest updateTest = new UpdateTest(TestType);
                updateTest.ShowDialog();
                RefreshTestTypes();
            }
            else
                MessageBox.Show("Please select a Test to update.", "No Test Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
