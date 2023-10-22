using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomTextBox : TextBox
{
    public CustomTextBox()
    {
        this.Size = new System.Drawing.Size(150, 30);

        // Đặt font mặc định
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
    }
}
