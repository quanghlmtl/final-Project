using System;
using System.Drawing;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Properties;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CuoiKi_QuanLyNganHang.Class
{
    public class lineShape : Label
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;

        public lineShape()
        {
            this.Font = new Font("Averta Std CY", 10f);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Transparent;
            this.Size = new Size(100, 20);
            this.ForeColor = Color.White;
            this.underLinedStyle = true;
            this.Padding = new Padding(7,7,7,7);
        }

        [Category("Custom Advance")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public bool UnderLinedStyle
        {
            get
            {
                return underLinedStyle;
            }
            set
            {
                underLinedStyle = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underLinedStyle)//line style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else//normal style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
    }
}