namespace DVLD.Sections.Applications.Manage_Applications.Local_License_Applications
{
    partial class LocalLicenseApplications
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
            this.components = new System.ComponentModel.Container();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_FilterationValue = new System.Windows.Forms.TextBox();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_FilterBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_AddLocalLicenseApplication = new System.Windows.Forms.Button();
            this.DGV_LocalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.CMS_LocalLicenseApplicationsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_ApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ScheduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Seperator = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_IssueLicense_FirstTime = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenseApplications)).BeginInit();
            this.CMS_LocalLicenseApplicationsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(325, -41);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(154, 23);
            this.LB_Opration.TabIndex = 39;
            this.LB_Opration.Text = "Manage People";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-77, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filter By :";
            // 
            // TB_FilterationValue
            // 
            this.TB_FilterationValue.Location = new System.Drawing.Point(228, 148);
            this.TB_FilterationValue.Name = "TB_FilterationValue";
            this.TB_FilterationValue.Size = new System.Drawing.Size(100, 20);
            this.TB_FilterationValue.TabIndex = 48;
            this.TB_FilterationValue.TextChanged += new System.EventHandler(this.TB_FilterationValue_TextChanged);
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(538, 146);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 47;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "# Records :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Local Driving License Applications";
            // 
            // CB_FilterBy
            // 
            this.CB_FilterBy.FormattingEnabled = true;
            this.CB_FilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No",
            "Full Name",
            "Status"});
            this.CB_FilterBy.Location = new System.Drawing.Point(89, 147);
            this.CB_FilterBy.Name = "CB_FilterBy";
            this.CB_FilterBy.Size = new System.Drawing.Size(124, 21);
            this.CB_FilterBy.TabIndex = 42;
            this.CB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FilterBy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Filter By :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.licence;
            this.pictureBox1.Location = new System.Drawing.Point(413, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_AddLocalLicenseApplication
            // 
            this.BTN_AddLocalLicenseApplication.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddLocalLicenseApplication.BackgroundImage = global::DVLD.Properties.Resources.New_license;
            this.BTN_AddLocalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddLocalLicenseApplication.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_AddLocalLicenseApplication.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_AddLocalLicenseApplication.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddLocalLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddLocalLicenseApplication.Location = new System.Drawing.Point(931, 132);
            this.BTN_AddLocalLicenseApplication.Name = "BTN_AddLocalLicenseApplication";
            this.BTN_AddLocalLicenseApplication.Size = new System.Drawing.Size(49, 38);
            this.BTN_AddLocalLicenseApplication.TabIndex = 43;
            this.BTN_AddLocalLicenseApplication.UseVisualStyleBackColor = false;
            this.BTN_AddLocalLicenseApplication.Click += new System.EventHandler(this.BTN_AddLocalLicenseApplication_Click);
            // 
            // DGV_LocalLicenseApplications
            // 
            this.DGV_LocalLicenseApplications.AllowUserToAddRows = false;
            this.DGV_LocalLicenseApplications.AllowUserToDeleteRows = false;
            this.DGV_LocalLicenseApplications.AllowUserToOrderColumns = true;
            this.DGV_LocalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LocalLicenseApplications.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_LocalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LocalLicenseApplications.ContextMenuStrip = this.CMS_LocalLicenseApplicationsActions;
            this.DGV_LocalLicenseApplications.Location = new System.Drawing.Point(17, 180);
            this.DGV_LocalLicenseApplications.Name = "DGV_LocalLicenseApplications";
            this.DGV_LocalLicenseApplications.ReadOnly = true;
            this.DGV_LocalLicenseApplications.Size = new System.Drawing.Size(963, 349);
            this.DGV_LocalLicenseApplications.TabIndex = 49;
            // 
            // CMS_LocalLicenseApplicationsActions
            // 
            this.CMS_LocalLicenseApplicationsActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_LocalLicenseApplicationsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ApplicationDetails,
            this.TSMI_UpdateApplication,
            this.TSMI_DeleteApplication,
            this.TSMI_CancelApplication,
            this.TSMI_ScheduleTests,
            this.TSMI_Seperator,
            this.TSMI_IssueLicense_FirstTime,
            this.TSMI_ShowLicense,
            this.TSMI_PersonLicenseHistory});
            this.CMS_LocalLicenseApplicationsActions.Name = "CMS_PeopleHandle";
            this.CMS_LocalLicenseApplicationsActions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMS_LocalLicenseApplicationsActions.Size = new System.Drawing.Size(220, 208);
            this.CMS_LocalLicenseApplicationsActions.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_LocalLicenseApplicationsActions_Opening);
            // 
            // TSMI_ApplicationDetails
            // 
            this.TSMI_ApplicationDetails.Name = "TSMI_ApplicationDetails";
            this.TSMI_ApplicationDetails.Size = new System.Drawing.Size(219, 22);
            this.TSMI_ApplicationDetails.Text = "Application Details";
            // 
            // TSMI_UpdateApplication
            // 
            this.TSMI_UpdateApplication.Name = "TSMI_UpdateApplication";
            this.TSMI_UpdateApplication.Size = new System.Drawing.Size(219, 22);
            this.TSMI_UpdateApplication.Text = "Update Application";
            // 
            // TSMI_DeleteApplication
            // 
            this.TSMI_DeleteApplication.Name = "TSMI_DeleteApplication";
            this.TSMI_DeleteApplication.Size = new System.Drawing.Size(219, 22);
            this.TSMI_DeleteApplication.Text = "Delete Application";
            // 
            // TSMI_CancelApplication
            // 
            this.TSMI_CancelApplication.Name = "TSMI_CancelApplication";
            this.TSMI_CancelApplication.Size = new System.Drawing.Size(219, 22);
            this.TSMI_CancelApplication.Text = "Cancel Application";
            this.TSMI_CancelApplication.Click += new System.EventHandler(this.TSMI_CancelApplication_Click);
            // 
            // TSMI_ScheduleTests
            // 
            this.TSMI_ScheduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_VisionTest,
            this.TSMI_WrittenTest,
            this.TSMI_StreetTest});
            this.TSMI_ScheduleTests.Name = "TSMI_ScheduleTests";
            this.TSMI_ScheduleTests.Size = new System.Drawing.Size(219, 22);
            this.TSMI_ScheduleTests.Text = "Schedule Tests";
            // 
            // TSMI_VisionTest
            // 
            this.TSMI_VisionTest.Name = "TSMI_VisionTest";
            this.TSMI_VisionTest.Size = new System.Drawing.Size(180, 22);
            this.TSMI_VisionTest.Text = "Vision Test";
            this.TSMI_VisionTest.Click += new System.EventHandler(this.TSMI_VisionTest_Click);
            // 
            // TSMI_WrittenTest
            // 
            this.TSMI_WrittenTest.Name = "TSMI_WrittenTest";
            this.TSMI_WrittenTest.Size = new System.Drawing.Size(180, 22);
            this.TSMI_WrittenTest.Text = "Written Test";
            this.TSMI_WrittenTest.Click += new System.EventHandler(this.TSMI_WrittenTest_Click);
            // 
            // TSMI_StreetTest
            // 
            this.TSMI_StreetTest.Name = "TSMI_StreetTest";
            this.TSMI_StreetTest.Size = new System.Drawing.Size(180, 22);
            this.TSMI_StreetTest.Text = "Street Test";
            this.TSMI_StreetTest.Click += new System.EventHandler(this.TSMI_StreetTest_Click);
            // 
            // TSMI_Seperator
            // 
            this.TSMI_Seperator.Name = "TSMI_Seperator";
            this.TSMI_Seperator.Size = new System.Drawing.Size(216, 6);
            // 
            // TSMI_IssueLicense_FirstTime
            // 
            this.TSMI_IssueLicense_FirstTime.Name = "TSMI_IssueLicense_FirstTime";
            this.TSMI_IssueLicense_FirstTime.Size = new System.Drawing.Size(219, 22);
            this.TSMI_IssueLicense_FirstTime.Text = "Issue License (First Time)";
            // 
            // TSMI_ShowLicense
            // 
            this.TSMI_ShowLicense.Name = "TSMI_ShowLicense";
            this.TSMI_ShowLicense.Size = new System.Drawing.Size(219, 22);
            this.TSMI_ShowLicense.Text = "Show License";
            // 
            // TSMI_PersonLicenseHistory
            // 
            this.TSMI_PersonLicenseHistory.Name = "TSMI_PersonLicenseHistory";
            this.TSMI_PersonLicenseHistory.Size = new System.Drawing.Size(219, 22);
            this.TSMI_PersonLicenseHistory.Text = "Person License History";
            // 
            // LocalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.TB_FilterationValue);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_AddLocalLicenseApplication);
            this.Controls.Add(this.CB_FilterBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_LocalLicenseApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License Applications";
            this.Load += new System.EventHandler(this.LocalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenseApplications)).EndInit();
            this.CMS_LocalLicenseApplicationsActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_FilterationValue;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_AddLocalLicenseApplication;
        private System.Windows.Forms.ComboBox CB_FilterBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_LocalLicenseApplications;
        private System.Windows.Forms.ContextMenuStrip CMS_LocalLicenseApplicationsActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ApplicationDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CancelApplication;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ScheduleTests;
        private System.Windows.Forms.ToolStripSeparator TSMI_Seperator;
        private System.Windows.Forms.ToolStripMenuItem TSMI_IssueLicense_FirstTime;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ShowLicense;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VisionTest;
        private System.Windows.Forms.ToolStripMenuItem TSMI_WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StreetTest;
    }
}