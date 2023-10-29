namespace CuoiKi_QuanLyNganHang
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsNewAccout = new CuoiKi_QuanLyNganHang.Class.lineShape();
            this.lsForgetPassword = new CuoiKi_QuanLyNganHang.Class.lineShape();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hidden = new System.Windows.Forms.PictureBox();
            this.presently = new System.Windows.Forms.PictureBox();
            this.txtPassword = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtUser = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsNewAccout);
            this.panel1.Controls.Add(this.lsForgetPassword);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 630);
            this.panel1.TabIndex = 0;
            // 
            // lsNewAccout
            // 
            this.lsNewAccout.AutoSize = true;
            this.lsNewAccout.BackColor = System.Drawing.Color.Transparent;
            this.lsNewAccout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(224)))));
            this.lsNewAccout.BorderSize = 3;
            this.lsNewAccout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsNewAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsNewAccout.ForeColor = System.Drawing.Color.White;
            this.lsNewAccout.Location = new System.Drawing.Point(429, 508);
            this.lsNewAccout.Name = "lsNewAccout";
            this.lsNewAccout.Padding = new System.Windows.Forms.Padding(7);
            this.lsNewAccout.Size = new System.Drawing.Size(109, 31);
            this.lsNewAccout.TabIndex = 24;
            this.lsNewAccout.Text = "Tạo tài khoản";
            this.lsNewAccout.UnderLinedStyle = true;
            this.lsNewAccout.Click += new System.EventHandler(this.lsNewAccout_Click);
            // 
            // lsForgetPassword
            // 
            this.lsForgetPassword.AutoSize = true;
            this.lsForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lsForgetPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(146)))), ((int)(((byte)(224)))));
            this.lsForgetPassword.BorderSize = 3;
            this.lsForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lsForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lsForgetPassword.ForeColor = System.Drawing.Color.White;
            this.lsForgetPassword.Location = new System.Drawing.Point(134, 508);
            this.lsForgetPassword.Name = "lsForgetPassword";
            this.lsForgetPassword.Padding = new System.Windows.Forms.Padding(7);
            this.lsForgetPassword.Size = new System.Drawing.Size(119, 31);
            this.lsForgetPassword.TabIndex = 23;
            this.lsForgetPassword.Text = "Quên mật khẩu";
            this.lsForgetPassword.UnderLinedStyle = true;
            this.lsForgetPassword.Click += new System.EventHandler(this.lsForgetPassword_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Location = new System.Drawing.Point(242, 146);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(165, 33);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(31)))), ((int)(((byte)(145)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(31)))), ((int)(((byte)(145)))));
            this.btnLogin.BorderColor = System.Drawing.Color.White;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(137, 412);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(400, 45);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "DNQT Bank";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(145, 363);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(60, 24);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hidden);
            this.panel2.Controls.Add(this.presently);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(137, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 39);
            this.panel2.TabIndex = 6;
            // 
            // hidden
            // 
            this.hidden.Image = ((System.Drawing.Image)(resources.GetObject("hidden.Image")));
            this.hidden.Location = new System.Drawing.Point(370, 3);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(27, 25);
            this.hidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidden.TabIndex = 5;
            this.hidden.TabStop = false;
            this.hidden.Click += new System.EventHandler(this.lsNewAccout_Click);
            this.hidden.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Hidden_MouseDown);
            this.hidden.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Hidden_MouseUp);
            // 
            // presently
            // 
            this.presently.Image = ((System.Drawing.Image)(resources.GetObject("presently.Image")));
            this.presently.Location = new System.Drawing.Point(370, 3);
            this.presently.Name = "presently";
            this.presently.Size = new System.Drawing.Size(27, 25);
            this.presently.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.presently.TabIndex = 4;
            this.presently.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoScroll = true;
            this.txtPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtPassword.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(400, 36);
            this.txtPassword.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TabStop = false;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderLinedStyle = true;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.FormLogin_Leave);
            // 
            // txtUser
            // 
            this.txtUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUser.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUser.BorderSize = 2;
            this.txtUser.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtUser.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(137, 228);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.PasswordChar = false;
            this.txtUser.Size = new System.Drawing.Size(400, 36);
            this.txtUser.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtUser.TabIndex = 2;
            this.txtUser.TabStop = false;
            this.txtUser.Texts = "";
            this.txtUser.UnderLinedStyle = true;
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.FormLogin_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(743, 630);
            this.Controls.Add(this.panel1);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJControls.RJTextBox txtPassword;
        private RJControls.RJTextBox txtUser;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTitle;
        private RJControls.RJButton btnLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox hidden;
        private System.Windows.Forms.PictureBox presently;
        private Class.lineShape lsForgetPassword;
        private Class.lineShape lsNewAccout;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}

