using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public CustomMessageBox(string value)
        {
            InitializeComponent();
            CenterToScreen();
            this.lblTitle.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
