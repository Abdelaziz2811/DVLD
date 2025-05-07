namespace DVLD
{
    partial class ManagePeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople));
            this.DGV_People = new System.Windows.Forms.DataGridView();
            this.CMS_PeopleActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_AddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UpdatePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Seperator = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_FilterBy = new System.Windows.Forms.ComboBox();
            this.LB_Opration = new System.Windows.Forms.Label();
            this.LB_RecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_FilterationValue = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_AddPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).BeginInit();
            this.CMS_PeopleActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_People
            // 
            this.DGV_People.AllowUserToAddRows = false;
            this.DGV_People.AllowUserToDeleteRows = false;
            this.DGV_People.AllowUserToOrderColumns = true;
            this.DGV_People.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_People.ContextMenuStrip = this.CMS_PeopleActions;
            this.DGV_People.Location = new System.Drawing.Point(12, 183);
            this.DGV_People.Name = "DGV_People";
            this.DGV_People.ReadOnly = true;
            this.DGV_People.Size = new System.Drawing.Size(963, 349);
            this.DGV_People.TabIndex = 0;
            // 
            // CMS_PeopleActions
            // 
            this.CMS_PeopleActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ShowDetails,
            this.TSMI_AddPerson,
            this.TSMI_UpdatePerson,
            this.TSMI_DeletePerson,
            this.TSMI_Refresh,
            this.TSMI_Seperator,
            this.TSMI_SendEmail,
            this.TSMI_PhoneCall});
            this.CMS_PeopleActions.Name = "CMS_PeopleHandle";
            this.CMS_PeopleActions.Size = new System.Drawing.Size(152, 164);
            // 
            // TSMI_ShowDetails
            // 
            this.TSMI_ShowDetails.Name = "TSMI_ShowDetails";
            this.TSMI_ShowDetails.Size = new System.Drawing.Size(151, 22);
            this.TSMI_ShowDetails.Text = "Show Details";
            this.TSMI_ShowDetails.Click += new System.EventHandler(this.TSMI_ShowDetails_Click);
            // 
            // TSMI_AddPerson
            // 
            this.TSMI_AddPerson.Name = "TSMI_AddPerson";
            this.TSMI_AddPerson.Size = new System.Drawing.Size(151, 22);
            this.TSMI_AddPerson.Text = "Add Person";
            this.TSMI_AddPerson.Click += new System.EventHandler(this.TSMI_AddPerson_Click);
            // 
            // TSMI_UpdatePerson
            // 
            this.TSMI_UpdatePerson.Name = "TSMI_UpdatePerson";
            this.TSMI_UpdatePerson.Size = new System.Drawing.Size(151, 22);
            this.TSMI_UpdatePerson.Text = "Update Person";
            this.TSMI_UpdatePerson.Click += new System.EventHandler(this.TSMI_UpdatePerson_Click);
            // 
            // TSMI_DeletePerson
            // 
            this.TSMI_DeletePerson.Name = "TSMI_DeletePerson";
            this.TSMI_DeletePerson.Size = new System.Drawing.Size(151, 22);
            this.TSMI_DeletePerson.Text = "Delete Person";
            this.TSMI_DeletePerson.Click += new System.EventHandler(this.TSMI_DeletePerson_Click);
            // 
            // TSMI_Refresh
            // 
            this.TSMI_Refresh.Name = "TSMI_Refresh";
            this.TSMI_Refresh.Size = new System.Drawing.Size(151, 22);
            this.TSMI_Refresh.Text = "Refresh";
            this.TSMI_Refresh.Click += new System.EventHandler(this.TSMI_Refresh_Click);
            // 
            // TSMI_Seperator
            // 
            this.TSMI_Seperator.Name = "TSMI_Seperator";
            this.TSMI_Seperator.Size = new System.Drawing.Size(148, 6);
            // 
            // TSMI_SendEmail
            // 
            this.TSMI_SendEmail.Name = "TSMI_SendEmail";
            this.TSMI_SendEmail.Size = new System.Drawing.Size(151, 22);
            this.TSMI_SendEmail.Text = "Send Email";
            this.TSMI_SendEmail.Click += new System.EventHandler(this.TSMI_SendEmail_Click);
            // 
            // TSMI_PhoneCall
            // 
            this.TSMI_PhoneCall.Name = "TSMI_PhoneCall";
            this.TSMI_PhoneCall.Size = new System.Drawing.Size(151, 22);
            this.TSMI_PhoneCall.Text = "Phone Call";
            this.TSMI_PhoneCall.Click += new System.EventHandler(this.TSMI_PhoneCall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By :";
            // 
            // CB_FilterBy
            // 
            this.CB_FilterBy.FormattingEnabled = true;
            this.CB_FilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No.",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Nationality",
            "Gender",
            "Phone",
            "Email",
            "Address"});
            this.CB_FilterBy.Location = new System.Drawing.Point(84, 154);
            this.CB_FilterBy.Name = "CB_FilterBy";
            this.CB_FilterBy.Size = new System.Drawing.Size(124, 21);
            this.CB_FilterBy.TabIndex = 2;
            this.CB_FilterBy.SelectedIndexChanged += new System.EventHandler(this.CB_FilterBy_SelectedIndexChanged);
            // 
            // LB_Opration
            // 
            this.LB_Opration.AutoSize = true;
            this.LB_Opration.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Opration.Location = new System.Drawing.Point(418, 0);
            this.LB_Opration.Name = "LB_Opration";
            this.LB_Opration.Size = new System.Drawing.Size(154, 23);
            this.LB_Opration.TabIndex = 22;
            this.LB_Opration.Text = "Manage People";
            // 
            // LB_RecordsCount
            // 
            this.LB_RecordsCount.AutoSize = true;
            this.LB_RecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RecordsCount.Location = new System.Drawing.Point(533, 153);
            this.LB_RecordsCount.Name = "LB_RecordsCount";
            this.LB_RecordsCount.Size = new System.Drawing.Size(23, 19);
            this.LB_RecordsCount.TabIndex = 32;
            this.LB_RecordsCount.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "# Records :";
            // 
            // TB_FilterationValue
            // 
            this.TB_FilterationValue.Location = new System.Drawing.Point(223, 155);
            this.TB_FilterationValue.Name = "TB_FilterationValue";
            this.TB_FilterationValue.Size = new System.Drawing.Size(100, 20);
            this.TB_FilterationValue.TabIndex = 33;
            this.TB_FilterationValue.Validated += new System.EventHandler(this.TB_FilterationValue_Validated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Properties.Resources.People;
            this.pictureBox1.Location = new System.Drawing.Point(408, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_AddPerson
            // 
            this.BTN_AddPerson.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AddPerson.BackgroundImage")));
            this.BTN_AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_AddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_AddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddPerson.Location = new System.Drawing.Point(926, 139);
            this.BTN_AddPerson.Name = "BTN_AddPerson";
            this.BTN_AddPerson.Size = new System.Drawing.Size(49, 38);
            this.BTN_AddPerson.TabIndex = 3;
            this.BTN_AddPerson.UseVisualStyleBackColor = false;
            this.BTN_AddPerson.Click += new System.EventHandler(this.BTN_AddPerson_Click);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 544);
            this.Controls.Add(this.TB_FilterationValue);
            this.Controls.Add(this.LB_RecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Opration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_AddPerson);
            this.Controls.Add(this.CB_FilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_People);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_People)).EndInit();
            this.CMS_PeopleActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_People;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_FilterBy;
        private System.Windows.Forms.Button BTN_AddPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_PeopleActions;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem TSMI_AddPerson;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UpdatePerson;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DeletePerson;
        private System.Windows.Forms.ToolStripSeparator TSMI_Seperator;
        private System.Windows.Forms.ToolStripMenuItem TSMI_SendEmail;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PhoneCall;
        private System.Windows.Forms.Label LB_Opration;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Refresh;
        private System.Windows.Forms.Label LB_RecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_FilterationValue;
    }
}