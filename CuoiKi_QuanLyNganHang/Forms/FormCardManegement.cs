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
    internal partial class FormCardManegement : Form
    {
        private Queue<DataRow> temporaryQueue = new Queue<DataRow>();
        private string nameCardAcc = "";
        private string query = "SELECT [NameTK] FROM [TaiKhoan] Where ID = @id";
        private string query2 = "select CardNumber, IssueDate, ExpirationDate, CVV from Cards where ID = @id";
        public FormCardManegement()
        {
            InitializeComponent();
        }
        
        private int id = 0;
        private int count = 0;
        public FormCardManegement(int id)
        {
            InitializeComponent();
            nameCardAcc = HandleSql.GetDataFromDTB(query, id);
            this.id = id;
        }
        //method 
        public void ReLoadForm()
        {
            flowLayoutPanel.Controls.Clear();
            FormCardManegement_Load(this, EventArgs.Empty);
        }

        private void FormCardManegement_Load(object sender, EventArgs e)
        {
            temporaryQueue = HandleSql.GetDataFromDTB0(query2, id);
            count = temporaryQueue.Count;
            int i = 1;
            if (count == 0)
            {
                flowLayoutPanel.Visible = false;
                left.Visible = false;
                right.Visible = false;
                btnCreatCard.Visible = true;
            }
            else
            {
                flowLayoutPanel.Visible = true;
                left.Visible = true;
                right.Visible = true;
                btnCreatCard.Visible = false;
                while (temporaryQueue.Count > 0)
                {
                    i++;
                    string doi = i.ToString();
                    string newFormName = "newcard" + doi;
                    DataRow row = temporaryQueue.Dequeue();
                    string numberCard = row["CardNumber"].ToString();
                    string issueDate = row["IssueDate"].ToString();
                    string expirationDate = row["ExpirationDate"].ToString();
                    string cVV = row["CVV"].ToString();
                    Card name = new Card(id, numberCard, issueDate, expirationDate, cVV, nameCardAcc);
                    flowLayoutPanel.Controls.Add(name);
                }
            }
           
        }
        private int x = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (x >= 0 && x < 488 * (count - 1))
            {
                x += 488;
                flowLayoutPanel.AutoScrollPosition = new System.Drawing.Point(x, flowLayoutPanel.AutoScrollPosition.Y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (x > 0 && x <= 488 * (count -1))
            {
                x -= 488;
                flowLayoutPanel.AutoScrollPosition = new System.Drawing.Point(x, flowLayoutPanel.AutoScrollPosition.Y);
            }
        }

        private void FormCardManegement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Link_card newCard = new Link_card(id);
            newCard.Show();
        }
    }
}
