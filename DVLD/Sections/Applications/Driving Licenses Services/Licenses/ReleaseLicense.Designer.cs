﻿namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    partial class ReleaseLicense
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
            this.TC_ReleaseLicense = new System.Windows.Forms.TabControl();
            this.TP_LicenseInfo = new System.Windows.Forms.TabPage();
            this.UC_LicenseSelector = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseSelector();
            this.BTN_Next = new System.Windows.Forms.Button();
            this.BTN_NextToApplicationInfo = new System.Windows.Forms.Button();
            this.TP_ReleaseInfo = new System.Windows.Forms.TabPage();
            this.GB_ApplicationInfo = new System.Windows.Forms.GroupBox();
            this.BTN_LicenseInfo = new System.Windows.Forms.Button();
            this.LB_DetainID = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_LicenseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_DetainDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BTN_Release = new System.Windows.Forms.Button();
            this.LB_ApplicationFees = new System.Windows.Forms.Label();
            this.LB_FineFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_TotalFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_ReleaseLicense.SuspendLayout();
            this.TP_LicenseInfo.SuspendLayout();
            this.TP_ReleaseInfo.SuspendLayout();
            this.GB_ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_ReleaseLicense
            // 
            this.TC_ReleaseLicense.Controls.Add(this.TP_LicenseInfo);
            this.TC_ReleaseLicense.Controls.Add(this.TP_ReleaseInfo);
            this.TC_ReleaseLicense.Location = new System.Drawing.Point(11, 14);
            this.TC_ReleaseLicense.Name = "TC_ReleaseLicense";
            this.TC_ReleaseLicense.SelectedIndex = 0;
            this.TC_ReleaseLicense.Size = new System.Drawing.Size(781, 508);
            this.TC_ReleaseLicense.TabIndex = 36;
            this.TC_ReleaseLicense.SelectedIndexChanged += new System.EventHandler(this.TC_ReleaseLicense_SelectedIndexChanged);
            // 
            // TP_LicenseInfo
            // 
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
            // UC_LicenseSelector
            // 
            this.UC_LicenseSelector.BackColor = System.Drawing.SystemColors.Window;
            this.UC_LicenseSelector.Location = new System.Drawing.Point(4, 6);
            this.UC_LicenseSelector.Name = "UC_LicenseSelector";
            this.UC_LicenseSelector.Size = new System.Drawing.Size(763, 441);
            this.UC_LicenseSelector.TabIndex = 32;
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
            // TP_ReleaseInfo
            // 
            this.TP_ReleaseInfo.Controls.Add(this.GB_ApplicationInfo);
            this.TP_ReleaseInfo.Controls.Add(this.BTN_Release);
            this.TP_ReleaseInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_ReleaseInfo.Name = "TP_ReleaseInfo";
            this.TP_ReleaseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ReleaseInfo.Size = new System.Drawing.Size(773, 482);
            this.TP_ReleaseInfo.TabIndex = 1;
            this.TP_ReleaseInfo.Text = "Release Info";
            this.TP_ReleaseInfo.UseVisualStyleBackColor = true;
            // 
            // GB_ApplicationInfo
            // 
            this.GB_ApplicationInfo.Controls.Add(this.LB_TotalFees);
            this.GB_ApplicationInfo.Controls.Add(this.label2);
            this.GB_ApplicationInfo.Controls.Add(this.LB_FineFees);
            this.GB_ApplicationInfo.Controls.Add(this.label3);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ApplicationFees);
            this.GB_ApplicationInfo.Controls.Add(this.BTN_LicenseInfo);
            this.GB_ApplicationInfo.Controls.Add(this.LB_DetainID);
            this.GB_ApplicationInfo.Controls.Add(this.LB_CreatedBy);
            this.GB_ApplicationInfo.Controls.Add(this.label9);
            this.GB_ApplicationInfo.Controls.Add(this.label8);
            this.GB_ApplicationInfo.Controls.Add(this.LB_LicenseID);
            this.GB_ApplicationInfo.Controls.Add(this.label11);
            this.GB_ApplicationInfo.Controls.Add(this.LB_DetainDate);
            this.GB_ApplicationInfo.Controls.Add(this.label13);
            this.GB_ApplicationInfo.Controls.Add(this.label17);
            this.GB_ApplicationInfo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GB_ApplicationInfo.Location = new System.Drawing.Point(6, 6);
            this.GB_ApplicationInfo.Name = "GB_ApplicationInfo";
            this.GB_ApplicationInfo.Size = new System.Drawing.Size(761, 246);
            this.GB_ApplicationInfo.TabIndex = 50;
            this.GB_ApplicationInfo.TabStop = false;
            this.GB_ApplicationInfo.Text = "Application Info";
            // 
            // BTN_LicenseInfo
            // 
            this.BTN_LicenseInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_LicenseInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_LicenseInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_LicenseInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_LicenseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LicenseInfo.Location = new System.Drawing.Point(451, 187);
            this.BTN_LicenseInfo.Name = "BTN_LicenseInfo";
            this.BTN_LicenseInfo.Size = new System.Drawing.Size(178, 28);
            this.BTN_LicenseInfo.TabIndex = 49;
            this.BTN_LicenseInfo.Tag = " ";
            this.BTN_LicenseInfo.Text = "License Info";
            this.BTN_LicenseInfo.UseVisualStyleBackColor = false;
            this.BTN_LicenseInfo.Click += new System.EventHandler(this.BTN_LicenseInfo_Click);
            // 
            // LB_DetainID
            // 
            this.LB_DetainID.AutoSize = true;
            this.LB_DetainID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainID.Location = new System.Drawing.Point(188, 46);
            this.LB_DetainID.Name = "LB_DetainID";
            this.LB_DetainID.Size = new System.Drawing.Size(27, 19);
            this.LB_DetainID.TabIndex = 44;
            this.LB_DetainID.Text = "??";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(639, 93);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(21, 19);
            this.LB_CreatedBy.TabIndex = 39;
            this.LB_CreatedBy.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created By               :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Application Fees  :";
            // 
            // LB_LicenseID
            // 
            this.LB_LicenseID.AutoSize = true;
            this.LB_LicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LicenseID.Location = new System.Drawing.Point(638, 46);
            this.LB_LicenseID.Name = "LB_LicenseID";
            this.LB_LicenseID.Size = new System.Drawing.Size(27, 19);
            this.LB_LicenseID.TabIndex = 35;
            this.LB_LicenseID.Text = "??";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "License ID                :";
            // 
            // LB_DetainDate
            // 
            this.LB_DetainDate.AutoSize = true;
            this.LB_DetainDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainDate.Location = new System.Drawing.Point(188, 93);
            this.LB_DetainDate.Name = "LB_DetainDate";
            this.LB_DetainDate.Size = new System.Drawing.Size(21, 19);
            this.LB_DetainDate.TabIndex = 32;
            this.LB_DetainDate.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Detain Date         :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(158, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "Detain ID             :";
            // 
            // BTN_Release
            // 
            this.BTN_Release.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Release.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Release.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Release.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Release.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Release.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Release.Location = new System.Drawing.Point(328, 280);
            this.BTN_Release.Name = "BTN_Release";
            this.BTN_Release.Size = new System.Drawing.Size(117, 35);
            this.BTN_Release.TabIndex = 49;
            this.BTN_Release.Tag = " ";
            this.BTN_Release.Text = "Release";
            this.BTN_Release.UseVisualStyleBackColor = false;
            this.BTN_Release.Click += new System.EventHandler(this.BTN_Release_Click);
            // 
            // LB_ApplicationFees
            // 
            this.LB_ApplicationFees.AutoSize = true;
            this.LB_ApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationFees.Location = new System.Drawing.Point(188, 139);
            this.LB_ApplicationFees.Name = "LB_ApplicationFees";
            this.LB_ApplicationFees.Size = new System.Drawing.Size(21, 19);
            this.LB_ApplicationFees.TabIndex = 50;
            this.LB_ApplicationFees.Text = "--";
            // 
            // LB_FineFees
            // 
            this.LB_FineFees.AutoSize = true;
            this.LB_FineFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FineFees.Location = new System.Drawing.Point(644, 139);
            this.LB_FineFees.Name = "LB_FineFees";
            this.LB_FineFees.Size = new System.Drawing.Size(21, 19);
            this.LB_FineFees.TabIndex = 52;
            this.LB_FineFees.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "Fine Fees                  :";
            // 
            // LB_TotalFees
            // 
            this.LB_TotalFees.AutoSize = true;
            this.LB_TotalFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalFees.Location = new System.Drawing.Point(188, 187);
            this.LB_TotalFees.Name = "LB_TotalFees";
            this.LB_TotalFees.Size = new System.Drawing.Size(21, 19);
            this.LB_TotalFees.TabIndex = 54;
            this.LB_TotalFees.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Total Fees            :";
            // 
            // ReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 536);
            this.Controls.Add(this.TC_ReleaseLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReleaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release License";
            this.TC_ReleaseLicense.ResumeLayout(false);
            this.TP_LicenseInfo.ResumeLayout(false);
            this.TP_ReleaseInfo.ResumeLayout(false);
            this.GB_ApplicationInfo.ResumeLayout(false);
            this.GB_ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC_ReleaseLicense;
        private System.Windows.Forms.TabPage TP_LicenseInfo;
        private User_Controls.Applications_Section.Local_License.UC_LicenseSelector UC_LicenseSelector;
        public System.Windows.Forms.Button BTN_Next;
        private System.Windows.Forms.Button BTN_NextToApplicationInfo;
        private System.Windows.Forms.TabPage TP_ReleaseInfo;
        public System.Windows.Forms.GroupBox GB_ApplicationInfo;
        public System.Windows.Forms.Button BTN_LicenseInfo;
        public System.Windows.Forms.Label LB_DetainID;
        public System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label LB_LicenseID;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label LB_DetainDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button BTN_Release;
        public System.Windows.Forms.Label LB_FineFees;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LB_ApplicationFees;
        public System.Windows.Forms.Label LB_TotalFees;
        private System.Windows.Forms.Label label2;
    }
}