using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;

namespace ChessNut
{
    public partial class Table : Form
    {
        //FontFamily ChessFont = new FontFamily(@"assets\fonts\#Chess TFB");

        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };

        int WhiteScore;
        int BlackScore;

        List<Move> moves = new List<Move>();

        int border_size = 50;
        int square_size = 50;

        string turn;

        string whiteCheckStatus;
        string blackCheckStatus;

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

        public void ResetPieces()
        {
            whitePieces = new List<Piece> { };
            blackPieces = new List<Piece> { };
            whitePiecesTaken = new List<Piece> { };
            blackPiecesTaken = new List<Piece> { };
            turn = "White";

            // add black pieces
            whitePieces.Add(WhiteRook1);
            whitePieces.Add(WhiteKnight1);
            whitePieces.Add(WhiteBishop1);
            whitePieces.Add(WhiteQueen);
            whitePieces.Add(WhiteKing);
            whitePieces.Add(WhiteBishop2);
            whitePieces.Add(WhiteKnight2);
            whitePieces.Add(WhiteRook2);
            whitePieces.Add(WhitePawn1);
            whitePieces.Add(WhitePawn2);
            whitePieces.Add(WhitePawn3);
            whitePieces.Add(WhitePawn4);
            whitePieces.Add(WhitePawn5);
            whitePieces.Add(WhitePawn6);
            whitePieces.Add(WhitePawn7);
            whitePieces.Add(WhitePawn8);

            // add white pieces
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
        }
        public Table()
        {
            InitializeComponent();

            ResetPieces();

            // create button array
            InitializeTableLayoutPanel();
            AssignClickEvent();
            initialise_table();

            // init selected piece is empty
            SelectedPiece = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
        }

