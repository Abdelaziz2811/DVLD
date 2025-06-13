using DVLD.User_Controls.Applications_Section.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments
{
    public partial class TakeTest : Form
    {
        string FormOperation = string.Empty;
        public TakeTest(string FormOperation)
        {
            InitializeComponent();

            this.FormOperation = FormOperation;
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            SetFormOperation();
        }

        void SetFormOperation()
        {
            UC_TestDetails.LB_Operation.Text = FormOperation;
        }
    }
}
