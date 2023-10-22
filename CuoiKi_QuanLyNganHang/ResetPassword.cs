using System;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.MoreForm;
namespace CuoiKi_QuanLyNganHang
{
    public partial class ResetPassword : Method
    {
        public ResetPassword()
        {
            InitializeComponent();
            //Assign a common Enter event to all textbox
            txtFullName.Enter += ResetPassword_Enter;
            txtCCCD.Enter += ResetPassword_Enter;
            txtNumberPhone.Enter += ResetPassword_Enter;
            txtUser.Enter += ResetPassword_Enter;
        }

        //Event Form load
        private void ResetPassword_Load(object sender, EventArgs e)
        {
            lblTitle.Parent = pictureBox1;
            btnHome.Parent = pictureBox1;
            lblFullName.Hide();
            lblCCCD.Hide();
            lblNumberPhone.Hide();
            lblUser.Hide();           
        }

        //Event toolboxes
        //Enter and leave more toolboxes    
        private void ResetPassword_Enter(object sender, EventArgs e)
        {
            if (sender == txtFullName)
            {
                HandleEnterMoreProperties(sender, e, lblFullName, txtFullName, "Họ và tên");
                 return;
            }
            if (sender == txtCCCD)
            {
                HandleEnterMoreProperties(sender, e, lblCCCD, txtCCCD, "Số CCCD");
                return;
            }
            else if (sender == txtNumberPhone)
            {
                HandleEnterMoreProperties(sender, e, lblNumberPhone, txtNumberPhone, "Số điện thoại");
                return;
            }
            else if (sender == txtUser)
            {
                HandleEnterMoreProperties(sender, e, lblUser, txtUser, "Tên tài khoản");
                return;
            }
        }
        private void ResetPassword_Leave(object sender, EventArgs e)
        {
            HandleEmpty(txtFullName, lblFullName, "Họ và tên", false);
            HandleEmpty(txtCCCD, lblCCCD, "Số CCCD", false);
            HandleEmpty(txtNumberPhone, lblNumberPhone, "Số điện thoại", false);
            HandleEmpty(txtUser, lblUser, "Tên tài khoản", false);
        }

        //Button home
        private void btnHome_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
        }

        //Event close form
        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
