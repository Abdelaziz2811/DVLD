namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.International_License_Applications
{
    partial class ManageInternationalLicenseApplications
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
            this.TB_FilterationValue = new System.Windows.Forms.TextBox();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_AddInternationalLicenseApplication = new System.Windows.Forms.Button();
            this.CB_FilterBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_InternationalLicenseApplications = new System.Windows.Forms.DataGridView();
            this.CMS_InternationalLicenseApplicationsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_PersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_LicenseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PersonLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.TSMI_VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_WrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenseApplications)).BeginInit();
            this.CMS_InternationalLicenseApplicationsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_FilterationValue
            // 
            this.TB_FilterationValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TB_FilterationValue.Location = new System.Drawing.Point(228, 156);
            this.TB_FilterationValue.Name = "TB_FilterationValue";
            this.TB_FilterationValue.Size = new System.Drawing.Size(100, 20);
            this.TB_FilterationValue.TabIndex = 57;
            this.TB_FilterationValue.TextChanged += new System.EventHandler(this.TB_FilterationValue_TextChanged);
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(538, 154);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 56;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "# Records :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.licence;
            this.pictureBox1.Location = new System.Drawing.Point(413, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_AddInternationalLicenseApplication
            // 
            this.BTN_AddInternationalLicenseApplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_AddInternationalLicenseApplication.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddInternationalLicenseApplication.BackgroundImage = global::DVLD.Properties.Resources.New_license;
            this.BTN_AddInternationalLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddInternationalLicenseApplication.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_AddInternationalLicenseApplication.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_AddInternationalLicenseApplication.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddInternationalLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddInternationalLicenseApplication.Location = new System.Drawing.Point(931, 140);
            this.BTN_AddInternationalLicenseApplication.Name = "BTN_AddInternationalLicenseApplication";
            this.BTN_AddInternationalLicenseApplication.Size = new System.Drawing.Size(49, 38);
            this.BTN_AddInternationalLicenseApplication.TabIndex = 52;
            this.BTN_AddInternationalLicenseApplication.UseVisualStyleBackColor = false;
            this.BTN_AddInternationalLicenseApplication.Click += new System.EventHandler(this.BTN_AddInternationalLicenseApplication_Click);
            // 
            // CB_FilterBy
            // 
            this.CB_FilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_FilterBy.FormattingEnabled = true;
            this.CB_FilterBy.Items.AddRange(new object[] {
            "None",
            "I.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "IsActive"});
            this.CB_FilterBy.Location = new System.Drawing.Point(89, 155);
            this.CB_FilterBy.Name = "CB_FilterBy";
            this.CB_FilterBy.Size = new System.Drawing.Size(124, 21);
            this.CB_FilterBy.TabIndex = 51;
            this.CB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FilterBy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Filter By :";
            // 
            // DGV_InternationalLicenseApplications
            // 
            this.DGV_InternationalLicenseApplications.AllowUserToAddRows = false;
            this.DGV_InternationalLicenseApplications.AllowUserToDeleteRows = false;
            this.DGV_InternationalLicenseApplications.AllowUserToOrderColumns = true;
            this.DGV_InternationalLicenseApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGV_InternationalLicenseApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InternationalLicenseApplications.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_InternationalLicenseApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InternationalLicenseApplications.ContextMenuStrip = this.CMS_InternationalLicenseApplicationsActions;
            this.DGV_InternationalLicenseApplications.Location = new System.Drawing.Point(17, 188);
            this.DGV_InternationalLicenseApplications.Name = "DGV_InternationalLicenseApplications";
            this.DGV_InternationalLicenseApplications.ReadOnly = true;
            this.DGV_InternationalLicenseApplications.Size = new System.Drawing.Size(963, 349);
            this.DGV_InternationalLicenseApplications.TabIndex = 58;
            // 
            // CMS_InternationalLicenseApplicationsActions
            // 
            this.CMS_InternationalLicenseApplicationsActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_InternationalLicenseApplicationsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PersonDetails,
            this.TSMI_LicenseDetails,
            this.TSMI_PersonLicenseHistory});
            this.CMS_InternationalLicenseApplicationsActions.Name = "CMS_PeopleHandle";
            this.CMS_InternationalLicenseApplicationsActions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMS_InternationalLicenseApplicationsActions.Size = new System.Drawing.Size(208, 70);
            // 
            // TSMI_PersonDetails
            // 
            this.TSMI_PersonDetails.Name = "TSMI_PersonDetails";
            this.TSMI_PersonDetails.Size = new System.Drawing.Size(207, 22);
            this.TSMI_PersonDetails.Text = "Person Details";
            this.TSMI_PersonDetails.Click += new System.EventHandler(this.TSMI_PersonDetails_Click);
            // 
            // TSMI_LicenseDetails
            // 
            this.TSMI_LicenseDetails.Name = "TSMI_LicenseDetails";
            this.TSMI_LicenseDetails.Size = new System.Drawing.Size(207, 22);
            this.TSMI_LicenseDetails.Text = "License Details";
            this.TSMI_LicenseDetails.Click += new System.EventHandler(this.TSMI_LicenseDetails_Click);
            // 
            // TSMI_PersonLicenseHistory
            // 
            this.TSMI_PersonLicenseHistory.Name = "TSMI_PersonLicenseHistory";
            this.TSMI_PersonLicenseHistory.Size = new System.Drawing.Size(207, 22);
            this.TSMI_PersonLicenseHistory.Text = "Person License History";
            this.TSMI_PersonLicenseHistory.Click += new System.EventHandler(this.TSMI_PersonLicenseHistory_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, -4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 23);
            this.label3.TabIndex = 59;
            this.label3.Text = "International Driving License Applications";
            // 
            // TSMI_VisionTest
            // 
            this.TSMI_VisionTest.Name = "TSMI_VisionTest";
            this.TSMI_VisionTest.Size = new System.Drawing.Size(136, 22);
            this.TSMI_VisionTest.Text = "Vision Test";
            // 
            // TSMI_WrittenTest
            // 
            this.TSMI_WrittenTest.Name = "TSMI_WrittenTest";
            this.TSMI_WrittenTest.Size = new System.Drawing.Size(136, 22);
            this.TSMI_WrittenTest.Text = "Written Test";
            // 
            // TSMI_StreetTest
            // 
            this.TSMI_StreetTest.Name = "TSMI_StreetTest";
            this.TSMI_StreetTest.Size = new System.Drawing.Size(136, 22);
            this.TSMI_StreetTest.Text = "Street Test";
            // 
            // ManageInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_FilterationValue);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_AddInternationalLicenseApplication);
            this.Controls.Add(this.CB_FilterBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_InternationalLicenseApplications);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage International License Applications";
            this.Load += new System.EventHandler(this.ManageInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenseApplications)).EndInit();
            this.CMS_InternationalLicenseApplicationsActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_FilterationValue;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_AddInternationalLicenseApplication;
        private System.Windows.Forms.ComboBox CB_FilterBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_InternationalLicenseApplications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip CMS_InternationalLicenseApplicationsActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_LicenseDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PersonLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem TSMI_VisionTest;
        private System.Windows.Forms.ToolStripMenuItem TSMI_WrittenTest;
        private System.Windows.Forms.ToolStripMenuItem TSMI_StreetTest;
    }
}