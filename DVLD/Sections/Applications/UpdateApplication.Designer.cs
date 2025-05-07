namespace DVLD.Sections.Applications
{
    partial class UpdateApplication
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
            this.LB_ApplicationID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_ApplicationTitle = new System.Windows.Forms.TextBox();
            this.NUD_ApplicationFees = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ApplicationFees)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_ApplicationID
            // 
            this.LB_ApplicationID.AutoSize = true;
            this.LB_ApplicationID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationID.Location = new System.Drawing.Point(154, 53);
            this.LB_ApplicationID.Name = "LB_ApplicationID";
            this.LB_ApplicationID.Size = new System.Drawing.Size(33, 19);
            this.LB_ApplicationID.TabIndex = 6;
            this.LB_ApplicationID.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Application ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Application Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application Fees :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_ApplicationTitle
            // 
            this.TB_ApplicationTitle.Location = new System.Drawing.Point(173, 101);
            this.TB_ApplicationTitle.Name = "TB_ApplicationTitle";
            this.TB_ApplicationTitle.Size = new System.Drawing.Size(282, 20);
            this.TB_ApplicationTitle.TabIndex = 10;
            // 
            // NUD_ApplicationFees
            // 
            this.NUD_ApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_ApplicationFees.Location = new System.Drawing.Point(173, 146);
            this.NUD_ApplicationFees.Name = "NUD_ApplicationFees";
            this.NUD_ApplicationFees.Size = new System.Drawing.Size(282, 22);
            this.NUD_ApplicationFees.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Update Application";
            // 
            // BTN_Save
            // 
            this.BTN_Save.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.BTN_Save.Location = new System.Drawing.Point(168, 195);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(132, 30);
            this.BTN_Save.TabIndex = 15;
            this.BTN_Save.Tag = "";
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = false;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // UpdateApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(468, 252);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NUD_ApplicationFees);
            this.Controls.Add(this.TB_ApplicationTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_ApplicationID);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Application";
            this.Load += new System.EventHandler(this.UpdateApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ApplicationFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LB_ApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TB_ApplicationTitle;
        private System.Windows.Forms.NumericUpDown NUD_ApplicationFees;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button BTN_Save;
    }
}