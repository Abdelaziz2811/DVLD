namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments
{
    partial class TestAppointments
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
            this.DGV_TestAppointments = new System.Windows.Forms.DataGridView();
            this.LB_TestType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.BTN_ScheduleAppointment = new System.Windows.Forms.Button();
            this.CMS_LocalLicenseApplicationsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_UpdateTestAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.UC_LicenseApplicationInfo = new DVLD.User_Controls.Applications_Section.UC_LicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestAppointments)).BeginInit();
            this.CMS_LocalLicenseApplicationsActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_TestAppointments
            // 
            this.DGV_TestAppointments.AllowUserToAddRows = false;
            this.DGV_TestAppointments.AllowUserToDeleteRows = false;
            this.DGV_TestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TestAppointments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_TestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TestAppointments.Location = new System.Drawing.Point(12, 409);
            this.DGV_TestAppointments.Name = "DGV_TestAppointments";
            this.DGV_TestAppointments.ReadOnly = true;
            this.DGV_TestAppointments.Size = new System.Drawing.Size(808, 150);
            this.DGV_TestAppointments.TabIndex = 1;
            // 
            // LB_TestType
            // 
            this.LB_TestType.AutoSize = true;
            this.LB_TestType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TestType.Location = new System.Drawing.Point(276, 0);
            this.LB_TestType.Name = "LB_TestType";
            this.LB_TestType.Size = new System.Drawing.Size(191, 23);
            this.LB_TestType.TabIndex = 26;
            this.LB_TestType.Text = "Test Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "# Records :";
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(429, 376);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 28;
            this.LB_RecordsCount.Text = "--";
            // 
            // BTN_ScheduleAppointment
            // 
            this.BTN_ScheduleAppointment.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_ScheduleAppointment.BackgroundImage = global::DVLD.Properties.Resources.appointments;
            this.BTN_ScheduleAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_ScheduleAppointment.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_ScheduleAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_ScheduleAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_ScheduleAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ScheduleAppointment.Location = new System.Drawing.Point(771, 366);
            this.BTN_ScheduleAppointment.Name = "BTN_ScheduleAppointment";
            this.BTN_ScheduleAppointment.Size = new System.Drawing.Size(49, 38);
            this.BTN_ScheduleAppointment.TabIndex = 29;
            this.BTN_ScheduleAppointment.UseVisualStyleBackColor = false;
            this.BTN_ScheduleAppointment.Click += new System.EventHandler(this.BTN_ScheduleAppointment_Click);
            // 
            // CMS_LocalLicenseApplicationsActions
            // 
            this.CMS_LocalLicenseApplicationsActions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMS_LocalLicenseApplicationsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateTestAppointment,
            this.TSMI_TakeTest});
            this.CMS_LocalLicenseApplicationsActions.Name = "CMS_PeopleHandle";
            this.CMS_LocalLicenseApplicationsActions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CMS_LocalLicenseApplicationsActions.Size = new System.Drawing.Size(226, 48);
            // 
            // TSMI_UpdateTestAppointment
            // 
            this.TSMI_UpdateTestAppointment.Name = "TSMI_UpdateTestAppointment";
            this.TSMI_UpdateTestAppointment.Size = new System.Drawing.Size(225, 22);
            this.TSMI_UpdateTestAppointment.Text = "Update Test Appointment";
            this.TSMI_UpdateTestAppointment.Click += new System.EventHandler(this.TSMI_UpdateTestAppointment_Click);
            // 
            // TSMI_TakeTest
            // 
            this.TSMI_TakeTest.Name = "TSMI_TakeTest";
            this.TSMI_TakeTest.Size = new System.Drawing.Size(225, 22);
            this.TSMI_TakeTest.Text = "Take Test";
            this.TSMI_TakeTest.Click += new System.EventHandler(this.TSMI_TakeTest_Click);
            // 
            // UC_LicenseApplicationInfo
            // 
            this.UC_LicenseApplicationInfo.Location = new System.Drawing.Point(12, 47);
            this.UC_LicenseApplicationInfo.Name = "UC_LicenseApplicationInfo";
            this.UC_LicenseApplicationInfo.Size = new System.Drawing.Size(808, 315);
            this.UC_LicenseApplicationInfo.TabIndex = 0;
            // 
            // TestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 571);
            this.Controls.Add(this.BTN_ScheduleAppointment);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_TestType);
            this.Controls.Add(this.DGV_TestAppointments);
            this.Controls.Add(this.UC_LicenseApplicationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Appointments";
            this.Load += new System.EventHandler(this.VisionTestVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestAppointments)).EndInit();
            this.CMS_LocalLicenseApplicationsActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TestAppointments;
        private System.Windows.Forms.Label LB_TestType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Button BTN_ScheduleAppointment;
        private System.Windows.Forms.ContextMenuStrip CMS_LocalLicenseApplicationsActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TakeTest;
        public User_Controls.Applications_Section.UC_LicenseApplicationInfo UC_LicenseApplicationInfo;
    }
}