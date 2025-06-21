namespace DVLD.User_Controls
{
    partial class UC_Person_Selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Person_Selector));
            this.GB_Search = new System.Windows.Forms.GroupBox();
            this.BTN_FindPerson = new System.Windows.Forms.Button();
            this.BTN_AddPerson = new System.Windows.Forms.Button();
            this.TXTB_SearchBox = new System.Windows.Forms.TextBox();
            this.CB_FindBy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Person_Info = new DVLD.User_Controls.UC_Person_Info();
            this.GB_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Search
            // 
            this.GB_Search.Controls.Add(this.BTN_FindPerson);
            this.GB_Search.Controls.Add(this.BTN_AddPerson);
            this.GB_Search.Controls.Add(this.TXTB_SearchBox);
            this.GB_Search.Controls.Add(this.CB_FindBy);
            this.GB_Search.Controls.Add(this.label4);
            this.GB_Search.Location = new System.Drawing.Point(3, 0);
            this.GB_Search.Name = "GB_Search";
            this.GB_Search.Size = new System.Drawing.Size(645, 81);
            this.GB_Search.TabIndex = 1;
            this.GB_Search.TabStop = false;
            this.GB_Search.Text = "Search";
            // 
            // BTN_FindPerson
            // 
            this.BTN_FindPerson.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_FindPerson.BackgroundImage = global::DVLD.Properties.Resources.Find_Person;
            this.BTN_FindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_FindPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_FindPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_FindPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_FindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FindPerson.Location = new System.Drawing.Point(464, 22);
            this.BTN_FindPerson.Name = "BTN_FindPerson";
            this.BTN_FindPerson.Size = new System.Drawing.Size(49, 38);
            this.BTN_FindPerson.TabIndex = 28;
            this.BTN_FindPerson.UseVisualStyleBackColor = false;
            this.BTN_FindPerson.Click += new System.EventHandler(this.BTN_FindPerson_Click);
            // 
            // BTN_AddPerson
            // 
            this.BTN_AddPerson.BackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_AddPerson.BackgroundImage")));
            this.BTN_AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_AddPerson.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_AddPerson.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_AddPerson.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.BTN_AddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddPerson.Location = new System.Drawing.Point(557, 22);
            this.BTN_AddPerson.Name = "BTN_AddPerson";
            this.BTN_AddPerson.Size = new System.Drawing.Size(49, 38);
            this.BTN_AddPerson.TabIndex = 27;
            this.BTN_AddPerson.UseVisualStyleBackColor = false;
            this.BTN_AddPerson.Click += new System.EventHandler(this.BTN_AddPerson_Click);
            // 
            // TXTB_SearchBox
            // 
            this.TXTB_SearchBox.Location = new System.Drawing.Point(290, 31);
            this.TXTB_SearchBox.Name = "TXTB_SearchBox";
            this.TXTB_SearchBox.Size = new System.Drawing.Size(126, 20);
            this.TXTB_SearchBox.TabIndex = 26;
            // 
            // CB_FindBy
            // 
            this.CB_FindBy.FormattingEnabled = true;
            this.CB_FindBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo."});
            this.CB_FindBy.Location = new System.Drawing.Point(133, 31);
            this.CB_FindBy.Name = "CB_FindBy";
            this.CB_FindBy.Size = new System.Drawing.Size(121, 21);
            this.CB_FindBy.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Find By :";
            // 
            // Person_Info
            // 
            this.Person_Info.BackColor = System.Drawing.SystemColors.Window;
            this.Person_Info.Location = new System.Drawing.Point(3, 86);
            this.Person_Info.Name = "Person_Info";
            this.Person_Info.Size = new System.Drawing.Size(658, 297);
            this.Person_Info.TabIndex = 0;
            // 
            // UC_Person_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.GB_Search);
            this.Controls.Add(this.Person_Info);
            this.Name = "UC_Person_Selector";
            this.Size = new System.Drawing.Size(660, 382);
            this.Load += new System.EventHandler(this.UC_Person_Selector_Load);
            this.GB_Search.ResumeLayout(false);
            this.GB_Search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.GroupBox GB_Search;
        public System.Windows.Forms.Button BTN_AddPerson;
        public System.Windows.Forms.TextBox TXTB_SearchBox;
        public System.Windows.Forms.ComboBox CB_FindBy;
        public System.Windows.Forms.Button BTN_FindPerson;
        public UC_Person_Info Person_Info;
    }
}
