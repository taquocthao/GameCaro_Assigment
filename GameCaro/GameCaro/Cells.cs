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
        private Point _Location;
        private int _Owned;


        public Cells()
        {
            _Column = 0;
            _Rows = 0;
        }

        public Cells(int rows, int column, Point location, int owned)
        {
            this._Column = column;
            this._Rows = rows;
            this.Location = location;
            this.Owned = owned;
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

        public Point Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        public int Owned
        {
            get { return _Owned; }
            set { _Owned = value; }
        }
        
    }
}
