namespace DVLD.Sections.Tests
{
    partial class ManageTestTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_TestTypes = new System.Windows.Forms.DataGridView();
            this.CMS_TestTypeActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_UpdateTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestTypes)).BeginInit();
            this.CMS_TestTypeActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TestTypes
            // 
            this.DGV_TestTypes.AllowUserToAddRows = false;
            this.DGV_TestTypes.AllowUserToDeleteRows = false;
            this.DGV_TestTypes.AllowUserToOrderColumns = true;
            this.DGV_TestTypes.AllowUserToResizeRows = false;
            this.DGV_TestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_TestTypes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_TestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TestTypes.ContextMenuStrip = this.CMS_TestTypeActions;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_TestTypes.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TestTypes.Location = new System.Drawing.Point(12, 202);
            this.DGV_TestTypes.Name = "DGV_TestTypes";
            this.DGV_TestTypes.ReadOnly = true;
            this.DGV_TestTypes.Size = new System.Drawing.Size(776, 236);
            this.DGV_TestTypes.TabIndex = 42;
            // 
            // CMS_TestTypeActions
            // 
            this.CMS_TestTypeActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_UpdateTestType});
            this.CMS_TestTypeActions.Name = "CMS_PeopleHandle";
            this.CMS_TestTypeActions.Size = new System.Drawing.Size(163, 26);
            // 
            // TSMI_UpdateTestType
            // 
            this.TSMI_UpdateTestType.Name = "TSMI_UpdateTestType";
            this.TSMI_UpdateTestType.Size = new System.Drawing.Size(162, 22);
            this.TSMI_UpdateTestType.Text = "Update Test Type";
            this.TSMI_UpdateTestType.Click += new System.EventHandler(this.TSMI_UpdateTestType_Click);
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(440, 168);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 41;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "# Records :";
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(306, -2);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(193, 23);
            this.LB_Opration.TabIndex = 39;
            this.LB_Opration.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.checklist;
            this.pictureBox1.Location = new System.Drawing.Point(315, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // ManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_TestTypes);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageTestTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Tests Types";
            this.Load += new System.EventHandler(this.ManageTestsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TestTypes)).EndInit();
            this.CMS_TestTypeActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TestTypes;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_TestTypeActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdateTestType;
    }
}