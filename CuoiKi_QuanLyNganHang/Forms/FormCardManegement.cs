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

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class FormCardManegement : Form
    {
        public FormCardManegement()
        {
            InitializeComponent();
        }

        private int x = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (x >= 0 && x < 488 * 3)
            {
                x += 488;
                flowLayoutPanel.AutoScrollPosition = new System.Drawing.Point(x, flowLayoutPanel.AutoScrollPosition.Y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x > 0 && x <= 488 * 3)
            {
                x -= 488;
                flowLayoutPanel.AutoScrollPosition = new System.Drawing.Point(x, flowLayoutPanel.AutoScrollPosition.Y);
            }
        }

        private void FormCardManegement_Load(object sender, EventArgs e)
        {
            Card newcard1 = new Card(561396725596);
            Card newcard2 = new Card(123456789012);
            Card newcard3 = new Card(654321567865);
            Card newcard4 = new Card(261220032312);
            flowLayoutPanel.Controls.Add(newcard1);
            flowLayoutPanel.Controls.Add(newcard2);
            flowLayoutPanel.Controls.Add(newcard3);
            flowLayoutPanel.Controls.Add(newcard4);
        }
    }
}
