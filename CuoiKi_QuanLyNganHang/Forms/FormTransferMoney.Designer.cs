namespace CuoiKi_QuanLyNganHang
{
    partial class FormTransferMoney
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccountBalance = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBank = new CuoiKi_QuanLyNganHang.Class.CustomComboBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnConfirm = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtMoney = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.txtBankNumber = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.lineShape1 = new CuoiKi_QuanLyNganHang.Class.lineShape();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Averta Std CY", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số dư khả năng:  ";
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAccountBalance.BorderColor = System.Drawing.Color.Black;
            this.txtAccountBalance.BorderSize = 2;
            this.txtAccountBalance.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtAccountBalance.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountBalance.ForeColor = System.Drawing.Color.DimGray;
            this.txtAccountBalance.Location = new System.Drawing.Point(252, 52);
            this.txtAccountBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountBalance.Multiline = false;
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.NumberMoney = true;
            this.txtAccountBalance.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.txtAccountBalance.PasswordChar = false;
            this.txtAccountBalance.Size = new System.Drawing.Size(511, 36);
            this.txtAccountBalance.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtAccountBalance.TabIndex = 0;
            this.txtAccountBalance.Texts = "";
            this.txtAccountBalance.UnderLinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Averta Std CY Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(35, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Thông tin tài khoản";
            // 
            // txtBank
            // 
            this.txtBank.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBank.BorderColor = System.Drawing.Color.Black;
            this.txtBank.BorderSize = 2;
            this.txtBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.txtBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBank.ForeColor = System.Drawing.Color.DimGray;
            this.txtBank.IconColor = System.Drawing.Color.Black;
            this.txtBank.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.txtBank.ListTextColor = System.Drawing.Color.DimGray;
            this.txtBank.Location = new System.Drawing.Point(253, 140);
            this.txtBank.MinimumSize = new System.Drawing.Size(200, 30);
            this.txtBank.Name = "txtBank";
            this.txtBank.Padding = new System.Windows.Forms.Padding(2);
            this.txtBank.Size = new System.Drawing.Size(510, 36);
            this.txtBank.TabIndex = 27;
            this.txtBank.Texts = "";
            this.txtBank.OnSelectedIndexChanged += new System.EventHandler(this.txtBank_OnSelectedIndexChanged);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.Font = new System.Drawing.Font("Averta Std CY Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName1.Location = new System.Drawing.Point(65, 242);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(177, 25);
            this.lblName1.TabIndex = 26;
            this.lblName1.Text = "Người thụ hưởng: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Averta Std CY Thin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(250, 239);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 28);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 0;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(332, 396);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 40);
            this.btnConfirm.TabIndex = 24;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Averta Std CY Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(137, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nội dung:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Averta Std CY Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(157, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Averta Std CY Thin", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(105, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Averta Std CY Thin", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngân hàng thụ hưởng: ";
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.Window;
            this.txtContent.BorderColor = System.Drawing.Color.Black;
            this.txtContent.BorderSize = 2;
            this.txtContent.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtContent.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.Color.DimGray;
            this.txtContent.Location = new System.Drawing.Point(254, 339);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Multiline = false;
            this.txtContent.Name = "txtContent";
            this.txtContent.NumberMoney = false;
            this.txtContent.Padding = new System.Windows.Forms.Padding(5);
            this.txtContent.PasswordChar = false;
            this.txtContent.Size = new System.Drawing.Size(510, 36);
            this.txtContent.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtContent.TabIndex = 19;
            this.txtContent.Texts = "";
            this.txtContent.UnderLinedStyle = false;
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoney.BorderColor = System.Drawing.Color.Black;
            this.txtMoney.BorderSize = 2;
            this.txtMoney.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtMoney.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.ForeColor = System.Drawing.Color.DimGray;
            this.txtMoney.Location = new System.Drawing.Point(253, 287);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoney.Multiline = false;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.NumberMoney = true;
            this.txtMoney.Padding = new System.Windows.Forms.Padding(5);
            this.txtMoney.PasswordChar = false;
            this.txtMoney.Size = new System.Drawing.Size(511, 36);
            this.txtMoney.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtMoney.TabIndex = 18;
            this.txtMoney.Texts = "";
            this.txtMoney.UnderLinedStyle = false;
            this.txtMoney.Leave += new System.EventHandler(this.txtMoney_Leave);
            // 
            // txtBankNumber
            // 
            this.txtBankNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtBankNumber.BorderColor = System.Drawing.Color.Black;
            this.txtBankNumber.BorderSize = 2;
            this.txtBankNumber.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtBankNumber.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtBankNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBankNumber.Location = new System.Drawing.Point(252, 189);
            this.txtBankNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtBankNumber.Multiline = false;
            this.txtBankNumber.Name = "txtBankNumber";
            this.txtBankNumber.NumberMoney = false;
            this.txtBankNumber.Padding = new System.Windows.Forms.Padding(5);
            this.txtBankNumber.PasswordChar = false;
            this.txtBankNumber.Size = new System.Drawing.Size(511, 36);
            this.txtBankNumber.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.Number;
            this.txtBankNumber.TabIndex = 17;
            this.txtBankNumber.Texts = "";
            this.txtBankNumber.UnderLinedStyle = false;
            this.txtBankNumber.Leave += new System.EventHandler(this.txtBankNumber_Leave);
            // 
            // lineShape1
            // 
            this.lineShape1.AutoSize = true;
            this.lineShape1.BackColor = System.Drawing.Color.Transparent;
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderSize = 2;
            this.lineShape1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineShape1.Font = new System.Drawing.Font("Averta Std CY", 10F);
            this.lineShape1.ForeColor = System.Drawing.Color.White;
            this.lineShape1.Location = new System.Drawing.Point(37, 92);
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.Padding = new System.Windows.Forms.Padding(7);
            this.lineShape1.Size = new System.Drawing.Size(726, 32);
            this.lineShape1.TabIndex = 28;
            this.lineShape1.Text = "                                                                                 " +
    "                                                                                " +
    "               ";
            this.lineShape1.UnderLinedStyle = true;
            // 
            // FormTransferMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuoiKi_QuanLyNganHang.Properties.Resources.cool_background5;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.lineShape1);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtBankNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.label1);
            this.Name = "FormTransferMoney";
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.FormTransferMoney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private RJControls.RJTextBox txtAccountBalance;
        private System.Windows.Forms.Label label6;
        private Class.CustomComboBox txtBank;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName;
        private RJControls.RJButton btnConfirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private RJControls.RJTextBox txtContent;
        private RJControls.RJTextBox txtMoney;
        private RJControls.RJTextBox txtBankNumber;
        private Class.lineShape lineShape1;
    }
}