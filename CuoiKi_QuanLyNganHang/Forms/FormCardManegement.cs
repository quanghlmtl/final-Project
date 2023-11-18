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
        private Queue<DataRow> temporaryQueue;
        private string nameCardAcc = "";
        private string query = "SELECT [NameTK] FROM [TaiKhoan] Where ID = @id";
        private string query2 = "select CardNumber, IssueDate, ExpirationDate, CVV from Cards where ID = @id";
        public FormCardManegement()
        {
            InitializeComponent();
        }
        public FormCardManegement(int id)
        {
            InitializeComponent();
            nameCardAcc = HandleSql.GetDataFromDTB(query, id);
            temporaryQueue = HandleSql.GetDataFromDTB0(query2, id);
        }

        private void FormCardManegement_Load(object sender, EventArgs e)
        {
            int i = 2;
            Card newcard1 = new Card();
            flowLayoutPanel.Controls.Add(newcard1);
            newcard1.Hide();
            while (temporaryQueue.Count > 0)
            {
                i++;
                string doi = i.ToString();
                string newFormName = "newcard" + doi;
                DataRow row = temporaryQueue.Dequeue();
                Card name = new Card(row, nameCardAcc);
                flowLayoutPanel.Controls.Add(name);
            }
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
    }
}
