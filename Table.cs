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

        Piece Piece1 = new Piece();
        Piece Piece2 = new Piece();
        Piece Piece3 = new Piece();
        Piece Piece4 = new Piece();
        Piece Piece5 = new Piece();
        Piece Piece6 = new Piece();
        Piece Piece7 = new Piece();
        Piece Piece8 = new Piece();
        Piece Piece9 = new Piece();
        Piece Piece10 = new Piece();
        Piece Piece11= new Piece();
        Piece Piece12 = new Piece();

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();

            Piece1.Row = 0;
            Piece1.Column = 0;
            //chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;
            Piece1.Class = "";
            Piece1.Color = "White";

            Piece2.Row = 0;
            Piece2.Column = 0;
            Piece2.Class = "";
            Piece2.Color = "Black";

            initialise_table();
        }

        public void initialise_table()
        {
            Piece1.Row = 7;
            Piece1.Column = 0;
            Piece1.Class = "Rook";
            Piece1.Color = "White";

            Piece2.Row = 7;
            Piece2.Column = 1;
            Piece2.Class = "Knight"; ;
            Piece2.Color = "White";

            Piece3.Row = 7;
            Piece3.Column = 2;
            Piece3.Class = "Bishop";
            Piece3.Color = "White";

            Piece4.Row = 7;
            Piece4.Column = 3;
            Piece4.Class = "King";
            Piece4.Color = "White";

            Piece5.Row = 7;
            Piece5.Column = 4;
            Piece5.Class = "Quuen";
            Piece5.Color = "White";

            Piece6.Row = 7;
            Piece6.Column = 5;
            Piece6.Class = "Bishop";
            Piece6.Color = "White";

            Piece7.Row = 7;
            Piece7.Column = 6;
            Piece7.Class = "Knight"; ;
            Piece7.Color = "White";

            Piece8.Row = 7;
            Piece8.Column = 7;
            Piece8.Class = "Rook";
            Piece8.Color = "White";

        }

        private void Draw_Board(object sender, PaintEventArgs e)
        {
            // Creating multiple shapes with filled color

            Color white = Color.FromArgb(255, 249, 177);
            Color black = Color.FromArgb(191, 152, 95);

            SolidBrush whiteBrush = new SolidBrush(white);
            SolidBrush blackBrush = new SolidBrush(black);


            chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;

            // draw squares
            for (int x = 0; x < 8; x++)  
            {
                for (int y = 0; y < 8; y++)
                {
                    Square s = chessNutBoard.squares[x, y];

                    if (((x % 2 == 0) & (y % 2 == 0)) | ((x % 2 != 0) & (y % 2 != 0)))
                    {
                        if (s.CurrentlyOccupied == true)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.Red), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(whiteBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        }
                    }
                    else
                    {
                        if (s.CurrentlyOccupied == true)
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.Red), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(blackBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        }
                    }
                    e.Graphics.DrawString(x.ToString()+y.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                }
            }
        }

        private void Draw_Labels(object sender, PaintEventArgs e)
        {
            // add numbers
            int num = 1;
            for (int y = 8; y > 0; y--)
            {
                e.Graphics.DrawString(y.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), border_size - 12, square_size * (num)+20);
                num += 1;
            }

            // add letters
            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
            for (int x = 0; x < letters.Length; x++)
            {
                e.Graphics.DrawString(letters[x], new Font("Courier New", 10), new SolidBrush(Color.Black), square_size * x + border_size + 16, square_size * 8 + border_size);
            }
        }

        private void Draw_Title(object sender, PaintEventArgs e)
        {
            // add title
            string[] letters = { "C", "h", "e", "s", "s", "N", "u", "t" };
            for (int x = 0; x < letters.Length; x++)
            {
                e.Graphics.DrawString(letters[x], new Font("Cooper", 20), new SolidBrush(Color.Black), square_size * x + border_size + 10, 10);
            }
        }

        private void Draw_Piece(object sender, PaintEventArgs e, Piece piece)
        {
            string icon = "";
            switch (piece.Class)
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

            SolidBrush brush = new SolidBrush(Color.Black);
            switch (piece.Color)
            {
                case "Black":
                    brush.Color = Color.Black;
                    break;

                case "White":
                    brush.Color = Color.White;
                    break;
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Square s = chessNutBoard.squares[x, y];

                    if ((x == piece.Column) & (y == piece.Row))
                    {
                        e.Graphics.DrawString(icon, new Font("Chess TFB", 35), brush, x * square_size + border_size, y * square_size + border_size+1);
                    }
                    else if (s.LegalNextMove == true)
                    {
                        e.Graphics.DrawString("+", new Font("Verdana", 20), brush, x * square_size + border_size, y * square_size + border_size);
                    }
                }
            }
        }
        private void Draw_Pieces(object sender, PaintEventArgs e)
        {
            Draw_Piece(sender, e, Piece1);
            Draw_Piece(sender, e, Piece2);
            Draw_Piece(sender, e, Piece3);
            Draw_Piece(sender, e, Piece4);
            Draw_Piece(sender, e, Piece5);
            Draw_Piece(sender, e, Piece6);
            Draw_Piece(sender, e, Piece7);
            Draw_Piece(sender, e, Piece8);
        }

        private void Table_Load(object sender, PaintEventArgs e)
        {
            chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            Draw_Title(sender, e);
            Draw_Board(sender, e);
            Draw_Labels(sender, e);

            Draw_Pieces(sender, e);

            Draw_AvailableMoves(sender, e);
            Draw_AvailableMoves2(sender, e);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;

            Piece1.SelectedAvalailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, Piece1, Piece2);

            
            //Selected2.SelectedAvalailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected2.SelectedColumn, Selected2.SelectedRow], Selected2.SelectedPiece);
        }

        private void MovePiece(object sender, EventArgs e, Piece pieceToMove)
        {
            //chessNutBoard.squares[pieceToMove.PrevColumn, pieceToMove.PrevRow].CurrentlyOccupied = false;
            

            Table_Load(sender, e);
            this.Invalidate();
        }

        private void PieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected piece 
            Piece1.Class = PieceSelectionBox.GetItemText(this.PieceSelectionBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void Draw_AvailableMoves(object sender, PaintEventArgs e)
        {
            // print number of avalible moves
            string message = "Possible Moves: " + Piece1.SelectedAvalailableMoves.ToString();
            e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 160);   
        }

        private void PieceSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected piece
            Piece2.Class = PieceSelectionBox2.GetItemText(this.PieceSelectionBox2.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void RowSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected row
            Piece1.PrevRow = Piece1.Row;
            Piece1.Row = 7 - RowSelectionBox.SelectedIndex;

            chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, Piece1);
        }

        private void ColumnSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected column
            Piece1.PrevColumn = Piece1.Column;
            Piece1.Column = ColumnSelectionBox.SelectedIndex;

            chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, Piece1);
        }
        private void RowSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected row
            Piece2.PrevRow = Piece2.Row;
            Piece2.Row = 7 - RowSelectionBox2.SelectedIndex;

            chessNutBoard.squares[Piece2.PrevColumn, Piece2.PrevRow].CurrentlyOccupied = false;
            chessNutBoard.squares[Piece2.Column, Piece2.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, Piece2);
        }

        private void ColumnSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected column
            Piece2.PrevColumn = Piece2.Column;
            Piece2.Column = ColumnSelectionBox2.SelectedIndex;

            chessNutBoard.squares[Piece2.PrevColumn, Piece2.PrevRow].CurrentlyOccupied = false;
            chessNutBoard.squares[Piece2.Column, Piece2.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, Piece2);
        }

        private void Draw_AvailableMoves2(object sender, PaintEventArgs e)
        {
            // print number of avalible moves
            string message = "Possible Moves: " + Piece2.SelectedAvalailableMoves.ToString();
            e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 270);
        }

        private void ColorSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Piece1.Color = SelectionColorBox.GetItemText(this.SelectionColorBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void ColorSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            Piece2.Color = SelectionColorBox2.GetItemText(this.SelectionColorBox2.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }
    }
}