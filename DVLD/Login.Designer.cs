namespace DVLD
{
    partial class Login
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
            this.BTN_Login = new System.Windows.Forms.Button();
            this.TXTB_Username = new System.Windows.Forms.TextBox();
            this.TXTB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CHB_Rememberme = new System.Windows.Forms.CheckBox();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTN_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTN_Login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BTN_Login.Location = new System.Drawing.Point(529, 278);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(156, 43);
            this.BTN_Login.TabIndex = 1;
            this.BTN_Login.Text = "login";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // TXTB_Username
            // 
            this.TXTB_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_Username.Location = new System.Drawing.Point(591, 154);
            this.TXTB_Username.Name = "TXTB_Username";
            this.TXTB_Username.Size = new System.Drawing.Size(136, 27);
            this.TXTB_Username.TabIndex = 2;
            this.TXTB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTB_Password
            // 
            this.TXTB_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTB_Password.Location = new System.Drawing.Point(591, 204);
            this.TXTB_Password.Name = "TXTB_Password";
            this.TXTB_Password.PasswordChar = '●';
            this.TXTB_Password.Size = new System.Drawing.Size(136, 27);
            this.TXTB_Password.TabIndex = 3;
            this.TXTB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(499, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login Screen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(479, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(484, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // CHB_Rememberme
            // 
            this.CHB_Rememberme.AutoSize = true;
            this.CHB_Rememberme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_Rememberme.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CHB_Rememberme.Location = new System.Drawing.Point(552, 348);
            this.CHB_Rememberme.Name = "CHB_Rememberme";
            this.CHB_Rememberme.Size = new System.Drawing.Size(114, 20);
            this.CHB_Rememberme.TabIndex = 7;
            this.CHB_Rememberme.Text = "Rememberme";
            this.CHB_Rememberme.UseVisualStyleBackColor = true;
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackgroundImage = global::DVLD.Properties.Resources.Close;
            this.BTN_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Close.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BTN_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Location = new System.Drawing.Point(773, 17);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(27, 26);
            this.BTN_Close.TabIndex = 8;
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DVLD.Properties.Resources.DVLD_Login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 447);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.CHB_Rememberme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTB_Password);
            this.Controls.Add(this.TXTB_Username);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.TextBox TXTB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHB_Rememberme;
        private System.Windows.Forms.Button BTN_Close;
        public System.Windows.Forms.TextBox TXTB_Username;
    }
}