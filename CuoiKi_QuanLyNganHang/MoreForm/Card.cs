using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuoiKi_QuanLyNganHang.MoreForm
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        private string text = "";

        public Card(long number)
        {
            InitializeComponent();
            text = number.ToString();
        }

        private void lblNumberCard_TextChanged(object sender, EventArgs e)
        {
            string formattedText = FormatLblNumberCard();
            lblNumberCard.Text = formattedText;
        }

        //method 
        string FormatLblNumberCard()
        {
            string formattedText = "";
            int count = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                formattedText = text[i] + formattedText;
                count++;
                if (count % 3 == 0 && i > 0)
                {
                    formattedText = " " + formattedText; // Thay dấu chấm thành dấu phẩy nếu bạn muốn
                }
            }

            return formattedText;
        }

        private void Card_Load(object sender, EventArgs e)
        {
            lblNumberCard_TextChanged(sender, e);
        }

        private bool checkBtn2 = true;
        private void rjButton2_Click(object sender, EventArgs e)
        {
            if (checkBtn2)
            {
                label2.Text = "Khóa";
                rjButton2.Text = "Mở khóa thẻ";
                checkBtn2 = !checkBtn2;
            }
            else
            {
                label2.Text = "Đang hoạt động";
                rjButton2.Text = "Khóa thẻ";
                checkBtn2 = !checkBtn2;
            }
        }
    }
}
