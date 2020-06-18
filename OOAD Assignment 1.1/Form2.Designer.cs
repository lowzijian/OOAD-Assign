namespace OOAD_Assignment_1._1
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.lblLoginID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxLoginID = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblIC = new System.Windows.Forms.Label();
            this.tbxIC = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.tbxPhoneNum = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLoginAsMember = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLoginAsStaff = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.picInfo2 = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginID
            // 
            this.lblLoginID.AutoSize = true;
            this.lblLoginID.BackColor = System.Drawing.Color.White;
            this.lblLoginID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginID.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoginID.Location = new System.Drawing.Point(14, 195);
            this.lblLoginID.Name = "lblLoginID";
            this.lblLoginID.Size = new System.Drawing.Size(115, 30);
            this.lblLoginID.TabIndex = 0;
            this.lblLoginID.Text = "Login ID:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Maroon;
            this.lblPassword.Location = new System.Drawing.Point(14, 285);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 30);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.Maroon;
            this.lblAge.Location = new System.Drawing.Point(14, 223);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(69, 30);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age:";
            // 
            // tbxLoginID
            // 
            this.tbxLoginID.Location = new System.Drawing.Point(146, 202);
            this.tbxLoginID.Name = "tbxLoginID";
            this.tbxLoginID.Size = new System.Drawing.Size(253, 22);
            this.tbxLoginID.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(146, 292);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(253, 22);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.MouseLeave += new System.EventHandler(this.tbxPassword_MouseLeave);
            this.tbxPassword.MouseHover += new System.EventHandler(this.tbxPassword_MouseHover);
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(19, 264);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(355, 22);
            this.tbxAge.TabIndex = 5;
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.BackColor = System.Drawing.Color.White;
            this.lblIC.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIC.ForeColor = System.Drawing.Color.Maroon;
            this.lblIC.Location = new System.Drawing.Point(15, 308);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(46, 30);
            this.lblIC.TabIndex = 6;
            this.lblIC.Text = "IC:";
            // 
            // tbxIC
            // 
            this.tbxIC.Location = new System.Drawing.Point(19, 353);
            this.tbxIC.Name = "tbxIC";
            this.tbxIC.Size = new System.Drawing.Size(355, 22);
            this.tbxIC.TabIndex = 7;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.White;
            this.lblPhoneNum.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhoneNum.Location = new System.Drawing.Point(15, 399);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(199, 30);
            this.lblPhoneNum.TabIndex = 8;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // tbxPhoneNum
            // 
            this.tbxPhoneNum.Location = new System.Drawing.Point(19, 453);
            this.tbxPhoneNum.Name = "tbxPhoneNum";
            this.tbxPhoneNum.Size = new System.Drawing.Size(355, 22);
            this.tbxPhoneNum.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Maroon;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(86, 531);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(288, 46);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(412, 662);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(214, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(670, 662);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 45);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLoginAsMember
            // 
            this.btnLoginAsMember.BackColor = System.Drawing.Color.Maroon;
            this.btnLoginAsMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsMember.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsMember.Location = new System.Drawing.Point(498, 585);
            this.btnLoginAsMember.Name = "btnLoginAsMember";
            this.btnLoginAsMember.Size = new System.Drawing.Size(288, 45);
            this.btnLoginAsMember.TabIndex = 15;
            this.btnLoginAsMember.Text = "Login As &Member";
            this.btnLoginAsMember.UseVisualStyleBackColor = false;
            this.btnLoginAsMember.Visible = false;
            this.btnLoginAsMember.Click += new System.EventHandler(this.btnLoginAsMember_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(15, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 30);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(19, 184);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(355, 22);
            this.tbxName.TabIndex = 17;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.lblLogin);
            this.panelLogin.Controls.Add(this.cbxShowPassword);
            this.panelLogin.Controls.Add(this.tbxLoginID);
            this.panelLogin.Controls.Add(this.lblLoginID);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.tbxPassword);
            this.panelLogin.Location = new System.Drawing.Point(-2, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(464, 575);
            this.panelLogin.TabIndex = 18;
            this.panelLogin.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(403, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblLogin.Location = new System.Drawing.Point(10, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(119, 40);
            this.lblLogin.TabIndex = 19;
            this.lblLogin.Text = "Sign In";
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.BackColor = System.Drawing.Color.White;
            this.cbxShowPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShowPassword.ForeColor = System.Drawing.Color.Maroon;
            this.cbxShowPassword.Location = new System.Drawing.Point(135, 374);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(180, 27);
            this.cbxShowPassword.TabIndex = 18;
            this.cbxShowPassword.Text = "View Password";
            this.cbxShowPassword.UseVisualStyleBackColor = false;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // btnLoginAsStaff
            // 
            this.btnLoginAsStaff.BackColor = System.Drawing.Color.Maroon;
            this.btnLoginAsStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAsStaff.ForeColor = System.Drawing.Color.White;
            this.btnLoginAsStaff.Location = new System.Drawing.Point(498, 585);
            this.btnLoginAsStaff.Name = "btnLoginAsStaff";
            this.btnLoginAsStaff.Size = new System.Drawing.Size(288, 45);
            this.btnLoginAsStaff.TabIndex = 21;
            this.btnLoginAsStaff.Text = "Login As &Staff";
            this.btnLoginAsStaff.UseVisualStyleBackColor = false;
            this.btnLoginAsStaff.Visible = false;
            this.btnLoginAsStaff.Click += new System.EventHandler(this.btnLoginAsStaff_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.panelLogin);
            this.panelRegister.Controls.Add(this.button2);
            this.panelRegister.Controls.Add(this.lblRegister);
            this.panelRegister.Controls.Add(this.lblAge);
            this.panelRegister.Controls.Add(this.lblName);
            this.panelRegister.Controls.Add(this.btnRegister);
            this.panelRegister.Controls.Add(this.tbxName);
            this.panelRegister.Controls.Add(this.tbxAge);
            this.panelRegister.Controls.Add(this.tbxIC);
            this.panelRegister.Controls.Add(this.tbxPhoneNum);
            this.panelRegister.Controls.Add(this.lblIC);
            this.panelRegister.Controls.Add(this.lblPhoneNum);
            this.panelRegister.Location = new System.Drawing.Point(412, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(464, 579);
            this.panelRegister.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(403, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 31);
            this.button2.TabIndex = 22;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.Maroon;
            this.lblRegister.Location = new System.Drawing.Point(6, 18);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(141, 40);
            this.lblRegister.TabIndex = 20;
            this.lblRegister.Text = "Register";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Maroon;
            this.pnlInfo.Controls.Add(this.lblInfo3);
            this.pnlInfo.Controls.Add(this.picInfo2);
            this.pnlInfo.Controls.Add(this.picInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(406, 719);
            this.pnlInfo.TabIndex = 20;
            this.pnlInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlInfo_MouseDown);
            this.pnlInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlInfo_MouseMove);
            this.pnlInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlInfo_MouseUp);
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.ForeColor = System.Drawing.Color.White;
            this.lblInfo3.Location = new System.Drawing.Point(96, 322);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(202, 37);
            this.lblInfo3.TabIndex = 2;
            this.lblInfo3.Text = "TGK CINEMA";
            // 
            // picInfo2
            // 
            this.picInfo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picInfo2.Image = ((System.Drawing.Image)(resources.GetObject("picInfo2.Image")));
            this.picInfo2.Location = new System.Drawing.Point(103, 68);
            this.picInfo2.Name = "picInfo2";
            this.picInfo2.Size = new System.Drawing.Size(186, 218);
            this.picInfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo2.TabIndex = 1;
            this.picInfo2.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.White;
            this.picInfo.Location = new System.Drawing.Point(69, 36);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(262, 269);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 719);
            this.Controls.Add(this.btnLoginAsMember);
            this.Controls.Add(this.btnLoginAsStaff);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "User Form";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox tbxLoginID;
        public System.Windows.Forms.TextBox tbxPassword;
        public System.Windows.Forms.TextBox tbxAge;
        public System.Windows.Forms.TextBox tbxIC;
        public System.Windows.Forms.TextBox tbxPhoneNum;
        public System.Windows.Forms.TextBox tbxName;
        public System.Windows.Forms.Label lblLoginID;
        public System.Windows.Forms.Label lblPassword;
        public System.Windows.Forms.Label lblAge;
        public System.Windows.Forms.Label lblIC;
        public System.Windows.Forms.Label lblPhoneNum;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.Button btnReset;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnLoginAsMember;
        public System.Windows.Forms.Panel panelLogin;
        public System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picInfo2;
        private System.Windows.Forms.Label lblInfo3;
        public System.Windows.Forms.Button btnLoginAsStaff;
    }
}