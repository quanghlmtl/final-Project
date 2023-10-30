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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void setToolBoxs(bool value)
        {
            lblDate.Visible = value;
            lblKeyWord.Visible = value;
            lblBank.Visible = value;
            lblFrom.Visible = value;
            cbListBanks.Visible = value;
            txtKeyWord.Visible = value;
            dateTime2.Visible = value;
            dateTime2.Visible = value;
            btnSearch2.Visible = value;
            btnRefresh.Visible = value;
            btnBack.Visible = value;
            value = !value;
            btnNewUser.Visible = value;
            btnSearch.Visible = value;
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
           setToolBoxs(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            setToolBoxs(false);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormNewAccount newAccount = new FormNewAccount();
            newAccount.HideHomeButton();
            newAccount.Show();
        }

    }
}
