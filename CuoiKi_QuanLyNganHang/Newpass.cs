using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
using CuoiKi_QuanLyNganHang.Class;
using CuoiKi_QuanLyNganHang.Sql;

namespace CuoiKi_QuanLyNganHang
{
    public partial class Newpass : Form
    {
        string username;
        public Newpass(string username)
        {
            this.username = username;
            InitializeComponent();
            CenterToScreen();
        }

        private void Newpass_Load(object sender, EventArgs e)
        {
            lblName.Text = "Hi " + username;
        }
        private void success()
        {
            string user = username;
            string newpass = rjTextBox2.Texts;
            if (string.IsNullOrWhiteSpace(rjTextBox1.Texts) || string.IsNullOrWhiteSpace(rjTextBox2.Texts))
            {
                MessageBox.Show("Chưa nhập đủ mật khẩu mới và nhắc lại mật khẩu mới");
                rjTextBox1.Select();
            }
            else
            {
                if (rjTextBox1.Texts != rjTextBox2.Texts)
                {
                    MessageBox.Show("Xác nhận mật khẩu mới không trùng khớp");
                    rjTextBox2.Select();
                }
                else
                {
                    DataProvider.Instance.UpdateAccount(username, newpass);
                     MessageBox.Show("Tạo mật khẩu mới thành công");
                     FormLogin flg = new FormLogin();
                     this.Hide();
                     flg.ShowDialog();
                }
            }

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            success();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin flg = new FormLogin();
            flg.ShowDialog();
        }
    }
}
