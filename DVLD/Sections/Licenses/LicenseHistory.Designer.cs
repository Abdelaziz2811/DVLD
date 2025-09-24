namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    partial class LicenseHistory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.UC_Person_Selector = new DVLD.User_Controls.UC_Person_Selector();
            this.UC_LicenseHistory = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseHistory();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(72, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 74);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "License History";
            // 
            // UC_Person_Selector
            // 
            this.UC_Person_Selector.BackColor = System.Drawing.SystemColors.Window;
            this.UC_Person_Selector.Location = new System.Drawing.Point(72, -39);
            this.UC_Person_Selector.Name = "UC_Person_Selector";
            this.UC_Person_Selector.Size = new System.Drawing.Size(653, 382);
            this.UC_Person_Selector.TabIndex = 0;
            // 
            // uC_LicenseHistory1
            // 
            this.UC_LicenseHistory.BackColor = System.Drawing.SystemColors.Window;
            this.UC_LicenseHistory.Location = new System.Drawing.Point(12, 358);
            this.UC_LicenseHistory.Name = "uC_LicenseHistory1";
            this.UC_LicenseHistory.Size = new System.Drawing.Size(776, 246);
            this.UC_LicenseHistory.TabIndex = 2;
            // 
            // LicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.UC_LicenseHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UC_Person_Selector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License History";
            this.Load += new System.EventHandler(this.LicenseHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.UC_Person_Selector UC_Person_Selector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private User_Controls.Applications_Section.Local_License.UC_LicenseHistory UC_LicenseHistory;
    }
}