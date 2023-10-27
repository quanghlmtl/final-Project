using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi_QuanLyNganHang.Forms
{
    public partial class FormNotifications : Form
    {
        public FormNotifications()
        {
            InitializeComponent();
           
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
        }

        private void FormNotifications_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
