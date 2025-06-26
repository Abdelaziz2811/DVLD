namespace DVLD.User_Controls.Applications_Section.Local_License
{
    partial class UC_LicenseSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_Search = new System.Windows.Forms.GroupBox();
            this.BTN_FindLicense = new System.Windows.Forms.Button();
            this.BTN_LicenseHistory = new System.Windows.Forms.Button();
            this.TXTB_SearchBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UC_LicenseInfo = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseInfo();
            this.GB_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Search
            // 
            this.GB_Search.Controls.Add(this.BTN_FindLicense);
            this.GB_Search.Controls.Add(this.BTN_LicenseHistory);
            this.GB_Search.Controls.Add(this.TXTB_SearchBox);
            this.GB_Search.Controls.Add(this.label4);
            this.GB_Search.Location = new System.Drawing.Point(3, 3);
            this.GB_Search.Name = "GB_Search";
            this.GB_Search.Size = new System.Drawing.Size(756, 81);
            this.GB_Search.TabIndex = 3;
            this.GB_Search.TabStop = false;
            this.GB_Search.Text = "Search";
            // 
            // BTN_FindLicense
            // 
            this.BTN_FindLicense.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_FindLicense.BackgroundImage = global::DVLD.Properties.Resources.licence;
            this.BTN_FindLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_FindLicense.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_FindLicense.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_FindLicense.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_FindLicense.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_FindLicense.Location = new System.Drawing.Point(395, 19);
            this.BTN_FindLicense.Name = "BTN_FindLicense";
            this.BTN_FindLicense.Size = new System.Drawing.Size(54, 42);
            this.BTN_FindLicense.TabIndex = 31;
            this.BTN_FindLicense.UseVisualStyleBackColor = false;
            this.BTN_FindLicense.Click += new System.EventHandler(this.BTN_FindLicense_Click);
            // 
            // BTN_LicenseHistory
            // 
            this.BTN_LicenseHistory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_LicenseHistory.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_LicenseHistory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LicenseHistory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_LicenseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LicenseHistory.Location = new System.Drawing.Point(472, 27);
            this.BTN_LicenseHistory.Name = "BTN_LicenseHistory";
            this.BTN_LicenseHistory.Size = new System.Drawing.Size(117, 28);
            this.BTN_LicenseHistory.TabIndex = 30;
            this.BTN_LicenseHistory.Tag = " ";
            this.BTN_LicenseHistory.Text = "License History";
            this.BTN_LicenseHistory.UseVisualStyleBackColor = false;
            this.BTN_LicenseHistory.Click += new System.EventHandler(this.BTN_LicenseHistory_Click);
            // 
            // TXTB_SearchBox
            // 
            this.TXTB_SearchBox.Location = new System.Drawing.Point(241, 31);
            this.TXTB_SearchBox.Name = "TXTB_SearchBox";
            this.TXTB_SearchBox.Size = new System.Drawing.Size(126, 20);
            this.TXTB_SearchBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "License ID :";
            // 
            // UC_LicenseInfo
            // 
            this.UC_LicenseInfo.Location = new System.Drawing.Point(3, 89);
            this.UC_LicenseInfo.Name = "UC_LicenseInfo";
            this.UC_LicenseInfo.Size = new System.Drawing.Size(756, 352);
            this.UC_LicenseInfo.TabIndex = 0;
            // 
            // UC_LicenseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.GB_Search);
            this.Controls.Add(this.UC_LicenseInfo);
            this.Name = "UC_LicenseSelector";
            this.Size = new System.Drawing.Size(763, 441);
            this.GB_Search.ResumeLayout(false);
            this.GB_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox GB_Search;
        public System.Windows.Forms.Button BTN_LicenseHistory;
        public System.Windows.Forms.TextBox TXTB_SearchBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BTN_FindLicense;
        public UC_LicenseInfo UC_LicenseInfo;
    }
}
