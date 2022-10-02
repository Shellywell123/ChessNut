using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNut
{
    public class Square
    {
        public int RowNumber {get; set;}
        public int ColumnNumber {get; set; }
        public bool CurrentlyOccupied {get; set;}
        public bool LegalNextMove {get; set;}

        public Square(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}