namespace DVLD.Sections.Applications.Driving_Licenses_Services.Licenses
{
    partial class RenewDrivingLicense
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
            this.BTN_Next = new System.Windows.Forms.Button();
            this.UC_LicenseSelector = new DVLD.User_Controls.Applications_Section.Local_License.UC_LicenseSelector();
            this.BTN_NextToApplicationInfo = new System.Windows.Forms.Button();
            this.TP_ApplicationInfo = new System.Windows.Forms.TabPage();
            this.GB_ApplicationInfo = new System.Windows.Forms.GroupBox();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_TotalFees = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_LicenseFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_LicenseInfo = new System.Windows.Forms.Button();
            this.LB_RAppID = new System.Windows.Forms.Label();
            this.LB_ExpirationDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LB_ExpiredLicenseID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_ApplicationFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_RenewedLicenseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_ApplicationDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LB_IssueDate = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BTN_Renew = new System.Windows.Forms.Button();
            this.TC_LicenseApplication.SuspendLayout();
            this.TP_LicenseInfo.SuspendLayout();
            this.TP_ApplicationInfo.SuspendLayout();
            this.GB_ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Operation
            // 
            this.LB_Operation.AutoSize = true;
            this.LB_Operation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Operation.Location = new System.Drawing.Point(247, 7);
            this.LB_Operation.Name = "LB_Operation";
            this.LB_Operation.Size = new System.Drawing.Size(290, 19);
            this.LB_Operation.TabIndex = 33;
            this.LB_Operation.Text = "Renew Driving License Application";
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
            this.TC_LicenseApplication.TabIndex = 32;
            this.TC_LicenseApplication.SelectedIndexChanged += new System.EventHandler(this.TC_LicenseApplication_SelectedIndexChanged);
            // 
            // TP_LicenseInfo
            // 
            this.TP_LicenseInfo.Controls.Add(this.BTN_Next);
            this.TP_LicenseInfo.Controls.Add(this.UC_LicenseSelector);
            this.TP_LicenseInfo.Controls.Add(this.BTN_NextToApplicationInfo);
            this.TP_LicenseInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_LicenseInfo.Name = "TP_LicenseInfo";
            this.TP_LicenseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_LicenseInfo.Size = new System.Drawing.Size(773, 482);
            this.TP_LicenseInfo.TabIndex = 0;
            this.TP_LicenseInfo.Text = "License Info";
            this.TP_LicenseInfo.UseVisualStyleBackColor = true;
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
            // UC_LicenseSelector
            // 
            this.UC_LicenseSelector.BackColor = System.Drawing.SystemColors.Window;
            this.UC_LicenseSelector.Location = new System.Drawing.Point(6, 6);
            this.UC_LicenseSelector.Name = "UC_LicenseSelector";
            this.UC_LicenseSelector.Size = new System.Drawing.Size(763, 441);
            this.UC_LicenseSelector.TabIndex = 26;
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
            this.TP_ApplicationInfo.Controls.Add(this.BTN_Renew);
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
            this.GB_ApplicationInfo.Controls.Add(this.TB_Notes);
            this.GB_ApplicationInfo.Controls.Add(this.label5);
            this.GB_ApplicationInfo.Controls.Add(this.LB_TotalFees);
            this.GB_ApplicationInfo.Controls.Add(this.label2);
            this.GB_ApplicationInfo.Controls.Add(this.LB_LicenseFees);
            this.GB_ApplicationInfo.Controls.Add(this.label4);
            this.GB_ApplicationInfo.Controls.Add(this.BTN_LicenseInfo);
            this.GB_ApplicationInfo.Controls.Add(this.LB_RAppID);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ExpirationDate);
            this.GB_ApplicationInfo.Controls.Add(this.label12);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ExpiredLicenseID);
            this.GB_ApplicationInfo.Controls.Add(this.label10);
            this.GB_ApplicationInfo.Controls.Add(this.LB_CreatedBy);
            this.GB_ApplicationInfo.Controls.Add(this.label9);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ApplicationFees);
            this.GB_ApplicationInfo.Controls.Add(this.label8);
            this.GB_ApplicationInfo.Controls.Add(this.LB_RenewedLicenseID);
            this.GB_ApplicationInfo.Controls.Add(this.label11);
            this.GB_ApplicationInfo.Controls.Add(this.LB_ApplicationDate);
            this.GB_ApplicationInfo.Controls.Add(this.label13);
            this.GB_ApplicationInfo.Controls.Add(this.LB_IssueDate);
            this.GB_ApplicationInfo.Controls.Add(this.label15);
            this.GB_ApplicationInfo.Controls.Add(this.label17);
            this.GB_ApplicationInfo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GB_ApplicationInfo.Location = new System.Drawing.Point(6, 6);
            this.GB_ApplicationInfo.Name = "GB_ApplicationInfo";
            this.GB_ApplicationInfo.Size = new System.Drawing.Size(761, 383);
            this.GB_ApplicationInfo.TabIndex = 48;
            this.GB_ApplicationInfo.TabStop = false;
            this.GB_ApplicationInfo.Text = "Application Info";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(224, 258);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(516, 107);
            this.TB_Notes.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 54;
            this.label5.Text = "Notes                     :";
            // 
            // LB_TotalFees
            // 
            this.LB_TotalFees.AutoSize = true;
            this.LB_TotalFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalFees.Location = new System.Drawing.Point(638, 218);
            this.LB_TotalFees.Name = "LB_TotalFees";
            this.LB_TotalFees.Size = new System.Drawing.Size(21, 19);
            this.LB_TotalFees.TabIndex = 53;
            this.LB_TotalFees.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total Fees                  :";
            // 
            // LB_LicenseFees
            // 
            this.LB_LicenseFees.AutoSize = true;
            this.LB_LicenseFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LicenseFees.Location = new System.Drawing.Point(188, 218);
            this.LB_LicenseFees.Name = "LB_LicenseFees";
            this.LB_LicenseFees.Size = new System.Drawing.Size(21, 19);
            this.LB_LicenseFees.TabIndex = 51;
            this.LB_LicenseFees.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "License Fees          :";
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
            this.BTN_LicenseInfo.Location = new System.Drawing.Point(18, 337);
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
            // LB_ExpirationDate
            // 
            this.LB_ExpirationDate.AutoSize = true;
            this.LB_ExpirationDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_ExpirationDate.Location = new System.Drawing.Point(638, 133);
            this.LB_ExpirationDate.Name = "LB_ExpirationDate";
            this.LB_ExpirationDate.Size = new System.Drawing.Size(21, 19);
            this.LB_ExpirationDate.TabIndex = 43;
            this.LB_ExpirationDate.Text = "--";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(446, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "Expiration Date         :";
            // 
            // LB_ExpiredLicenseID
            // 
            this.LB_ExpiredLicenseID.AutoSize = true;
            this.LB_ExpiredLicenseID.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_ExpiredLicenseID.Location = new System.Drawing.Point(638, 90);
            this.LB_ExpiredLicenseID.Name = "LB_ExpiredLicenseID";
            this.LB_ExpiredLicenseID.Size = new System.Drawing.Size(21, 19);
            this.LB_ExpiredLicenseID.TabIndex = 41;
            this.LB_ExpiredLicenseID.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "Expired License ID    :";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(638, 176);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(21, 19);
            this.LB_CreatedBy.TabIndex = 39;
            this.LB_CreatedBy.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created By                 :";
            // 
            // LB_ApplicationFees
            // 
            this.LB_ApplicationFees.AutoSize = true;
            this.LB_ApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationFees.Location = new System.Drawing.Point(188, 176);
            this.LB_ApplicationFees.Name = "LB_ApplicationFees";
            this.LB_ApplicationFees.Size = new System.Drawing.Size(21, 19);
            this.LB_ApplicationFees.TabIndex = 37;
            this.LB_ApplicationFees.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Application Fees    :";
            // 
            // LB_RenewedLicenseID
            // 
            this.LB_RenewedLicenseID.AutoSize = true;
            this.LB_RenewedLicenseID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RenewedLicenseID.Location = new System.Drawing.Point(638, 46);
            this.LB_RenewedLicenseID.Name = "LB_RenewedLicenseID";
            this.LB_RenewedLicenseID.Size = new System.Drawing.Size(21, 19);
            this.LB_RenewedLicenseID.TabIndex = 35;
            this.LB_RenewedLicenseID.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Renewed License ID :";
            // 
            // LB_ApplicationDate
            // 
            this.LB_ApplicationDate.AutoSize = true;
            this.LB_ApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationDate.Location = new System.Drawing.Point(188, 90);
            this.LB_ApplicationDate.Name = "LB_ApplicationDate";
            this.LB_ApplicationDate.Size = new System.Drawing.Size(21, 19);
            this.LB_ApplicationDate.TabIndex = 32;
            this.LB_ApplicationDate.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Application Date   :";
            // 
            // LB_IssueDate
            // 
            this.LB_IssueDate.AutoSize = true;
            this.LB_IssueDate.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_IssueDate.Location = new System.Drawing.Point(188, 133);
            this.LB_IssueDate.Name = "LB_IssueDate";
            this.LB_IssueDate.Size = new System.Drawing.Size(21, 19);
            this.LB_IssueDate.TabIndex = 30;
            this.LB_IssueDate.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 19);
            this.label15.TabIndex = 29;
            this.label15.Text = "Issue Date             :";
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
            // BTN_Renew
            // 
            this.BTN_Renew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Renew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Renew.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Renew.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Renew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Renew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Renew.Location = new System.Drawing.Point(328, 399);
            this.BTN_Renew.Name = "BTN_Renew";
            this.BTN_Renew.Size = new System.Drawing.Size(117, 35);
            this.BTN_Renew.TabIndex = 32;
            this.BTN_Renew.Tag = " ";
            this.BTN_Renew.Text = "Renew";
            this.BTN_Renew.UseVisualStyleBackColor = false;
            this.BTN_Renew.Click += new System.EventHandler(this.BTN_Renew_Click);
            // 
            // RenewDrivingLicense
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
            this.Name = "RenewDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RenewDrivingLicense";
            this.TC_LicenseApplication.ResumeLayout(false);
            this.TP_LicenseInfo.ResumeLayout(false);
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
        private User_Controls.Applications_Section.Local_License.UC_LicenseSelector UC_LicenseSelector;
        private System.Windows.Forms.Button BTN_NextToApplicationInfo;
        private System.Windows.Forms.TabPage TP_ApplicationInfo;
        public System.Windows.Forms.GroupBox GB_ApplicationInfo;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LB_TotalFees;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LB_LicenseFees;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button BTN_LicenseInfo;
        public System.Windows.Forms.Label LB_RAppID;
        public System.Windows.Forms.Label LB_ExpirationDate;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label LB_ExpiredLicenseID;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label LB_ApplicationFees;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label LB_RenewedLicenseID;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label LB_ApplicationDate;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label LB_IssueDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button BTN_Renew;
    }
}