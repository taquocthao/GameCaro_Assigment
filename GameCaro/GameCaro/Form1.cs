﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {

        private BoardGame board;

        private GameState state;

        private Cells[,] arrayCells;

        private Stack<Cells> cacNuocDaDi;

        private int turn = 1;

        private Graphics g;

        private bool ready = false;

        private int playWith = 0; // chơi với người = 1, với máy bằng 2

        private SoundPlayer soundNewGame;

        private EvaluateCell eval;

        public Form1()
        {
            InitializeComponent();
            init();
        }
        //hàm khởi tạo
        public void init()
        {
            board = new BoardGame(19, 19);
            state = new GameState();
            //InitArrayCells();
            cacNuocDaDi = new Stack<Cells>();
            g = pnlBanCo.CreateGraphics();
            soundNewGame = new SoundPlayer(Properties.Resources.NewGame);
            eval = new EvaluateCell();
        }

        // khởi tạo mảng ô cờ
        public void InitArrayCells()
        {
            arrayCells = new Cells[board.NoOfRows, board.NoOfColumn];
            for (int i = 0; i < board.NoOfRows; i++)
            {
                for (int j = 0; j < board.NoOfColumn; j++)
                {
                    arrayCells[i, j] = new Cells(i, j, new Point(j * Cells.WIDTH, i * Cells.HEIGHT), 0);
                }
            }
        }
        // hàm đánh cờ
        public bool Chess(Graphics g, int x, int y)
        {
            if ((x % Cells.WIDTH == 0) || (y % Cells.HEIGHT == 0))
                return false;
            int col = x / Cells.WIDTH;
            int row = y / Cells.HEIGHT;
            if (arrayCells[row, col].Owned != 0)
                return false;
            switch (turn)
            {
                case 1:
                    arrayCells[row, col].Owned = 1;
                    board.DrawPawn(g, arrayCells[row, col].Location, MyPaint.solidBlack());
                    turn = 2;
                    break;
                case 2:
                    arrayCells[row, col].Owned = 2;
                    board.DrawPawn(g, arrayCells[row, col].Location, MyPaint.solidRed());
                    turn = 1;
                    break;
            }
            Cells cells = new Cells(arrayCells[row, col].Rows, arrayCells[row, col].Column, arrayCells[row, col].Location, arrayCells[row, col].Owned);
            cacNuocDaDi.Push(cells);
            return true;
        }
    

       // vẽ lại các quân cờ - Trường hợp người chơi nhấn vào nút minimum
        public void DrawPawnAgain(Graphics gr)
        {
            foreach (Cells cel in cacNuocDaDi)
            {
                if (cel.Owned == 1)
                    board.DrawPawn(gr, cel.Location, MyPaint.solidBlack());
                else if (cel.Owned == 2)
                    board.DrawPawn(gr, cel.Location, MyPaint.solidRed());
            }
        }

        //hàm kiểm tra chiến thắng
        private bool IsEndGame()
        {
            Cells cell = cacNuocDaDi.Peek();
            if (cacNuocDaDi.Count == 0)
                return false;
            if (cacNuocDaDi.Count == board.NoOfRows * board.NoOfColumn)
            {
                MessageBox.Show("Hòa cờ");
                return true;
            }
            if (state.isEndGame(cell.Rows, cell.Column, cell.Owned, arrayCells))
            {
                if (cell.Owned == 1)
                {
                    MessageBox.Show("Quân đen chiến thắng!");
                    
                }
                else if (cell.Owned == 2)
                {
                    MessageBox.Show("Quân đỏ chiến thắng!");
                }
                ready = false;
                return true;
            }
            return false;
        }


        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            board.DrawBoardGame(g);
            DrawPawnAgain(g);
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (ready == true)
            {
                Chess(g, e.X, e.Y);
                if(playWith == 1) // chế độ chơi với người
                {
                    if (IsEndGame())
                        return;
                }
                else if(playWith == 2) // chế độ với máy
                {
                    MachineChess(g);
                    if (IsEndGame())
                        return;
                }
                
            }
            else
                return;
        }

        private void chơiVớiNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerWithPlayer();
            board.DrawBoardGame(g);
        }

        private void đánhVớiMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerWithComputer();
            board.DrawBoardGame(g);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblPlayerVsPlayer_Click(object sender, EventArgs e)
        {
            PlayerWithPlayer();
        }

        private void lblPlayerVsComputer_Click(object sender, EventArgs e)
        {
            PlayerWithComputer();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void StartGame()
        {
            label1.Visible = false;
            lblPlayerVsPlayer.Visible = false;
            lblPlayerVsComputer.Visible = false;
            lblThoat.Visible = false;

            g.Clear(pnlBanCo.BackColor);
            InitArrayCells(); //khởi tạo mảng ô cờ
            cacNuocDaDi = new Stack<Cells>();
            soundNewGame.Play();
        }



        private void PlayerWithPlayer()
        {
            ready = true;
            playWith = 1;
            StartGame();
        }

        private void PlayerWithComputer()
        {
            ready = true;
            playWith = 2;
            StartGame();
            MachineChess(g);
        }
        // máy đánh

        #region  AI

        private void MachineChess(Graphics g)
        {
            if (cacNuocDaDi.Count == 0)
            {
                Chess(g, board.NoOfRows / 2 * Cells.WIDTH + 1, board.NoOfColumn / 2 * Cells.HEIGHT + 1);
            }
            else
            {
                Cells cell = FindMove();
                Chess(g, cell.Location.X + 1, cell.Location.Y + 1);
            }
        }

        private Cells FindMove()
        {
            Cells cell = new Cells();
            long score = 0;
            for (int i = 0; i < board.NoOfRows; i++)
            {
                for (int j = 0; j < board.NoOfColumn; j++)
                {
                    if (arrayCells[i, j].Owned == 0)
                    {
                        long attackScore = eval.AttackScore(i, j, arrayCells);
                        long DenfenseScore = eval.DenfenseScore(i, j, arrayCells);
                        long tempScore = attackScore > DenfenseScore ? attackScore : DenfenseScore;
                        if (score < tempScore)
                        {
                            score = tempScore;
                            cell = new Cells(arrayCells[i, j].Rows, arrayCells[i, j].Column, arrayCells[i, j].Location, arrayCells[i, j].Owned);
                        }
                    }
                }
            }
            return cell;
        }

        #endregion


        #region Hiệu ứng trên lable

        private void lblPlayerVsPlayer_MouseHover_1(object sender, EventArgs e)
        {
            lblPlayerVsPlayer.BackColor = Color.Green;
        }

        private void lblPlayerVsPlayer_MouseLeave_1(object sender, EventArgs e)
        {
            lblPlayerVsPlayer.BackColor = Color.FromArgb(0, 192, 9);
        }

        private void lblPlayerVsComputer_MouseHover_1(object sender, EventArgs e)
        {
            lblPlayerVsComputer.BackColor = Color.Green;
        }

        private void lblPlayerVsComputer_MouseLeave_1(object sender, EventArgs e)
        {
            lblPlayerVsComputer.BackColor = Color.FromArgb(0, 192, 9);
        }

        private void lblThoat_MouseHover(object sender, EventArgs e)
        {
            lblThoat.BackColor = Color.Green;
        }

        private void lblThoat_MouseLeave(object sender, EventArgs e)
        {
            lblThoat.BackColor = Color.FromArgb(0, 192, 9);
        }

        #endregion

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("phiên bản caro-v1.0\n\nNhóm thực hiện:\n\tTạ Quốc Thảo - 5140342\n\t Trần Nguyễn Hữu Nhật", 
                "Thông tin tác giả",
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }


        
    }
}
