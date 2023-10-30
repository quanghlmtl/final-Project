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
namespace CuoiKi_QuanLyNganHang
{
    public partial class FormNewAccount : Method
    {
        public FormNewAccount()
        {
            InitializeComponent();
            lblNewAcc.Parent = pictureBox1;
            lblMessage.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
        }

        public void HideHomeButton()
        {
            btnHome.Visible = false;
        }
        //Event toolboxs
        //Button click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ( CheckNullOrWhiteSpace(txtName, lblMessage, "Họ và tên", "full name"))
                return;
            else if ( CheckNullOrWhiteSpace(txtCCCD, lblMessage, "Số CCCD", "citizen identification"))
                return;
            else if (CheckNullOrWhiteSpace(txtPhoneNumb, lblMessage, "Số điện thoại", "phone number"))
                return;
            else if (CheckNullOrWhiteSpace(txtUsername, lblMessage, "Tên tài khoản", "username"))
                return;
            else if (CheckNullOrWhiteSpace(txtPassword1, lblMessage, "Mật khẩu", "password"))
                return;
            else if (CheckNullOrWhiteSpace(txtPassword2, lblMessage, "Nhập lại mật khẩu", "password again"))
                return;
            if (txtPassword2.Texts != txtPassword1.Texts)
            {
                this.lblMessage.Visible = true;
                this.lblMessage.Text = "*Those passwords didn’t match. Try again.";
                txtPassword2.Focus();
                return;
            }
            else lblMessage.Visible = false;
        }

        //Hidden password
        private void hidden1_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword1, "Mật khẩu");
        }
        private void hidden1_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword1, "Mật khẩu");
        }
        private void hidden2_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }
        private void hidden2_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword2, "Nhập lại mật khẩu");
        }

        //Hover username, password 
        private void NewAccount_Enter(object sender, EventArgs e)
        {
            if (sender == txtName)
            {
                HandleEnter(sender, e, txtName, "Họ và tên", false);
                return;
            }
            else if (sender == txtCCCD)
            {
                HandleEnter(sender, e, txtCCCD, "Số CCCD", false);
                return;
            }
            else if (sender == txtPhoneNumb)
            {
                HandleEnter(sender, e, txtPhoneNumb, "Số điện thoại", false);
                return;
            }
            else if (sender == txtUsername)
            {
                HandleEnter(sender, e, txtUsername, "Tên tài khoản", false);
                return;
            }
        }
        private void txtPassword1_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtPassword1, "Mật khẩu", true);
        }
        private void txtPassword2_Enter(object sender, EventArgs e)
        {
            HandleEnter(sender, e, txtPassword2, "Nhập lại mật khẩu", true);
        }
        private void NewAccount_Leave(object sender, EventArgs e)
        {
            HandleLeave(sender, e, txtName, "Họ và tên", false);
            HandleLeave(sender, e, txtCCCD, "Số CCCD", false);
            HandleLeave(sender, e, txtPhoneNumb, "Số điện thoại", false);
            HandleLeave(sender, e, txtUsername, "Tên tài khoản", false);
            HandleLeave(sender, e, txtPassword1, "Mật khẩu", true);
            HandleLeave(sender, e, txtPassword2, "Nhập lại mật khẩu", true);
        }

        //Btn home
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        //Event form
        //Close form
        private void FormNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
