using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.User_Controls.Applications_Section.Local_License
{
    public partial class UC_LicenseHistory : UserControl
    {
        public UC_LicenseHistory()
        {
            InitializeComponent();
        }

        private void TB_LicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TB_LicenseType.SelectedIndex == 0)
            {
                LB_RecordsCount.Text = DGV_LocalLicenseHistory.RowCount.ToString();
            }
            else
                LB_RecordsCount.Text = DGV_InternationalLicenseHistory.RowCount.ToString();
        }
    }
}
