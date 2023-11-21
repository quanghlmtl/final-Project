using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class Home : Form
    {
        string query = "SELECT [Sotk] FROM [TaiKhoan] Where ID = @id";
        string query2 = "SELECT [SoDuTK] FROM [TaiKhoan] Where ID = @id";
        private int id = 0;
        public Home()
        {
            InitializeComponent();
        }
        public Home(string name, int id)
        {
            InitializeComponent();
            lblHello.Text = lblHello.Text + " " + name;
            this.id = id;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            lblNumberBank.Text = HandleSql.GetDataFromDTB(query, id);
            txtAccountBalance.Texts = HandleSql.GetDataFromDTB(query2, id);
            txtAccountBalance.Enabled = false;
            txtAccountBalance.BackColor = Color.White;
        }
        private void hideMoreButton(bool value)
        {
            item1.Visible = value;
            item2.Visible = value;
            item3.Visible = value;
            btnHide.Visible = value;
            value = !value;
            btnShow.Visible = value;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            hideMoreButton(false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            hideMoreButton(true);
        }

        private void hidden_MouseDown(object sender, MouseEventArgs e)
        {
            hidden.SendToBack();
            txtAccountBalance.PasswordChar = false;
            presently.BringToFront();
        }

        private void presently_MouseDown(object sender, MouseEventArgs e)
        {
            presently.SendToBack();
            txtAccountBalance.PasswordChar = true;
            hidden.BringToFront();
        }
    }
}
