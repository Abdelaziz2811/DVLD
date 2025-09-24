namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments
{
    partial class TakeTest
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
            this.RB_Pass = new System.Windows.Forms.RadioButton();
            this.RB_Fail = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.UC_TestDetails = new DVLD.User_Controls.Applications_Section.Tests.UC_TestDetails();
            this.SuspendLayout();
            // 
            // RB_Pass
            // 
            this.RB_Pass.AutoSize = true;
            this.RB_Pass.Checked = true;
            this.RB_Pass.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Pass.Location = new System.Drawing.Point(184, 323);
            this.RB_Pass.Name = "RB_Pass";
            this.RB_Pass.Size = new System.Drawing.Size(61, 22);
            this.RB_Pass.TabIndex = 1;
            this.RB_Pass.TabStop = true;
            this.RB_Pass.Text = "Pass";
            this.RB_Pass.UseVisualStyleBackColor = true;
            // 
            // RB_Fail
            // 
            this.RB_Fail.AutoSize = true;
            this.RB_Fail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Fail.Location = new System.Drawing.Point(297, 323);
            this.RB_Fail.Name = "RB_Fail";
            this.RB_Fail.Size = new System.Drawing.Size(54, 22);
            this.RB_Fail.TabIndex = 2;
            this.RB_Fail.Text = "Fail";
            this.RB_Fail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Test Result :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Notes :";
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Save.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Location = new System.Drawing.Point(290, 453);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(117, 33);
            this.BTN_Save.TabIndex = 51;
            this.BTN_Save.Tag = " ";
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // LB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(188, 368);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "LB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(472, 61);
            this.TB_Notes.TabIndex = 52;
            // 
            // UC_TestDetails
            // 
            this.UC_TestDetails.Location = new System.Drawing.Point(5, -2);
            this.UC_TestDetails.Name = "UC_TestDetails";
            this.UC_TestDetails.Size = new System.Drawing.Size(687, 315);
            this.UC_TestDetails.TabIndex = 0;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(696, 506);
            this.Controls.Add(this.TB_Notes);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RB_Fail);
            this.Controls.Add(this.RB_Pass);
            this.Controls.Add(this.UC_TestDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakeTest";
            this.Load += new System.EventHandler(this.TakeTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User_Controls.Applications_Section.Tests.UC_TestDetails UC_TestDetails;
        private System.Windows.Forms.RadioButton RB_Pass;
        private System.Windows.Forms.RadioButton RB_Fail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TB_Notes;
    }
}