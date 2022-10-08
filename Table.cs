using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChessNut
{
    public partial class Table : Form
    {
        //FontFamily ChessFont = new FontFamily(@"assets\fonts\#Chess TFB");
    


        static Board chessNutBoard = new Board(8);

        Selection Selected = new Selection();
        

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();
            Selected.SelectedRow = 0;
            Selected.SelectedColumn = 0;
            Selected.SelectedPiece = "";
        }

        private void Draw_Board(object sender, PaintEventArgs e)
        {
            // Creating multiple shapes with filled color
            Color white = Color.FromArgb(255, 249, 177);
            Color black = Color.FromArgb(191, 152, 95);

            SolidBrush whiteBrush = new SolidBrush(white);
            SolidBrush blackBrush = new SolidBrush(black);

            // draw squares
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (((x % 2 == 0) & (y % 2 == 0)) | ((x % 2 != 0) & (y % 2 != 0)))
                    {
                        e.Graphics.FillRectangle(whiteBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(blackBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }
                }
            }
        }
        private void Draw_Labels(object sender, PaintEventArgs e)
        {
            // add numbers
            int num = 1;
            for (int y = 8; y > 0; y--)
            {
                e.Graphics.DrawString(y.ToString(), new Font("Verdana", 10), new SolidBrush(Color.Black), border_size / 2 - 10, square_size * (num));
                num += 1;
            }

            // add letters
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
            for (int x = 0; x < letters.Length; x++)
            {
                e.Graphics.DrawString(letters[x], new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * x + border_size + 10, square_size * 8 + border_size);
            }
        }

        private void Draw_Title(object sender, PaintEventArgs e)
        {
            // add title
            string[] letters = { "C", "h", "e", "s", "s", "N", "u", "t" };
            for (int x = 0; x < letters.Length; x++)
            {
                e.Graphics.DrawString(letters[x], new Font("Verdana", 20), new SolidBrush(Color.Black), square_size * x + border_size + 10, 0);
            }
        }
        private void Draw_Piece(object sender, PaintEventArgs e, string piece)
        {
            string icon = "X";
            switch (piece)
            {
                case "King":
                    icon = "S";
                    break;

                case "Queen":
                    icon = "T";
                    break;

                case "Rook":
                    icon = "P";
                    break;

                case "Knight":
                    icon = "Q";
                    break;

                case "Bishop":
                    icon = "R";
                    break;
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Square s = chessNutBoard.squares[x, y];
                    Console.Write(x.ToString() + y.ToString());

                    if (s.CurrentlyOccupied == true)
                    {
                        e.Graphics.DrawString(icon, new Font("Chess TFB", 35), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);

                    }
                    else if (s.LegalNextMove == true)
                    {
                        e.Graphics.DrawString("+", new Font("Verdana", 20), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                        //Console.Write("| + ");new F
                    }
                    else
                    {
                        e.Graphics.DrawString(" ", new Font("Verdana", 20), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                        //Console.Write("|   ");
                    }
                }
            }
        }
        private void Table_Load(object sender, PaintEventArgs e)
        {   
            Draw_Board(sender, e);
            Draw_Labels(sender, e);
            Draw_Title(sender, e);
            Draw_Piece(sender, e, Selected.SelectedPiece);
            Draw_AvailableMoves(sender, e);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            chessNutBoard.squares[Selected.SelectedColumn, Selected.SelectedRow].CurrentlyOccupied = true;
            Selected.SelectedAvalailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected.SelectedColumn, Selected.SelectedRow], Selected.SelectedPiece);
        }

        private void PieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected piece 
            Selected.SelectedPiece = PieceSelectionBox.GetItemText(this.PieceSelectionBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void RowSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected row
            Selected.SelectedRow = 7 - RowSelectionBox.SelectedIndex;
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void ColumnSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected column
            Selected.SelectedColumn = ColumnSelectionBox.SelectedIndex;
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void Draw_AvailableMoves(object sender, PaintEventArgs e)
        {
            // print number of avalible moves
            string message = "Avalaible Moves: " + Selected.SelectedAvalailableMoves.ToString();
            e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 10, 300);   
        }
    }
}