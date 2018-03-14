using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    class MyPaint
    {
        public static Pen pen;

        public static SolidBrush sbRed;

        public static SolidBrush sbBlack;

        public static SolidBrush sbSilver;

        public static SolidBrush sbBlue;
        public static Pen GetPen()
        {
            pen = new Pen(Color.LightBlue);
            return pen;
        }

        public static SolidBrush solidRed()
        {
            sbRed = new SolidBrush(Color.Red);
            return sbRed;
        }

        public static SolidBrush solidBlack()
        {
            sbBlack = new SolidBrush(Color.Black);
            return sbBlack;
        }


        public static SolidBrush solidSilver()
        {
            sbSilver = new SolidBrush(Color.Silver);
            return sbSilver;
        }

        public static SolidBrush solidBlue()
        {
            sbBlue = new SolidBrush(Color.Blue);
            return sbBlue;
        }

    }
}
