using CuoiKi_QuanLyNganHang.Sql;
using System;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormHistory : Form
    {

        private string tuKhoa = " ";
        private int id;
        public FormHistory(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            lblDatepicker.Text = dateTimePicker1.Text;
            tuKhoa = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            load();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDatepicker.Text = dateTimePicker1.Text;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            load();         
        }
        private void load()
        {
            string query = "[dbo].[SelectAllGiaoDich]";
            dataGridView1.DataSource = new DataProvider().SelectData(query, tuKhoa,id);       
        }
    }
}
