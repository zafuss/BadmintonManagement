using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement
{
    public static class UIConstants
    {
        // màu mặc dịnh cho cột được dock bên trái from
        public static readonly Color LeftSideBackColor = Color.LightGray;
        // padding cho text ở button level 1
        public static readonly Padding Level1ButtonPadding = new Padding(14, 0, 0, 0);
        // padding cho text ở button level 2
        public static readonly Padding Level2ButtonPadding = new Padding(46, 0, 0, 0);
        // chiều cao mặc định của button
        public static readonly int DefaultSideButtonHeight = 40;
    }
}
