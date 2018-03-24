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
            int countCheoTren = 0;
            int countCheoDuoi = 0;
            int temp1 = currentRow;
            int temp2 = currentCol;

            if ((currentRow == 0 && currentCol == 0) || (currentCol == 0))
            {
                if (owner == arrayCells[currentRow++, currentCol++].Owned)
                    countCheoTren++;
            }
            else if ((currentRow == 0 && currentCol == (board.NoOfColumn - 1)) || currentRow < 4 && currentCol == (board.NoOfColumn - 1))
                return false;
            else if (currentCol == (board.NoOfColumn - 1) && currentRow >= 4)
            {
                if (owner == arrayCells[currentRow--, currentCol--].Owned)
                    countCheoTren++;
                else
                    return false;
            }
            else if (currentCol == 0 && currentRow >= (board.NoOfRows - 5))
                return false;
            else if (currentRow == (board.NoOfRows - 1) && currentCol < 4)
                return false;
            else
            {
                for (int i = currentRow; i >= 0 && currentCol >= 0; i--)
                {
                    if (owner == arrayCells[currentRow--, currentCol--].Owned)
                        countCheoTren++;
                    else
                        break;
                }

                currentRow = temp1;
                currentCol = temp2;

                for (int i = currentRow; i < board.NoOfRows && currentCol < board.NoOfColumn; i++)
                {
                    if (owner == arrayCells[currentRow++, currentCol++].Owned)
                        countCheoDuoi++;
                    else break;
                }
            }

            return ((countCheoTren + countCheoDuoi) >= 6);
        }


        //đường chéo ngược
        private bool isSecondDiagonal(int currentRow, int currentCol, int owner, Cells[,] arrayCells)
        {
            int countCheoTren = 0;
            int countCheoDuoi = 0;
            int temp1 = currentRow;
            int temp2 = currentCol;


            if ((currentCol == 0 && currentRow <= 3) || (currentRow == 0 && currentCol <= 3))
                return false;

            else if ((currentCol == board.NoOfColumn - 1 && currentRow > board.NoOfRows - 5) ||
                (currentRow == board.NoOfRows - 1 && currentCol > board.NoOfColumn - 5))
                return false;
            //người chơi đánh tại vị trí viền bên phải bàn cờ
            else if ((currentRow == 0 && currentCol == board.NoOfColumn - 1) || currentCol == board.NoOfColumn - 1)
            {
                for (int i = 0; i < board.NoOfRows && currentCol >= 0; i++)
                {
                    if (owner == arrayCells[currentRow++, currentCol--].Owned)
                        countCheoDuoi++;
                    else
                        break;
                }
            }
            // cột bên trái
            else if ((currentCol == 0 && currentRow == board.NoOfRows - 1) || currentCol == 0 && currentRow >= 3)
            {
                for (int i = currentRow; i >= 0 && currentCol >= board.NoOfColumn - 1; i--)
                {
                    if (owner == arrayCells[currentRow--, currentCol++].Owned)
                        countCheoTren++;
                    else
                        break;
                }
            }
            // dòng cuối bàn cờ
            else if (currentRow == board.NoOfRows - 1)
            {
                for (int i = currentRow; i >= 0 && currentCol < board.NoOfColumn; i++)
                {
                    if (owner == arrayCells[currentRow--, currentCol++].Owned)
                        countCheoTren++;
                    else
                        break;
                }
            }
            /*
             *nếu người chơi đánh quân cờ không nằm trên các đường biên của bàn cờ 
             */
            else if (currentRow > 0 && currentCol > 0 && currentRow < board.NoOfRows - 1 && currentCol < board.NoOfColumn - 1)
            {
                for (int i = currentRow; i >= 0 && (currentCol < board.NoOfColumn); i--)
                {
                    if (owner == arrayCells[currentRow--, currentCol++].Owned)
                        countCheoTren++;
                    else
                        break;
                }

                currentRow = temp1;
                currentCol = temp2;

                for (int j = currentRow; j < board.NoOfRows && currentCol >= 0; j++)
                {
                    if (owner == arrayCells[currentRow++, currentCol--].Owned)
                        countCheoDuoi++;
                    else
                        break;
                }
            }

            return (countCheoTren + countCheoDuoi >= 5);
        }
    }
}
