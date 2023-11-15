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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            //if (menuExpand == false)
            //{
            //    menuContainer.Height += 100;
            //    if (menuContainer.Height >= 196)
            //    {
            //        menuTransition.Stop();
            //        menuExpand = true;
            //    }
            //    else
            //    {
            //        menuContainer.Height -= 100;
            //        if (menuContainer.Height <= 60)
            //        {
            //            menuTransition.Stop();
            //            menuExpand = false;
            //        }
            //    }
            //}
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void transition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menu.Height += 100;
                if (menu.Height >= 149)
                {
                    transition.Stop();
                    menuExpand = true;
                }
                else
                {
                    menu.Height -= 100;
                    if (menu.Height <= 49)
                    {
                        transition.Stop();
                        menuExpand = false;
                    }
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        { 
            transition.Start();
        }
    }
}
