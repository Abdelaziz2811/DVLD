namespace DVLD.Sections.Applications
{
    partial class ManageApplicationTypes
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
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.DGV_ApplicationTypes = new System.Windows.Forms.DataGridView();
            this.CMS_ApplicationTypeActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_UpdateApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationTypes)).BeginInit();
            this.CMS_ApplicationTypeActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(440, 160);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 36;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "# Records :";
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(270, -4);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(260, 23);
            this.LB_Opration.TabIndex = 34;
            this.LB_Opration.Text = "Manage Application Types";
            // 
            // DGV_ApplicationTypes
            // 
            this.DGV_ApplicationTypes.AllowUserToAddRows = false;
            this.DGV_ApplicationTypes.AllowUserToDeleteRows = false;
            this.DGV_ApplicationTypes.AllowUserToOrderColumns = true;
            this.DGV_ApplicationTypes.AllowUserToResizeRows = false;
            this.DGV_ApplicationTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ApplicationTypes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_ApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ApplicationTypes.ContextMenuStrip = this.CMS_ApplicationTypeActions;
            this.DGV_ApplicationTypes.Location = new System.Drawing.Point(12, 194);
            this.DGV_ApplicationTypes.Name = "DGV_ApplicationTypes";
            this.DGV_ApplicationTypes.ReadOnly = true;
            this.DGV_ApplicationTypes.Size = new System.Drawing.Size(776, 244);
            this.DGV_ApplicationTypes.TabIndex = 37;
            // 
            // CMS_ApplicationTypeActions
            // 
            this.CMS_ApplicationTypeActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateApplicationType});
            this.CMS_ApplicationTypeActions.Name = "CMS_PeopleHandle";
            this.CMS_ApplicationTypeActions.Size = new System.Drawing.Size(204, 26);
            // 
            // TSMI_UpdateApplicationType
            // 
            this.TSMI_UpdateApplicationType.Name = "TSMI_UpdateApplicationType";
            this.TSMI_UpdateApplicationType.Size = new System.Drawing.Size(203, 22);
            this.TSMI_UpdateApplicationType.Text = "Update Application Type";
            this.TSMI_UpdateApplicationType.Click += new System.EventHandler(this.TSMI_UpdateApplicationType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Application;
            this.pictureBox1.Location = new System.Drawing.Point(315, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ManageApplicationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_ApplicationTypes);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageApplicationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Application Types";
            this.Load += new System.EventHandler(this.ManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationTypes)).EndInit();
            this.CMS_ApplicationTypeActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGV_ApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip CMS_ApplicationTypeActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateApplicationType;
    }
}