        public void initialise_table()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessNutBoard.squares[i, j].CurrentlyOccupied = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
                }
            }

            foreach (Piece piece in whitePieces)
            {
                piece.NumberOfTimesMoved = 0;
                piece.Column = piece.StartColumn;
                piece.Row = piece.StartRow;
                chessNutBoard.squares[piece.Column, piece.Row].CurrentlyOccupied = piece;
            }

            foreach (Piece piece in blackPieces)
            {
                piece.NumberOfTimesMoved = 0;
                piece.Column = piece.StartColumn;
                piece.Row = piece.StartRow;
                chessNutBoard.squares[piece.Column, piece.Row].CurrentlyOccupied = piece;
            }
        }
        private void GameOverCheck(object sender, EventArgs e)
        {
            foreach (Piece piece in blackPiecesTaken)
            {
                if (piece.Name == "Black King")
                {
                    MessageBox.Show("White Wins");
                    WhiteScore += 1;
                    ResetGame(sender, e);
                }
            }

            foreach (Piece piece in whitePiecesTaken)
            {
                if (piece.Name == "White King")
                {
                    MessageBox.Show("Black Wins");
                    BlackScore += 1;
                    ResetGame(sender, e);
                }
            }
        }

        private void InitializeTableLayoutPanel()
        {
            for (int i = 0; i < BoardLayoutPanel.ColumnCount; i++)
            {
                for (int j = 0; j < BoardLayoutPanel.RowCount; j++)
                { 
                    Button button = new Button();
                    button.Visible = true;
                    button.Dock = DockStyle.Fill;
                    button.Padding = new Padding(0);
                    button.Margin = new Padding(0, 0, 0, 0);
                    if (((i % 2 == 0) & (j % 2 == 0)) | ((i % 2 != 0) & (j % 2 != 0)))
                    {
                        button.BackColor = Color.FromArgb(255, 249, 177);
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(191, 152, 95);
                    }
                    ButtonPieceText(button, i, j);
                    BoardLayoutPanel.Controls.Add(button, i, j);
                }
            }
        }

        private void UpdateTableLayoutPanel()
        {
            foreach (Button c in BoardLayoutPanel.Controls.OfType<Button>())
            {
                
                int i = BoardLayoutPanel.GetPositionFromControl(c).Column;
                int j = BoardLayoutPanel.GetPositionFromControl(c).Row;
                ButtonPieceText(c, i, j); 
            }
        }

        private void ShowLegalMoves()
        {
            foreach (Control button in BoardLayoutPanel.Controls.OfType<Button>())
            {
                int i = BoardLayoutPanel.GetPositionFromControl(button).Column;
                int j = BoardLayoutPanel.GetPositionFromControl(button).Row;

                if ((i == SelectedPiece.Column) & (j == SelectedPiece.Row))
                {
                    button.BackColor = Color.FromArgb(77, 255, 77); 
                }
                
                else if (chessNutBoard.squares[i, j].LegalNextMove == true)
                    {
                    if (((i % 2 == 0) & (j % 2 == 0)) | ((i % 2 != 0) & (j % 2 != 0)))
                    {
                        button.BackColor = Color.FromArgb(51, 186, 56);
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(28, 94, 28);
                    }
                }
                else
                {
                    if (((i % 2 == 0) & (j % 2 == 0)) | ((i % 2 != 0) & (j % 2 != 0)))
                    {
                        button.BackColor = Color.FromArgb(255, 249, 177);
                    }
                    else
                    {
                        button.BackColor = Color.FromArgb(191, 152, 95);
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

        private void ButtonPieceText(Button button, int x, int y)
        {
            Piece pieceToDraw = null;
            foreach (Piece piece in blackPieces)
            {
                
                if ((piece.Column == x) & (piece.Row == y))
                {
                    pieceToDraw = piece;
                }
                
            }
            foreach (Piece piece in whitePieces)
            {

                if ((piece.Column == x) & (piece.Row == y))
                {
                    pieceToDraw = piece;
                }

            }
            if (pieceToDraw == null)
            {
                button.Text = "";
                return ;
            }

            string icon = "";
            string outline = "";
            switch (pieceToDraw.Class)
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
            switch (pieceToDraw.Color)
            {
                case "Black":
                    button.Text = icon;
                    button.Font = new Font("Chess TFB", 30);
                    button.ForeColor = Color.Black;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    break;

                case "White":
                    button.Text = icon;
                    button.Font = new Font("Chess TFB", 30);
                    button.ForeColor = Color.Gray;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    //e.Graphics.DrawString(icon, new Font("Chess TFB", 40), new SolidBrush(Color.White), (piece.Column - 1 / 2) * square_size + border_size, piece.Row * square_size + border_size);
                    //e.Graphics.DrawString(outline, new Font("Chess TFB", 40), new SolidBrush(Color.Black), (piece.Column - 1 / 2) * square_size + border_size, piece.Row * square_size + border_size);
                    break;
            }
        }

        private void Draw_CurrentInfo(object sender, PaintEventArgs e)
        {
            // print number of avalible moves

            // Moves.Text        = "Possible Moves        : " + SelectedPiece.AvailableMoves.Count.ToString();
            //  CurrentPiece.Text = "Current Piece       : " + SelectedPiece.Name.ToString();
            // Takable.Text      = "Takable Pieces      : 0";
            
            TakenBlack.Text       = "Taken Black Pieces : " + blackPiecesTaken.Count.ToString();
            BlackCheckStatus.Text = "Black Check Status : " + blackCheckStatus;

            TakenWhite.Text       = "Taken White Pieces : " + whitePiecesTaken.Count.ToString();
            WhiteCheckStatus.Text = "White Check Status : " + whiteCheckStatus;

            CurrentTurnBox.Text   = "Current Turn : " + turn;
            Score.Text            = "Score W-B   : " + WhiteScore.ToString() + "-" + BlackScore.ToString();
        }

        private void Table_Load(object sender, PaintEventArgs e)
        {
            Draw_Title(sender, e);
            Draw_Labels(sender, e);
            Draw_CurrentInfo(sender, e);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            GameOverCheck(sender, e);
            if (SelectedPiece!= null)
            {
                SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);

                List<Move> moves = new List<Move>();
                foreach (Move avaliableMove in SelectedPiece.AvailableMoves)
                {
                    moves.Add(avaliableMove);
                }
                UpdateTableLayoutPanel();
            }
            ShowLegalMoves();
        }
        private void CheckChecker()
        {
            string blackCheckStatus_ = "Free";

            // check players pieces for check
            foreach (Piece piece in whitePieces)
            {
                List<Move> MovesToCheck = chessNutBoard.MarkNextLegalMoves(chessNutBoard, piece);

                foreach (Move move in MovesToCheck)
                {
                    //MessageBox.Show(move.TakablePiece.Name + " "+piece.Name);
                    if (move.TakablePiece.Name == "Black King")
                    {
                        MessageBox.Show("Black in Check");
                        blackCheckStatus_ = "Check";
                    }
                }
            }
            blackCheckStatus = blackCheckStatus_;

            string whiteCheckStatus_ = "Free";
            // check opponents pieces for check
            foreach (Piece piece in blackPieces)
            {
                List<Move> MovesToCheck = chessNutBoard.MarkNextLegalMoves(chessNutBoard, piece);

                foreach (Move move in MovesToCheck)
                {
                    if (move.TakablePiece.Name == "White King")
                    {
                        MessageBox.Show("White in Check");
                        whiteCheckStatus_ = "Check";
                    }
                }
            }
            whiteCheckStatus = whiteCheckStatus_;
        }

        private void MovePiece(object sender, EventArgs e, Piece pieceToMove)
        {
            // move piece
            chessNutBoard.squares[pieceToMove.PrevColumn, pieceToMove.PrevRow].CurrentlyOccupied = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
            chessNutBoard.squares[pieceToMove.Column, pieceToMove.Row].CurrentlyOccupied = pieceToMove;

            // set last piece moved (needed for en passant)
            foreach (Piece piece in blackPieces)
            {
                piece.LastPieceMoved = false;
            }
            foreach (Piece piece in whitePieces)
            {
                piece.LastPieceMoved = false;
            }
            pieceToMove.LastPieceMoved = true;

            // new take system
            Piece pieceToTake = null;
            foreach (Move move in pieceToMove.AvailableMoves)
            {
                if ((move.Column == pieceToMove.Column) & (move.Row == pieceToMove.Row))
                {
                    pieceToTake = move.TakablePiece;
                }
            }

            if (pieceToTake != null)
            {
                switch (pieceToTake.Color)
                {
                    case "White":
                        whitePiecesTaken.Add(pieceToTake);
                        whitePieces.Remove(pieceToTake);
                        break;

                    case "Black":
                        blackPiecesTaken.Add(pieceToTake);
                        blackPieces.Remove(pieceToTake);
                        break;
                }
            }
            
            // reset selected piece
            SelectedPiece = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
            Table_Load(sender, e);
            this.Invalidate();
        }
        private void ResetGame(object sender, EventArgs e)
        {
            ResetPieces();
            initialise_table();
            UpdateTableLayoutPanel();
            Table_Load(sender, e);
            turn = "White";
            this.Invalidate();
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
        private void AssignClickEvent()
        {
            foreach (Control c in BoardLayoutPanel.Controls.OfType<Button>())
            {
                c.Click += new EventHandler(OnClick);
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            int column = BoardLayoutPanel.GetPositionFromControl(button).Column;
            int row = BoardLayoutPanel.GetPositionFromControl(button).Row;

            // select a piece
            string nextTurn = turn;
            if (SelectedPiece.Name == "Nothing")
            {
                switch (turn)
                {
                    case "White":
                        foreach (Piece piece in whitePieces)
                        {
                            if ((piece.Column == column) & (piece.Row == row))
                            {
                                SelectedPiece = piece;
                            }
                        }
                        foreach (Piece piece in blackPieces)
                        {
                            if ((piece.Column == column) & (piece.Row == row))
                            {
                                MessageBox.Show("White's Turn");
                            }
                        }
                        break;

                    case "Black":
                        foreach (Piece piece in blackPieces)
                        {
                            if ((piece.Column == column) & (piece.Row == row))
                            {
                                SelectedPiece = piece;
                            }
                        }
                        foreach (Piece piece in whitePieces)
                        {
                            if ((piece.Column == column) & (piece.Row == row))
                            {
                                MessageBox.Show("Black's Turn");
                            }
                        }
                        break;
                }
                SelectedPiece.AvailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard, SelectedPiece);
                Table_Load(sender, e);
            }

            //select a move
            else
            {
                foreach (Move move in SelectedPiece.AvailableMoves)
                {
                    if ((move.Row == row) & (move.Column == column))
                    {
                        SelectedPiece.PrevColumn = SelectedPiece.Column;
                        SelectedPiece.PrevRow    = SelectedPiece.Row;

                        SelectedPiece.Column = move.Column;
                        SelectedPiece.Row    = move.Row;

                        SelectedPiece.NumberOfTimesMoved += 1;

                        MovePiece(sender, e, SelectedPiece);
                        CheckChecker();

                        switch (turn)
                        {
                            case "White":
                                nextTurn = "Black";
                                break;

                            case "Black":
                                nextTurn = "White";
                                break;
                        }
                        turn = nextTurn;
                        Table_Load(sender, e);
                    }
                }
                SelectedPiece = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetGame(sender, e);
        }

        private void CheckStatus_Click(object sender, EventArgs e)
        {

        }

        private void AvailableMoves_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void BoardLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}