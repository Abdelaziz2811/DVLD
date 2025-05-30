﻿using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.Countries;
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
        DataTable DTLocalLicenseApplications;

        public LocalLicenseApplications()
        {
            InitializeComponent();
        }

        private void LocalLicenseApplications_Load(object sender, EventArgs e)
        {
            LoadLocalLicensApplications();
            CustomizeDGVColumns();
            LocalLicenseApplicationsCount();
            InitializeCB_FilterBy();
        }

        void LoadLocalLicensApplications()
        {
            DTLocalLicenseApplications = clsLocalLicenseApplication_BLL.GetLocalLicenseApplications();
            DGV_LocalLicenseApplications.DataSource = DTLocalLicenseApplications;
        }

        void CustomizeDGVColumns()
        {
            DGV_LocalLicenseApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "L.D.L AppID";
            DGV_LocalLicenseApplications.Columns["NationalNo"].HeaderText = "National No";
            DGV_LocalLicenseApplications.Columns["FullName"].HeaderText = "Full Name";
            DGV_LocalLicenseApplications.Columns["ApplicationDate"].HeaderText = "Application Date";
            DGV_LocalLicenseApplications.Columns["PassedTestCount"].HeaderText = "Passed Test Count";
        }

        void LocalLicenseApplicationsCount()
        {
            LB_RecordsCount.Text = DGV_LocalLicenseApplications.RowCount.ToString();
        }

        void InitializeCB_FilterBy()
        {
            CB_FilterBy.SelectedIndex = 0;
        }

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() == "None")
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                LoadLocalLicensApplications();
            }
            else
                TB_FilterationValue.Enabled = true;
        }

        bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(TB_FilterationValue.Text))
            {
                MessageBox.Show("Please enter a value to filter by.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else return true;
        }

        void FilterBy(string FilterBy)
        {
                DTLocalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = '{TB_FilterationValue.Text}'";
        }

        private void TB_FilterationValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!IsInputValid()) return;

                switch (CB_FilterBy.SelectedItem.ToString())
                {
                    case "L.D.L AppID":

                        FilterBy("L.D.L AppID");

                        break;

                    case "National No":

                        FilterBy("National No");

                        break;

                    case "Full Name":

                        FilterBy("Full Name");

                        break;
                    case "Status":

                        FilterBy("Status");

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
