﻿using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace ChessNut
{

    public class Board
    {
        // size of the board
        public int Size { get; set; }

        // 2d array
        public Square[,] squares { get; set; }

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
        public List<Move> MarkNextLegalMoves(Board currentBoard, Piece currentPiece)
        {
            Square currentSquare = currentBoard.squares[currentPiece.Column, currentPiece.Row];

            squares = currentBoard.squares;
            // clear the board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    squares[i, j].LegalNextMove = false;
                    //squares[i, j].CurrentlyOccupied = false;
                }
            }

            // reset currently occupied square as it was cleared earlier
            //currentBoard.squares[currentPiece.Column, currentPiece.Row].CurrentlyOccupied = true;
            //currentBoard.squares[otherPiece.Column, otherPiece.Row].CurrentlyOccupied = true;

            //int availableMoves = 0;
            List<Move> availableMoves = new List<Move>();

            // find all legal moves on board and mark them 
            switch (currentPiece.Class)
            {
                case "Knight":
                    // can be rewitten 
                    if (SquareOnBoard(currentSquare.RowNumber + 2, currentSquare.ColumnNumber + 1) == true)
                    {
                        squares[currentSquare.RowNumber + 2, currentSquare.ColumnNumber + 1].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber + 2, currentSquare.ColumnNumber - 1) == true)
                    {
                        squares[currentSquare.RowNumber + 2, currentSquare.ColumnNumber - 1].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber - 2, currentSquare.ColumnNumber + 1) == true)
                    {
                        squares[currentSquare.RowNumber - 2, currentSquare.ColumnNumber + 1].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber - 2, currentSquare.ColumnNumber - 1) == true)
                    {
                        squares[currentSquare.RowNumber - 2, currentSquare.ColumnNumber - 1].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber + 1, currentSquare.ColumnNumber + 2) == true)
                    {
                        squares[currentSquare.RowNumber + 1, currentSquare.ColumnNumber + 2].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber + 1, currentSquare.ColumnNumber - 2) == true)
                    {
                        squares[currentSquare.RowNumber + 1, currentSquare.ColumnNumber - 2].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber - 1, currentSquare.ColumnNumber + 2) == true)
                    {
                        squares[currentSquare.RowNumber - 1, currentSquare.ColumnNumber + 2].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    if (SquareOnBoard(currentSquare.RowNumber - 1, currentSquare.ColumnNumber - 2) == true)
                    {
                        squares[currentSquare.RowNumber - 1, currentSquare.ColumnNumber - 2].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                    }
                    break;

                case "King":
                    int leftLim = currentSquare.ColumnNumber - 1;
                    int rightLim = currentSquare.ColumnNumber + 1;
                    int topLim = currentSquare.RowNumber - 1;
                    int bottomLim = currentSquare.RowNumber + 1;

                    if (leftLim < 0)
                    {
                        leftLim = 0;
                    }
                    if (rightLim > 7)
                    {
                        rightLim = 7;
                    }
                    if (topLim < 0)
                    {
                        topLim = 0;
                    }
                    if (bottomLim > 7)
                    {
                        bottomLim = 7;
                    }

                    for (int i = topLim; i <= bottomLim; i++)
                    {
                        for (int j = leftLim; j <= rightLim; j++)
                        {
                            squares[i, j].LegalNextMove = true;
                            availableMoves.Add(new Move
                            {
                                BoardPosition = i.ToString() + j.ToString(),
                                Column = 0,
                                Row = 0
                            });
                        }
                    }
                    break;

                case "Rook":

                    //top
                    
                    for (int y = currentPiece.Row; y >= 0; y--)
                    {
                        int x = currentPiece.Column;
                        //ignore currently occupied square
                        if (y == currentPiece.Row)
                        {
                            continue;
                        }

                        squares[x, y].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[currentPiece.Column, y].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // right
                    
                    for (int x = currentPiece.Column; x < 8; x++)
                    {
                        int y = currentPiece.Row;
                        //ignore currently occupied square
                        if (x == currentSquare.RowNumber)
                        {
                            continue;
                        }

                        squares[x, currentPiece.Row].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // bottom
                    for (int y = currentPiece.Row; y < 8; y++)
                    {
                        //ignore currently occupied square
                        if (y == currentSquare.ColumnNumber)
                        {
                            continue;
                        }

                        squares[currentPiece.Column, y].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });

                        if (currentBoard.squares[currentPiece.Column, y].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // left
                    for (int x = currentPiece.Column; x >= 0; x--)
                    {
                        int y = currentPiece.Row;
                        //ignore currently occupied square
                        if (x == currentSquare.RowNumber)
                        {
                            continue;
                        }

                        squares[x, y].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[x, currentPiece.Row].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }
                    break;

                case "Bishop":
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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // top right
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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // bottom right
                    for (int x = currentPiece.Column; x < 8; x++)
                    {
                        for (int y = currentPiece.Row; y < 8; y++)
                        {
                            // ignore currently occupied square
                            if ((x == currentSquare.RowNumber) & (y == currentSquare.ColumnNumber))
                            {
                                continue;
                            }

                            // y=x
                            if ((x - currentSquare.RowNumber) == (y - currentSquare.ColumnNumber))
                            {
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // bottom left
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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }
                    break;

                case "Queen":

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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    //top
                    for (int y = currentPiece.Row; y >= 0; y--)
                    {
                        //ignore currently occupied square
                        if (y == currentPiece.Row)
                        {
                            continue;
                        }

                        squares[currentPiece.Column, y].LegalNextMove = true;
                        availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });

                        if (currentBoard.squares[currentPiece.Column, y].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // top right
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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // right
                    for (int x = currentPiece.Column; x < 8; x++)
                    {
                        int y = currentPiece.Row;
                        //ignore currently occupied square
                        if (x == currentSquare.RowNumber)
                        {
                            continue;
                        }

                        squares[x, y].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[x, currentPiece.Row].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // bottom right
                    for (int x = currentPiece.Column; x < 8; x++)
                    {
                        for (int y = currentPiece.Row; y < 8; y++)
                        {
                            // ignore currently occupied square
                            if ((x == currentSquare.RowNumber) & (y == currentSquare.ColumnNumber))
                            {
                                continue;
                            }

                            // y=x
                            if ((x - currentSquare.RowNumber) == (y - currentSquare.ColumnNumber))
                            {
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // bottom
                    for (int y = currentPiece.Row; y < 8; y++)
                    {
                        int x = currentPiece.Column;
                        //ignore currently occupied square
                        if (y == currentSquare.ColumnNumber)
                        {
                            continue;
                        }

                        squares[x, y].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[currentPiece.Column, y].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    // bottom left
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
                                squares[x, y].LegalNextMove = true;
                                availableMoves.Add(new Move
                                {
                                    BoardPosition = x.ToString() + y.ToString(),
                                    Column = 0,
                                    Row = 0
                                });
                            }

                            if (currentBoard.squares[x, y].CurrentlyOccupied == true)
                            {
                                break;
                            }
                        }
                    }

                    // left
                    for (int x = currentPiece.Column; x >= 0; x--)
                    {
                        int y = currentPiece.Row;
                        //ignore currently occupied square
                        if (x == currentSquare.RowNumber)
                        {
                            continue;
                        }

                        squares[x, y].LegalNextMove = true;
                        availableMoves.Add(new Move
                        {
                            BoardPosition = x.ToString() + y.ToString(),
                            Column = 0,
                            Row = 0
                        });

                        if (currentBoard.squares[x, currentPiece.Row].CurrentlyOccupied == true)
                        {
                            break;
                        }
                    }

                    break;

                case "Pawn":
                    // requires a direction based on color/player position

                    
                    switch (currentPiece.Color)
                    {

                        case "White":
                            int x;
                            int y;
                            x = currentPiece.Column;
                            y = currentPiece.Row - 1;

                            currentBoard.squares[x, y].LegalNextMove = true;
                            availableMoves.Add(new Move { 
                                BoardPosition = x.ToString() + y.ToString(), 
                                Column = 0, 
                                Row = 0 });

                            //if (currentBoard.squares[currentPiece.Column + 1, currentPiece.Row - 1].CurrentlyOccupied == true)
                            //{
                            //    currentBoard.squares[currentPiece.Column + 1, currentPiece.Row - 1].LegalNextMove = true;
                            //    availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                            //}
                            //if (currentBoard.squares[currentPiece.Column - 1, currentPiece.Row - 1].CurrentlyOccupied == true)
                            //{
                            //    currentBoard.squares[currentPiece.Column - 1, currentPiece.Row - 1].LegalNextMove = true;
                            //    availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                            //}
                            break;

                        case "Black":
                            int xb;
                            int yb;
                            xb = currentPiece.Column;
                            yb = currentPiece.Row + 1;
                            currentBoard.squares[xb,yb].LegalNextMove = true;
                            availableMoves.Add(new Move
                            {
                                BoardPosition = xb.ToString() + yb.ToString(),
                                Column = 0,
                                Row = 0
                            });

                            //if ((currentBoard.squares[currentPiece.Column + 1, currentPiece.Row + 1].CurrentlyOccupied)))
                            //{
                            //    currentBoard.squares[currentPiece.Column + 1, currentPiece.Row + 1].LegalNextMove = true;
                            //    availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                            //}
                            //if ((currentBoard.squares[currentPiece.Column - 1, currentPiece.Row + 1].CurrentlyOccupied)))
                            //{
                            //    currentBoard.squares[currentPiece.Column - 1, currentPiece.Row + 1].LegalNextMove = true;
                            //    availableMoves.Add(new Move { BoardPosition = "XX", Column = 0, Row = 0 });
                            //}
                            break;
                    }

                    break;
            }

            //return availableMoves;
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
    }
}