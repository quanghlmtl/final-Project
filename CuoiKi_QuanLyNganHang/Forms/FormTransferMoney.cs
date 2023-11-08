using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormTransferMoney : Method
    {
        string query = "SELECT [NameBank] FROM [Bank]";
        string query2 = "SELECT [SoDuTK] FROM [TaiKhoan] Where ID = @id";
        string query3 = "[CHECK_ACCOUNT_EXISTENCE] @sotk  , @nameBank";

        private int id = 0;
        private string name = "";
        private string checkNumberBank;
        public FormTransferMoney()
        {
            InitializeComponent();
        }
        public FormTransferMoney(int id, string name)
        {
            this.id = id;
            this.name = name;
            InitializeComponent();
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
            txtBank.Text = "";
            txtBankNumber.Texts = "";
            txtMoney.Texts = "";
            txtContent.Texts = "";
        }
        
        //event
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtMoney.Texts)))
            {
                int money = int.Parse(txtMoney.Texts);
                if (money < 1000)
                    MessageBox.Show("Số tiền quá bé vui lòng chuyển tiền lớn hơn 1.000 vnđ");
            }
            else
            {
                MessageBox.Show("error");
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
                    if (checkNumberBank == "null")
                    {
                        MessageBox.Show("Số tài khoản bạn nhập không tồn tại");
                        lblName.Text = "";
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

        private string contentTo = "";
        public string contentFrom = "";

        private void txtMoney_Leave(object sender, EventArgs e)
        {
            contentTo = "Chuyển tiền đến " + lblName.Text;
            contentFrom = "Nhận tiền từ " + name;
            txtContent.Texts = contentTo;
        }

        private void txtContent_Leave(object sender, EventArgs e)
        {
            string content = contentTo;
            if(txtContent.Texts == "")
            {
                txtContent.Texts = content;
                contentTo = content;
            }
            else if(contentTo != txtContent.Texts)
            {
                contentTo = txtContent.Texts;
            }
        }
    }
}
