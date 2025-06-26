namespace DVLD
{
    partial class Add_UpdateUser
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
            this.LB_Opration = new System.Windows.Forms.Label();
            this.UC_Update_AddUser = new DVLD.User_Controls.Users_Section_Controls.UC_Add_UpdateUser();
            this.SuspendLayout();
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(340, 7);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(121, 19);
            this.LB_Opration.TabIndex = 22;
            this.LB_Opration.Text = "Add User Info";
            // 
            // Update_AddUser
            // 
            this.UC_Update_AddUser.Location = new System.Drawing.Point(44, 49);
            this.UC_Update_AddUser.Name = "Update_AddUser";
            this.UC_Update_AddUser.Size = new System.Drawing.Size(713, 483);
            this.UC_Update_AddUser.TabIndex = 23;
            // 
            // Add_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 544);
            this.Controls.Add(this.UC_Update_AddUser);
            this.Controls.Add(this.LB_Opration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_UpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update/Add User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_UpdateUser_FormClosing);
            this.Load += new System.EventHandler(this.Update_AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Opration;
        private User_Controls.Users_Section_Controls.UC_Add_UpdateUser UC_Update_AddUser;
    }
}