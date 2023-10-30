namespace CuoiKi_QuanLyNganHang
{
    partial class UserManagement
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTime2 = new System.Windows.Forms.DateTimePicker();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.btnBack = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.btnSearch2 = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.cbListBanks = new CuoiKi_QuanLyNganHang.Class.cbBorder();
            this.txtKeyWord = new CuoiKi_QuanLyNganHang.RJControls.RJTextBox();
            this.btnSearch = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            this.btnNewUser = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 300);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(377, 18);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 18);
            this.lblTo.TabIndex = 28;
            this.lblTo.Text = "To: ";
            this.lblTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(123, 18);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 18);
            this.lblFrom.TabIndex = 27;
            this.lblFrom.Text = "From: ";
            this.lblFrom.Visible = false;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBank.Location = new System.Drawing.Point(30, 116);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(87, 18);
            this.lblBank.TabIndex = 26;
            this.lblBank.Text = "Ngân hàng: ";
            this.lblBank.Visible = false;
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyWord.Location = new System.Drawing.Point(30, 71);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(70, 18);
            this.lblKeyWord.TabIndex = 25;
            this.lblKeyWord.Text = "Từ khóa: ";
            this.lblKeyWord.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(29, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(82, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Ngày tháng";
            this.lblDate.Visible = false;
            // 
            // dateTime2
            // 
            this.dateTime2.Checked = false;
            this.dateTime2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime2.Location = new System.Drawing.Point(417, 12);
            this.dateTime2.Name = "dateTime2";
            this.dateTime2.Size = new System.Drawing.Size(154, 26);
            this.dateTime2.TabIndex = 22;
            this.dateTime2.TabStop = false;
            this.dateTime2.Visible = false;
            // 
            // dateTime1
            // 
            this.dateTime1.Checked = false;
            this.dateTime1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTime1.Location = new System.Drawing.Point(181, 12);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(154, 26);
            this.dateTime1.TabIndex = 21;
            this.dateTime1.TabStop = false;
            this.dateTime1.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRefresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRefresh.BorderRadius = 0;
            this.btnRefresh.BorderSize = 0;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(632, 54);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 30);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextColor = System.Drawing.Color.White;
            this.btnRefresh.UseCompatibleTextRendering = true;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBack.BorderRadius = 0;
            this.btnBack.BorderSize = 0;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(632, 100);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 30);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch2.BorderRadius = 0;
            this.btnSearch2.BorderSize = 0;
            this.btnSearch2.FlatAppearance.BorderSize = 0;
            this.btnSearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.ForeColor = System.Drawing.Color.White;
            this.btnSearch2.Location = new System.Drawing.Point(632, 12);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(95, 30);
            this.btnSearch2.TabIndex = 29;
            this.btnSearch2.Text = "Tìm kiếm";
            this.btnSearch2.TextColor = System.Drawing.Color.White;
            this.btnSearch2.UseCompatibleTextRendering = true;
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Visible = false;
            // 
            // cbListBanks
            // 
            this.cbListBanks.BackColor = System.Drawing.SystemColors.Window;
            this.cbListBanks.BorderColor = System.Drawing.Color.MediumBlue;
            this.cbListBanks.BorderSize = 2;
            this.cbListBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListBanks.Font = new System.Drawing.Font("Averta Std CY", 10F);
            this.cbListBanks.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbListBanks.FormattingEnabled = true;
            this.cbListBanks.Location = new System.Drawing.Point(126, 109);
            this.cbListBanks.Name = "cbListBanks";
            this.cbListBanks.Size = new System.Drawing.Size(445, 25);
            this.cbListBanks.TabIndex = 23;
            this.cbListBanks.UnderLinedStyle = false;
            this.cbListBanks.Visible = false;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyWord.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtKeyWord.BorderSize = 2;
            this.txtKeyWord.ControlPadding = new System.Windows.Forms.Padding(0);
            this.txtKeyWord.CTextAlign = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose2.Left;
            this.txtKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyWord.ForeColor = System.Drawing.Color.DimGray;
            this.txtKeyWord.Location = new System.Drawing.Point(126, 62);
            this.txtKeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyWord.Multiline = false;
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Padding = new System.Windows.Forms.Padding(5);
            this.txtKeyWord.PasswordChar = false;
            this.txtKeyWord.Size = new System.Drawing.Size(445, 27);
            this.txtKeyWord.StateValue = CuoiKi_QuanLyNganHang.RJControls.RJTextBox.Choose.All;
            this.txtKeyWord.TabIndex = 20;
            this.txtKeyWord.Texts = "";
            this.txtKeyWord.UnderLinedStyle = false;
            this.txtKeyWord.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(443, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewUser.BorderRadius = 0;
            this.btnNewUser.BorderSize = 0;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(151, 54);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(150, 40);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "Thêm người dùng ";
            this.btnNewUser.TextColor = System.Drawing.Color.White;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbListBanks);
            this.Controls.Add(this.dateTime2);
            this.Controls.Add(this.dateTime1);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNewUser);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJControls.RJButton btnNewUser;
        private RJControls.RJButton btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblKeyWord;
        private System.Windows.Forms.Label lblDate;
        private Class.cbBorder cbListBanks;
        private System.Windows.Forms.DateTimePicker dateTime2;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private RJControls.RJTextBox txtKeyWord;
        private RJControls.RJButton btnSearch2;
        private RJControls.RJButton btnBack;
        private RJControls.RJButton btnRefresh;
    }
}