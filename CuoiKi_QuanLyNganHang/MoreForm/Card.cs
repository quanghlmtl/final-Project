using System;
using System.Collections;
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
        DataRow temporaryQueue;
        public Card()
        {
            InitializeComponent();
        }
        public Card(DataRow data, string name)
        {
            InitializeComponent();
            lblNameCard.Text = name;
            temporaryQueue = data;
        }

        private string numberCard = "";
        private string issueDate = "";
        private string expirationDate = "";
        private string cVV = "";
        private void Card_Load(object sender, EventArgs e)
        {
            numberCard = temporaryQueue[0].ToString();
            issueDate = temporaryQueue[1].ToString();
            expirationDate = temporaryQueue[2].ToString();
            cVV = temporaryQueue[3].ToString();
            lblNameCard.Text = numberCard;
            //lblNumberCard_TextChanged(sender, e);
        }
        private void lblNumberCard_TextChanged(object sender, EventArgs e)
        {
            //string formattedText = FormatLblNumberCard();
            //lblNumberCard.Text = formattedText;
        }

        //method 
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
            card_details infoCard = new card_details();
            infoCard.Show();
        }
    }
}
