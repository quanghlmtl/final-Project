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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();          
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            lblTitle.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
            lblFullName.Hide();
            lblCCCD.Hide();
            lblNumberPhone.Hide();
            lblUser.Hide();
        }
        //enter and leave
        private void txt_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Texts == "")
            {
                txtFullName.Padding = new Padding(5, 15, 5, 5);
                txtFullName.Font = new Font("Averta Std CY", 16); 
                this.txtFullName.Texts = "Họ và tên";
                lblFullName.Hide();
            }
            if (txtCCCD.Texts == "")
            {
                txtCCCD.Padding = new Padding(5, 15, 5, 5);
                txtCCCD.Font = new Font("Averta Std CY", 16);
                this.txtCCCD.Texts = "Số CCCD";
                lblCCCD.Hide();
            }
            if (txtNumberPhone.Texts == "")
            {
                txtNumberPhone.Padding = new Padding(5, 15, 5, 5);
                txtNumberPhone.Font = new Font("Averta Std CY", 16);
                this.txtNumberPhone.Texts = "Số điện thoại";
                lblNumberPhone.Hide();
            }
            if (txtUser.Texts == "")
            {
                txtUser.Padding = new Padding(5, 15, 5, 5);
                txtUser.Font = new Font("Averta Std CY", 16);
                this.txtUser.Texts = "Tên tài khoản";
                lblUser.Hide();
            }
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            lblFullName.Show();
            txtFullName.Font = new Font("Averta Std CY", 12);
            txtFullName.Padding = new Padding(5, 25, 5, 5);
            if (txtFullName.Texts == "Họ và tên")
                this.txtFullName.Texts = "";
        }
        private void txt2_Enter(object sender, EventArgs e)
        {
            lblCCCD.Show();
            txtCCCD.Font = new Font("Averta Std CY", 12);
            txtCCCD.Padding = new Padding(5, 25, 5, 5);
            if (txtCCCD.Texts == "Số CCCD")
                this.txtCCCD.Texts = "";
        }

        private void txt3_Enter(object sender, EventArgs e)
        {
            lblNumberPhone.Show();
            txtNumberPhone.Font = new Font("Averta Std CY", 12);
            txtNumberPhone.Padding = new Padding(5, 25, 5, 5);
            if (txtNumberPhone.Texts == "Số điện thoại")
                this.txtNumberPhone.Texts = "";
        }

        private void txt4_Enter(object sender, EventArgs e)
        {
            lblUser.Show();
            txtUser.Font = new Font("Averta Std CY", 12);
            txtUser.Padding = new Padding(5, 25, 5, 5);
            if (txtUser.Texts == "Tên tài khoản")
                this.txtUser.Texts = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
