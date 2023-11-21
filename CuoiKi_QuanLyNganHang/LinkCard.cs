using CuoiKi_QuanLyNganHang.Sql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang
{
    public partial class Link_card : Form
    {
        string query = "SELECT [Sotk]  FROM [TaiKhoan] Where ID = @id";
        string query2 = "SELECT [SoDuTK] FROM [TaiKhoan] Where ID = @id";
        string query3 = "SELECT [NameTk] FROM [TaiKhoan] Where ID = @id";
        private string query4 = "InsertCard @ID , @CardNumber , @SoDuCard , @IssueDate , @ExpirationDate";
        private string linkedAccout = "Linked accout: ";
        DateTime currentTime = DateTime.Now;
        private string dateStart = ""; 
        private string dateEnd = "";
        public Link_card()
        {
            InitializeComponent();
        }

        private int id = 0;
        public Link_card(int id)
        {
            InitializeComponent();
            CenterToScreen();
            rjTextBox1.Visible = false;
            this.id = id;
            txtName.Texts = HandleSql.GetDataFromDTB(query3, id);
            linkedAcc.Text = linkedAccout + HandleSql.GetDataFromDTB(query, id) + " - " + txtName.Texts;
            rjTextBox1.Texts = HandleSql.GetDataFromDTB(query, id);
        }

        private void Link_card_Load(object sender, EventArgs e)
        {
            Blance.Text = rjTextBox1.Texts + " VND";
            dateStart = currentTime.ToString();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            //Draw border
            using (Pen penBorder = new Pen(Color.Black, 3))
            {
                graph.DrawRectangle(penBorder, 0, 0, 606, 560);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CardNumber = GenerateRandomBankNumber();
            int SoduTK = 0;
            dateEnd = currentTime.AddYears(5).ToString();
            DataProvider.Instance.SetDataToCards(query4, new object[] { id, CardNumber, SoduTK, dateStart, dateEnd });
            card_details newcard = new card_details(txtName.Texts, CardNumber, dateStart, dateEnd);
            this.Close();
            newcard.ShowDialog();
        }

        private void Link_card_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        static string GenerateRandomBankNumber()
        {
            Random random = new Random();
            string bankNumber = "";
            for (int i = 4; i > 0; i--)
            {
                int randomValue = random.Next(1000, 9999);
                bankNumber += " " + randomValue.ToString();
            }
            return bankNumber.Substring(1);
        }

    }
}
