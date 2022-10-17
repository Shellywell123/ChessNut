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
        

        Piece WhiteQueen   = new Piece { Class = "Queen",  Color = "White", Name = "White Queen"};
        Piece WhiteKing    = new Piece { Class = "King",   Color = "White", Name = "White King"};
        Piece WhiteBishop1 = new Piece { Class = "Bishop", Color = "White", Name = "White Bishop 1"};
        Piece WhiteBishop2 = new Piece { Class = "Bishop", Color = "White", Name = "White Bishop 2" };
        Piece WhiteKnight1 = new Piece { Class = "Knight", Color = "White", Name = "White Knight 1"};
        Piece WhiteKnight2 = new Piece { Class = "Knight", Color = "White", Name = "White Knight 2"};
        Piece WhiteRook1   = new Piece { Class = "Rook",   Color = "White", Name = "White Rook 1"};
        Piece WhiteRook2   = new Piece { Class = "Rook",   Color = "White", Name = "White Rook 2"};
        Piece WhitePawn1   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 1"};
        Piece WhitePawn2   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 2"};
        Piece WhitePawn3   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 3"};
        Piece WhitePawn4   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 4"};
        Piece WhitePawn5   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 5"};
        Piece WhitePawn6   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 6"};
        Piece WhitePawn7   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 7"};
        Piece WhitePawn8   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 8" };

        Piece BlackQueen   = new Piece { Class = "Queen",  Color = "Black", Name = "Black Queen"};
        Piece BlackKing    = new Piece { Class = "King",   Color = "Black", Name = "Black King"};
        Piece BlackBishop1 = new Piece { Class = "Bishop", Color = "Black", Name = "Black Bishop 1"};
        Piece BlackBishop2 = new Piece { Class = "Bishop", Color = "Black", Name = "Black Bishop 2"};
        Piece BlackKnight1 = new Piece { Class = "Knight", Color = "Black", Name = "Black Knight 1"};
        Piece BlackKnight2 = new Piece { Class = "Knight", Color = "Black", Name = "Black Knight 2"};
        Piece BlackRook1   = new Piece { Class = "Rook",   Color = "Black", Name = "Black Rook 1"};
        Piece BlackRook2   = new Piece { Class = "Rook",   Color = "Black", Name = "Black Rook2"};
        Piece BlackPawn1   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 1"};
        Piece BlackPawn2   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 2"};
        Piece BlackPawn3   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 3"};
        Piece BlackPawn4   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 4"};
        Piece BlackPawn5   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 5"};
        Piece BlackPawn6   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 6"};
        Piece BlackPawn7   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 7"};
        Piece BlackPawn8   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 8" };

        Piece SelectedPiece;

        List<Move> moves = new List<Move>();
        

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();

            // white combo box piece selector
            List<Piece> whitePieces = new List<Piece>();
            whitePieces.Add(WhiteQueen);
            whitePieces.Add(WhiteKing);
            whitePieces.Add(WhiteBishop1);
            whitePieces.Add(WhiteBishop2);
            whitePieces.Add(WhiteKnight1);
            whitePieces.Add(WhiteKnight2);
            whitePieces.Add(WhiteRook1);
            whitePieces.Add(WhiteRook2);
            whitePieces.Add(WhitePawn1);
            whitePieces.Add(WhitePawn2);
            whitePieces.Add(WhitePawn3);
            whitePieces.Add(WhitePawn4);
            whitePieces.Add(WhitePawn5);
            whitePieces.Add(WhitePawn6);
            whitePieces.Add(WhitePawn7);
            whitePieces.Add(WhitePawn8);

            WhitePieceSelectionBox.DataSource = whitePieces;
            WhitePieceSelectionBox.DisplayMember = "Name";
            WhitePieceSelectionBox.Text = "Piece ...";

            // black combo box piece selector
            List<Piece> blackPieces = new List<Piece>();
            blackPieces.Add(BlackQueen);
            blackPieces.Add(BlackKing);
            blackPieces.Add(BlackBishop1);
            blackPieces.Add(BlackBishop2);
            blackPieces.Add(BlackKnight1);
            blackPieces.Add(BlackKnight2);
            blackPieces.Add(BlackRook1);
            blackPieces.Add(BlackRook2);
            blackPieces.Add(BlackPawn1);
            blackPieces.Add(BlackPawn2);
            blackPieces.Add(BlackPawn3);
            blackPieces.Add(BlackPawn4);
            blackPieces.Add(BlackPawn5);
            blackPieces.Add(BlackPawn6);
            blackPieces.Add(BlackPawn7);
            blackPieces.Add(BlackPawn8);

            BlackPieceSelectionBox.DataSource = blackPieces;
            BlackPieceSelectionBox.DisplayMember = "Name";
            BlackPieceSelectionBox.Text = "Piece ...";

            initialise_table();

            SelectedPiece = WhitePawn4;
            WhitePieceSelectionBox.SelectedItem = WhiteQueen;
            SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);


            
            AvailableMoves.DisplayMember = "BoardPosition";
            AvailableMoves.Text = "Avaliable Moves ...";

            
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


            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;

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
                    e.Graphics.DrawString(x.ToString()+y.ToString(), new Font("Courier New", 7), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
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
            if (piece.Name == SelectedPiece.Name)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(10, 77, 255, 77)), SelectedPiece.Column * square_size + border_size, SelectedPiece.Row * square_size + border_size, square_size, square_size);
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
                        //e.Graphics.DrawString(x.ToString() + y.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                    }
                }
            }
        }
        private void Draw_Pieces(object sender, PaintEventArgs e)
        {
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
            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            //chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            Draw_Title(sender, e);
            Draw_Board(sender, e);
            Draw_Labels(sender, e);
            Draw_Pieces(sender, e);
            Draw_CurrentInfo(sender, e);
            
        }

        private void Table_Load(object sender, EventArgs e)
        {
            
            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;

            SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);
            List<Move> moves = new List<Move>();
            foreach (Move avaliableMove in SelectedPiece.AvailableMoves)
            {
                moves.Add(avaliableMove);
            }
            //Moves.add(BoardPosition);
            AvailableMoves.DataSource = moves;
            AvailableMoves.Text = SelectedPiece.AvailableMoves.Count.ToString()+" Possible Moves";
        }

        private void MovePiece(object sender, EventArgs e, Piece pieceToMove)
        {
            //chessNutBoard.squares[pieceToMove.PrevColumn, pieceToMove.PrevRow].CurrentlyOccupied = false;
            
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void WhitePieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPiece = WhitePieceSelectionBox.SelectedItem as Piece;

            // set currently selected piece 
            //Piece1.Class = PieceSelectionBox.GetItemText(this.PieceSelectionBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void Draw_CurrentInfo(object sender, PaintEventArgs e)
        {
            // print number of avalible moves

            Moves.Text        = "Possible Moves : " + SelectedPiece.AvailableMoves.Count.ToString();
            CurrentPiece.Text = "Current Piece  : " + SelectedPiece.Name.ToString();
            Takable.Text      = "Takable Pieces : 0";
            CheckStatus.Text  = "CheckStatus    : 0";

            // e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 140);   
        }

        private void BlackPieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPiece = BlackPieceSelectionBox.SelectedItem as Piece;
            // set currently selected piece
            //Piece2.Class = BlackPieceSelectionBox.GetItemText(this.BlackPieceSelectionBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void RowSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected row
            
            if (chessNutBoard.squares[SelectedPiece.Column, 7- RowSelectionBox.SelectedIndex].LegalNextMove == true)
            {
                SelectedPiece.PrevRow = SelectedPiece.Row;
                SelectedPiece.Row = 7 - RowSelectionBox.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }
            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            //chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, SelectedPiece);
        }

        private void ColumnSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected column
            if (chessNutBoard.squares[ColumnSelectionBox.SelectedIndex, SelectedPiece.Row].LegalNextMove == true)
            {
                SelectedPiece.PrevColumn = SelectedPiece.Column;
                SelectedPiece.Column = ColumnSelectionBox.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Invalid Move");
            }

            //chessNutBoard.squares[Piece1.PrevColumn, Piece1.PrevRow].CurrentlyOccupied = false;
            //chessNutBoard.squares[Piece1.Column, Piece1.Row].CurrentlyOccupied = true;

            MovePiece(sender, e, SelectedPiece);
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CurrentPiece_Click(object sender, EventArgs e)
        {

        }

        private void Takable_Click(object sender, EventArgs e)
        {

        }
    }
}