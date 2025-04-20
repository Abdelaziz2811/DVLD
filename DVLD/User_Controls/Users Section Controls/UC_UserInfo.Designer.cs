namespace DVLD.User_Controls.Users_Section_Controls
{
    partial class UC_UserInfo
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
            this.person_Info1 = new DVLD.User_Controls.UC_Person_Info();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.LB_Username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_IsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // person_Info1
            // 
            this.person_Info1.BackColor = System.Drawing.SystemColors.Window;
            this.person_Info1.Location = new System.Drawing.Point(0, 0);
            this.person_Info1.Name = "person_Info1";
            this.person_Info1.Size = new System.Drawing.Size(651, 297);
            this.person_Info1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LB_IsActive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LB_Username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LB_UserID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(3, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "User ID :";
            // 
            // LB_UserID
            // 
            this.LB_UserID.AutoSize = true;
            this.LB_UserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserID.Location = new System.Drawing.Point(118, 36);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(21, 19);
            this.LB_UserID.TabIndex = 26;
            this.LB_UserID.Text = "--";
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_Username.Location = new System.Drawing.Point(325, 36);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(21, 19);
            this.LB_Username.TabIndex = 28;
            this.LB_Username.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username :";
            // 
            // LB_IsActive
            // 
            this.LB_IsActive.AutoSize = true;
            this.LB_IsActive.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_IsActive.Location = new System.Drawing.Point(560, 36);
            this.LB_IsActive.Name = "LB_IsActive";
            this.LB_IsActive.Size = new System.Drawing.Size(21, 19);
            this.LB_IsActive.TabIndex = 30;
            this.LB_IsActive.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "IsActive :";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.person_Info1);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(651, 386);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Person_Info person_Info1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LB_IsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_UserID;
        private System.Windows.Forms.Label label4;
    }
}
