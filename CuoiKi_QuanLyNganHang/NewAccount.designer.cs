namespace CuoiKi_QuanLyNganHang
{
    partial class FormNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewAccount));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtCCCD = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtPhoneNumb = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtUsername = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.lblNewAcc = new System.Windows.Forms.Label();
            this.btnCreate = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hidden1 = new System.Windows.Forms.PictureBox();
            this.presently1 = new System.Windows.Forms.PictureBox();
            this.txtPassword1 = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hidden2 = new System.Windows.Forms.PictureBox();
            this.presently2 = new System.Windows.Forms.PictureBox();
            this.txtPassword2 = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidden1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidden2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 630);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtName.BorderSize = 2;
            this.txtName.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtName.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(183, 94);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.NumberMoney = false;
            this.txtName.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtName.PasswordChar = false;
            this.txtName.Size = new System.Drawing.Size(372, 55);
            this.txtName.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtName.TabIndex = 1;
            this.txtName.Texts = "Họ và tên";
            this.txtName.UnderLinedStyle = true;
            this.txtName.Enter += new System.EventHandler(this.NewAccount_Enter);
            this.txtName.Leave += new System.EventHandler(this.NewAccount_Leave);
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCCCD.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCCCD.BorderSize = 2;
            this.txtCCCD.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtCCCD.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtCCCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.ForeColor = System.Drawing.Color.DimGray;
            this.txtCCCD.Location = new System.Drawing.Point(183, 167);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txtCCCD.Multiline = true;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.NumberMoney = false;
            this.txtCCCD.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtCCCD.PasswordChar = false;
            this.txtCCCD.Size = new System.Drawing.Size(372, 55);
            this.txtCCCD.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtCCCD.TabIndex = 2;
            this.txtCCCD.Texts = "Số CCCD";
            this.txtCCCD.UnderLinedStyle = true;
            this.txtCCCD.Enter += new System.EventHandler(this.NewAccount_Enter);
            this.txtCCCD.Leave += new System.EventHandler(this.txtCCCD_Leave);
            // 
            // txtPhoneNumb
            // 
            this.txtPhoneNumb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPhoneNumb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPhoneNumb.BorderSize = 2;
            this.txtPhoneNumb.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtPhoneNumb.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtPhoneNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumb.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumb.Location = new System.Drawing.Point(183, 239);
            this.txtPhoneNumb.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumb.Multiline = true;
            this.txtPhoneNumb.Name = "txtPhoneNumb";
            this.txtPhoneNumb.NumberMoney = false;
            this.txtPhoneNumb.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtPhoneNumb.PasswordChar = false;
            this.txtPhoneNumb.Size = new System.Drawing.Size(372, 55);
            this.txtPhoneNumb.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtPhoneNumb.TabIndex = 3;
            this.txtPhoneNumb.Texts = "Số điện thoại";
            this.txtPhoneNumb.UnderLinedStyle = true;
            this.txtPhoneNumb.Enter += new System.EventHandler(this.NewAccount_Enter);
            this.txtPhoneNumb.Leave += new System.EventHandler(this.txtPhoneNumb_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtUsername.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(183, 311);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.NumberMoney = false;
            this.txtUsername.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.Size = new System.Drawing.Size(372, 55);
            this.txtUsername.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Texts = "Tên tài khoản";
            this.txtUsername.UnderLinedStyle = true;
            this.txtUsername.Enter += new System.EventHandler(this.NewAccount_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblNewAcc
            // 
            this.lblNewAcc.AutoSize = true;
            this.lblNewAcc.BackColor = System.Drawing.Color.Transparent;
            this.lblNewAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAcc.Location = new System.Drawing.Point(216, 22);
            this.lblNewAcc.Name = "lblNewAcc";
            this.lblNewAcc.Size = new System.Drawing.Size(319, 33);
            this.lblNewAcc.TabIndex = 7;
            this.lblNewAcc.Text = "TẠO TÀI KHOẢN MỚI";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreate.BorderRadius = 0;
            this.btnCreate.BorderSize = 0;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(277, 554);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Xác nhận";
            this.btnCreate.TextColor = System.Drawing.Color.White;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(191, 516);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(60, 24);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(691, 11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 33;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hidden1);
            this.panel2.Controls.Add(this.presently1);
            this.panel2.Controls.Add(this.txtPassword1);
            this.panel2.Location = new System.Drawing.Point(183, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 55);
            this.panel2.TabIndex = 34;
            // 
            // hidden1
            // 
            this.hidden1.Image = ((System.Drawing.Image)(resources.GetObject("hidden1.Image")));
            this.hidden1.Location = new System.Drawing.Point(342, 15);
            this.hidden1.Name = "hidden1";
            this.hidden1.Size = new System.Drawing.Size(27, 25);
            this.hidden1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidden1.TabIndex = 5;
            this.hidden1.TabStop = false;
            this.hidden1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hidden1_MouseDown);
            this.hidden1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hidden1_MouseUp);
            // 
            // presently1
            // 
            this.presently1.Image = ((System.Drawing.Image)(resources.GetObject("presently1.Image")));
            this.presently1.Location = new System.Drawing.Point(342, 15);
            this.presently1.Name = "presently1";
            this.presently1.Size = new System.Drawing.Size(27, 25);
            this.presently1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.presently1.TabIndex = 4;
            this.presently1.TabStop = false;
            // 
            // txtPassword1
            // 
            this.txtPassword1.AutoScroll = true;
            this.txtPassword1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassword1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword1.BorderSize = 2;
            this.txtPassword1.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtPassword1.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtPassword1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword1.Location = new System.Drawing.Point(0, 0);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword1.Multiline = false;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.NumberMoney = false;
            this.txtPassword1.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtPassword1.PasswordChar = false;
            this.txtPassword1.Size = new System.Drawing.Size(372, 46);
            this.txtPassword1.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtPassword1.TabIndex = 3;
            this.txtPassword1.TabStop = false;
            this.txtPassword1.Texts = "Mật khẩu";
            this.txtPassword1.UnderLinedStyle = true;
            this.txtPassword1.Enter += new System.EventHandler(this.txtPassword1_Enter);
            this.txtPassword1.Leave += new System.EventHandler(this.NewAccount_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hidden2);
            this.panel1.Controls.Add(this.presently2);
            this.panel1.Controls.Add(this.txtPassword2);
            this.panel1.Location = new System.Drawing.Point(183, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 55);
            this.panel1.TabIndex = 35;
            // 
            // hidden2
            // 
            this.hidden2.Image = ((System.Drawing.Image)(resources.GetObject("hidden2.Image")));
            this.hidden2.Location = new System.Drawing.Point(342, 15);
            this.hidden2.Name = "hidden2";
            this.hidden2.Size = new System.Drawing.Size(27, 25);
            this.hidden2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidden2.TabIndex = 5;
            this.hidden2.TabStop = false;
            this.hidden2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hidden2_MouseDown);
            this.hidden2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hidden2_MouseUp);
            // 
            // presently2
            // 
            this.presently2.Image = ((System.Drawing.Image)(resources.GetObject("presently2.Image")));
            this.presently2.Location = new System.Drawing.Point(342, 15);
            this.presently2.Name = "presently2";
            this.presently2.Size = new System.Drawing.Size(27, 25);
            this.presently2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.presently2.TabIndex = 4;
            this.presently2.TabStop = false;
            // 
            // txtPassword2
            // 
            this.txtPassword2.AutoScroll = true;
            this.txtPassword2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPassword2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword2.BorderSize = 2;
            this.txtPassword2.ControlPadding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtPassword2.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtPassword2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword2.Location = new System.Drawing.Point(0, 0);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword2.Multiline = false;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.NumberMoney = false;
            this.txtPassword2.Padding = new System.Windows.Forms.Padding(8, 15, 5, 5);
            this.txtPassword2.PasswordChar = false;
            this.txtPassword2.Size = new System.Drawing.Size(372, 46);
            this.txtPassword2.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtPassword2.TabIndex = 3;
            this.txtPassword2.TabStop = false;
            this.txtPassword2.Texts = "Nhập lại mật khẩu";
            this.txtPassword2.UnderLinedStyle = true;
            this.txtPassword2.Enter += new System.EventHandler(this.txtPassword2_Enter);
            this.txtPassword2.Leave += new System.EventHandler(this.NewAccount_Leave);
            // 
            // FormNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNewAcc);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPhoneNumb);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNewAccount";
            this.Text = "FormNewAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewAccount_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidden1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidden2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presently2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControls.RJTextBox txtName;
        private RJControls.RJTextBox txtCCCD;
        private RJControls.RJTextBox txtPhoneNumb;
        private RJControls.RJTextBox txtUsername;
        private System.Windows.Forms.Label lblNewAcc;
        private RJControls.RJButton btnCreate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox hidden1;
        private System.Windows.Forms.PictureBox presently1;
        private RJControls.RJTextBox txtPassword1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox hidden2;
        private System.Windows.Forms.PictureBox presently2;
        private RJControls.RJTextBox txtPassword2;
    }
}