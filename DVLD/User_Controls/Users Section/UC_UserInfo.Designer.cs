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
            this.Person_Info = new DVLD.User_Controls.UC_Person_Info();
            this.GB_LogInfo = new System.Windows.Forms.GroupBox();
            this.LB_IsActive = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GB_LogInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Person_Info
            // 
            this.Person_Info.BackColor = System.Drawing.SystemColors.Window;
            this.Person_Info.Location = new System.Drawing.Point(0, 0);
            this.Person_Info.Name = "Person_Info";
            this.Person_Info.Size = new System.Drawing.Size(651, 297);
            this.Person_Info.TabIndex = 0;
            // 
            // GB_LogInfo
            // 
            this.GB_LogInfo.Controls.Add(this.LB_IsActive);
            this.GB_LogInfo.Controls.Add(this.label6);
            this.GB_LogInfo.Controls.Add(this.LB_UserName);
            this.GB_LogInfo.Controls.Add(this.label3);
            this.GB_LogInfo.Controls.Add(this.LB_UserID);
            this.GB_LogInfo.Controls.Add(this.label4);
            this.GB_LogInfo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.GB_LogInfo.Location = new System.Drawing.Point(3, 303);
            this.GB_LogInfo.Name = "GB_LogInfo";
            this.GB_LogInfo.Size = new System.Drawing.Size(645, 80);
            this.GB_LogInfo.TabIndex = 1;
            this.GB_LogInfo.TabStop = false;
            this.GB_LogInfo.Text = "Login Information";
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
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LB_UserName.Location = new System.Drawing.Point(325, 36);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(21, 19);
            this.LB_UserName.TabIndex = 28;
            this.LB_UserName.Text = "--";
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
            // UC_UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.GB_LogInfo);
            this.Controls.Add(this.Person_Info);
            this.Name = "UC_UserInfo";
            this.Size = new System.Drawing.Size(651, 386);
            this.GB_LogInfo.ResumeLayout(false);
            this.GB_LogInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_LogInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public UC_Person_Info Person_Info;
        public System.Windows.Forms.Label LB_IsActive;
        public System.Windows.Forms.Label LB_UserName;
        public System.Windows.Forms.Label LB_UserID;
    }
}
