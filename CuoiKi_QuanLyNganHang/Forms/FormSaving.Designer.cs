namespace CuoiKi_QuanLyNganHang.Forms
{
    partial class FormSaving
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccountBalance = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSendingTerm = new CuoiKi_QuanLyNganHang.Class.CustomComboBox();
            this.btnConfirm = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.txtDateEnd = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtInterest = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtMoney = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAccountBalance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông tin tài khoản";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountBalance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAccountBalance.BorderSize = 2;
            this.txtAccountBalance.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtAccountBalance.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalance.ForeColor = System.Drawing.Color.DimGray;
            this.txtAccountBalance.Location = new System.Drawing.Point(240, 45);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountBalance.Multiline = false;
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.NumberMoney = true;
            this.txtAccountBalance.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccountBalance.PasswordChar = false;
            this.txtAccountBalance.Size = new System.Drawing.Size(469, 36);
            this.txtAccountBalance.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtAccountBalance.TabIndex = 0;
            this.txtAccountBalance.Texts = "";
            this.txtAccountBalance.UnderLinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số dư";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSendingTerm);
            this.groupBox2.Controls.Add(this.btnConfirm);
            this.groupBox2.Controls.Add(this.txtDateEnd);
            this.groupBox2.Controls.Add(this.txtInterest);
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(770, 345);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtSendingTerm
            // 
            this.txtSendingTerm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSendingTerm.BorderColor = System.Drawing.Color.HotPink;
            this.txtSendingTerm.BorderSize = 2;
            this.txtSendingTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtSendingTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSendingTerm.ForeColor = System.Drawing.Color.DimGray;
            this.txtSendingTerm.IconColor = System.Drawing.Color.HotPink;
            this.txtSendingTerm.Items.AddRange(new object[] {
            "Một Tháng",
            "Ba Tháng",
            "Sáu Tháng",
            "Một Năm",
            "Ba Năm",
            "Mười Năm"});
            this.txtSendingTerm.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.txtSendingTerm.ListTextColor = System.Drawing.Color.DimGray;
            this.txtSendingTerm.Location = new System.Drawing.Point(240, 103);
            this.txtSendingTerm.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtSendingTerm.Name = "txtSendingTerm";
            this.txtSendingTerm.Padding = new System.Windows.Forms.Padding(2);
            this.txtSendingTerm.Size = new System.Drawing.Size(469, 30);
            this.txtSendingTerm.TabIndex = 10;
            this.txtSendingTerm.Texts = "";
            this.txtSendingTerm.OnSelectedIndexChanged += new System.EventHandler(this.txtSendingTerm_OnSelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 0;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(312, 283);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateEnd.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDateEnd.BorderSize = 2;
            this.txtDateEnd.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtDateEnd.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEnd.ForeColor = System.Drawing.Color.DimGray;
            this.txtDateEnd.Location = new System.Drawing.Point(240, 191);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateEnd.Multiline = false;
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.NumberMoney = false;
            this.txtDateEnd.Padding = new System.Windows.Forms.Padding(5);
            this.txtDateEnd.PasswordChar = false;
            this.txtDateEnd.Size = new System.Drawing.Size(469, 27);
            this.txtDateEnd.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtDateEnd.TabIndex = 8;
            this.txtDateEnd.Texts = "";
            this.txtDateEnd.UnderLinedStyle = false;
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.SystemColors.Window;
            this.txtInterest.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtInterest.BorderSize = 2;
            this.txtInterest.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtInterest.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.ForeColor = System.Drawing.Color.DimGray;
            this.txtInterest.Location = new System.Drawing.Point(240, 149);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterest.Multiline = false;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.NumberMoney = true;
            this.txtInterest.Padding = new System.Windows.Forms.Padding(5);
            this.txtInterest.PasswordChar = false;
            this.txtInterest.Size = new System.Drawing.Size(469, 27);
            this.txtInterest.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtInterest.TabIndex = 7;
            this.txtInterest.Texts = "";
            this.txtInterest.UnderLinedStyle = false;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoney.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMoney.BorderSize = 2;
            this.txtMoney.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtMoney.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.DimGray;
            this.txtMoney.Location = new System.Drawing.Point(240, 55);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Multiline = false;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.NumberMoney = true;
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.PasswordChar = false;
            this.txtMoney.Size = new System.Drawing.Size(469, 27);
            this.txtMoney.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtMoney.TabIndex = 5;
            this.txtMoney.Texts = "";
            this.txtMoney.UnderLinedStyle = false;
            this.txtMoney._TextChanged += new System.EventHandler(this.txtMoney__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày đến hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tiền lãi cuối kỳ dự kiến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kỳ hạn gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số tiền gửi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin tiết kiệm";
            // 
            // FormSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSaving";
            this.Text = "Lập sổ tiết kiệm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private RJControls.RJTextBox txtAccountBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private RJControls.RJTextBox txtDateEnd;
        private RJControls.RJTextBox txtInterest;
        private RJControls.RJTextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJControls.RJButton btnConfirm;
        private Class.CustomComboBox txtSendingTerm;
        private System.Windows.Forms.Timer timer1;
    }
}