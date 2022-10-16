using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessNut
{
    public class Piece
    {
        public string Name                  { get; set; }
        public string Class                 { get; set; }
        public int Row                      { get; set; }
        public int Column                   { get; set; }
        public int PrevRow                  { get; set; }
        public int PrevColumn               { get; set; }
        public int SelectedAvalailableMoves { get; set; }
        public string Color                 { get; set; }

    }
}
