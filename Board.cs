using System;
using System.Collections.Generic;
using System.Text;

namespace ChessNut
{
    public class Board
    {
        // size of the board
        public int Size {get; set;}

        // 2d array
        public Square[,] squares {get; set;}

        // constructor
        public Board (int s)
        {
            // intial board size
            Size = s;
            squares = new Square[Size,Size];

            // new 2d array
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    squares[i,j] = new Square(i,j);
                }
            }
        }

        public void MarkNextLegalMoves(Square currentSquare, string chessPiece)
        {
            // clear the board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    squares[i,j].LegalNextMove = false;
                    squares[i,j].CurrentlyOccupied = false;
                }
            }

            // find all legal moves on board and mark them 
            switch (chessPiece)
            {
                case "Knight" or "k":
                    // can be rewitten 
                    if (SquareOnBoard(currentSquare.RowNumber +2, currentSquare.ColumnNumber +1) == true)
                    {
                        squares[currentSquare.RowNumber +2, currentSquare.ColumnNumber +1].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber +2, currentSquare.ColumnNumber -1) == true)
                    {
                        squares[currentSquare.RowNumber +2, currentSquare.ColumnNumber -1].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber -2, currentSquare.ColumnNumber +1) == true)
                    {
                        squares[currentSquare.RowNumber -2, currentSquare.ColumnNumber +1].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber -2, currentSquare.ColumnNumber -1) == true)
                    {
                        squares[currentSquare.RowNumber -2, currentSquare.ColumnNumber -1].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber +1, currentSquare.ColumnNumber +2) == true)
                    {
                        squares[currentSquare.RowNumber +1, currentSquare.ColumnNumber +2].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber +1, currentSquare.ColumnNumber -2) == true)
                    {
                        squares[currentSquare.RowNumber +1, currentSquare.ColumnNumber -2].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber -1, currentSquare.ColumnNumber +2) == true)
                    {
                        squares[currentSquare.RowNumber -1, currentSquare.ColumnNumber +2].LegalNextMove = true;
                    }
                    if (SquareOnBoard(currentSquare.RowNumber -1, currentSquare.ColumnNumber -2) == true)
                    {
                        squares[currentSquare.RowNumber -1, currentSquare.ColumnNumber -2].LegalNextMove = true;
                    }
                    break;

                case "King" or "K":
                    int leftLim = currentSquare.ColumnNumber - 1;
                    int rightLim = currentSquare.ColumnNumber +1;
                    int topLim = currentSquare.RowNumber -1;
                    int bottomLim = currentSquare.RowNumber+1;

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
                        }
                    }
                    break;
                
                case "Rook" or "R":
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if ((i == currentSquare.RowNumber) | (j == currentSquare.ColumnNumber))
                            {
                                squares[i, j].LegalNextMove = true;
                            }
                        }
                    }
                    break;

                case "Bishop" or "B":
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            // can be rewritten to compare squared values instead of 2 if stats
                            if ((((i) - currentSquare.RowNumber )  == ((j) - currentSquare.ColumnNumber)) | (((i) - currentSquare.RowNumber )  == - ((j) - currentSquare.ColumnNumber)))
                            {
                                squares[i, j].LegalNextMove = true;
                            }
                        }
                    } 
                    break;

                case "Queen" or "Q":
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if ((i == currentSquare.RowNumber) | (j == currentSquare.ColumnNumber))
                            {
                                squares[i, j].LegalNextMove = true;
                            }
                            // can be rewritten to compare squared values instead of 2 if stats
                            if (((i) - currentSquare.RowNumber )  == ((j) - currentSquare.ColumnNumber))
                            {
                                squares[i, j].LegalNextMove = true;
                            }
                            if (((i) - currentSquare.RowNumber )  == - ((j) - currentSquare.ColumnNumber))
                            {
                                squares[i, j].LegalNextMove = true;
                            }
                        }
                    }
                    break;

                case "Pawn" or "P":
                    // requires a direction based on color/player position
                    break;
            }
            // reset currnelty occipied square as it was cleared earlier
            squares[currentSquare.RowNumber, currentSquare.ColumnNumber].CurrentlyOccupied = true;
        }

        public bool SquareOnBoard(int RowNumber, int ColumnNumber)
        {
            bool onBoard = false;
            if ((0 <= RowNumber) & (RowNumber < 8 ) & (0 <=ColumnNumber) & (ColumnNumber < 8 ))
            {
                onBoard = true;
            }
            return onBoard;
        }
    }
}