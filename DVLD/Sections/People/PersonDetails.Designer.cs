namespace DVLD
{
    partial class PersonDetails
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
            this.UC_Person_Info = new DVLD.User_Controls.UC_Person_Info();
            this.SuspendLayout();
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(343, -2);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(127, 19);
            this.LB_Opration.TabIndex = 23;
            this.LB_Opration.Text = "Person Details";
            // 
            // UC_Person_Info
            // 
            this.UC_Person_Info.BackColor = System.Drawing.SystemColors.Window;
            this.UC_Person_Info.Location = new System.Drawing.Point(13, 15);
            this.UC_Person_Info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UC_Person_Info.Name = "UC_Person_Info";
            this.UC_Person_Info.Size = new System.Drawing.Size(763, 343);
            this.UC_Person_Info.TabIndex = 0;
            // 
            // PersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(788, 367);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.UC_Person_Info);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PersonDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonDetails_FormClosing);
            this.Load += new System.EventHandler(this.PersonDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.UC_Person_Info UC_Person_Info;
        private System.Windows.Forms.Label LB_Opration;
    }
}