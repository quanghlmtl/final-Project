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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int money = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            string txt = rjTextBox1.Texts.Replace(".", "");
            money = int.Parse(txt);
            label2.Text = money.ToString();
        }
    }
}
