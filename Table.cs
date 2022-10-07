using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessNut
{
    public partial class Table : Form
    { 

        static Board chessNutBoard = new Board(8);
        Selection Selected = new Selection();

        int border_size = 50;
        int square_size = 50;

        public Table()
        {
            InitializeComponent();
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
                        e.Graphics.FillRectangle(blackBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(whiteBrush, x * square_size + border_size, y * square_size + border_size, square_size, square_size);
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
                    icon = "K";
                    break;

                case "Queen":
                    icon = "Q";
                    break;

                case "Rook":
                    icon = "R";
                    break;

                case "Knight":
                    icon = "k";
                    break;

                case "Bishop":
                    icon = "B";
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
                        e.Graphics.DrawString(icon, new Font("Verdana", 20), new SolidBrush(Color.Black), x * square_size + border_size, y * square_size + border_size);

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
        private void Refresh_Button(object sender, PaintEventArgs e)
        {
            // Creating and setting the properties of Button
            Button Mybutton = new Button();
            Mybutton.Location = new Point(10 * square_size + 2 * border_size, border_size + 130);
            Mybutton.Text = "Refresh";
            Mybutton.AutoSize = true;
            Mybutton.BackColor = Color.LightBlue;
            //Mybutton.Click += (sender, e) =>
            //{
             //   MessageBox.Show("Button Clicked");
            //};

            // Adding this button to form
            this.Controls.Add(Mybutton);
        }


        private void Table_Load(object sender, PaintEventArgs e)
        {
            
            Selected.SelectedRow = 0;
            Selected.SelectedColumn = 0;
            //Draw_Board(sender, e);
            Draw_Labels(sender, e);
            Draw_Title(sender, e);
            //Draw_Test_Piece(sender, e);

            chessNutBoard.squares[Selected.SelectedRow, Selected.SelectedColumn].CurrentlyOccupied = true;
            chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected.SelectedRow, Selected.SelectedColumn], "Knight");
            Draw_Piece(sender, e, "Knight");
            //Refresh_Button(sender, e);
        }

        private void Table_Load(object sender, EventArgs e)
        {
            chessNutBoard.squares[Selected.SelectedRow, Selected.SelectedColumn].CurrentlyOccupied = true;
            chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[Selected.SelectedRow, Selected.SelectedColumn], "Knight");
            //Draw_Piece(sender, e, "Knight");
        }

        private void PieceSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set currently selected piece 
        }

        private void RowSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.SelectedRow = RowSelectionBox.SelectedIndex;
            Table_Load(sender, e);
            this.Invalidate();
        }

        private void ColumnSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected.SelectedColumn = ColumnSelectionBox.SelectedIndex;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public class Selection
    {
        public string SelectedPiece { get; set; }
        public int SelectedRow { get; set; }
        public int SelectedColumn { get; set; }
    }
}