namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    partial class ReplaceDrivingLicense
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
            this.LB_Operation = new System.Windows.Forms.Label();
            this.TC_LicenseApplication = new System.Windows.Forms.TabControl();
            this.TP_LicenseInfo = new System.Windows.Forms.TabPage();
            this.GB_ReplacementType = new System.Windows.Forms.GroupBox();
            this.RB_DamagedLicense = new System.Windows.Forms.RadioButton();
            this.RB_LostLicense = new System.Windows.Forms.RadioButton();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.BTN_NextToApplicationInfo = new System.Windows.Forms.Button();
            this.TP_ApplicationInfo = new System.Windows.Forms.TabPage();
            this.GB_ApplicationInfo = new System.Windows.Forms.GroupBox();
            this.BTN_LicenseInfo = new System.Windows.Forms.Button();
            this.LB_RAppID = new System.Windows.Forms.Label();
            this.LB_OldLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_ApplicationFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_ReplacedLicenseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_ApplicationDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BTN_Replace = new System.Windows.Forms.Button();
            this.UC_LicenseSelector = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseSelector();
            this.TC_LicenseApplication.SuspendLayout();
            this.TP_LicenseInfo.SuspendLayout();
            this.GB_ReplacementType.SuspendLayout();
            this.TP_ApplicationInfo.SuspendLayout();
            this.GB_ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Operation
            // 
            this.LB_Operation.AutoSize = true;
            this.LB_Operation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Operation.Location = new System.Drawing.Point(171, -2);
            this.LB_Operation.Name = "LB_Operation";
            this.LB_Operation.Size = new System.Drawing.Size(460, 19);
            this.LB_Operation.TabIndex = 35;
            this.LB_Operation.Text = "Replace Driving License Application (Damaged License)";
            this.LB_Operation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TC_LicenseApplication
            // 
            this.TC_LicenseApplication.Controls.Add(this.TP_LicenseInfo);
            this.TC_LicenseApplication.Controls.Add(this.TP_ApplicationInfo);
            this.TC_LicenseApplication.Location = new System.Drawing.Point(11, 22);
            this.TC_LicenseApplication.Name = "TC_LicenseApplication";
            this.TC_LicenseApplication.SelectedIndex = 0;
            this.TC_LicenseApplication.Size = new System.Drawing.Size(781, 508);
            this.TC_LicenseApplication.TabIndex = 34;
            this.TC_LicenseApplication.SelectedIndexChanged += new System.EventHandler(this.TC_LicenseApplication_SelectedIndexChanged);
            // 
            // TP_LicenseInfo
            // 
            this.TP_LicenseInfo.Controls.Add(this.GB_ReplacementType);
            this.TP_LicenseInfo.Controls.Add(this.UC_LicenseSelector);
            this.TP_LicenseInfo.Controls.Add(this.BTN_Next);
            this.TP_LicenseInfo.Controls.Add(this.BTN_NextToApplicationInfo);
            this.TP_LicenseInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_LicenseInfo.Name = "TP_LicenseInfo";
            this.TP_LicenseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_LicenseInfo.Size = new System.Drawing.Size(773, 482);
            this.TP_LicenseInfo.TabIndex = 0;
            this.TP_LicenseInfo.Text = "License Info";
            this.TP_LicenseInfo.UseVisualStyleBackColor = true;
            // 
            // GB_ReplacementType
            // 
            this.GB_ReplacementType.Controls.Add(this.RB_DamagedLicense);
            this.GB_ReplacementType.Controls.Add(this.RB_LostLicense);
            this.GB_ReplacementType.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GB_ReplacementType.Location = new System.Drawing.Point(583, 337);
            this.GB_ReplacementType.Name = "GB_ReplacementType";
            this.GB_ReplacementType.Size = new System.Drawing.Size(162, 93);
            this.GB_ReplacementType.TabIndex = 31;
            this.GB_ReplacementType.TabStop = false;
            this.GB_ReplacementType.Text = "Replacement Type";
            // 
            // RB_DamagedLicense
            // 
            this.RB_DamagedLicense.AutoSize = true;
            this.RB_DamagedLicense.Checked = true;
            this.RB_DamagedLicense.Location = new System.Drawing.Point(14, 29);
            this.RB_DamagedLicense.Name = "RB_DamagedLicense";
            this.RB_DamagedLicense.Size = new System.Drawing.Size(125, 20);
            this.RB_DamagedLicense.TabIndex = 32;
            this.RB_DamagedLicense.TabStop = true;
            this.RB_DamagedLicense.Text = "Damaged License";
            this.RB_DamagedLicense.UseVisualStyleBackColor = true;
            this.RB_DamagedLicense.CheckedChanged += new System.EventHandler(this.RB_DamagedLicense_CheckedChanged);
            // 
            // RB_LostLicense
            // 
            this.RB_LostLicense.AutoSize = true;
            this.RB_LostLicense.Location = new System.Drawing.Point(14, 55);
            this.RB_LostLicense.Name = "RB_LostLicense";
            this.RB_LostLicense.Size = new System.Drawing.Size(94, 20);
            this.RB_LostLicense.TabIndex = 31;
            this.RB_LostLicense.Text = "Lost License";
            this.RB_LostLicense.UseVisualStyleBackColor = true;
            // 
            // BTN_Next
            // 
            this.BTN_Next.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Next.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Next.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Next.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Next.Location = new System.Drawing.Point(328, 448);
            this.BTN_Next.Name = "BTN_Next";
            this.BTN_Next.Size = new System.Drawing.Size(117, 28);
            this.BTN_Next.TabIndex = 30;
            this.BTN_Next.Tag = " ";
            this.BTN_Next.Text = "Next";
            this.BTN_Next.UseVisualStyleBackColor = false;
            this.BTN_Next.Click += new System.EventHandler(this.BTN_Next_Click);
            // 
            // BTN_NextToApplicationInfo
            // 
            this.BTN_NextToApplicationInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_NextToApplicationInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_NextToApplicationInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_NextToApplicationInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_NextToApplicationInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_NextToApplicationInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NextToApplicationInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NextToApplicationInfo.Location = new System.Drawing.Point(600, 398);
            this.BTN_NextToApplicationInfo.Name = "BTN_NextToApplicationInfo";
            this.BTN_NextToApplicationInfo.Size = new System.Drawing.Size(92, 32);
            this.BTN_NextToApplicationInfo.TabIndex = 25;
            this.BTN_NextToApplicationInfo.Text = "Next";
            this.BTN_NextToApplicationInfo.UseVisualStyleBackColor = false;
            // 
            // TP_ApplicationInfo
            // 
            this.TP_ApplicationInfo.Controls.Add(this.GB_ApplicationInfo);
            this.TP_ApplicationInfo.Controls.Add(this.BTN_Replace);
            this.TP_ApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_ApplicationInfo.Name = "TP_ApplicationInfo";
            this.TP_ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ApplicationInfo.Size = new System.Drawing.Size(773, 482);
            this.TP_ApplicationInfo.TabIndex = 1;
            this.TP_ApplicationInfo.Text = "Application Info";
            this.TP_ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // GB_ApplicationInfo
            // 
            this.GB_ApplicationInfo.Controls.Add(this.BTN_LicenseInfo);
            this.GB_ApplicationInfo.Controls.Add(this.LB_RAppID);
            this.GB_ApplicationInfo.Controls.Add(this.LB_OldLicenseID);
            this.GB_ApplicationInfo.Controls.Add(this.label10);
            this.GB_ApplicationInfo.Controls.Add(this.LB_CreatedBy);
            this.GB_ApplicationInfo.Controls.Add(this.label9);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ApplicationFees);
            this.GB_ApplicationInfo.Controls.Add(this.label8);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ReplacedLicenseID);
            this.GB_ApplicationInfo.Controls.Add(this.label11);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ApplicationDate);
            this.GB_ApplicationInfo.Controls.Add(this.label13);
            this.GB_ApplicationInfo.Controls.Add(this.label17);
            this.GB_ApplicationInfo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GB_ApplicationInfo.Location = new System.Drawing.Point(6, 6);
            this.GB_ApplicationInfo.Name = "GB_ApplicationInfo";
            this.GB_ApplicationInfo.Size = new System.Drawing.Size(761, 256);
            this.GB_ApplicationInfo.TabIndex = 50;
            this.GB_ApplicationInfo.TabStop = false;
            this.GB_ApplicationInfo.Text = "Application Info";
            // 
            // BTN_LicenseInfo
            // 
            this.BTN_LicenseInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_LicenseInfo.Enabled = false;
            this.BTN_LicenseInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_LicenseInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LicenseInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_LicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LicenseInfo.Location = new System.Drawing.Point(18, 193);
            this.BTN_LicenseInfo.Name = "BTN_LicenseInfo";
            this.BTN_LicenseInfo.Size = new System.Drawing.Size(178, 28);
            this.BTN_LicenseInfo.TabIndex = 49;
            this.BTN_LicenseInfo.Tag = " ";
            this.BTN_LicenseInfo.Text = "License Info";
            this.BTN_LicenseInfo.UseVisualStyleBackColor = false;
            this.BTN_LicenseInfo.Click += new System.EventHandler(this.BTN_LicenseInfo_Click);
            // 
            // LB_RAppID
            // 
            this.LB_RAppID.AutoSize = true;
            this.LB_RAppID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RAppID.Location = new System.Drawing.Point(182, 46);
            this.LB_RAppID.Name = "LB_RAppID";
            this.LB_RAppID.Size = new System.Drawing.Size(27, 19);
            this.LB_RAppID.TabIndex = 44;
            this.LB_RAppID.Text = "??";
            // 
            // LB_OldLicenseID
            // 
            this.LB_OldLicenseID.AutoSize = true;
            this.LB_OldLicenseID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_OldLicenseID.Location = new System.Drawing.Point(637, 93);
            this.LB_OldLicenseID.Name = "LB_OldLicenseID";
            this.LB_OldLicenseID.Size = new System.Drawing.Size(21, 19);
            this.LB_OldLicenseID.TabIndex = 41;
            this.LB_OldLicenseID.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(445, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Old License ID           :";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(638, 140);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(21, 19);
            this.LB_CreatedBy.TabIndex = 39;
            this.LB_CreatedBy.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created By                 :";
            // 
            // LB_ApplicationFees
            // 
            this.LB_ApplicationFees.AutoSize = true;
            this.LB_ApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationFees.Location = new System.Drawing.Point(188, 140);
            this.LB_ApplicationFees.Name = "LB_ApplicationFees";
            this.LB_ApplicationFees.Size = new System.Drawing.Size(21, 19);
            this.LB_ApplicationFees.TabIndex = 37;
            this.LB_ApplicationFees.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Application Fees    :";
            // 
            // LB_ReplacedLicenseID
            // 
            this.LB_ReplacedLicenseID.AutoSize = true;
            this.LB_ReplacedLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ReplacedLicenseID.Location = new System.Drawing.Point(638, 46);
            this.LB_ReplacedLicenseID.Name = "LB_ReplacedLicenseID";
            this.LB_ReplacedLicenseID.Size = new System.Drawing.Size(27, 19);
            this.LB_ReplacedLicenseID.TabIndex = 35;
            this.LB_ReplacedLicenseID.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Replaced License ID :";
            // 
            // LB_ApplicationDate
            // 
            this.LB_ApplicationDate.AutoSize = true;
            this.LB_ApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationDate.Location = new System.Drawing.Point(186, 93);
            this.LB_ApplicationDate.Name = "LB_ApplicationDate";
            this.LB_ApplicationDate.Size = new System.Drawing.Size(21, 19);
            this.LB_ApplicationDate.TabIndex = 32;
            this.LB_ApplicationDate.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Application Date   :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(167, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "R.L.Application ID :";
            // 
            // BTN_Replace
            // 
            this.BTN_Replace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Replace.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Replace.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Replace.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Replace.Location = new System.Drawing.Point(328, 294);
            this.BTN_Replace.Name = "BTN_Replace";
            this.BTN_Replace.Size = new System.Drawing.Size(117, 35);
            this.BTN_Replace.TabIndex = 49;
            this.BTN_Replace.Tag = " ";
            this.BTN_Replace.Text = "Replace";
            this.BTN_Replace.UseVisualStyleBackColor = false;
            this.BTN_Replace.Click += new System.EventHandler(this.BTN_Replace_Click);
            // 
            // UC_LicenseSelector
            // 
            this.UC_LicenseSelector.BackColor = System.Drawing.SystemColors.Window;
            this.UC_LicenseSelector.Location = new System.Drawing.Point(4, 6);
            this.UC_LicenseSelector.Name = "UC_LicenseSelector";
            this.UC_LicenseSelector.Size = new System.Drawing.Size(763, 441);
            this.UC_LicenseSelector.TabIndex = 32;
            // 
            // ReplaceDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 536);
            this.Controls.Add(this.LB_Operation);
            this.Controls.Add(this.TC_LicenseApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace Driving License";
            this.TC_LicenseApplication.ResumeLayout(false);
            this.TP_LicenseInfo.ResumeLayout(false);
            this.GB_ReplacementType.ResumeLayout(false);
            this.GB_ReplacementType.PerformLayout();
            this.TP_ApplicationInfo.ResumeLayout(false);
            this.GB_ApplicationInfo.ResumeLayout(false);
            this.GB_ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Operation;
        private System.Windows.Forms.TabControl TC_LicenseApplication;
        private System.Windows.Forms.TabPage TP_LicenseInfo;
        public System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.Button BTN_NextToApplicationInfo;
        private System.Windows.Forms.TabPage TP_ApplicationInfo;
        public System.Windows.Forms.GroupBox GB_ApplicationInfo;
        public System.Windows.Forms.Button BTN_LicenseInfo;
        public System.Windows.Forms.Label LB_RAppID;
        public System.Windows.Forms.Label LB_OldLicenseID;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label LB_ApplicationFees;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label LB_ReplacedLicenseID;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label LB_ApplicationDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button BTN_Replace;
        private System.Windows.Forms.GroupBox GB_ReplacementType;
        private System.Windows.Forms.RadioButton RB_LostLicense;
        private System.Windows.Forms.RadioButton RB_DamagedLicense;
        private User_Controls.Applications_Section.Local_License.UC_LicenseSelector UC_LicenseSelector;
    }
}