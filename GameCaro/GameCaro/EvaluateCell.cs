using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    class EvaluateCell
    {
        public static long[] ATTACK_SCORE = { 0, 3, 24, 192, 1536, 12288, 98304 };
        public static long[] DENFENSE_SCORE = { 0, 1, 9, 81, 729, 6561, 59049 };
        private BoardGame board;
        public EvaluateCell()
        {
            board = new BoardGame(19, 19);
        }

        

        public long AttackScore(int currentRow, int currentColumn, Cells[,] arrayCells)
        {
            long score = AttackVertical(currentRow, currentColumn, arrayCells) + AttackHorizal(currentRow, currentColumn, arrayCells)
                + AttackMainDiagonal(currentRow, currentColumn, arrayCells) + AttackSecondDiagonal(currentRow, currentColumn, arrayCells);
             return score;
        }

        public long DenfenseScore(int currentRow, int currentColumn, Cells[,] arrayCells)
        {
            long score = DenfenseVertical(currentRow, currentColumn, arrayCells) + DenfenseHorizal(currentRow, currentColumn, arrayCells)
                + DenfenseMainDiagonal(currentRow, currentColumn, arrayCells) + DenfenseSecondDiagonal(currentRow, currentColumn, arrayCells);
            return score;
        }


        #region attack
        private long AttackVertical(int currentRow, int currentColumn,Cells[,] arrayCells)
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentRow + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow + Dem, currentColumn].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow + Dem, currentColumn].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentRow - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow - Dem, currentColumn].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow - Dem, currentColumn].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            if (countPlayer == 2)
                return 0;
            score -= DENFENSE_SCORE[countPlayer + 1];
            score += ATTACK_SCORE[countComputer];
            return score;
        }

        private long AttackHorizal(int currentRow, int currentColumn,Cells[,] arrayCells)
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow, currentColumn + Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow, currentColumn - Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            if (countPlayer == 2)
                return 0;
            score -= DENFENSE_SCORE[countPlayer + 1];
            score += ATTACK_SCORE[countComputer];
            return score;
        }

        private long AttackMainDiagonal(int currentRow, int currentColumn,Cells[,] arrayCells) // "/"
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfColumn && currentRow + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0 && currentRow - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            if (countPlayer == 2)
                return 0;
            score -= DENFENSE_SCORE[countPlayer + 1];
            score += ATTACK_SCORE[countComputer];
            return score;
        }

        private long AttackSecondDiagonal(int currentRow, int currentColumn, Cells[,] arrayCells) // "\"
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfColumn && currentRow + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0 && currentRow - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 1)
                    countComputer++;
                else if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                    break;
                }
                else
                    break;

            }
            if (countPlayer == 2)
                return 0;
            score -= DENFENSE_SCORE[countPlayer + 1];
            score += ATTACK_SCORE[countComputer];
            return score;
        }

        #endregion

        #region denfense

        private long DenfenseVertical(int currentRow, int currentColumn, Cells[,] arrayCells)
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentRow + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow + Dem, currentColumn].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow + Dem, currentColumn].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentRow - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow - Dem, currentColumn].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow - Dem, currentColumn].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            if (countComputer == 2)
                return 0;
            score += DENFENSE_SCORE[countPlayer];
            return score;
        }

        private long DenfenseHorizal(int currentRow, int currentColumn, Cells[,] arrayCells)
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow, currentColumn + Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow, currentColumn - Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }
                else if (arrayCells[currentRow, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            if (countComputer == 2)
                return 0;
            score += DENFENSE_SCORE[countPlayer];
            return score;
        }

        private long DenfenseMainDiagonal(int currentRow, int currentColumn, Cells[,] arrayCells) // "/"
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfRows; Dem++)
            {
                if (arrayCells[currentRow, currentColumn + Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow, currentColumn - Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }
                else if (arrayCells[currentRow, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            if (countComputer == 2)
                return 0;
            score += DENFENSE_SCORE[countPlayer];
            return score;
        }

        private long DenfenseSecondDiagonal(int currentRow, int currentColumn, Cells[,] arrayCells) // "\"
        {
            int countPlayer = 0;
            int countComputer = 0;
            long score = 0;
            for (int Dem = 1; Dem < 6 && currentColumn + Dem < board.NoOfColumn && currentRow + Dem < board.NoOfRows; Dem++)
            {

                if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow + Dem, currentColumn + Dem].Owned == 2)
                {
                    countPlayer++;

                }
                else
                    break;

            }
            for (int Dem = 1; Dem < 6 && currentColumn - Dem >= 0 && currentRow - Dem >= 0; Dem++)
            {
                if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 1)
                {
                    countComputer++;
                    break;
                }

                else if (arrayCells[currentRow - Dem, currentColumn - Dem].Owned == 2)
                {
                    countPlayer++;
                }
                else
                    break;

            }
            if (countComputer == 2)
                return 0;
            score += DENFENSE_SCORE[countPlayer];
            return score;
        }

        #endregion


    }
}
