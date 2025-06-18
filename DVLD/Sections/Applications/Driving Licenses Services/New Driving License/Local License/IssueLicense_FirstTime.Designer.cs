namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    partial class IssueLicense_FirstTime
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
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.BTN_Issue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UC_LicenseApplicationInfo = new DVLD.User_Controls.Applications_Section.UC_LicenseApplicationInfo();
            this.SuspendLayout();
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(127, 332);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(667, 61);
            this.TB_Notes.TabIndex = 55;
            // 
            // BTN_Issue
            // 
            this.BTN_Issue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Issue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Issue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Issue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Issue.Location = new System.Drawing.Point(358, 406);
            this.BTN_Issue.Name = "BTN_Issue";
            this.BTN_Issue.Size = new System.Drawing.Size(117, 33);
            this.BTN_Issue.TabIndex = 54;
            this.BTN_Issue.Tag = " ";
            this.BTN_Issue.Text = "Issue";
            this.BTN_Issue.UseVisualStyleBackColor = false;
            this.BTN_Issue.Click += new System.EventHandler(this.BTN_Issue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Notes :";
            // 
            // UC_LicenseApplicationInfo
            // 
            this.UC_LicenseApplicationInfo.Location = new System.Drawing.Point(11, 1);
            this.UC_LicenseApplicationInfo.Name = "UC_LicenseApplicationInfo";
            this.UC_LicenseApplicationInfo.Size = new System.Drawing.Size(810, 316);
            this.UC_LicenseApplicationInfo.TabIndex = 0;
            // 
            // IssueLicense_FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.TB_Notes);
            this.Controls.Add(this.BTN_Issue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UC_LicenseApplicationInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueLicense_FirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue License - First Time";
            this.Load += new System.EventHandler(this.IssueLicense_FirstTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Applications_Section.UC_LicenseApplicationInfo UC_LicenseApplicationInfo;
        private System.Windows.Forms.TextBox TB_Notes;
        public System.Windows.Forms.Button BTN_Issue;
        private System.Windows.Forms.Label label1;
    }
}