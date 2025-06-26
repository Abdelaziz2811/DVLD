namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    partial class LicenseApplicationInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.UC_LicenseApplicationInfo = new DVLD.User_Controls.Applications_Section.UC_LicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "License Application Info";
            // 
            // UC_LicenseApplicationInfo
            // 
            this.UC_LicenseApplicationInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UC_LicenseApplicationInfo.Location = new System.Drawing.Point(12, 25);
            this.UC_LicenseApplicationInfo.Name = "UC_LicenseApplicationInfo";
            this.UC_LicenseApplicationInfo.Size = new System.Drawing.Size(811, 316);
            this.UC_LicenseApplicationInfo.TabIndex = 0;
            // 
            // LicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(835, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UC_LicenseApplicationInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseApplicationInfo";
            this.Text = "License Application Info";
            this.Load += new System.EventHandler(this.LicenseApplicationInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Applications_Section.UC_LicenseApplicationInfo UC_LicenseApplicationInfo;
        private System.Windows.Forms.Label label1;
    }
}