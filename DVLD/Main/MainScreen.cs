using DVLD.Sections.Applications;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License;
using DVLD.Sections.Applications.Manage_Applications.Local_License_Applications;
using DVLD.Sections.Drivers;
using DVLD.Sections.Tests;
using DVLD.Sections.Users;
using DVLD_BLL.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainScreen: Form
    {
        public MainScreen(string Username)
        {
            InitializeComponent();

            clsGlobalSettings.CurrentUser = clsUsers_BLL.Find(Username);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SetFormSize();
        }

        void SetFormSize()
        {
            Rectangle workArea = Screen.PrimaryScreen.WorkingArea;
            this.Location = new Point(workArea.Left - 8, workArea.Top);
            this.Size = new Size(workArea.Width + 19, workArea.Height + 8);
        }

        private void TSM_People_Click(object sender, EventArgs e)
        {
            ManagePeople managePeople = new ManagePeople();
            managePeople.Show();
        }

        private void TSM_Users_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }

        private void TSMI_CurrentUser_Click(object sender, EventArgs e)
        {
            UserDetails currentUser = new UserDetails(ref clsGlobalSettings.CurrentUser);
            currentUser.ShowDialog();
        }

        private void TSMI_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangeUserPassword changeUserPassword = new ChangeUserPassword(ref clsGlobalSettings.CurrentUser);
            changeUserPassword.ShowDialog();
        }

        private void TSMI_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void TSMI_ManageApplicationTypes_Click(object sender, EventArgs e)
        {
            ManageApplicationTypes manageApplicationTypes = new ManageApplicationTypes();
            manageApplicationTypes.Show();
        }

        private void TSMI_ManageTestTypes_Click(object sender, EventArgs e)
        {
            ManageTestTypes manageTestsTypes = new ManageTestTypes();
            manageTestsTypes.ShowDialog();
        }

        private void TSMI_LocalLicense_Click(object sender, EventArgs e)
        {
            LocalLicense local_License = new LocalLicense();
            local_License.ShowDialog();
        }

        private void TSMI_LocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            ManageLocalLicenseApplications localLicenseApplications = new ManageLocalLicenseApplications();
            localLicenseApplications.ShowDialog();
        }

        private void TSM_Drivers_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers();
            drivers.ShowDialog();
        }
    }
}
