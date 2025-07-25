﻿using DVLD.Sections.Applications.Driving_Licenses_Services.Licenses;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments;
using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_BLL.Countries;
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

namespace DVLD.Sections.Applications.Manage_Applications.Local_License_Applications
{
    public partial class ManageLocalLicenseApplications : Form
    {
        DataTable DTLocalLicenseApplications;

        public ManageLocalLicenseApplications()
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

        void RefreshLocalLicenseApplications()
        {
            LoadLocalLicensApplications();
            LocalLicenseApplicationsCount();
        }

        private void BTN_AddLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            LocalLicense localLicense = new LocalLicense();
            localLicense.ShowDialog();
            RefreshLocalLicenseApplications();
        }

        private void CB_FilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FilterBy.SelectedItem.ToString() == "None")
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                RefreshLocalLicenseApplications();
            }
            else
                TB_FilterationValue.Enabled = true;
        }

        void FilterBy(string FilterBy)
        {
            if (FilterBy == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(TB_FilterationValue.Text, out int LDAppID))
                    DTLocalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = '{LDAppID}'";
            }
            else
                DTLocalLicenseApplications.DefaultView.RowFilter = $"{FilterBy} = '{TB_FilterationValue.Text}'";
        }

        private void TB_FilterationValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_FilterationValue.Text))
            {
                TB_FilterationValue.Text = string.Empty;
                TB_FilterationValue.Enabled = false;
                RefreshLocalLicenseApplications();
                return;
            }

            switch (CB_FilterBy.SelectedItem.ToString())
            {
                case "L.D.L AppID":

                    FilterBy("LocalDrivingLicenseApplicationID");

                    break;

                case "National No":

                    FilterBy("NationalNo");

                    break;

                case "Full Name":

                    FilterBy("FullName");

                    break;
                case "Status":

                    FilterBy("Status");

                    break;

                default:
                    break;

            }
        }

        private void CMS_LocalLicenseApplicationsActions_Opening(object sender, CancelEventArgs e)
        {
            EnableCMS_LocalLicenseApplicationsActionsItems();
            switch (DGV_LocalLicenseApplications.CurrentRow.Cells[6].Value.ToString())
            {
                case "New":
                    TSMI_IssueLicense_FirstTime.Enabled = false;
                    TSMI_ShowLicense.Enabled = false;
                    switch (DGV_LocalLicenseApplications.CurrentRow.Cells[5].Value.ToString())
                    {
                        case "0":
                            TSMI_WrittenTest.Enabled = false;
                            TSMI_StreetTest.Enabled = false;
                            break;
                        case "1":
                            TSMI_VisionTest.Enabled = false;
                            TSMI_StreetTest.Enabled = false;
                            break;
                        case "2":
                            TSMI_VisionTest.Enabled = false;
                            TSMI_WrittenTest.Enabled = false;
                            break;
                        case "3":
                            TSMI_ScheduleTests.Enabled = false;
                            TSMI_IssueLicense_FirstTime.Enabled = true;
                            break;
                    }
                    break;

                case "Canceled":

                    TSMI_CancelApplication.Enabled = false;
                    TSMI_ScheduleTests.Enabled = false;
                    TSMI_IssueLicense_FirstTime.Enabled = false;
                    TSMI_ShowLicense.Enabled = false;
                    TSMI_PersonLicenseHistory.Enabled = false;
                    break;
                case "Completed":
                    TSMI_UpdateApplication.Enabled = false;
                    TSMI_DeleteApplication.Enabled = false;
                    TSMI_CancelApplication.Enabled = false;
                    TSMI_ScheduleTests.Enabled = false;
                    TSMI_IssueLicense_FirstTime.Enabled = false;
                    break;
            }
        }

        void EnableCMS_LocalLicenseApplicationsActionsItems()
        {
            TSMI_IssueLicense_FirstTime.Enabled = true;
            TSMI_ShowLicense.Enabled = true;
            TSMI_CancelApplication.Enabled = true;
            TSMI_ScheduleTests.Enabled = true;
            TSMI_PersonLicenseHistory.Enabled = true;
            TSMI_UpdateApplication.Enabled = true;
            TSMI_DeleteApplication.Enabled = true;

            TSMI_VisionTest.Enabled = true;
            TSMI_WrittenTest.Enabled = true;
            TSMI_StreetTest.Enabled = true;
        }

        private void TSMI_ApplicationDetails_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value));
            clsApplications_BLL Application;
            if (LocalLicenseApplication != null && (Application = clsApplications_BLL.Find(LocalLicenseApplication.ApplicationID)) != null)
            {
                LicenseApplicationInfo licenseApplicationInfo = new LicenseApplicationInfo(LocalLicenseApplication, Application);
                licenseApplicationInfo.ShowDialog();
            }
            else
                MessageBox.Show("The selected local license application doesn't exists anymore", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TSMI_UpdateApplication_Click(object sender, EventArgs e)
        {
            //..
        }

        private void TSMI_DeleteApplication_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete this LDL.Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                if (clsLocalLicenseApplication_BLL.Delete(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("LDL.Application has been Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshLocalLicenseApplications();
                }
                else
                    MessageBox.Show("The Current LDL.Application can't be deleted, Because it has data linked to it", "Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("LDL.Application Deletion has been canceled", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_CancelApplication_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value));
            clsApplications_BLL Application;
            if (LocalLicenseApplication != null && (Application = clsApplications_BLL.Find(LocalLicenseApplication.ApplicationID)) != null)
            {
                if (Application.ApplicationStatus == enApplicationStatus.New)
                {
                    if (MessageBox.Show("Are you sure you want to cancel the current application!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;

                    Application.ApplicationStatus = enApplicationStatus.Canceled;
                    Application.LastStatusDate = DateTime.Now;
                    if (Application.Save())
                    {
                        MessageBox.Show("The selected local license application has been canceled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshLocalLicenseApplications();
                        return;
                    }
                    MessageBox.Show("The selected local license application has not been canceled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("The selected local license application cannot be canceled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("The selected local license application doesn't exists anymore", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TSMI_VisionTest_Click(object sender, EventArgs e)
        {
            TestAppointments VisionTestAppointments = new TestAppointments(clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value)), enTestType.VisionTest);
            if (VisionTestAppointments != null)
            {
                VisionTestAppointments.ShowDialog();
                RefreshLocalLicenseApplications();
            }
            else
                MessageBox.Show("The selected Test Appointment doesn't exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TSMI_WrittenTest_Click(object sender, EventArgs e)
        {
            TestAppointments WrittenTestAppointments = new TestAppointments(clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value)), enTestType.WrittenTest);
            if (WrittenTestAppointments != null)
            {
                WrittenTestAppointments.ShowDialog();
                RefreshLocalLicenseApplications();
            }
            else
                MessageBox.Show("The selected Test Appointment doesn't exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TSMI_StreetTest_Click(object sender, EventArgs e)
        {
            TestAppointments StreetTestAppointments = new TestAppointments(clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value)), enTestType.StreetTest);
            if (StreetTestAppointments != null)
            {
                StreetTestAppointments.ShowDialog();
                RefreshLocalLicenseApplications();
            }
            else
                MessageBox.Show("The selected Test Appointment doesn't exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TSMI_IssueLicense_FirstTime_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value));
            if (LocalLicenseApplication != null)
            {
                IssueLicense_FirstTime issueLicense_FirstTime = new IssueLicense_FirstTime(ref LocalLicenseApplication);
                issueLicense_FirstTime.ShowDialog();
                RefreshLocalLicenseApplications();
            }
            else
                MessageBox.Show("The selected local license application doesn't exists anymore", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TSMI_ShowLicense_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value));
            clsLicense_BLL License = clsLicense_BLL.FindByAppID(LocalLicenseApplication.ApplicationID);
            if (LocalLicenseApplication != null)
            {
                if (License != null)
                {
                    LicenseInfo licenseDetails = new LicenseInfo(License);
                    licenseDetails.ShowDialog();
                    RefreshLocalLicenseApplications();
                }
            }
            else
                MessageBox.Show("The selected local license application doesn't exists anymore", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TSMI_PersonLicenseHistory_Click(object sender, EventArgs e)
        {
            clsLocalLicenseApplication_BLL LocalLicenseApplication = clsLocalLicenseApplication_BLL.Find(Convert.ToInt32(DGV_LocalLicenseApplications.CurrentRow.Cells[0].Value));
            if (LocalLicenseApplication != null)
            {
                LicenseHistory licenseHistory = new LicenseHistory(LocalLicenseApplication.NationalNo);
                licenseHistory.ShowDialog();
            }
        }
    }
}
