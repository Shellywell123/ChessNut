﻿using System;
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
        Selection Selected2 = new Selection();

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();

            Selected.SelectedRow = 0;
            Selected.SelectedColumn = 0;
            Selected.SelectedPiece = "";
            Selected.SelectedPieceColor = "White";

            Selected2.SelectedRow = 0;
            Selected2.SelectedColumn = 0;
            Selected2.SelectedPiece = "";
            Selected2.SelectedPieceColor = "Black";
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

        private void Draw_Piece(object sender, PaintEventArgs e, Selection selected)
        {
            string icon = "";
            switch (selected.SelectedPiece)
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
            switch (selected.SelectedPieceColor)
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
                    Console.Write(x.ToString() + y.ToString());

                    if ((x == selected.SelectedColumn) & (y == selected.SelectedRow))
                    {
                        e.Graphics.DrawString(icon, new Font("Chess TFB", 35), brush, x * square_size + border_size, y * square_size + border_size+1);
                    }
                    else if (s.LegalNextMove == true)
                    {
                        e.Graphics.DrawString("+", new Font("Verdana", 20), brush, x * square_size + border_size, y * square_size + border_size);
                    }
                    else
                    {
                        e.Graphics.DrawString(" ", new Font("Verdana", 20), brush, x * square_size + border_size, y * square_size + border_size);
                    }
                }
            }
        }

        private void Table_Load(object sender, PaintEventArgs e)
        {
            Draw_Title(sender, e);
            Draw_Board(sender, e);
            Draw_Labels(sender, e);

            Draw_Piece(sender, e, Selected);
            Draw_Piece(sender, e, Selected2);

            //Draw_AvailableMoves(sender, e);
           // Draw_AvailableMoves2(sender, e);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            chessNutBoard.squares[Selected.SelectedColumn, Selected.SelectedRow].CurrentlyOccupied = true;
            //Selected.SelectedAvalailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected.SelectedColumn, Selected.SelectedRow], Selected.SelectedPiece);

            chessNutBoard.squares[Selected2.SelectedColumn, Selected2.SelectedRow].CurrentlyOccupied = true;
            //Selected2.SelectedAvalailableMoves = chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected2.SelectedColumn, Selected2.SelectedRow], Selected2.SelectedPiece);
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
            string message = "Possible Moves: " + Selected.SelectedAvalailableMoves.ToString();
            e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 140);   
        }

        private void PieceSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected piece 
            Selected2.SelectedPiece = PieceSelectionBox2.GetItemText(this.PieceSelectionBox2.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void RowSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected row
            Selected2.SelectedRow = 7 - RowSelectionBox2.SelectedIndex;
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void ColumnSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            // set currently selected column
            Selected2.SelectedColumn = ColumnSelectionBox2.SelectedIndex;
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void Draw_AvailableMoves2(object sender, PaintEventArgs e)
        {
            // print number of avalible moves
            string message = "Possible Moves: " + Selected2.SelectedAvalailableMoves.ToString();
            e.Graphics.DrawString(message, new Font("Verdana", 10), new SolidBrush(Color.Black), square_size * 8 + border_size + 15, 250);
        }

        private void ColorSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.SelectedPieceColor = SelectionColorBox.GetItemText(this.SelectionColorBox.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void ColorSelectionBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            Selected2.SelectedPieceColor = SelectionColorBox2.GetItemText(this.SelectionColorBox2.SelectedItem);
            Table_Load(sender, e);
            this.Invalidate();
        }
    }
}