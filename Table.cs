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

        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };

        List<Move> moves = new List<Move>();

        int border_size = 50;
        int square_size = 50;

        static Board chessNutBoard = new Board(8);
        
        List<Piece> whitePieces = new List<Piece>();
        List<Piece> blackPieces = new List<Piece>();
        List<Piece> whitePiecesTaken = new List<Piece>();
        List<Piece> blackPiecesTaken = new List<Piece>();

        Piece WhiteRook1   = new Piece { Class = "Rook",   Color = "White", Name = "White Rook 1"  , StartColumn = 0, StartRow = 7};
        Piece WhiteKnight1 = new Piece { Class = "Knight", Color = "White", Name = "White Knight 1", StartColumn = 1, StartRow = 7};
        Piece WhiteBishop1 = new Piece { Class = "Bishop", Color = "White", Name = "White Bishop 1", StartColumn = 2, StartRow = 7};
        Piece WhiteQueen   = new Piece { Class = "Queen",  Color = "White", Name = "White Queen"   , StartColumn = 3, StartRow = 7};
        Piece WhiteKing    = new Piece { Class = "King",   Color = "White", Name = "White King"    , StartColumn = 4, StartRow = 7};
        Piece WhiteBishop2 = new Piece { Class = "Bishop", Color = "White", Name = "White Bishop 2", StartColumn = 5, StartRow = 7};
        Piece WhiteKnight2 = new Piece { Class = "Knight", Color = "White", Name = "White Knight 2", StartColumn = 6, StartRow = 7};
        Piece WhiteRook2   = new Piece { Class = "Rook",   Color = "White", Name = "White Rook 2"  , StartColumn = 7, StartRow = 7};
        Piece WhitePawn1   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 1"  , StartColumn = 0, StartRow = 6};
        Piece WhitePawn2   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 2"  , StartColumn = 1, StartRow = 6};
        Piece WhitePawn3   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 3"  , StartColumn = 2, StartRow = 6};
        Piece WhitePawn4   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 4"  , StartColumn = 3, StartRow = 6};
        Piece WhitePawn5   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 5"  , StartColumn = 4, StartRow = 6};
        Piece WhitePawn6   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 6"  , StartColumn = 5, StartRow = 6};
        Piece WhitePawn7   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 7"  , StartColumn = 6, StartRow = 6};
        Piece WhitePawn8   = new Piece { Class = "Pawn",   Color = "White", Name = "White Pawn 8"  , StartColumn = 7, StartRow = 6};

        Piece BlackRook1   = new Piece { Class = "Rook",   Color = "Black", Name = "Black Rook",     StartColumn = 0, StartRow = 0}; 
        Piece BlackKnight1 = new Piece { Class = "Knight", Color = "Black", Name = "Black Knight 1", StartColumn = 1, StartRow = 0}; 
        Piece BlackBishop1 = new Piece { Class = "Bishop", Color = "Black", Name = "Black Bishop 1", StartColumn = 2, StartRow = 0}; 
        Piece BlackQueen   = new Piece { Class = "Queen",  Color = "Black", Name = "Black Queen"   , StartColumn = 3, StartRow = 0};
        Piece BlackKing    = new Piece { Class = "King",   Color = "Black", Name = "Black King"    , StartColumn = 4, StartRow = 0};
        Piece BlackBishop2 = new Piece { Class = "Bishop", Color = "Black", Name = "Black Bishop 2", StartColumn = 5, StartRow = 0};
        Piece BlackKnight2 = new Piece { Class = "Knight", Color = "Black", Name = "Black Knight 2", StartColumn = 6, StartRow = 0};
        Piece BlackRook2   = new Piece { Class = "Rook",   Color = "Black", Name = "Black Rook2"   , StartColumn = 7, StartRow = 0};
        Piece BlackPawn1   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 1"  , StartColumn = 0, StartRow = 1};
        Piece BlackPawn2   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 2"  , StartColumn = 1, StartRow = 1};
        Piece BlackPawn3   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 3"  , StartColumn = 2, StartRow = 1};
        Piece BlackPawn4   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 4"  , StartColumn = 3, StartRow = 1};
        Piece BlackPawn5   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 5"  , StartColumn = 4, StartRow = 1};
        Piece BlackPawn6   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 6"  , StartColumn = 5, StartRow = 1};
        Piece BlackPawn7   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 7"  , StartColumn = 6, StartRow = 1};
        Piece BlackPawn8   = new Piece { Class = "Pawn",   Color = "Black", Name = "Black Pawn 8",   StartColumn = 7, StartRow = 1};

        Piece SelectedPiece;

        public Table()
        {
            InitializeComponent();

            // white combo box piece selector

            whitePieces.Add(WhiteRook1);
            whitePieces.Add(WhiteKnight1);
            whitePieces.Add(WhiteBishop1);
            whitePieces.Add(WhiteQueen);
            whitePieces.Add(WhiteKing);            
            whitePieces.Add(WhiteBishop2);     
            whitePieces.Add(WhiteKnight2);            
            whitePieces.Add(WhiteRook2);
            //whitePieces.Add(WhitePawn1);
            whitePieces.Add(WhitePawn2);
            whitePieces.Add(WhitePawn3);
            whitePieces.Add(WhitePawn4);
            whitePieces.Add(WhitePawn5);
            whitePieces.Add(WhitePawn6);
            whitePieces.Add(WhitePawn7);
            //whitePieces.Add(WhitePawn8);

            WhitePieceSelectionBox.DataSource = whitePieces;
            WhitePieceSelectionBox.DisplayMember = "Name";
            WhitePieceSelectionBox.SelectedIndex = -1;

            // black combo box piece selector
            blackPieces.Add(BlackRook1);
            blackPieces.Add(BlackKnight1);
            blackPieces.Add(BlackBishop1);
            blackPieces.Add(BlackQueen);
            blackPieces.Add(BlackKing);
            blackPieces.Add(BlackBishop2);
            blackPieces.Add(BlackKnight2);
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
            BlackPieceSelectionBox.SelectedIndex = -1;

            initialise_table();

            SelectedPiece = new Piece { Name = "No SelectedPiece"};
            //SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);

            AvailableMoves.DisplayMember = "BoardPosition";
            //AvailableMoves.Text = "Avaliable Moves ...";
        }

        public void initialise_table()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessNutBoard.squares[i, j].CurrentlyOccupied = "free";
                }
            }

            foreach (Piece piece in whitePieces)
            {
                piece.NumberOfTimesMoved = 0;
                piece.Column = piece.StartColumn;
                piece.Row = piece.StartRow;
                chessNutBoard.squares[piece.Column, piece.Row].CurrentlyOccupied = piece.Color;
                piece.Name = letters[piece.Column] + (8 - piece.Row).ToString() + " - " + piece.Color + " " + piece.Class;
            }

            foreach (Piece piece in blackPieces)
            {
                piece.NumberOfTimesMoved = 0;
                piece.Column = piece.StartColumn;
                piece.Row = piece.StartRow;
                chessNutBoard.squares[piece.Column, piece.Row].CurrentlyOccupied = piece.Color;
                piece.Name = letters[piece.Column] + (8 - piece.Row).ToString() + " - " + piece.Color + " " + piece.Class;
            }
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
                        e.Graphics.FillRectangle(whiteBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(blackBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }

                    if ((s.CurrentlyOccupied == "Black") | (s.CurrentlyOccupied == "White"))
                    {
               //         e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 77, 77)), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }

                    if (SelectedPiece != null)
                    {
                        if ((x == SelectedPiece.Column) & (y == SelectedPiece.Row))
                        {
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 51)), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        }
                    }
                   // e.Graphics.DrawString(x.ToString()+y.ToString(), new Font("Courier New", 7), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
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
            if (piece.Taken == true)
            {
                return;
            }
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
            //if (piece.Name == SelectedPiece.Name)
            //{
            //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(10, 77, 255, 77)), SelectedPiece.Column * square_size + border_size, SelectedPiece.Row * square_size + border_size, square_size, square_size);
            //}
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
                        //e.Graphics.DrawString("+", new Font("Verdana", 20), new SolidBrush(Color.Red), (x - 1 / 2) * square_size + border_size, y * square_size + border_size + 1);
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(6,77,255,77)), x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                        //e.Graphics.DrawString(x.ToString() + y.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);
                    }
                }
            }
        }
        private void Draw_Pieces(object sender, PaintEventArgs e)
        {
            foreach (Piece piece in whitePieces)
            {
                Draw_Piece(sender, e, piece);
            }

            foreach (Piece piece in blackPieces)
            {
                Draw_Piece(sender, e, piece);
            }
        }

        private void Draw_CurrentInfo(object sender, PaintEventArgs e)
        {
            // print number of avalible moves

            Moves.Text = "Possible Moves : " + SelectedPiece.AvailableMoves.Count.ToString();
            CurrentPiece.Text = "Current Piece  : " + SelectedPiece.Name.ToString();
            Takable.Text = "Takable Pieces : 0";
            CheckStatus.Text = "CheckStatus    : 0";

            // e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 140);   
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
            if (SelectedPiece!= null)
            {
                SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);

                List<Move> moves = new List<Move>();
                foreach (Move avaliableMove in SelectedPiece.AvailableMoves)
                {
                    moves.Add(avaliableMove);
                }
                //Moves.add(BoardPosition);
                AvailableMoves.DataSource = moves;
                AvailableMoves.SelectedIndex = -1;
                AvailableMoves.Text = SelectedPiece.AvailableMoves.Count.ToString() + " Possible Moves";
            }
        }

        private void MovePiece(object sender, EventArgs e, Piece pieceToMove)
        {
            chessNutBoard.squares[pieceToMove.PrevColumn, pieceToMove.PrevRow].CurrentlyOccupied = "free";
            chessNutBoard.squares[pieceToMove.Column, pieceToMove.Row].CurrentlyOccupied = pieceToMove.Color;

            Piece pieceToTake = new Piece();
            switch (pieceToMove.Color)
            {
                case "White":
                    foreach (Piece piece in blackPieces)
                    {
                        if (piece.Color == OppositeColor(pieceToMove.Color))
                        {
                            if ((piece.Column == pieceToMove.Column) & (piece.Row == pieceToMove.Row))
                            {
                                pieceToTake = piece;
                            }
                        }
                    }
                    pieceToTake.Taken = true;
                    blackPiecesTaken.Add(pieceToTake);
                    blackPieces.Remove(pieceToTake);
                    break;

                case "Black":
                    foreach (Piece piece in whitePieces)
                    {
                        if (piece.Color == OppositeColor(pieceToMove.Color))
                        {
                            if ((piece.Column == pieceToMove.Column) & (piece.Row == pieceToMove.Row))
                            {
                                pieceToTake = piece;
                            }
                        }
                    }
                    pieceToTake.Taken = true;
                    whitePiecesTaken.Add(pieceToTake);
                    whitePieces.Remove(pieceToTake);
                    break;
            }
                    
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void WhitePieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WhitePieceSelectionBox.SelectedIndex < 0)
            {
                WhitePieceSelectionBox.Text = "No Selected Piece";
            }
            else
            {
                SelectedPiece = WhitePieceSelectionBox.SelectedItem as Piece;

                // set currently selected piece 
                //Piece1.Class = PieceSelectionBox.GetItemText(this.PieceSelectionBox.SelectedItem);
                Table_Load(sender, e);
                this.Invalidate();
            }
        }

        private void BlackPieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BlackPieceSelectionBox.SelectedIndex < 0)
            {
                BlackPieceSelectionBox.Text = "No Selected Piece";
            }
            else
            {
                SelectedPiece = BlackPieceSelectionBox.SelectedItem as Piece;
                // set currently selected piece
                //Piece2.Class = BlackPieceSelectionBox.GetItemText(this.BlackPieceSelectionBox.SelectedItem);
                Table_Load(sender, e);
                this.Invalidate();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            initialise_table();
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if ((WhitePieceSelectionBox.SelectedIndex < 0) & (BlackPieceSelectionBox.SelectedIndex < 0))
            {
                MessageBox.Show("Select a Piece");
            }
            else if (AvailableMoves.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Move");
            }
            else
            {
                Move selectedMove = AvailableMoves.SelectedItem as Move;

                SelectedPiece.PrevColumn = SelectedPiece.Column;
                SelectedPiece.PrevRow = SelectedPiece.Row;

                SelectedPiece.Column = selectedMove.Column;
                SelectedPiece.Row = 7 - selectedMove.Row;

                SelectedPiece.NumberOfTimesMoved += 1;

                MovePiece(sender, e, SelectedPiece);
                foreach (Piece piece in whitePieces)
                {
                    piece.Name = letters[piece.Column] + (8 - piece.Row).ToString() + " - " + piece.Color + " " + piece.Class;
                }

                foreach (Piece piece in blackPieces)
                {
                    piece.Name = letters[piece.Column] + (8 - piece.Row).ToString() + " - " + piece.Color + " " + piece.Class;
                }

                BlackPieceSelectionBox.DataSource = blackPieces;
                WhitePieceSelectionBox.DataSource = whitePieces;

                // SelectedPiece.Name = letters[SelectedPiece.Column] + (8 - SelectedPiece.Row).ToString() + " - " + SelectedPiece.Color + " " + SelectedPiece.Class;
            }
        }

        public string OppositeColor(string color)
        {
            string oppositeColor = "";
            if (color == "Black")
            {
                oppositeColor = "White";
            }
            if (color == "White")
            {
                oppositeColor = "Black";
            }
            return oppositeColor;
        }
        private void CheckStatus_Click(object sender, EventArgs e)
        {

        }

        private void AvailableMoves_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected column

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