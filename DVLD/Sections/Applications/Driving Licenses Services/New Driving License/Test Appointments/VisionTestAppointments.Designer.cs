namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments
{
    partial class VisionTestAppointments
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
            this.DGV_TestAppointments = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.UC_LicenseApplicationInfo = new DVLD.User_Controls.Applications_Section.UC_LicenseApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TestAppointments
            // 
            this.DGV_TestAppointments.AllowUserToAddRows = false;
            this.DGV_TestAppointments.AllowUserToDeleteRows = false;
            this.DGV_TestAppointments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_TestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TestAppointments.Location = new System.Drawing.Point(12, 409);
            this.DGV_TestAppointments.Name = "DGV_TestAppointments";
            this.DGV_TestAppointments.ReadOnly = true;
            this.DGV_TestAppointments.Size = new System.Drawing.Size(808, 150);
            this.DGV_TestAppointments.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Vision Test Appointments";
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
            // UC_LicenseApplicationInfo
            // 
            this.UC_LicenseApplicationInfo.Location = new System.Drawing.Point(12, 47);
            this.UC_LicenseApplicationInfo.Name = "UC_LicenseApplicationInfo";
            this.UC_LicenseApplicationInfo.Size = new System.Drawing.Size(808, 315);
            this.UC_LicenseApplicationInfo.TabIndex = 0;
            // 
            // VisionTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(832, 571);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_TestAppointments);
            this.Controls.Add(this.UC_LicenseApplicationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisionTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appointment";
            this.Load += new System.EventHandler(this.VisionTestVisionTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Applications_Section.UC_LicenseApplicationInfo UC_LicenseApplicationInfo;
        private System.Windows.Forms.DataGridView DGV_TestAppointments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_RecordsCount;
    }
}