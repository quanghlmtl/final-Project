using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;

using Application = System.Windows.Forms.Application;

namespace CuoiKi_QuanLyNganHang
{
    public partial class card_details : Method
    {
        bool inforCard = false;
        private int id = 0;
        private string query = "delete from cards where CardNumber = @cardNumber";
        private string query2 = "select CVV from Cards where CardNumber = @cardNumber";
        public card_details()
        {
            InitializeComponent();
            CenterToScreen();
        }

        void setTB()
        {
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
            tb4.Enabled = false;
            tb1.BackColor = Color.White;
            tb2.BackColor = Color.White;
            tb3.BackColor = Color.White;
            tb4.BackColor = Color.White;
        }
        public card_details(int id, string data1, string data2, string data3, string data4, string data5, string data6)
        {
            InitializeComponent();
            CenterToScreen();
            this.id = id;
            lblNumberCard.Text = data1;
            lblNameCard.Text = data2;
            tb1.Texts = data3;
            tb2.Texts = data4;
            tb3.Texts = handleDate(data5);
            tb4.Texts = handleDate(data6);
            setTB();
            inforCard = true;
        }
        private string numberB = "";
        string name = "";
        public card_details(string name, string numberBank, string dateStart, string dateEnd)
        {
            InitializeComponent();
            CenterToScreen();
            lblNumberCard.Text = tb1.Texts = numberBank;
            lblNameCard.Text = name;
            tb2.Texts = HandleSql.HandleDatafromCards(query2, numberBank);
            tb3.Texts = handleDate(dateStart);
            tb4.Texts = handleDate(dateEnd);
            setTB();
        }
        private void card_details_Load(object sender, EventArgs e)
        {
            if (inforCard)
                btnSave.Text = "Return";
            else
            {
                btnSave.Text = "Save";
                label9.Visible = false;
            }
        }
        //method 
        string handleDate(string date)
        {
            string[] itemDate = date.Split(' ');
            return itemDate[2] + "/" + itemDate[3];
        }
        private void card_details_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (inforCard)
            {
                if (MessageBox.Show("Bạn có chắc chắc muốn xóa thẻ ngân hàng này không?", "Xóa thẻ ngân hàng",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    HandleSql.HandleDatafromCards(query, tb1.Texts);
                    this.Close();
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is FormCardManegement)
                        {
                            ((FormCardManegement)form).ReLoadForm();
                        }
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!inforCard)
            {
                this.Close();
                foreach (Form form in Application.OpenForms)
                {
                    if (form is FormCardManegement)
                    {
                        ((FormCardManegement)form).ReLoadForm();
                    }
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using (Pen penBorder = new Pen(Color.Black, 3))
            {
                graph.DrawRectangle(penBorder, 0, 0, 810, 498);
            }
        }
    }
}
