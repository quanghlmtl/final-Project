using System;
using System.Drawing;
using System.Windows.Forms;
using CuoiKi_QuanLyNganHang.Properties;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CuoiKi_QuanLyNganHang.Class
{
    public class cbBorder : ComboBox
    {

        private Color _borderColor = Color.MediumSlateBlue;
        private int _borderSize = 2;
        private bool _underLinedStyle = false;
        public cbBorder()
        {
            this.Font = new Font("Averta Std CY", 10f);
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(100, 20);
            this.ForeColor = Color.White;
            this._underLinedStyle = true;
            this.Padding = new Padding(7,7,7,7);
        }
        [Category("Custom Advance")]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public int BorderSize
        {
            get
            {
                return _borderSize;
            }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custom Advance")]
        public bool UnderLinedStyle
        {
            get
            {
                return _underLinedStyle;
            }
            set
            {
                _underLinedStyle = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (_underLinedStyle)//line style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else//normal style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
    }
}
