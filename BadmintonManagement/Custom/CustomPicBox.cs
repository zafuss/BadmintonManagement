using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Custom
{
    public class CustomPicBox : PictureBox
    {
        // Tạo thuộc tính độ rộng cho viền của picturebox
        public int BorderWidth { get; set; } = 1;
        // Tạo thuộc tính màu  viền cho picturebox
        public Color BorderColor { get; set; } = Color.Black;


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                pe.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
            }
        }

    }
}
