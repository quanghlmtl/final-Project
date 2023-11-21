namespace CuoiKi_QuanLyNganHang
{
    partial class FormHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDatepicker = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllGiaoDichBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHDataSet2 = new CuoiKi_QuanLyNganHang.QLNHDataSet2();
            this.giaoDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHDataSet = new CuoiKi_QuanLyNganHang.QLNHDataSet();
            this.giaoDichTableAdapter = new CuoiKi_QuanLyNganHang.QLNHDataSetTableAdapters.GiaoDichTableAdapter();
            this.qLNHDataSet1 = new CuoiKi_QuanLyNganHang.QLNHDataSet1();
            this.selectAllGiaoDichBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllGiaoDichTableAdapter = new CuoiKi_QuanLyNganHang.QLNHDataSet1TableAdapters.SelectAllGiaoDichTableAdapter();
            this.selectAllGiaoDichTableAdapter1 = new CuoiKi_QuanLyNganHang.QLNHDataSet2TableAdapters.SelectAllGiaoDichTableAdapter();
            this.rjButton1 = new CuoiKi_QuanLyNganHang.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllGiaoDichBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllGiaoDichBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.FormHistory_Load);
            // 
            // lblDatepicker
            // 
            this.lblDatepicker.AutoSize = true;
            this.lblDatepicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatepicker.Location = new System.Drawing.Point(6, 77);
            this.lblDatepicker.Name = "lblDatepicker";
            this.lblDatepicker.Size = new System.Drawing.Size(117, 20);
            this.lblDatepicker.TabIndex = 3;
            this.lblDatepicker.Text = "Từ trước tới nay";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDGDDataGridViewTextBoxColumn,
            this.NameTK,
            this.NameTK1,
            this.soTienDataGridViewTextBoxColumn,
            this.dateGDDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectAllGiaoDichBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDGDDataGridViewTextBoxColumn
            // 
            this.iDGDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDGDDataGridViewTextBoxColumn.DataPropertyName = "IDGD";
            this.iDGDDataGridViewTextBoxColumn.HeaderText = "Mã Giao Dịch";
            this.iDGDDataGridViewTextBoxColumn.Name = "iDGDDataGridViewTextBoxColumn";
            this.iDGDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NameTK
            // 
            this.NameTK.DataPropertyName = "NameTK";
            this.NameTK.HeaderText = "Người Gửi";
            this.NameTK.Name = "NameTK";
            this.NameTK.ReadOnly = true;
            this.NameTK.Width = 140;
            // 
            // NameTK1
            // 
            this.NameTK1.DataPropertyName = "NameTK1";
            this.NameTK1.HeaderText = "Người Nhận";
            this.NameTK1.Name = "NameTK1";
            this.NameTK1.ReadOnly = true;
            this.NameTK1.Width = 140;
            // 
            // soTienDataGridViewTextBoxColumn
            // 
            this.soTienDataGridViewTextBoxColumn.DataPropertyName = "SoTien";
            this.soTienDataGridViewTextBoxColumn.HeaderText = "Số Tiền";
            this.soTienDataGridViewTextBoxColumn.Name = "soTienDataGridViewTextBoxColumn";
            this.soTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateGDDataGridViewTextBoxColumn
            // 
            this.dateGDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateGDDataGridViewTextBoxColumn.DataPropertyName = "DateGD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateGDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateGDDataGridViewTextBoxColumn.HeaderText = "Ngày Giao Dịch";
            this.dateGDDataGridViewTextBoxColumn.Name = "dateGDDataGridViewTextBoxColumn";
            this.dateGDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateGDDataGridViewTextBoxColumn.Width = 120;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Nội Dung";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 200;
            // 
            // selectAllGiaoDichBindingSource1
            // 
            this.selectAllGiaoDichBindingSource1.DataMember = "SelectAllGiaoDich";
            this.selectAllGiaoDichBindingSource1.DataSource = this.qLNHDataSet2;
            // 
            // qLNHDataSet2
            // 
            this.qLNHDataSet2.DataSetName = "QLNHDataSet2";
            this.qLNHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoDichBindingSource
            // 
            this.giaoDichBindingSource.DataMember = "GiaoDich";
            this.giaoDichBindingSource.DataSource = this.qLNHDataSet;
            // 
            // qLNHDataSet
            // 
            this.qLNHDataSet.DataSetName = "QLNHDataSet";
            this.qLNHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giaoDichTableAdapter
            // 
            this.giaoDichTableAdapter.ClearBeforeFill = true;
            // 
            // qLNHDataSet1
            // 
            this.qLNHDataSet1.DataSetName = "QLNHDataSet1";
            this.qLNHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectAllGiaoDichBindingSource
            // 
            this.selectAllGiaoDichBindingSource.DataMember = "SelectAllGiaoDich";
            this.selectAllGiaoDichBindingSource.DataSource = this.qLNHDataSet1;
            // 
            // selectAllGiaoDichTableAdapter
            // 
            this.selectAllGiaoDichTableAdapter.ClearBeforeFill = true;
            // 
            // selectAllGiaoDichTableAdapter1
            // 
            this.selectAllGiaoDichTableAdapter1.ClearBeforeFill = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(10, 29);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(136, 26);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Tìm kiếm theo ngày";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CuoiKi_QuanLyNganHang.Properties.Resources.cool_background2;
            this.ClientSize = new System.Drawing.Size(840, 459);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.lblDatepicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormHistory";
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllGiaoDichBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaoDichBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllGiaoDichBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDatepicker;
        private RJControls.RJButton rjButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHDataSet qLNHDataSet;
        private System.Windows.Forms.BindingSource giaoDichBindingSource;
        private QLNHDataSetTableAdapters.GiaoDichTableAdapter giaoDichTableAdapter;
        private System.Windows.Forms.BindingSource selectAllGiaoDichBindingSource1;
        private QLNHDataSet2 qLNHDataSet2;
        private QLNHDataSet1 qLNHDataSet1;
        private System.Windows.Forms.BindingSource selectAllGiaoDichBindingSource;
        private QLNHDataSet1TableAdapters.SelectAllGiaoDichTableAdapter selectAllGiaoDichTableAdapter;
        private QLNHDataSet2TableAdapters.SelectAllGiaoDichTableAdapter selectAllGiaoDichTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
    }
}