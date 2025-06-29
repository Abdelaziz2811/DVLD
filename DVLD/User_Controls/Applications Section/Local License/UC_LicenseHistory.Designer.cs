namespace DVLD.User_Controls.Applications_Section.Local_License
{
    partial class UC_LicenseHistory
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
            this.TB_LicenseType = new System.Windows.Forms.TabControl();
            this.TP_Local = new System.Windows.Forms.TabPage();
            this.DGV_LocalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.TP_International = new System.Windows.Forms.TabPage();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_InternationalLicenseHistory = new System.Windows.Forms.DataGridView();
            this.TB_LicenseType.SuspendLayout();
            this.TP_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenseHistory)).BeginInit();
            this.TP_International.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_LicenseType
            // 
            this.TB_LicenseType.Controls.Add(this.TP_Local);
            this.TB_LicenseType.Controls.Add(this.TP_International);
            this.TB_LicenseType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LicenseType.Location = new System.Drawing.Point(3, 3);
            this.TB_LicenseType.Name = "TB_LicenseType";
            this.TB_LicenseType.SelectedIndex = 0;
            this.TB_LicenseType.Size = new System.Drawing.Size(770, 239);
            this.TB_LicenseType.TabIndex = 0;
            this.TB_LicenseType.SelectedIndexChanged += new System.EventHandler(this.TB_LicenseType_SelectedIndexChanged);
            // 
            // TP_Local
            // 
            this.TP_Local.Controls.Add(this.DGV_LocalLicenseHistory);
            this.TP_Local.Location = new System.Drawing.Point(4, 25);
            this.TP_Local.Name = "TP_Local";
            this.TP_Local.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Local.Size = new System.Drawing.Size(762, 210);
            this.TP_Local.TabIndex = 0;
            this.TP_Local.Text = "Local";
            this.TP_Local.UseVisualStyleBackColor = true;
            // 
            // DGV_LocalLicenseHistory
            // 
            this.DGV_LocalLicenseHistory.AllowUserToAddRows = false;
            this.DGV_LocalLicenseHistory.AllowUserToDeleteRows = false;
            this.DGV_LocalLicenseHistory.AllowUserToOrderColumns = true;
            this.DGV_LocalLicenseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LocalLicenseHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_LocalLicenseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_LocalLicenseHistory.Location = new System.Drawing.Point(3, 3);
            this.DGV_LocalLicenseHistory.Name = "DGV_LocalLicenseHistory";
            this.DGV_LocalLicenseHistory.ReadOnly = true;
            this.DGV_LocalLicenseHistory.Size = new System.Drawing.Size(756, 204);
            this.DGV_LocalLicenseHistory.TabIndex = 0;
            // 
            // TP_International
            // 
            this.TP_International.Controls.Add(this.DGV_InternationalLicenseHistory);
            this.TP_International.Location = new System.Drawing.Point(4, 25);
            this.TP_International.Name = "TP_International";
            this.TP_International.Padding = new System.Windows.Forms.Padding(3);
            this.TP_International.Size = new System.Drawing.Size(762, 210);
            this.TP_International.TabIndex = 1;
            this.TP_International.Text = "International";
            this.TP_International.UseVisualStyleBackColor = true;
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(451, 5);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 49;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "# Records :";
            // 
            // DGV_InternationalLicenseHistory
            // 
            this.DGV_InternationalLicenseHistory.AllowUserToAddRows = false;
            this.DGV_InternationalLicenseHistory.AllowUserToDeleteRows = false;
            this.DGV_InternationalLicenseHistory.AllowUserToOrderColumns = true;
            this.DGV_InternationalLicenseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InternationalLicenseHistory.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_InternationalLicenseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_InternationalLicenseHistory.Location = new System.Drawing.Point(3, 3);
            this.DGV_InternationalLicenseHistory.Name = "DGV_InternationalLicenseHistory";
            this.DGV_InternationalLicenseHistory.ReadOnly = true;
            this.DGV_InternationalLicenseHistory.Size = new System.Drawing.Size(756, 204);
            this.DGV_InternationalLicenseHistory.TabIndex = 1;
            // 
            // UC_LicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_LicenseType);
            this.Name = "UC_LicenseHistory";
            this.Size = new System.Drawing.Size(776, 246);
            this.TB_LicenseType.ResumeLayout(false);
            this.TP_Local.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenseHistory)).EndInit();
            this.TP_International.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage TP_Local;
        private System.Windows.Forms.TabPage TP_International;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TabControl TB_LicenseType;
        public System.Windows.Forms.DataGridView DGV_LocalLicenseHistory;
        public System.Windows.Forms.Label LB_RecordsCount;
        public System.Windows.Forms.DataGridView DGV_InternationalLicenseHistory;
    }
}
