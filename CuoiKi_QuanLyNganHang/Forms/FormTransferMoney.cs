using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang
{
    public partial class FormTransferMoney : Form
    {
        public FormTransferMoney()
        {
            InitializeComponent();
        }
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
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn chuyển tiền?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Chuyển tiền thành công!", "Thông báo!", MessageBoxButtons.OK);
                    Reset();
                }
            //}
        }
        private void Reset()
        {
            txtBank.Text = "";
            txtBankNumber.Texts = "";
            txtMoney.Texts = "";
            txtContent.Texts = "";
        }

    }
}
