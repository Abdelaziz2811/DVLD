using DVLD_BLL;
using DVLD_BLL.Countries;
using DVLD_BLL.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Drivers
{
    public partial class Drivers : Form
    {
        DataTable DTPDrivers;
        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            LoadDrivers();
            DriversCount();
            InitializeCB_FilterBy();
        }

        void LoadDrivers()
        {
            DTPDrivers = clsDrivers_BLL.LoadDrivers();
            DGV_Drivers.DataSource = DTPDrivers;
        }

        void DriversCount()
        {
            LB_RecordsCount.Text = DGV_Drivers.RowCount.ToString();
        }

        void InitializeCB_FilterBy()
        {
            CB_FilterBy.SelectedIndex = 0;
        }

        private void TB_FilterationValue_TextChanged(object sender, EventArgs e)
        {
            switch (CB_FilterBy.SelectedItem.ToString())
            {
                case "Person ID":

                    FilterBy("PersonID");

                    break;

                case "Driver ID":

                    FilterBy("DriverID");

                    break;

                case "National No.":

                    FilterBy("NationalNo");

                    break;

                case "Full Name":

                    FilterBy("FullName");

                    break;

                default:
                    break;
            }
        }

        void FilterBy(string FilterBy)
        {
            if (FilterBy == "DriverID")
            {
                if (int.TryParse(TB_FilterationValue.Text, out int DriverID))
                {
                    DTPDrivers.DefaultView.RowFilter = $"{FilterBy} = '{DriverID}'";
                }
            }
            else if (FilterBy == "PersonID")
            {
                if (int.TryParse(TB_FilterationValue.Text, out int PersonID))
                {
                    DTPDrivers.DefaultView.RowFilter = $"{FilterBy} = '{PersonID}'";
                }
            }
            else
                DTPDrivers.DefaultView.RowFilter = $"{FilterBy} = '{TB_FilterationValue.Text}'";
        }

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() == "None")
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                LoadDrivers();
            }
            else
                TB_FilterationValue.Enabled = true;
        }
    }
}
