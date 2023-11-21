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
            this.txtAccountBalance = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new CuoiKi_QuanLyNganHang.Class.lineShape();
            this.txtSendingTerm = new CuoiKi_QuanLyNganHang.Class.CustomComboBox();
            this.btnConfirm = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.txtDateEnd = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtInterest = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtMoney = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineShape2 = new CuoiKi_QuanLyNganHang.Class.lineShape();
            this.SuspendLayout();
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountBalance.BorderColor = System.Drawing.Color.Red;
            this.txtAccountBalance.BorderSize = 2;
            this.txtAccountBalance.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtAccountBalance.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalance.ForeColor = System.Drawing.Color.DimGray;
            this.txtAccountBalance.Location = new System.Drawing.Point(256, 61);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountBalance.Multiline = false;
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.NumberMoney = true;
            this.txtAccountBalance.Padding = new System.Windows.Forms.Padding(5);
            this.txtAccountBalance.PasswordChar = false;
            this.txtAccountBalance.Size = new System.Drawing.Size(469, 40);
            this.txtAccountBalance.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtAccountBalance.TabIndex = 11;
            this.txtAccountBalance.Texts = "";
            this.txtAccountBalance.UnderLinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Averta Std CY Thin", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(58, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số dư ";
            // 
            // lineShape1
            // 
            this.lineShape1.AutoSize = true;
            this.lineShape1.BackColor = System.Drawing.Color.Transparent;
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderSize = 1;
            this.lineShape1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineShape1.Font = new System.Drawing.Font("Averta Std CY", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineShape1.ForeColor = System.Drawing.Color.White;
            this.lineShape1.Location = new System.Drawing.Point(38, 8);
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Padding = new System.Windows.Forms.Padding(7);
            this.lineShape1.Size = new System.Drawing.Size(206, 39);
            this.lineShape1.TabIndex = 13;
            this.lineShape1.Text = "Thông tin tài khoản";
            this.lineShape1.UnderLinedStyle = true;
            // 
            // txtSendingTerm
            // 
            this.txtSendingTerm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSendingTerm.BorderColor = System.Drawing.Color.Red;
            this.txtSendingTerm.BorderSize = 2;
            this.txtSendingTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtSendingTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSendingTerm.ForeColor = System.Drawing.Color.DimGray;
            this.txtSendingTerm.IconColor = System.Drawing.Color.Red;
            this.txtSendingTerm.Items.AddRange(new object[] {
            "Một Tháng",
            "Ba Tháng",
            "Sáu Tháng",
            "Một Năm",
            "Ba Năm",
            "Mười Năm"});
            this.txtSendingTerm.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.txtSendingTerm.ListTextColor = System.Drawing.Color.DimGray;
            this.txtSendingTerm.Location = new System.Drawing.Point(256, 236);
            this.txtSendingTerm.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtSendingTerm.Name = "txtSendingTerm";
            this.txtSendingTerm.Padding = new System.Windows.Forms.Padding(2);
            this.txtSendingTerm.Size = new System.Drawing.Size(469, 37);
            this.txtSendingTerm.TabIndex = 23;
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
            this.btnConfirm.Location = new System.Drawing.Point(328, 389);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 40);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtDateEnd.BorderColor = System.Drawing.Color.Red;
            this.txtDateEnd.BorderSize = 2;
            this.txtDateEnd.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtDateEnd.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEnd.ForeColor = System.Drawing.Color.DimGray;
            this.txtDateEnd.Location = new System.Drawing.Point(256, 332);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateEnd.Multiline = false;
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.NumberMoney = false;
            this.txtDateEnd.Padding = new System.Windows.Forms.Padding(5);
            this.txtDateEnd.PasswordChar = false;
            this.txtDateEnd.Size = new System.Drawing.Size(469, 35);
            this.txtDateEnd.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtDateEnd.TabIndex = 21;
            this.txtDateEnd.Texts = "";
            this.txtDateEnd.UnderLinedStyle = false;
            // 
            // txtInterest
            // 
            this.txtInterest.BackColor = System.Drawing.SystemColors.Window;
            this.txtInterest.BorderColor = System.Drawing.Color.Red;
            this.txtInterest.BorderSize = 2;
            this.txtInterest.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtInterest.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterest.ForeColor = System.Drawing.Color.DimGray;
            this.txtInterest.Location = new System.Drawing.Point(256, 284);
            this.txtInterest.Margin = new System.Windows.Forms.Padding(4);
            this.txtInterest.Multiline = false;
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.NumberMoney = true;
            this.txtInterest.Padding = new System.Windows.Forms.Padding(5);
            this.txtInterest.PasswordChar = false;
            this.txtInterest.Size = new System.Drawing.Size(469, 35);
            this.txtInterest.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtInterest.TabIndex = 20;
            this.txtInterest.Texts = "";
            this.txtInterest.UnderLinedStyle = false;
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoney.BorderColor = System.Drawing.Color.Red;
            this.txtMoney.BorderSize = 2;
            this.txtMoney.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtMoney.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.DimGray;
            this.txtMoney.Location = new System.Drawing.Point(256, 188);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Multiline = false;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.NumberMoney = true;
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.PasswordChar = false;
            this.txtMoney.Size = new System.Drawing.Size(469, 35);
            this.txtMoney.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtMoney.TabIndex = 19;
            this.txtMoney.Texts = "";
            this.txtMoney.UnderLinedStyle = false;
            this.txtMoney._TextChanged += new System.EventHandler(this.txtMoney__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Averta Std CY Thin", 13F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(58, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày đến hạn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Averta Std CY Thin", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(58, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tiền lãi cuối kỳ dự kiến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Averta Std CY Thin", 13F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(59, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Kỳ hạn gửi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Averta Std CY Thin", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(58, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số tiền gửi";
            // 
            // lineShape2
            // 
            this.lineShape2.AutoSize = true;
            this.lineShape2.BackColor = System.Drawing.Color.Transparent;
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderSize = 1;
            this.lineShape2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineShape2.Font = new System.Drawing.Font("Averta Std CY", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineShape2.ForeColor = System.Drawing.Color.White;
            this.lineShape2.Location = new System.Drawing.Point(38, 129);
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.Padding = new System.Windows.Forms.Padding(7);
            this.lineShape2.Size = new System.Drawing.Size(198, 39);
            this.lineShape2.TabIndex = 24;
            this.lineShape2.Text = "Thông tin tiết kiệm";
            this.lineShape2.UnderLinedStyle = true;
            // 
            // FormSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuoiKi_QuanLyNganHang.Properties.Resources.cool_background3;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.lineShape2);
            this.Controls.Add(this.txtSendingTerm);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lineShape1);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.label1);
            this.Name = "FormSaving";
            this.Text = "Lập sổ tiết kiệm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJControls.RJTextBox txtAccountBalance;
        private System.Windows.Forms.Label label1;
        private Class.lineShape lineShape1;
        private Class.CustomComboBox txtSendingTerm;
        private RJControls.RJButton btnConfirm;
        private RJControls.RJTextBox txtDateEnd;
        private RJControls.RJTextBox txtInterest;
        private RJControls.RJTextBox txtMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Class.lineShape lineShape2;
    }
}