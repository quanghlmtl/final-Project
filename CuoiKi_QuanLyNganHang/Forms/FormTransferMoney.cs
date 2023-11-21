using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
using CuoiKi_QuanLyNganHang.Sql;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormTransferMoney : Method
    {
        private static int IDGD = 11100;
        private static int IDTO = 0;
        private int MONEY;
        private int Money2;
        private static string date = "";
        private int id = 0;
        private string name = "";
        private string checkNumberBank;
        string query = "SELECT [NameBank] FROM [Bank]";
        string query2 = "SELECT [SoDuTK] FROM [TaiKhoan] Where ID = @id";
        string query5 = "SELECT [ID] FROM [TaiKhoan] Where Sotk = @sotk";
        string query3 = "[CHECK_ACCOUNT_EXISTENCE] @sotk  , @nameBank";
        string query4 = "[INSERT_GIAODICH] @IDGD , @IDTo , @IDFrom , @SoTien , @DateGD , @Notes";

        public FormTransferMoney()
        {
            InitializeComponent();
        }
        public FormTransferMoney(int id, string name)
        {
            this.id = id;
            this.name = name;
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
            timer1.Tick += timer1_Tick;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            date = currentTime.ToString("dd/MM/yyyy");
        }
        private void FormTransferMoney_Load(object sender, EventArgs e)
        {
            txtAccountBalance.Enabled = false;
            lblName.Enabled = false;
            txtBank.Texts = HandleSql.GetDataFromDTB(query, txtBank);
            txtAccountBalance.Texts = HandleSql.GetDataFromDTB(query2, id);
        }
        //method
        private void Reset()
        {
            txtBankNumber.Texts = "";
            txtMoney.Texts = "";
            lblName.Text = "";
            txtContent.Texts = "";
        }
        //event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMoney.Texts) && !string.IsNullOrEmpty(txtBankNumber.Texts))
            {
                IDTO = HandleSql.GetDataFromDTB2(query5, int.Parse(txtBankNumber.Texts));

                string txtmoney = txtMoney.Texts.Replace(".", "");
                money = int.Parse(txtmoney);
                MONEY = money;
                Money2 = -MONEY;
                IDGD++;
                DataProvider.Instance.SetDataToGiaoDich(query4, IDGD, IDTO, id, MONEY, date, contentTo);
                DataProvider.Instance.UpdateBalance(Money2, id);
                DataProvider.Instance.UpdateBalance(MONEY, IDTO);
                txtAccountBalance.Texts = HandleSql.GetDataFromDTB(query2, id);
                Reset();
                CustomMessageBox message = new CustomMessageBox("Chuyển tiền thành công.");
                message.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }

        private void txtBank_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBankNumber.Texts))
            {
                int numberBank = 0;
                if (int.TryParse(txtBankNumber.Texts, out numberBank))
                {
                    checkNumberBank = HandleSql.GetDataFromDTB(query3, numberBank, txtBank.Texts);
                    if (checkNumberBank != "null")
                    {
                        lblName.Enabled = true;
                        lblName.Text = checkNumberBank;
                        contentTo = name + " Chuyển tiền";
                        txtContent.Texts = contentTo;
                    }
                }
            }
        }
        private void txtBankNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBankNumber.Texts))
            {
                int numberBank = 0;
                if (int.TryParse(txtBankNumber.Texts, out numberBank))
                {
                    checkNumberBank = HandleSql.GetDataFromDTB(query3, numberBank, txtBank.Texts);
                    if (checkNumberBank != "null")
                    {
                        lblName.Enabled = true;
                        lblName.Text = checkNumberBank;
                        contentTo = name + " Chuyển tiền";
                        txtContent.Texts = contentTo;
                    }
                    else
                    {
                        MessageBox.Show("Số tài khoản bạn nhập không tồn tại");
                        lblName.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Số tài khoản bạn nhập không hợp lệ");
                    lblName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Số tài khoản không được để trống");
                lblName.Text = "";
            }

        }
        private int money = 0;
        private string contentTo = "";
        private static string content = "";
        private void txtMoney_Leave(object sender, EventArgs e)
        {
            if (txtMoney.Texts != "")
            {
                string txtmoney = txtMoney.Texts.Replace(".", "");
                money = int.Parse(txtmoney);
                if (money < 1000)
                {
                    MessageBox.Show("Số tiền quá bé, vui lòng chuyển tiền lớn hơn 1.000 vnđ");
                }
            }
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            content = contentTo;
            if (txtContent.Texts == "")
            {
                txtContent.Texts = contentTo;
            }
            else if (content != txtContent.Texts)
            {
                content = txtContent.Texts;
            }
        }
       
    }
}
