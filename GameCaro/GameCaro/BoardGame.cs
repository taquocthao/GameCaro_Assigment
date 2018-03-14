using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    class BoardGame
    {
        private int numberOfRow;
        private int numberOfColumn;

        public BoardGame() 
        {
            
        }
        public BoardGame(int rows, int column)
        {
            this.numberOfRow = rows;
            this.numberOfColumn = column;
        }

        public int NoOfRows
        {
            get { return numberOfRow; }
            set { numberOfRow = value; }
        }

        public int NoOfColumn
        {
            get { return numberOfColumn; }
            set { numberOfColumn = value; }
        }


        // vẽ các đường dọc, ngang trong bàn cờ (Vẽ Bàn cờ)
        public void DrawBoardGame(Graphics g)
        {
            // vẽ các đường dọc
            for (int i = 0; i <= numberOfColumn; i++)
            {
                g.DrawLine(MyPaint.GetPen(), i * Cells.WIDTH, 0, i * Cells.WIDTH, numberOfRow * Cells.HEIGHT);
            }
            // vẽ đường ngang
            for (int j = 0; j <= numberOfRow; j++)
            {
                g.DrawLine(MyPaint.GetPen(), 0, j * Cells.HEIGHT, numberOfColumn * Cells.WIDTH, j * Cells.HEIGHT);
            }

        }

        //vẽ quân cờ
        public void DrawPawn(Graphics g, Point point, SolidBrush sb)
        {
            g.FillEllipse(sb, point.X + 2, point.Y + 2, Cells.WIDTH - 4, Cells.HEIGHT - 4);
        }



    }
}
