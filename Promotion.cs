using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessNut
{
    public partial class Promotion : Form
    {
        public String SelectedPromotionClass;
        public Piece PieceToPromote;
        public Board chessNutBoard;
        
        public Promotion(Board board, Piece piece)
        {
            chessNutBoard = board;
            PieceToPromote = piece;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void promotionPieceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void promotionPieceConfirm_Click(object sender, EventArgs e)
        {
            SelectedPromotionClass = promotionPieceBox.SelectedIndex.ToString();

            if (SelectedPromotionClass != null)
            {
                if (PieceToPromote.Name != "Nothing")
                {
                    // pick class promotion                

                    int pawnNumber;
                    PieceToPromote.Class = SelectedPromotionClass;
                    pawnNumber = PieceToPromote.Name[PieceToPromote.Name.Length - 1];
                    PieceToPromote.Name = PieceToPromote.Color + " Queen " + pawnNumber;
                    PieceToPromote.Promoted = true;
                    chessNutBoard.squares[PieceToPromote.Column, PieceToPromote.Row].CurrentlyOccupied = PieceToPromote;
                }
                Close();
            }
            else
            {
                MessageBox.Show("Select Piece.");
            }

            
            
        }
    }
}
