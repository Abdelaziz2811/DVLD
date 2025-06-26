namespace DVLD.Sections.Drivers
{
    partial class Drivers
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
            this.TB_FilterationValue = new System.Windows.Forms.TextBox();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_FilterBy = new System.Windows.Forms.ComboBox();
            this.DGV_Drivers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_FilterationValue
            // 
            this.TB_FilterationValue.Location = new System.Drawing.Point(223, 154);
            this.TB_FilterationValue.Name = "TB_FilterationValue";
            this.TB_FilterationValue.Size = new System.Drawing.Size(100, 20);
            this.TB_FilterationValue.TabIndex = 40;
            this.TB_FilterationValue.TextChanged += new System.EventHandler(this.TB_FilterationValue_TextChanged);
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(533, 152);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 39;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "# Records :";
            // 
            // CB_FilterBy
            // 
            this.CB_FilterBy.FormattingEnabled = true;
            this.CB_FilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "Driver ID",
            "National No.",
            "Full Name"});
            this.CB_FilterBy.Location = new System.Drawing.Point(84, 153);
            this.CB_FilterBy.Name = "CB_FilterBy";
            this.CB_FilterBy.Size = new System.Drawing.Size(124, 21);
            this.CB_FilterBy.TabIndex = 35;
            this.CB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FilterBy_SelectedIndexChanged);
            // 
            // DGV_Drivers
            // 
            this.DGV_Drivers.AllowUserToAddRows = false;
            this.DGV_Drivers.AllowUserToDeleteRows = false;
            this.DGV_Drivers.AllowUserToOrderColumns = true;
            this.DGV_Drivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Drivers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_Drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Drivers.Location = new System.Drawing.Point(12, 182);
            this.DGV_Drivers.Name = "DGV_Drivers";
            this.DGV_Drivers.ReadOnly = true;
            this.DGV_Drivers.Size = new System.Drawing.Size(963, 349);
            this.DGV_Drivers.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.Drivers;
            this.pictureBox1.Location = new System.Drawing.Point(408, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(454, -5);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(78, 23);
            this.LB_Opration.TabIndex = 41;
            this.LB_Opration.Text = "Drivers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filter By :";
            // 
            // Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.TB_FilterationValue);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CB_FilterBy);
            this.Controls.Add(this.DGV_Drivers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Drivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drivers";
            this.Load += new System.EventHandler(this.Drivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_FilterationValue;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CB_FilterBy;
        private System.Windows.Forms.DataGridView DGV_Drivers;
        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.Label label1;
    }
}