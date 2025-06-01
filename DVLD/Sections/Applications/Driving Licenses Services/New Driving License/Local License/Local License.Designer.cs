namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Local_License
{
    partial class LocalLicense
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
            this.TC_NewLicenseApplication = new System.Windows.Forms.TabControl();
            this.TP_PersonInfo = new System.Windows.Forms.TabPage();
            this.BTN_NextToApplicationInfo = new System.Windows.Forms.Button();
            this.TP_ApplicationInfo = new System.Windows.Forms.TabPage();
            this.LB_ApplicationFees = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_LicenseClasses = new System.Windows.Forms.ComboBox();
            this.LB_ApplicationDate = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_ApplicationID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.UC_Person_Selector = new DVLD.User_Controls.UC_Person_Selector();
            this.TC_NewLicenseApplication.SuspendLayout();
            this.TP_PersonInfo.SuspendLayout();
            this.TP_ApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TC_NewLicenseApplication
            // 
            this.TC_NewLicenseApplication.Controls.Add(this.TP_PersonInfo);
            this.TC_NewLicenseApplication.Controls.Add(this.TP_ApplicationInfo);
            this.TC_NewLicenseApplication.Location = new System.Drawing.Point(28, 40);
            this.TC_NewLicenseApplication.Name = "TC_NewLicenseApplication";
            this.TC_NewLicenseApplication.SelectedIndex = 0;
            this.TC_NewLicenseApplication.Size = new System.Drawing.Size(746, 464);
            this.TC_NewLicenseApplication.TabIndex = 0;
            this.TC_NewLicenseApplication.SelectedIndexChanged += new System.EventHandler(this.TB_NewLicenseApplication_SelectedIndexChanged);
            // 
            // TP_PersonInfo
            // 
            this.TP_PersonInfo.Controls.Add(this.BTN_NextToApplicationInfo);
            this.TP_PersonInfo.Controls.Add(this.UC_Person_Selector);
            this.TP_PersonInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_PersonInfo.Name = "TP_PersonInfo";
            this.TP_PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_PersonInfo.Size = new System.Drawing.Size(738, 438);
            this.TP_PersonInfo.TabIndex = 0;
            this.TP_PersonInfo.Text = "Person Info";
            this.TP_PersonInfo.UseVisualStyleBackColor = true;
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
            this.BTN_NextToApplicationInfo.Click += new System.EventHandler(this.BTN_NextToApplicationInfo_Click);
            // 
            // TP_ApplicationInfo
            // 
            this.TP_ApplicationInfo.Controls.Add(this.LB_ApplicationFees);
            this.TP_ApplicationInfo.Controls.Add(this.label6);
            this.TP_ApplicationInfo.Controls.Add(this.CB_LicenseClasses);
            this.TP_ApplicationInfo.Controls.Add(this.LB_ApplicationDate);
            this.TP_ApplicationInfo.Controls.Add(this.LB_CreatedBy);
            this.TP_ApplicationInfo.Controls.Add(this.BTN_Save);
            this.TP_ApplicationInfo.Controls.Add(this.label5);
            this.TP_ApplicationInfo.Controls.Add(this.label4);
            this.TP_ApplicationInfo.Controls.Add(this.label3);
            this.TP_ApplicationInfo.Controls.Add(this.LB_ApplicationID);
            this.TP_ApplicationInfo.Controls.Add(this.label1);
            this.TP_ApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_ApplicationInfo.Name = "TP_ApplicationInfo";
            this.TP_ApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_ApplicationInfo.Size = new System.Drawing.Size(738, 438);
            this.TP_ApplicationInfo.TabIndex = 1;
            this.TP_ApplicationInfo.Text = "Application Info";
            this.TP_ApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // LB_ApplicationFees
            // 
            this.LB_ApplicationFees.AutoSize = true;
            this.LB_ApplicationFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationFees.Location = new System.Drawing.Point(251, 224);
            this.LB_ApplicationFees.Name = "LB_ApplicationFees";
            this.LB_ApplicationFees.Size = new System.Drawing.Size(23, 19);
            this.LB_ApplicationFees.TabIndex = 47;
            this.LB_ApplicationFees.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "ApplicationFees :";
            // 
            // CB_LicenseClasses
            // 
            this.CB_LicenseClasses.BackColor = System.Drawing.SystemColors.Control;
            this.CB_LicenseClasses.FormattingEnabled = true;
            this.CB_LicenseClasses.Location = new System.Drawing.Point(255, 172);
            this.CB_LicenseClasses.Name = "CB_LicenseClasses";
            this.CB_LicenseClasses.Size = new System.Drawing.Size(196, 21);
            this.CB_LicenseClasses.TabIndex = 45;
            // 
            // LB_ApplicationDate
            // 
            this.LB_ApplicationDate.AutoSize = true;
            this.LB_ApplicationDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationDate.Location = new System.Drawing.Point(251, 122);
            this.LB_ApplicationDate.Name = "LB_ApplicationDate";
            this.LB_ApplicationDate.Size = new System.Drawing.Size(23, 19);
            this.LB_ApplicationDate.TabIndex = 44;
            this.LB_ApplicationDate.Text = "--";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(251, 271);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(23, 19);
            this.LB_CreatedBy.TabIndex = 42;
            this.LB_CreatedBy.Text = "--";
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(315, 350);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(92, 32);
            this.BTN_Save.TabIndex = 36;
            this.BTN_Save.Tag = "";
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Created By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "License Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Application Date :";
            // 
            // LB_ApplicationID
            // 
            this.LB_ApplicationID.AutoSize = true;
            this.LB_ApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationID.Location = new System.Drawing.Point(251, 70);
            this.LB_ApplicationID.Name = "LB_ApplicationID";
            this.LB_ApplicationID.Size = new System.Drawing.Size(27, 19);
            this.LB_ApplicationID.TabIndex = 38;
            this.LB_ApplicationID.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "ApplicationID :";
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(227, 5);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(317, 19);
            this.LB_Opration.TabIndex = 24;
            this.LB_Opration.Text = "New Local Driving License Application";
            this.LB_Opration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Person_Selector
            // 
            this.UC_Person_Selector.BackColor = System.Drawing.SystemColors.Window;
            this.UC_Person_Selector.Location = new System.Drawing.Point(41, 6);
            this.UC_Person_Selector.Name = "UC_Person_Selector";
            this.UC_Person_Selector.Size = new System.Drawing.Size(651, 386);
            this.UC_Person_Selector.TabIndex = 0;
            // 
            // Local_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.TC_NewLicenseApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Local_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local License";
            this.Load += new System.EventHandler(this.Local_License_Load);
            this.TC_NewLicenseApplication.ResumeLayout(false);
            this.TP_PersonInfo.ResumeLayout(false);
            this.TP_ApplicationInfo.ResumeLayout(false);
            this.TP_ApplicationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TC_NewLicenseApplication;
        private System.Windows.Forms.TabPage TP_PersonInfo;
        private System.Windows.Forms.TabPage TP_ApplicationInfo;
        private System.Windows.Forms.Label LB_Opration;
        private User_Controls.UC_Person_Selector UC_Person_Selector;
        private System.Windows.Forms.Button BTN_NextToApplicationInfo;
        public System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label LB_ApplicationID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LB_ApplicationDate;
        public System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.ComboBox CB_LicenseClasses;
        public System.Windows.Forms.Label LB_ApplicationFees;
        private System.Windows.Forms.Label label6;
    }
}