namespace DVLD.User_Controls.Users_Section_Controls
{
    partial class UC_Add_UpdateUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Add_UpdateUser));
            this.TC_UserInfo = new System.Windows.Forms.TabControl();
            this.TP_PersonalInfo = new System.Windows.Forms.TabPage();
            this.BTN_NextToLoginInfo = new System.Windows.Forms.Button();
            this.Person_Selector = new DVLD.User_Controls.UC_Person_Selector();
            this.TP_LoginInfo = new System.Windows.Forms.TabPage();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.CB_IsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.EP_UserLoginInfoValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.TC_UserInfo.SuspendLayout();
            this.TP_PersonalInfo.SuspendLayout();
            this.TP_LoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_UserLoginInfoValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_UserInfo
            // 
            this.TC_UserInfo.Controls.Add(this.TP_PersonalInfo);
            this.TC_UserInfo.Controls.Add(this.TP_LoginInfo);
            this.TC_UserInfo.Location = new System.Drawing.Point(3, 3);
            this.TC_UserInfo.Name = "TC_UserInfo";
            this.TC_UserInfo.SelectedIndex = 0;
            this.TC_UserInfo.Size = new System.Drawing.Size(707, 476);
            this.TC_UserInfo.TabIndex = 25;
            this.TC_UserInfo.SelectedIndexChanged += new System.EventHandler(this.TC_UserInfo_SelectedIndexChanged);
            // 
            // TP_PersonalInfo
            // 
            this.TP_PersonalInfo.Controls.Add(this.BTN_NextToLoginInfo);
            this.TP_PersonalInfo.Controls.Add(this.Person_Selector);
            this.TP_PersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_PersonalInfo.Name = "TP_PersonalInfo";
            this.TP_PersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_PersonalInfo.Size = new System.Drawing.Size(699, 450);
            this.TP_PersonalInfo.TabIndex = 0;
            this.TP_PersonalInfo.Text = "Personal Info";
            this.TP_PersonalInfo.UseVisualStyleBackColor = true;
            // 
            // BTN_NextToLoginInfo
            // 
            this.BTN_NextToLoginInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_NextToLoginInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_NextToLoginInfo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_NextToLoginInfo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_NextToLoginInfo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_NextToLoginInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NextToLoginInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NextToLoginInfo.Location = new System.Drawing.Point(580, 408);
            this.BTN_NextToLoginInfo.Name = "BTN_NextToLoginInfo";
            this.BTN_NextToLoginInfo.Size = new System.Drawing.Size(92, 32);
            this.BTN_NextToLoginInfo.TabIndex = 24;
            this.BTN_NextToLoginInfo.Text = "Next";
            this.BTN_NextToLoginInfo.UseVisualStyleBackColor = false;
            this.BTN_NextToLoginInfo.Click += new System.EventHandler(this.BTN_NextToLoginInfo_Click);
            // 
            // Person_Selector
            // 
            this.Person_Selector.BackColor = System.Drawing.SystemColors.Window;
            this.Person_Selector.Location = new System.Drawing.Point(24, 16);
            this.Person_Selector.Name = "Person_Selector";
            this.Person_Selector.Size = new System.Drawing.Size(651, 386);
            this.Person_Selector.TabIndex = 23;
            // 
            // TP_LoginInfo
            // 
            this.TP_LoginInfo.Controls.Add(this.BTN_Save);
            this.TP_LoginInfo.Controls.Add(this.CB_IsActive);
            this.TP_LoginInfo.Controls.Add(this.label5);
            this.TP_LoginInfo.Controls.Add(this.TB_ConfirmPassword);
            this.TP_LoginInfo.Controls.Add(this.label4);
            this.TP_LoginInfo.Controls.Add(this.TB_Password);
            this.TP_LoginInfo.Controls.Add(this.label3);
            this.TP_LoginInfo.Controls.Add(this.LB_UserID);
            this.TP_LoginInfo.Controls.Add(this.label1);
            this.TP_LoginInfo.Controls.Add(this.TB_UserName);
            this.TP_LoginInfo.Location = new System.Drawing.Point(4, 22);
            this.TP_LoginInfo.Name = "TP_LoginInfo";
            this.TP_LoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TP_LoginInfo.Size = new System.Drawing.Size(699, 450);
            this.TP_LoginInfo.TabIndex = 1;
            this.TP_LoginInfo.Text = "Login Info";
            this.TP_LoginInfo.UseVisualStyleBackColor = true;
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
            this.BTN_Save.Location = new System.Drawing.Point(286, 365);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(92, 32);
            this.BTN_Save.TabIndex = 4;
            this.BTN_Save.Tag = "";
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // CB_IsActive
            // 
            this.CB_IsActive.AutoSize = true;
            this.CB_IsActive.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_IsActive.Location = new System.Drawing.Point(290, 284);
            this.CB_IsActive.Name = "CB_IsActive";
            this.CB_IsActive.Size = new System.Drawing.Size(84, 20);
            this.CB_IsActive.TabIndex = 3;
            this.CB_IsActive.Text = "Is Active";
            this.CB_IsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Confirm Password :";
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(377, 228);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.PasswordChar = '●';
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_ConfirmPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password :";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(377, 176);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '●';
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username :";
            // 
            // LB_UserID
            // 
            this.LB_UserID.AutoSize = true;
            this.LB_UserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserID.Location = new System.Drawing.Point(379, 72);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(23, 19);
            this.LB_UserID.TabIndex = 26;
            this.LB_UserID.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "User ID :";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(377, 126);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(100, 20);
            this.TB_UserName.TabIndex = 0;
            this.TB_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Username_Validating);
            // 
            // EP_UserLoginInfoValidation
            // 
            this.EP_UserLoginInfoValidation.BlinkRate = 1;
            this.EP_UserLoginInfoValidation.ContainerControl = this;
            this.EP_UserLoginInfoValidation.Icon = ((System.Drawing.Icon)(resources.GetObject("EP_UserLoginInfoValidation.Icon")));
            // 
            // UC_Add_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TC_UserInfo);
            this.Name = "UC_Add_UpdateUser";
            this.Size = new System.Drawing.Size(713, 483);
            this.TC_UserInfo.ResumeLayout(false);
            this.TP_PersonalInfo.ResumeLayout(false);
            this.TP_LoginInfo.ResumeLayout(false);
            this.TP_LoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EP_UserLoginInfoValidation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_NextToLoginInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider EP_UserLoginInfoValidation;
        public UC_Person_Selector Person_Selector;
        public System.Windows.Forms.TabControl TC_UserInfo;
        public System.Windows.Forms.CheckBox CB_IsActive;
        public System.Windows.Forms.TextBox TB_ConfirmPassword;
        public System.Windows.Forms.TextBox TB_Password;
        public System.Windows.Forms.Label LB_UserID;
        public System.Windows.Forms.TextBox TB_UserName;
        public System.Windows.Forms.Button BTN_Save;
        public System.Windows.Forms.TabPage TP_PersonalInfo;
        public System.Windows.Forms.TabPage TP_LoginInfo;
    }
}
