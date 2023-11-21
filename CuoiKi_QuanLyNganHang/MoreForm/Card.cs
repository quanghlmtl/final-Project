using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Forms;


namespace CuoiKi_QuanLyNganHang.MoreForm
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        private int id = 0;
        public Card(int id, string data1, string data2, string data3, string data4, string name)
        {
            InitializeComponent();
            this.id = id;
            numberCard = data1;
            issueDate = data2;
            expirationDate = data3;
            cVV = data4;
            lblNameCard.Text = name;
            lblBank.Text = "DNQT Bank";
            lblBank.Location = new System.Drawing.Point(313, 18);
        }
        private string numberCard = "";
        private string issueDate = "";
        private string expirationDate = "";
        private string cVV = "";
        private void Card_Load(object sender, EventArgs e)
        {
            lblNumberCard.Text = numberCard;
            //lblNumberCard_TextChanged(sender, e);
        }
        private void lblNumberCard_TextChanged(object sender, EventArgs e)
        {
            //string formattedText = FormatLblNumberCard();
            //lblNumberCard.Text = formattedText;
        }

        //string FormatLblNumberCard()
        //{
        //    string formattedText = "";
        //    int count = 0;
        //    for (int i = text.Length - 1; i >= 0; i--)
        //    {
        //        formattedText = text[i] + formattedText;
        //        count++;
        //        if (count % 3 == 0 && i > 0)
        //        {
        //            formattedText = " " + formattedText;
        //        }
        //    }
        //    return formattedText;
        //}

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
        private void rjButton1_Click(object sender, EventArgs e)
        {
      
            card_details infoCard =
                new card_details(id, numberCard, lblNameCard.Text, numberCard, cVV, issueDate, expirationDate);
          infoCard.Show();
        }
    }
}
