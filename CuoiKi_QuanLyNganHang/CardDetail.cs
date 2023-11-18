using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CuoiKi_QuanLyNganHang
{
    public partial class card_details : Form
    {
        public card_details()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private string text = "";
        private string name = "";
        public card_details(string numberCard, string name)
        {
            InitializeComponent();
            CenterToScreen();
            lblNameCard.Text = numberCard;
            this.name = name;
            lblNameCard.Text = name;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void card_details_Load(object sender, EventArgs e)
        {
            lb1.Text = "Card Number";
            lb2.Text = "CVV";
            lb3.Text = "Issue Date";
            lb4.Text = "Expiration Date";
        }
    }
}
