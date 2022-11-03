using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.IO;

namespace ChessNut
{
    public class Board
    {
        // size of the board
        public int Size { get; set; }

        // 2d array
        public Square[,] squares { get; set; }

        string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };

        // constructor
        public Board(int s)
        {
            // intial board size
            Size = s;
            squares = new Square[Size, Size];

            // new 2d array
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    squares[i, j] = new Square(i, j);
                }
            }
        }
        public List<Move> AppendLegalMove(Board currentBoard, Piece currentPiece, List<Move> availableMoves, int x, int y)
           {
            Piece takablePiece;
            if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
            {
                takablePiece = currentBoard.squares[x, y].CurrentlyOccupied;
            }
            else
            {
                takablePiece = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 };
            }
            availableMoves.Add(new Move
            {
                BoardPosition = letters[x] + (8 - y).ToString(),
                Column = x,
                Row = y,
                TakablePiece = takablePiece
            });
            return availableMoves;
        }
        public List<Move> MarkNextLegalMoves(Board currentBoard, Piece currentPiece)
        {
            // clear the board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    squares[i, j].LegalNextMove = false;
                }
            }

            // piece is not null return no moves
            if (currentPiece.Name == "Nothing")
            {
                return new List<Move> { };
            }

            List<Move> availableMoves = new List<Move>();

            // find all legal moves on board and mark them 
            switch (currentPiece.Class)
            {
                case "Knight":
                    List<Move> allowedKnightMoves = new List<Move>();

                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column + 2), Row = (currentPiece.Row + 1) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column + 2), Row = (currentPiece.Row - 1) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column - 2), Row = (currentPiece.Row + 1) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column - 2), Row = (currentPiece.Row - 1) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column + 1), Row = (currentPiece.Row + 2) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column + 1), Row = (currentPiece.Row - 2) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column - 1), Row = (currentPiece.Row + 2) });
                    allowedKnightMoves.Add(new Move {Column = (currentPiece.Column - 1), Row = (currentPiece.Row - 2) });

                    foreach (Move allowedKnightMove in allowedKnightMoves)
                    {
                        int x = allowedKnightMove.Column;
                        int y = allowedKnightMove.Row;

                        if (SquareOnBoard(x, y) == true)
                        {
                            if (currentBoard.squares[x, y].CurrentlyOccupied.Color != currentPiece.Color)
                            {
                                currentBoard.squares[x, y].LegalNextMove = true;
                                availableMoves = AppendLegalMove(currentBoard,currentPiece, availableMoves, x, y);
                            }
                        }
                    }
                    break;

                case "King":
                    List<Move> allowedKingMoves = new List<Move>();

                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column + 1), Row = (currentPiece.Row + 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column + 1), Row = (currentPiece.Row - 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column + 1), Row = (currentPiece.Row + 0) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column + 0), Row = (currentPiece.Row + 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column + 0), Row = (currentPiece.Row - 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column - 1), Row = (currentPiece.Row + 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column - 1), Row = (currentPiece.Row - 1) });
                    allowedKingMoves.Add(new Move {Column = (currentPiece.Column - 1), Row = (currentPiece.Row + 0) });

                    foreach (Move allowedKnightMove in allowedKingMoves)
                    {
                        int x = allowedKnightMove.Column;
                        int y = allowedKnightMove.Row;

                        if (SquareOnBoard(x, y) == true)
                        {
                            if (currentBoard.squares[x, y].CurrentlyOccupied.Color != currentPiece.Color)
                            {
                                currentBoard.squares[x, y].LegalNextMove = true;
                                availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);
                            }
                        }
                    }
                    break;

                case "Pawn":

                    int direction = 0;
                    switch (currentPiece.Color)
                    {
                        case "White":
                            direction = -1;
                            break;

                        case "Black":
                            direction = +1;
                            break;
                    }
                    int xp = currentPiece.Column;
                    int yp = currentPiece.Row + direction;

                    // straight ahead moves
                    int[] yDirs = { 0, + direction};
                    foreach (int yDir in yDirs)
                    {
                        // straight ahead move
                        if (SquareOnBoard(xp, yp + yDir) == true)
                        {
                            if (currentBoard.squares[xp, yp].CurrentlyOccupied.Name == "Nothing")
                            {
                                currentBoard.squares[xp, yp + yDir].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = letters[xp] + (8 - yp).ToString(),
                                    Column = xp,
                                    Row = yp + yDir,
                                    TakablePiece = new Piece { Name = "Nothing", AvailableMoves = new List<Move>(), Column = -1, Row = -1 }
                                });
                            }
                        }
                    }

                    // diagonal take moves
                    int[] diagXDir= { +1, -1 };
                    foreach ( int xDir in diagXDir)
                    {
                        if (SquareOnBoard(xp + xDir, yp) == true)
                        {
                            if (currentBoard.squares[xp + xDir, yp].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                            {
                                currentBoard.squares[xp + xDir, yp].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = letters[xp + xDir] + (8 - yp).ToString(),
                                    Column = xp + xDir,
                                    Row = yp,
                                    TakablePiece = currentBoard.squares[xp + xDir, yp].CurrentlyOccupied
                                }); ;
                            }
                        }
                    }
                    break;

                case "Rook":
                    availableMoves = Top(currentBoard, currentPiece, availableMoves);
                    availableMoves = Right(currentBoard, currentPiece, availableMoves);
                    availableMoves = Bottom(currentBoard, currentPiece, availableMoves);
                    availableMoves = Left(currentBoard, currentPiece, availableMoves);
                    break;

                case "Bishop":
                    availableMoves = TopLeft(currentBoard, currentPiece, availableMoves);
                    availableMoves = TopRight(currentBoard, currentPiece, availableMoves);
                    availableMoves = BottomRight(currentBoard, currentPiece, availableMoves);
                    availableMoves = BottomLeft(currentBoard, currentPiece, availableMoves);
                    break;

                case "Queen":
                    availableMoves = Top(currentBoard, currentPiece, availableMoves);
                    availableMoves = Right(currentBoard, currentPiece, availableMoves);
                    availableMoves = Bottom(currentBoard, currentPiece, availableMoves);
                    availableMoves = Left(currentBoard, currentPiece, availableMoves);
                    availableMoves = TopLeft(currentBoard, currentPiece, availableMoves);
                    availableMoves = TopRight(currentBoard, currentPiece, availableMoves);
                    availableMoves = BottomRight(currentBoard, currentPiece, availableMoves);
                    availableMoves = BottomLeft(currentBoard, currentPiece, availableMoves);
                    break;
            }
            return availableMoves;
        }

        public List<Move> Right(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];
            // right
            for (int x = currentPiece.Column; x < 8; x++)
            {
                int y = currentPiece.Row;
                //ignore currently occupied square
                if (x == currentSquare.RowNumber)
                {
                    continue;
                }

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                {
                    return availableMoves;
                }

                currentBoard.squares[x, y].LegalNextMove = true;
                availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                {
                    return availableMoves;
                }
            }
            return availableMoves;
        }

        public List<Move> Left(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];
            // left
            for (int x = currentPiece.Column; x >= 0; x--)
            {
                int y = currentPiece.Row;
                //ignore currently occupied square
                if (x == currentSquare.RowNumber)
                {
                    continue;
                }

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                {
                    return availableMoves;
                }

                currentBoard.squares[x, y].LegalNextMove = true;
                availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                {
                    return availableMoves;
                }
            }
            return availableMoves;
        }

        public List<Move> Bottom(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];
            // bottom
            for (int y = currentPiece.Row; y < 8; y++)
            {
                int x = currentPiece.Column;
                //ignore currently occupied square
                if (y == currentSquare.ColumnNumber)
                {
                    continue;
                }

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                {
                    return availableMoves;
                }

                currentBoard.squares[x, y].LegalNextMove = true;
                availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                {
                    break;
                }
            }
            return availableMoves;
        }
        public List<Move> Top(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];
            //top
            for (int y = currentPiece.Row; y >= 0; y--)
            {
                int x = currentPiece.Column;
                //ignore currently occupied square
                if (y == currentPiece.Row)
                {
                    continue;
                }

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                {
                    return availableMoves;
                }

                currentBoard.squares[x, y].LegalNextMove = true;
                availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                {
                    break;
                }
            }
            return availableMoves;
        }
        public List<Move> TopLeft(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        { 
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];
        
            // top left
            for (int x = currentPiece.Column; x >= 0; x--)
            {
                for (int y = currentPiece.Row; y >= 0; y--)
                {
                    // ignore currently occupied square
                    if ((x == currentSquare.RowNumber) & (y == currentSquare.ColumnNumber))
                    {
                        continue;
                    }

                    // y=-x
                    if ((x - currentSquare.RowNumber) == (y - currentSquare.ColumnNumber))
                    {
                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                        {
                            return availableMoves;
                        }

                        currentBoard.squares[x, y].LegalNextMove = true;
                        availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                        {
                            return availableMoves;
                        }
                    }
                }
            }
            return availableMoves;
        }
        public List<Move> TopRight(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {

            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];

            for (int x = currentPiece.Column; x < 8; x++)
            {
                for (int y = currentPiece.Row; y >= 0; y--)
                {
                    // ignore currently occupied square
                    if ((x == currentSquare.RowNumber) & (y == currentSquare.ColumnNumber))
                    {
                        continue;
                    }

                    // y=x
                    if ((x - currentSquare.RowNumber) == -(y - currentSquare.ColumnNumber))
                    {
                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                        {
                            return availableMoves;
                        }

                        currentBoard.squares[x, y].LegalNextMove = true;
                        availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                        {
                            break;
                        }
                    }
                }
            }
            return availableMoves;
        }
        public List<Move> BottomRight(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];

            // bottom right
            for (int x = currentPiece.Column; x < 8; x++)
            {
                for (int y = currentPiece.Row; y < 8; y++)
                {
                    // ignore currently occupied square
                    if ((x == currentPiece.Column) & (y == currentPiece.Row))
                    {
                        continue;
                    }

                    // y=x
                    if ((x - currentSquare.RowNumber) == (y - currentSquare.ColumnNumber))
                    {
                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                        {
                            return availableMoves;
                        }

                        currentBoard.squares[x, y].LegalNextMove = true;
                        availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                        {
                            break;
                        }
                    }
                }
            }
            return availableMoves;
        }

        public List<Move> BottomLeft(Board currentBoard, Piece currentPiece, List<Move> availableMoves)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];

            for (int x = currentPiece.Column; x >= 0; x--)
            {
                for (int y = currentPiece.Row; y < 8; y++)
                {
                    // ignore currently occupied square
                    if ((x == currentSquare.RowNumber) & (y == currentSquare.ColumnNumber))
                    {
                        continue;
                    }

                    // y=x
                    if ((x - currentSquare.RowNumber) == -(y - currentSquare.ColumnNumber))
                    {
                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == currentPiece.Color)
                        {
                            return availableMoves;
                        }

                        currentBoard.squares[x, y].LegalNextMove = true;
                        availableMoves = AppendLegalMove(currentBoard, currentPiece, availableMoves, x, y);

                        if (currentBoard.squares[x, y].CurrentlyOccupied.Color == OppositeColor(currentPiece.Color))
                        {
                            return availableMoves;
                        }
                    }
                }
            }
            return availableMoves;
        }
        public bool SquareOnBoard(int RowNumber, int ColumnNumber)
        {
            bool onBoard = false;
            if ((0 <= RowNumber) & (RowNumber < 8) & (0 <= ColumnNumber) & (ColumnNumber < 8))
            {
                onBoard = true;
            }
            return onBoard;
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
    }
}