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
    public partial class FormInformation : Method
    {
        public FormInformation()
        {
            InitializeComponent();
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {
            txtPassword1.Enabled = false;
        }
        //hidden
        private void hidden_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword1, "");
        }

        private void hidden_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword1, "Mật khẩu");
        }

        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }

        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }
        //btn Change
        private void btnChange_Click(object sender, EventArgs e)
        {
            VisualChange();
            txtPassword1.Enabled = true;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtPassword1.Texts!=txtPassword2.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo!", MessageBoxButtons.RetryCancel);
            }
            else
            {
                MessageBox.Show("Thay đổi thành công!", "Thông báo!", MessageBoxButtons.OK);
                VisualChange();
            }
        }
        private void VisualChange()
        {
            btnChange.Visible = !btnChange.Visible;
            lblConfirmPass.Visible = !lblConfirmPass.Visible;
            txtPassword2.Visible = !txtPassword2.Visible;
            presently1.Visible = !presently1.Visible;
            hidden1.Visible = !hidden1.Visible;
            btnConfirm.Visible = !btnConfirm.Visible;
        }
    }
}
