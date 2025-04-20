namespace DVLD
{
    partial class AddUpdatePerson
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
            this.LB_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_UpdatePerson = new DVLD.User_Controls.UC_Add_UpdatePerson();
            this.SuspendLayout();
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(318, 9);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(140, 19);
            this.LB_Opration.TabIndex = 21;
            this.LB_Opration.Text = "Add Person Info";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(162, 42);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(18, 19);
            this.LB_ID.TabIndex = 24;
            this.LB_ID.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Peron ID :";
            // 
            // UC_Add_UpdatePerson
            // 
            this.Add_UpdatePerson.BackColor = System.Drawing.SystemColors.Window;
            this.Add_UpdatePerson.Location = new System.Drawing.Point(28, 55);
            this.Add_UpdatePerson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Add_UpdatePerson.Name = "UC_Add_UpdatePerson";
            this.Add_UpdatePerson.Size = new System.Drawing.Size(747, 336);
            this.Add_UpdatePerson.TabIndex = 0;
            // 
            // AddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(812, 403);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.Add_UpdatePerson);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdatePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Person";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUpdatePerson_FormClosing);
            this.Load += new System.EventHandler(this.Update_AddPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.UC_Add_UpdatePerson Add_UpdatePerson;
        public System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LB_Opration;
    }
}