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

        Piece WhiteQueen   = new Piece { Class = "Queen",  Color = "White" };
        Piece WhiteKing    = new Piece { Class = "King",   Color = "White" };
        Piece WhiteBishop1 = new Piece { Class = "Bishop", Color = "White" };
        Piece WhiteBishop2 = new Piece { Class = "Bishop", Color = "White" };
        Piece WhiteKnight1 = new Piece { Class = "Knight", Color = "White" };
        Piece WhiteKnight2 = new Piece { Class = "Knight", Color = "White" };
        Piece WhiteRook1   = new Piece { Class = "Rook",   Color = "White" };
        Piece WhiteRook2   = new Piece { Class = "Rook",   Color = "White" };
        Piece WhitePawn1   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn2   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn3   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn4   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn5   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn6   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn7   = new Piece { Class = "Pawn",   Color = "White" };
        Piece WhitePawn8   = new Piece { Class = "Pawn",   Color = "White" };

        Piece BlackQueen   = new Piece { Class = "Queen",  Color = "Black" };
        Piece BlackKing    = new Piece { Class = "King",   Color = "Black" };
        Piece BlackBishop1 = new Piece { Class = "Bishop", Color = "Black" };
        Piece BlackBishop2 = new Piece { Class = "Bishop", Color = "Black" };
        Piece BlackKnight1 = new Piece { Class = "Knight", Color = "Black" };
        Piece BlackKnight2 = new Piece { Class = "Knight", Color = "Black" };
        Piece BlackRook1   = new Piece { Class = "Rook",   Color = "Black" };
        Piece BlackRook2   = new Piece { Class = "Rook",   Color = "Black" };
        Piece BlackPawn1   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn2   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn3   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn4   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn5   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn6   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn7   = new Piece { Class = "Pawn",   Color = "Black" };
        Piece BlackPawn8   = new Piece { Class = "Pawn",   Color = "Black" };

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();

            Piece1.Row = 4;
            Piece1.Column = 4;
            //chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;
            Piece1.Class = "";
            Piece1.Color = "White";

            Piece2.Row = 5;
            Piece2.Column = 4;
            Piece2.Class = "";
            Piece2.Color = "Black";

            initialise_table();
        }

        public void initialise_table()
        {
            // white sttart positions
            WhiteQueen.Row = 7;
            WhiteQueen.Column = 3;

            WhiteKing.Row = 7;
            WhiteKing.Column = 4;

            WhiteBishop1.Row = 7;
            WhiteBishop1.Column = 2;

            WhiteBishop2.Row = 7;
            WhiteBishop2.Column = 5;

            WhiteKnight1.Row = 7;
            WhiteKnight1.Column = 1;

            WhiteKnight2.Row = 7;
            WhiteKnight2.Column = 6;

            WhiteRook1.Row = 7;
            WhiteRook1.Column = 0;

            WhiteRook2.Row = 7;
            WhiteRook2.Column = 7;

            WhitePawn1.Row = 6;
            WhitePawn1.Column = 0;

            WhitePawn2.Row = 6;
            WhitePawn2.Column = 1;

            WhitePawn3.Row = 6;
            WhitePawn3.Column = 2;

            WhitePawn4.Row = 6;
            WhitePawn4.Column = 3;

            WhitePawn5.Row = 6;
            WhitePawn5.Column = 4;

            WhitePawn6.Row = 6;
            WhitePawn6.Column = 5;

            WhitePawn7.Row = 6;
            WhitePawn7.Column = 6;

            WhitePawn8.Row = 6;
            WhitePawn8.Column = 7;


            // black start positions
            BlackQueen.Row = 0;
            BlackQueen.Column = 3;

            BlackKing.Row = 0;
            BlackKing.Column = 4;

            BlackBishop1.Row = 0;
            BlackBishop1.Column = 2;

            BlackBishop2.Row = 0;
            BlackBishop2.Column = 5;

            BlackKnight1.Row = 0;
            BlackKnight1.Column = 1;

            BlackKnight2.Row = 0;
            BlackKnight2.Column = 6;

            BlackRook1.Row = 0;
            BlackRook1.Column = 0;

            BlackRook2.Row = 0;
            BlackRook2.Column = 7;

            BlackPawn1.Row = 1;
            BlackPawn1.Column = 0;

            BlackPawn2.Row = 1;
            BlackPawn2.Column = 1;

            BlackPawn3.Row = 1;
            BlackPawn3.Column = 2;

            BlackPawn4.Row = 1;
            BlackPawn4.Column = 3;

            BlackPawn5.Row = 1;
            BlackPawn5.Column = 4;

            BlackPawn6.Row = 1;
            BlackPawn6.Column = 5;

            BlackPawn7.Row = 1;
            BlackPawn7.Column = 6;

            BlackPawn8.Row = 1;
            BlackPawn8.Column = 7;

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
            string outline = "";
            switch (piece.Class)
            {
                case "King":
                    icon = "S";
                    outline = "X";
                    break;

                case "Queen":
                    icon = "T";
                    outline = "Y";
                    break;

                case "Rook":
                    icon = "P";
                    outline = "V";
                    break;

                case "Knight":
                    icon = "Q";
                    outline = "W";
                    break;

                case "Bishop":
                    icon = "R";
                    outline = "Z";
                    break;

                case "Pawn":
                    icon = "O";
                    outline = "U";
                    break;
            }

            switch (piece.Color)
            {
                case "Black":
                    e.Graphics.DrawString(icon, new Font("Chess TFB", 40), new SolidBrush(Color.Black), (piece.Column - 1 / 2) * square_size + border_size, piece.Row * square_size + border_size);
                    break;

                case "White":
                    e.Graphics.DrawString(icon, new Font("Chess TFB", 40), new SolidBrush(Color.White), (piece.Column  - 1 / 2) * square_size + border_size, piece.Row * square_size + border_size);
                    e.Graphics.DrawString(outline, new Font("Chess TFB", 40), new SolidBrush(Color.Black), (piece.Column - 1 / 2) * square_size + border_size, piece.Row * square_size + border_size);

                    break;
            }

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Square s = chessNutBoard.squares[x, y];

                    if (s.LegalNextMove == true)
                    {
                        //e.Graphics.DrawString("+", new Font("Verdana", 20), new SolidBrush(Color.Green), (x - 1 / 2) * square_size + border_size, y * square_size + border_size + 1);
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(6,77,255,77)), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        e.Graphics.DrawString(x.ToString() + y.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                    }
                }
            }
        }
        private void Draw_Pieces(object sender, PaintEventArgs e)
        {
            Draw_Piece(sender, e, Piece1);
            Draw_Piece(sender, e, Piece2);

            Draw_Piece(sender, e, WhiteQueen);
            Draw_Piece(sender, e, WhiteKing);
            Draw_Piece(sender, e, WhiteRook1);
            Draw_Piece(sender, e, WhiteRook2);
            Draw_Piece(sender, e, WhiteBishop1);
            Draw_Piece(sender, e, WhiteBishop2);
            Draw_Piece(sender, e, WhiteKnight1);
            Draw_Piece(sender, e, WhiteKnight2);
            Draw_Piece(sender, e, WhitePawn1);
            Draw_Piece(sender, e, WhitePawn2);
            Draw_Piece(sender, e, WhitePawn3);
            Draw_Piece(sender, e, WhitePawn4);
            Draw_Piece(sender, e, WhitePawn5);
            Draw_Piece(sender, e, WhitePawn6);
            Draw_Piece(sender, e, WhitePawn7);
            Draw_Piece(sender, e, WhitePawn8);

            Draw_Piece(sender, e, BlackQueen);
            Draw_Piece(sender, e, BlackKing);
            Draw_Piece(sender, e, BlackRook1);
            Draw_Piece(sender, e, BlackRook2);
            Draw_Piece(sender, e, BlackBishop1);
            Draw_Piece(sender, e, BlackBishop2);
            Draw_Piece(sender, e, BlackKnight1);
            Draw_Piece(sender, e, BlackKnight2);
            Draw_Piece(sender, e, BlackPawn1);
            Draw_Piece(sender, e, BlackPawn2);
            Draw_Piece(sender, e, BlackPawn3);
            Draw_Piece(sender, e, BlackPawn4);
            Draw_Piece(sender, e, BlackPawn5);
            Draw_Piece(sender, e, BlackPawn6);
            Draw_Piece(sender, e, BlackPawn7);
            Draw_Piece(sender, e, BlackPawn8);
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