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

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            lblDatepicker.Text = dateTimePicker1.Text;
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
            tuKhoa = dateTimePicker1.Value.ToString("dd-mm-yyyy");
            string query = "[dbo].[SelectAllGiaoDich]";
            //DataProvider.Instance.ExecuteQuery2(query, new object[] { tukhoa });
            dataGridView1.DataSource = new DataProvider().SelectData(query, tuKhoa,id);
            //dataGridView1.Columns["IDGD"].HeaderText = "Mã giao dịch";
            //dataGridView1.Columns["IDFrom"].HeaderText = "Từ tài khoản";
            //dataGridView1.Columns["IDTo"].HeaderText = "Tới tài khoản";
            //dataGridView1.Columns["SoTien"].HeaderText = "Số Tiền";
            //dataGridView1.Columns["DateGD"].HeaderText = "Ngày Giao dịch";
            //dataGridView1.Columns["Notes"].HeaderText = "Nội dung";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
