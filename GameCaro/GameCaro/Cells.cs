using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class Cells
    {
        public const int WIDTH = 25;
        public const int HEIGHT= 25;


        private int _Column;
        private int _Rows;
        private Point _ViTri;
        private int _SoHuu;


        public Cells()
        {
            _Column = 0;
            _Rows = 0;
        }

        public Cells(int soDong, int soCot, Point vitri, int soHuu)
        {
            this._Column = soCot;
            this._Rows = soDong;
            this.ViTri = vitri;
            this.SoHuu = soHuu;
        }

        public int Column
        {
            get { return _Column; }
            set { _Column = value; }
        }

        public int Rows
        {
            get { return _Rows; }
            set { _Rows = value; }
        }

        public Point ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }

        public int SoHuu
        {
            get { return _SoHuu; }
            set { _SoHuu = value; }
        }
        
    }
}
