using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KONTROL
{
    internal class StyleRoundButtons : Button
    {
        //Скругление углов кнопки из системной библиотеки
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr RoundButton(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthRect, int nHeightEllipse);

        protected override void OnPaint(PaintEventArgs r)
        {
            base.OnPaint(r);
            IntPtr ptr = RoundButton(0, 0, Width, Height, 1, 1);
            Region = Region.FromHrgn(ptr);
        }
    }
}
