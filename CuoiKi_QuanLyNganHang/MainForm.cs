using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Class;

namespace CuoiKi_QuanLyNganHang
{
    public partial class MainForm : Form
    {
        private List<ur> c;
        public MainForm()
        {
            //this.InitializeComponent();
            //this.lblUserName.Text = "No login";
        }
        public MainForm(ur user)
        {
            //this.InitializeComponent();
            //this.InitializeItems();
            //this.userConnected = user;
            //this.lblUserName.Text = user.FirstName + " " + user.LastName;
            //this.pbProfilePicture.Image = user.ProfilePicture;
        }
    }
}
