namespace DVLD
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.MS_MainSections = new System.Windows.Forms.MenuStrip();
            this.TSM_Applications = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DrivingLicenseServices = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_NewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RenewDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ReplaceLostOrDamagedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ReleaseDetainedDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_RetakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_LocalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_InternationalDrivingLicenseApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ManageDetainedLicenses = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSI_DetainLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ManageApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_People = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Drivers = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_AccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_MainSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_MainSections
            // 
            this.MS_MainSections.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MS_MainSections.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS_MainSections.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.MS_MainSections.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Applications,
            this.TSM_People,
            this.TSM_Drivers,
            this.TSM_Users,
            this.TSM_AccountSettings});
            this.MS_MainSections.Location = new System.Drawing.Point(0, 0);
            this.MS_MainSections.Name = "MS_MainSections";
            this.MS_MainSections.Size = new System.Drawing.Size(1047, 48);
            this.MS_MainSections.TabIndex = 1;
            this.MS_MainSections.Tag = "";
            this.MS_MainSections.Text = "Main Sections";
            // 
            // TSM_Applications
            // 
            this.TSM_Applications.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSM_Applications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DrivingLicenseServices,
            this.TSMI_ManageApplications,
            this.TSMI_DetainLicense,
            this.TSMI_ManageApplicationType,
            this.mToolStripMenuItem});
            this.TSM_Applications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSM_Applications.Image = global::DVLD.Properties.Resources.Applications_s;
            this.TSM_Applications.Name = "TSM_Applications";
            this.TSM_Applications.Size = new System.Drawing.Size(147, 44);
            this.TSM_Applications.Text = "Applications";
            // 
            // TSMI_DrivingLicenseServices
            // 
            this.TSMI_DrivingLicenseServices.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TSMI_DrivingLicenseServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_NewDrivingLicense,
            this.TSMI_RenewDrivingLicense,
            this.TSMI_ReplaceLostOrDamagedLicense,
            this.TSMI_ReleaseDetainedDrivingLicense,
            this.TSMI_RetakeTest});
            this.TSMI_DrivingLicenseServices.Name = "TSMI_DrivingLicenseServices";
            this.TSMI_DrivingLicenseServices.Size = new System.Drawing.Size(261, 26);
            this.TSMI_DrivingLicenseServices.Text = "Driving Licenses Services";
            // 
            // TSMI_NewDrivingLicense
            // 
            this.TSMI_NewDrivingLicense.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TSMI_NewDrivingLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.TSMI_NewDrivingLicense.Name = "TSMI_NewDrivingLicense";
            this.TSMI_NewDrivingLicense.Size = new System.Drawing.Size(322, 26);
            this.TSMI_NewDrivingLicense.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.TSMI_LocalLicense_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // TSMI_RenewDrivingLicense
            // 
            this.TSMI_RenewDrivingLicense.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_RenewDrivingLicense.Name = "TSMI_RenewDrivingLicense";
            this.TSMI_RenewDrivingLicense.Size = new System.Drawing.Size(322, 26);
            this.TSMI_RenewDrivingLicense.Text = "Renew Driving License";
            this.TSMI_RenewDrivingLicense.Click += new System.EventHandler(this.TSMI_RenewDrivingLicense_Click);
            // 
            // TSMI_ReplaceLostOrDamagedLicense
            // 
            this.TSMI_ReplaceLostOrDamagedLicense.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ReplaceLostOrDamagedLicense.Name = "TSMI_ReplaceLostOrDamagedLicense";
            this.TSMI_ReplaceLostOrDamagedLicense.Size = new System.Drawing.Size(322, 26);
            this.TSMI_ReplaceLostOrDamagedLicense.Text = "Replace - Lost or Damaged License";
            this.TSMI_ReplaceLostOrDamagedLicense.Click += new System.EventHandler(this.TSMI_ReplaceLostOrDamagedLicense_Click);
            // 
            // TSMI_ReleaseDetainedDrivingLicense
            // 
            this.TSMI_ReleaseDetainedDrivingLicense.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ReleaseDetainedDrivingLicense.Name = "TSMI_ReleaseDetainedDrivingLicense";
            this.TSMI_ReleaseDetainedDrivingLicense.Size = new System.Drawing.Size(322, 26);
            this.TSMI_ReleaseDetainedDrivingLicense.Text = "Release Detained Driving License";
            // 
            // TSMI_RetakeTest
            // 
            this.TSMI_RetakeTest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_RetakeTest.Name = "TSMI_RetakeTest";
            this.TSMI_RetakeTest.Size = new System.Drawing.Size(322, 26);
            this.TSMI_RetakeTest.Text = "Schedule Or Retake Test";
            this.TSMI_RetakeTest.Click += new System.EventHandler(this.TSMI_RetakeTest_Click);
            // 
            // TSMI_ManageApplications
            // 
            this.TSMI_ManageApplications.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TSMI_ManageApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_LocalDrivingLicenseApplications,
            this.TSMI_InternationalDrivingLicenseApplications});
            this.TSMI_ManageApplications.Name = "TSMI_ManageApplications";
            this.TSMI_ManageApplications.Size = new System.Drawing.Size(261, 26);
            this.TSMI_ManageApplications.Text = "Manage Applications";
            // 
            // TSMI_LocalDrivingLicenseApplications
            // 
            this.TSMI_LocalDrivingLicenseApplications.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_LocalDrivingLicenseApplications.Name = "TSMI_LocalDrivingLicenseApplications";
            this.TSMI_LocalDrivingLicenseApplications.Size = new System.Drawing.Size(367, 26);
            this.TSMI_LocalDrivingLicenseApplications.Text = "Local Driving License Applications";
            this.TSMI_LocalDrivingLicenseApplications.Click += new System.EventHandler(this.TSMI_LocalDrivingLicenseApplications_Click);
            // 
            // TSMI_InternationalDrivingLicenseApplications
            // 
            this.TSMI_InternationalDrivingLicenseApplications.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_InternationalDrivingLicenseApplications.Name = "TSMI_InternationalDrivingLicenseApplications";
            this.TSMI_InternationalDrivingLicenseApplications.Size = new System.Drawing.Size(367, 26);
            this.TSMI_InternationalDrivingLicenseApplications.Text = "International Driving License Applications";
            this.TSMI_InternationalDrivingLicenseApplications.Click += new System.EventHandler(this.TSMI_InternationalDrivingLicenseApplications_Click);
            // 
            // TSMI_DetainLicense
            // 
            this.TSMI_DetainLicense.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TSMI_DetainLicense.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ManageDetainedLicenses,
            this.TSMSI_DetainLicense,
            this.TSMI_ReleaseDetainedLicense});
            this.TSMI_DetainLicense.Name = "TSMI_DetainLicense";
            this.TSMI_DetainLicense.Size = new System.Drawing.Size(261, 26);
            this.TSMI_DetainLicense.Text = "Detain Licenses";
            // 
            // TSMI_ManageDetainedLicenses
            // 
            this.TSMI_ManageDetainedLicenses.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ManageDetainedLicenses.Name = "TSMI_ManageDetainedLicenses";
            this.TSMI_ManageDetainedLicenses.Size = new System.Drawing.Size(264, 26);
            this.TSMI_ManageDetainedLicenses.Text = "Manage Detained Licenses";
            // 
            // TSMSI_DetainLicense
            // 
            this.TSMSI_DetainLicense.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMSI_DetainLicense.Name = "TSMSI_DetainLicense";
            this.TSMSI_DetainLicense.Size = new System.Drawing.Size(264, 26);
            this.TSMSI_DetainLicense.Text = "Detain License";
            this.TSMSI_DetainLicense.Click += new System.EventHandler(this.TSMSI_DetainLicense_Click);
            // 
            // TSMI_ReleaseDetainedLicense
            // 
            this.TSMI_ReleaseDetainedLicense.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ReleaseDetainedLicense.Name = "TSMI_ReleaseDetainedLicense";
            this.TSMI_ReleaseDetainedLicense.Size = new System.Drawing.Size(264, 26);
            this.TSMI_ReleaseDetainedLicense.Text = "Release Detained License";
            this.TSMI_ReleaseDetainedLicense.Click += new System.EventHandler(this.TSMI_ReleaseDetainedLicense_Click);
            // 
            // TSMI_ManageApplicationType
            // 
            this.TSMI_ManageApplicationType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ManageApplicationType.Name = "TSMI_ManageApplicationType";
            this.TSMI_ManageApplicationType.Size = new System.Drawing.Size(261, 26);
            this.TSMI_ManageApplicationType.Text = "Manage Application Types";
            this.TSMI_ManageApplicationType.Click += new System.EventHandler(this.TSMI_ManageApplicationTypes_Click);
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.mToolStripMenuItem.Text = "Manage Test Types";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.TSMI_ManageTestTypes_Click);
            // 
            // TSM_People
            // 
            this.TSM_People.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSM_People.Image = global::DVLD.Properties.Resources.People_s;
            this.TSM_People.Name = "TSM_People";
            this.TSM_People.Size = new System.Drawing.Size(108, 44);
            this.TSM_People.Text = "People";
            this.TSM_People.Click += new System.EventHandler(this.TSM_People_Click);
            // 
            // TSM_Drivers
            // 
            this.TSM_Drivers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSM_Drivers.Image = global::DVLD.Properties.Resources.Drivers_s;
            this.TSM_Drivers.Name = "TSM_Drivers";
            this.TSM_Drivers.Size = new System.Drawing.Size(112, 44);
            this.TSM_Drivers.Text = "Drivers";
            this.TSM_Drivers.Click += new System.EventHandler(this.TSM_Drivers_Click);
            // 
            // TSM_Users
            // 
            this.TSM_Users.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSM_Users.Image = global::DVLD.Properties.Resources.Users_s;
            this.TSM_Users.Name = "TSM_Users";
            this.TSM_Users.Size = new System.Drawing.Size(101, 44);
            this.TSM_Users.Text = "Users";
            this.TSM_Users.Click += new System.EventHandler(this.TSM_Users_Click);
            // 
            // TSM_AccountSettings
            // 
            this.TSM_AccountSettings.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSM_AccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CurrentUser,
            this.TSMI_ChangePassword,
            this.TSMI_SignOut});
            this.TSM_AccountSettings.Image = global::DVLD.Properties.Resources.System_Settings_s;
            this.TSM_AccountSettings.Name = "TSM_AccountSettings";
            this.TSM_AccountSettings.Size = new System.Drawing.Size(178, 44);
            this.TSM_AccountSettings.Text = "Account Settings";
            // 
            // TSMI_CurrentUser
            // 
            this.TSMI_CurrentUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_CurrentUser.Name = "TSMI_CurrentUser";
            this.TSMI_CurrentUser.Size = new System.Drawing.Size(203, 26);
            this.TSMI_CurrentUser.Text = "Current User";
            this.TSMI_CurrentUser.Click += new System.EventHandler(this.TSMI_CurrentUser_Click);
            // 
            // TSMI_ChangePassword
            // 
            this.TSMI_ChangePassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_ChangePassword.Name = "TSMI_ChangePassword";
            this.TSMI_ChangePassword.Size = new System.Drawing.Size(203, 26);
            this.TSMI_ChangePassword.Text = "Change Password";
            this.TSMI_ChangePassword.Click += new System.EventHandler(this.TSMI_ChangePassword_Click);
            // 
            // TSMI_SignOut
            // 
            this.TSMI_SignOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TSMI_SignOut.Name = "TSMI_SignOut";
            this.TSMI_SignOut.Size = new System.Drawing.Size(203, 26);
            this.TSMI_SignOut.Text = "Sign out";
            this.TSMI_SignOut.Click += new System.EventHandler(this.TSMI_SignOut_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DVLD.Properties.Resources.DVLD_Bckground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 604);
            this.Controls.Add(this.MS_MainSections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_MainSections;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.MS_MainSections.ResumeLayout(false);
            this.MS_MainSections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_MainSections;
        private System.Windows.Forms.ToolStripMenuItem TSM_Applications;
        private System.Windows.Forms.ToolStripMenuItem TSM_People;
        private System.Windows.Forms.ToolStripMenuItem TSM_Drivers;
        private System.Windows.Forms.ToolStripMenuItem TSM_Users;
        private System.Windows.Forms.ToolStripMenuItem TSM_AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CurrentUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DrivingLicenseServices;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ManageApplications;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DetainLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ManageApplicationType;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ChangePassword;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SignOut;
        private System.Windows.Forms.ToolStripMenuItem TSMI_NewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RenewDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ReplaceLostOrDamagedLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ReleaseDetainedDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_RetakeTest;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_LocalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem TSMI_InternationalDrivingLicenseApplications;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ManageDetainedLicenses;
        private System.Windows.Forms.ToolStripMenuItem TSMSI_DetainLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ReleaseDetainedLicense;
    }
}

