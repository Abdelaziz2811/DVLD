namespace DVLD.User_Controls.Users_Section_Controls
{
    partial class UC_Change_UserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Change_UserPassword));
            this.userInfo1 = new DVLD.User_Controls.Users_Section_Controls.UC_UserInfo();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_CurrentPassword = new System.Windows.Forms.TextBox();
            this.TB_NewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.EP_PasswordValidation = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EP_PasswordValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.SystemColors.Window;
            this.userInfo1.Location = new System.Drawing.Point(0, 0);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(651, 386);
            this.userInfo1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Current Password :";
            // 
            // TB_CurrentPassword
            // 
            this.TB_CurrentPassword.Location = new System.Drawing.Point(220, 405);
            this.TB_CurrentPassword.Name = "TB_CurrentPassword";
            this.TB_CurrentPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_CurrentPassword.TabIndex = 27;
            // 
            // TB_NewPassword
            // 
            this.TB_NewPassword.Location = new System.Drawing.Point(509, 406);
            this.TB_NewPassword.Name = "TB_NewPassword";
            this.TB_NewPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_NewPassword.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "New Password :";
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(220, 442);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.TB_ConfirmPassword.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Confirm Password :";
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.BTN_Save.Location = new System.Drawing.Point(477, 443);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(132, 30);
            this.BTN_Save.TabIndex = 32;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // EP_PasswordValidation
            // 
            this.EP_PasswordValidation.BlinkRate = 1;
            this.EP_PasswordValidation.ContainerControl = this;
            this.EP_PasswordValidation.Icon = ((System.Drawing.Icon)(resources.GetObject("EP_PasswordValidation.Icon")));
            // 
            // Change_UserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.TB_ConfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_CurrentPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userInfo1);
            this.Name = "Change_UserPassword";
            this.Size = new System.Drawing.Size(651, 487);
            ((System.ComponentModel.ISupportInitialize)(this.EP_PasswordValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_UserInfo userInfo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_CurrentPassword;
        private System.Windows.Forms.TextBox TB_NewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.ErrorProvider EP_PasswordValidation;
    }
}
