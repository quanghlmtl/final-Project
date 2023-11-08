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
        string query3 = "CHECK_ACCOUNT_EXISTENCE @sotk";

        private int id = 0;
        private string checkNumberBank;
        public FormTransferMoney()
        {
            InitializeComponent();
        }
        public FormTransferMoney(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void FormTransferMoney_Load(object sender, EventArgs e)
        {
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
            //if(string.IsNullOrEmpty(txtBank.Text))
            //{
            //    MessageBox.Show("Chưa chọn ngân hàng!", "Thông báo!", MessageBoxButtons.OK);
            //    txtBank.Focus();
            //}
            //else if (string.IsNullOrEmpty(txtBankNumber.Text))
            //{
            //    MessageBox.Show("Chưa chọn số tài khoản!", "Thông báo!", MessageBoxButtons.OK);
            //    txtBankNumber.Focus();
            
            //    lblName1.Visible = true;
            //    lblName.Visible = true;
            //      
            //}
            //else if (string.IsNullOrEmpty(txtMoney.Text))
            //{
            //    MessageBox.Show("Chưa chọn số tiền cần chuyển!", "Thông báo!", MessageBoxButtons.OK);
            //    txtMoney.Focus();
            //}
            //else
            //{
                //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn chuyển tiền?", "Xác nhận", MessageBoxButtons.YesNo);
                //if (result == DialogResult.Yes)
                //{
                //    MessageBox.Show("Chuyển tiền thành công!", "Thông báo!", MessageBoxButtons.OK);
                //    Reset();
                //}
            //}
        }

        private void txtBankNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBankNumber.Text))
            {
                int numberBank = int.Parse(txtBankNumber.Texts);
                checkNumberBank = HandleSql.GetDataFromDTB(query3, numberBank);
                if (checkNumberBank != "null")
                {
                    lblName.Text = checkNumberBank;
                }
                else
                {
                    MessageBox.Show("Số tài khoản bạn nhập không tồn tại");
                }
            }
            
        }
    }
}
