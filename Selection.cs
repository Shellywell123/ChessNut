using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessNut
{
    public class Selection
    {
        public string SelectedPiece { get; set; }
        public int SelectedRow { get; set; }
        public int SelectedColumn { get; set; }
        public int SelectedAvalailableMoves { get; set; }
        public string SelectedPieceColor { get; set; }

    }
}
