namespace DVLD.Sections.Users
{
    partial class ChangeUserPassword
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
            this.Change_UserPassword = new DVLD.User_Controls.Users_Section_Controls.UC_Change_UserPassword();
            this.SuspendLayout();
            // 
            // Change_UserPassword
            // 
            this.Change_UserPassword.BackColor = System.Drawing.SystemColors.Window;
            this.Change_UserPassword.Location = new System.Drawing.Point(69, 1);
            this.Change_UserPassword.Name = "Change_UserPassword";
            this.Change_UserPassword.Size = new System.Drawing.Size(651, 487);
            this.Change_UserPassword.TabIndex = 0;
            // 
            // ChangeUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.Change_UserPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change User Password";
            this.Load += new System.EventHandler(this.ChangeUserPassword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User_Controls.Users_Section_Controls.UC_Change_UserPassword Change_UserPassword;
    }
}