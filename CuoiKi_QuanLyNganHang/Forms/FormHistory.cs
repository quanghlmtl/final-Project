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
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            lblDatepicker.Text = dateTimePicker1.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDatepicker.Text = dateTimePicker1.Text;
        }
    }
}
