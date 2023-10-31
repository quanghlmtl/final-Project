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

        public Home()
        {
            InitializeComponent();
        }
        public Home(string name)
        {
            InitializeComponent();
            lblName.Text = name;
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
    }
}
