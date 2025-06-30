namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    partial class InternationalLicenseInfo
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
            this.UC_InternationalLicenseInfo = new DVLD.User_Controls.Applications_Section.International_Licenses.UC_InternationalLicenseInfo();
            this.LB_Operation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UC_InternationalLicenseInfo
            // 
            this.UC_InternationalLicenseInfo.Location = new System.Drawing.Point(39, 25);
            this.UC_InternationalLicenseInfo.Name = "UC_InternationalLicenseInfo";
            this.UC_InternationalLicenseInfo.Size = new System.Drawing.Size(781, 321);
            this.UC_InternationalLicenseInfo.TabIndex = 34;
            // 
            // LB_Operation
            // 
            this.LB_Operation.AutoSize = true;
            this.LB_Operation.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Operation.Location = new System.Drawing.Point(261, -5);
            this.LB_Operation.Name = "LB_Operation";
            this.LB_Operation.Size = new System.Drawing.Size(334, 23);
            this.LB_Operation.TabIndex = 35;
            this.LB_Operation.Text = "International Driving License Info";
            this.LB_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(857, 381);
            this.Controls.Add(this.LB_Operation);
            this.Controls.Add(this.UC_InternationalLicenseInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InternationalLicenseInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Info";
            this.Load += new System.EventHandler(this.InternationalLicenseInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private User_Controls.Applications_Section.International_Licenses.UC_InternationalLicenseInfo UC_InternationalLicenseInfo;
        private System.Windows.Forms.Label LB_Operation;
    }
}