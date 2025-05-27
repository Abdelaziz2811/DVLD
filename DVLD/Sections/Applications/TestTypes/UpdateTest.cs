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
    public partial class UpdateTest : Form
    {
        clsTestTypes_BLL TestType;
        public UpdateTest(clsTestTypes_BLL TestType)
        {
            InitializeComponent();

            this.TestType = TestType;
        }

        private void UpdateTest_Load(object sender, EventArgs e)
        {
            GetTestTypeInfo();
        }

        void GetTestTypeInfo()
        {
            LB_TestID.Text = TestType.TestTypeID.ToString();
            TB_TestTitle.Text = TestType.TestTypeTitle.ToString();
            TB_TestDescription.Text = TestType.TestTypeDescription.ToString();
            NUD_TestFees.Value = TestType.TestTypeFees;
        }

        void SetTestInfo()
        {
            TestType.TestTypeTitle = TB_TestTitle.Text;
            TestType.TestTypeDescription = TB_TestDescription.Text;
            TestType.TestTypeFees = Convert.ToInt16(NUD_TestFees.Value);
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (TestType.TestTypeTitle == TB_TestTitle.Text
                && TestType.TestTypeDescription == TB_TestDescription.Text
                && TestType.TestTypeFees == NUD_TestFees.Value)
            {
                MessageBox.Show("Please update test info", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (TB_TestTitle.Text == string.Empty
                || TB_TestDescription.Text == string.Empty)
            {
                MessageBox.Show("Invalid test info", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SetTestInfo();
                if (TestType.Update())
                {
                    MessageBox.Show("Test updated succesfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Test info hasn't been updated", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
