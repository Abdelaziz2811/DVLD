namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    partial class LicenseInfo
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
            this.UC_LicenseInfo = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseInfo();
            this.SuspendLayout();
            // 
            // UC_LicenseInfo
            // 
            this.UC_LicenseInfo.Location = new System.Drawing.Point(12, 2);
            this.UC_LicenseInfo.Name = "UC_LicenseInfo";
            this.UC_LicenseInfo.Size = new System.Drawing.Size(756, 352);
            this.UC_LicenseInfo.TabIndex = 0;
            // 
            // LicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 362);
            this.Controls.Add(this.UC_LicenseInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Details";
            this.Load += new System.EventHandler(this.LicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.Applications_Section.Local_License.UC_LicenseInfo UC_LicenseInfo;
    }
}