namespace DVLD
{
    partial class ManageUsers
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
            this.components = new System.ComponentModel.Container();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.CB_FilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Users = new System.Windows.Forms.DataGridView();
            this.CMS_UsersActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Seperator = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_RecordCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_AddUser = new System.Windows.Forms.Button();
            this.TB_FilterationValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).BeginInit();
            this.CMS_UsersActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(423, -4);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(143, 23);
            this.LB_Opration.TabIndex = 28;
            this.LB_Opration.Text = "Manage Users";
            // 
            // CB_FilterBy
            // 
            this.CB_FilterBy.FormattingEnabled = true;
            this.CB_FilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "User Name",
            "National No.",
            "Full Name",
            "Is Active"});
            this.CB_FilterBy.Location = new System.Drawing.Point(84, 160);
            this.CB_FilterBy.Name = "CB_FilterBy";
            this.CB_FilterBy.Size = new System.Drawing.Size(124, 21);
            this.CB_FilterBy.TabIndex = 25;
            this.CB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Filter By :";
            // 
            // DGV_Users
            // 
            this.DGV_Users.AllowUserToAddRows = false;
            this.DGV_Users.AllowUserToDeleteRows = false;
            this.DGV_Users.AllowUserToOrderColumns = true;
            this.DGV_Users.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Users.ContextMenuStrip = this.CMS_UsersActions;
            this.DGV_Users.Location = new System.Drawing.Point(12, 189);
            this.DGV_Users.Name = "DGV_Users";
            this.DGV_Users.ReadOnly = true;
            this.DGV_Users.Size = new System.Drawing.Size(963, 349);
            this.DGV_Users.TabIndex = 23;
            // 
            // CMS_UsersActions
            // 
            this.CMS_UsersActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ShowDetails,
            this.TSMI_AddUser,
            this.TSMI_UpdateUser,
            this.TSMI_DeleteUser,
            this.TSMI_ChangePassword,
            this.TSMI_Refresh,
            this.TSMI_Seperator,
            this.TSMI_SendEmail,
            this.TSMI_PhoneCall});
            this.CMS_UsersActions.Name = "CMS_PeopleHandle";
            this.CMS_UsersActions.Size = new System.Drawing.Size(166, 186);
            // 
            // TSMI_ShowDetails
            // 
            this.TSMI_ShowDetails.Name = "TSMI_ShowDetails";
            this.TSMI_ShowDetails.Size = new System.Drawing.Size(165, 22);
            this.TSMI_ShowDetails.Text = "Show Details";
            this.TSMI_ShowDetails.Click += new System.EventHandler(this.TSMI_ShowDetails_Click);
            // 
            // TSMI_AddUser
            // 
            this.TSMI_AddUser.Name = "TSMI_AddUser";
            this.TSMI_AddUser.Size = new System.Drawing.Size(165, 22);
            this.TSMI_AddUser.Text = "Add User";
            this.TSMI_AddUser.Click += new System.EventHandler(this.TSMI_AddUser_Click);
            // 
            // TSMI_UpdateUser
            // 
            this.TSMI_UpdateUser.Name = "TSMI_UpdateUser";
            this.TSMI_UpdateUser.Size = new System.Drawing.Size(165, 22);
            this.TSMI_UpdateUser.Text = "Update User";
            this.TSMI_UpdateUser.Click += new System.EventHandler(this.TSMI_UpdateUser_Click);
            // 
            // TSMI_DeleteUser
            // 
            this.TSMI_DeleteUser.Name = "TSMI_DeleteUser";
            this.TSMI_DeleteUser.Size = new System.Drawing.Size(165, 22);
            this.TSMI_DeleteUser.Text = "Delete User";
            this.TSMI_DeleteUser.Click += new System.EventHandler(this.TSMI_DeleteUser_Click);
            // 
            // TSMI_ChangePassword
            // 
            this.TSMI_ChangePassword.Name = "TSMI_ChangePassword";
            this.TSMI_ChangePassword.Size = new System.Drawing.Size(165, 22);
            this.TSMI_ChangePassword.Text = "ChangePassword";
            this.TSMI_ChangePassword.Click += new System.EventHandler(this.TSMI_ChangePassword_Click);
            // 
            // TSMI_Refresh
            // 
            this.TSMI_Refresh.Name = "TSMI_Refresh";
            this.TSMI_Refresh.Size = new System.Drawing.Size(165, 22);
            this.TSMI_Refresh.Text = "Refresh";
            this.TSMI_Refresh.Click += new System.EventHandler(this.TSMI_Refresh_Click);
            // 
            // TSMI_Seperator
            // 
            this.TSMI_Seperator.Name = "TSMI_Seperator";
            this.TSMI_Seperator.Size = new System.Drawing.Size(162, 6);
            // 
            // TSMI_SendEmail
            // 
            this.TSMI_SendEmail.Name = "TSMI_SendEmail";
            this.TSMI_SendEmail.Size = new System.Drawing.Size(165, 22);
            this.TSMI_SendEmail.Text = "Send Email";
            this.TSMI_SendEmail.Click += new System.EventHandler(this.TSMI_SendEmail_Click);
            // 
            // TSMI_PhoneCall
            // 
            this.TSMI_PhoneCall.Name = "TSMI_PhoneCall";
            this.TSMI_PhoneCall.Size = new System.Drawing.Size(165, 22);
            this.TSMI_PhoneCall.Text = "Phone Call";
            this.TSMI_PhoneCall.Click += new System.EventHandler(this.TSMI_PhoneCall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "# Records :";
            // 
            // LBL_RecordCount
            // 
            this.LBL_RecordCount.AutoSize = true;
            this.LBL_RecordCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RecordCount.Location = new System.Drawing.Point(533, 154);
            this.LBL_RecordCount.Name = "LBL_RecordCount";
            this.LBL_RecordCount.Size = new System.Drawing.Size(23, 19);
            this.LBL_RecordCount.TabIndex = 30;
            this.LBL_RecordCount.Text = "--";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.Users;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(408, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_AddUser
            // 
            this.BTN_AddUser.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddUser.BackgroundImage = global::DVLD.Properties.Resources.Add_User;
            this.BTN_AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddUser.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_AddUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_AddUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddUser.Location = new System.Drawing.Point(926, 145);
            this.BTN_AddUser.Name = "BTN_AddUser";
            this.BTN_AddUser.Size = new System.Drawing.Size(49, 38);
            this.BTN_AddUser.TabIndex = 26;
            this.BTN_AddUser.UseVisualStyleBackColor = false;
            this.BTN_AddUser.Click += new System.EventHandler(this.BTN_AddUser_Click);
            // 
            // TB_FilterationValue
            // 
            this.TB_FilterationValue.Location = new System.Drawing.Point(227, 160);
            this.TB_FilterationValue.Name = "TB_FilterationValue";
            this.TB_FilterationValue.Size = new System.Drawing.Size(100, 20);
            this.TB_FilterationValue.TabIndex = 34;
            this.TB_FilterationValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_FilterationValue_KeyDown);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 544);
            this.Controls.Add(this.TB_FilterationValue);
            this.Controls.Add(this.LBL_RecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_AddUser);
            this.Controls.Add(this.CB_FilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Users)).EndInit();
            this.CMS_UsersActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_AddUser;
        private System.Windows.Forms.ComboBox CB_FilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_RecordCount;
        private System.Windows.Forms.ContextMenuStrip CMS_UsersActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DeleteUser;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Refresh;
        private System.Windows.Forms.ToolStripSeparator TSMI_Seperator;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SendEmail;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PhoneCall;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ChangePassword;
        private System.Windows.Forms.TextBox TB_FilterationValue;
    }
}