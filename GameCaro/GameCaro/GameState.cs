using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    class GameState
    {

        private BoardGame board;

        public GameState()
        {
            board = new BoardGame(19, 19);
        }
        public bool isEndGame(int currentRow, int currenCol, int owner, Cells[,] arrayCells)
        {
            if (isEndGameInVertical(currentRow, currenCol, owner, arrayCells) || isEndGameInHorizal(currentRow, currenCol, owner, arrayCells)
                || isMainDiagonal(currentRow, currenCol, owner, arrayCells) || isSecondDiagonal(currentRow, currenCol, owner, arrayCells))
                return true;
            return false;
        }

        private bool isEndGameInVertical(int currentRow, int currentCol, int owner, Cells[,] arrayCells)
        {
            int countTop = 0;
            int countBottom = 0;
            int temp = currentRow;
            for (int i = currentRow; i >= 0; i--)
            {
                if (arrayCells[currentRow--, currentCol].Owned == owner)
                {
                    countTop++;
                }
                else
                    break;
            }
            currentRow = temp;

            for (int j = currentRow; j < board.NoOfRows; j++)
            {
                if (arrayCells[currentRow++, currentCol].Owned == owner)
                    countBottom++;
                else
                    break;
            }
            return (countTop + countBottom >= 6);
        }
        //kiểm tra kết thúc theo chiều ngang
        private bool isEndGameInHorizal(int currentRow, int currenCol, int owner, Cells[,] arrayCells)
        {
            int countLeft = 0;
            int countRight = 0;
            int temp = currenCol;
            for (int i = currenCol; i >= 0; i--)
            {
                if (arrayCells[currentRow, currenCol--].Owned == owner)
                {
                    countLeft++;
                }
                else
                    break;
            }
            currenCol = temp;
            for (int j = currenCol; j < board.NoOfColumn; j++)
            {
                if (arrayCells[currentRow, currenCol++].Owned == owner)
                    countRight++;
                else
                    break;
            }
            return (countLeft + countRight >= 6);
        }

        // duyệt đường chéo xuôi
        private bool isMainDiagonal(int currentRow, int currentCol, int owner, Cells[,] arrayCells)
        {
            int countUp = 0;
            int countDown = 0;         

            for (int i = 1; i < 6 && currentRow - i >= 0 && currentCol - i >= 0; i++)
            {
                if (owner == arrayCells[currentRow - i, currentCol - i].Owned)
                    countUp++;
                else
                    break;
            }
            for (int i = 0; i < 6 && currentRow + i < board.NoOfRows && currentCol + i < board.NoOfColumn; i++)
            {
                if (owner == arrayCells[currentRow + i, currentCol + i].Owned)
                    countDown++;
                else
                    break;
            }
                return ((countUp + countDown) >= 5);
        }


        //đường chéo ngược
        private bool isSecondDiagonal(int currentRow, int currentCol, int owner, Cells[,] arrayCells)
        {
            int countUp = 0;
            int countDown = 0;

            for (int i = 1; i < 6 && currentCol + i < board.NoOfColumn && currentRow - i >= 0; i++)
            {
                if (owner == arrayCells[currentRow - i, currentCol + i].Owned)
                    countUp++;
                else
                    break;
            }

            for (int i = 0; i < 6 && currentRow + i < board.NoOfRows && currentCol - i >= 0; i++ )
            {
                if (owner == arrayCells[currentRow + i, currentCol - i].Owned)
                    countDown++;
                else
                    break;
            }

            return ((countUp + countDown) >= 5);
        }
    }
}
