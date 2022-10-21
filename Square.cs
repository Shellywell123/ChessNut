using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessNut
{
    public class Square  
    {
        public int RowNumber            { get; set; }
        public int ColumnNumber         { get; set; }
        public string CurrentlyOccupied { get; set; }
        public bool LegalNextMove       { get; set; }

        public Square(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}