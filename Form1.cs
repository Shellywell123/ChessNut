namespace ChessNut
{
    public partial class Form1 : Form
    {
        //public object SelectedItem { get; set; }

        static Board chessNutBoard = new Board(8);

       // public Rectangle[,] squarePanel = new Rectangle[chessNutBoard.Size, chessNutBoard.Size];

        int border_size = 50;
        int square_size = 50;
        Rectangle rec = new Rectangle(25, 25, 45, 45);


    
        //private Dictionary<Piece, Rectangle> Pieces { get; set; }

        private Point MouseDownLocation;
        public Form1()
        {
            InitializeComponent();
          //  PopulatePanels();
        }

    //  private void PopulatePanels()
    //     {
    //         // create panels
    //         int panelSize = square_size;
    //     }
    // private void InitializeGame()
    //     {

    //         //Board = new Board();

    //         Pieces = new Dictionary<Piece, Rectangle>();
    //         Pieces.Add(new Piece(PieceType.Pawn, PieceColor.Black), new Rectangle(25, 25, 45, 45));
    //     }

        // private void Form1_Paint(object sender, EventArgs e)
        //     {
        //        // InitializeGame();
        //         DrawGame(sender, e);
        //     }
        // private void Draw_Test_Piece(object sender, PaintEventArgs e)
        //     {
        //         e.Graphics.FillRectangle(Brushes.Red, rec);
        //     }

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
                        if (((x%2 == 0) & (y%2 == 0)) | ((x%2 != 0) & (y%2 != 0)))
                        {
                            e.Graphics.FillRectangle(blackBrush, x*square_size+border_size, y*square_size+border_size, square_size, square_size);
                        }
                        else
                        {
                            e.Graphics.FillRectangle(whiteBrush, x*square_size+border_size, y*square_size+border_size, square_size, square_size);
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
                        e.Graphics.DrawString(y.ToString(),new Font("Verdana",10), new SolidBrush(Color.Black),border_size/2-10 ,square_size*(num));
                        num += 1;
                    }
                
                // add letters
                string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
                for (int x = 0; x < letters.Length; x++) 
                    {
                        e.Graphics.DrawString(letters[x],new Font("Verdana",10), new SolidBrush(Color.Black),square_size*x+border_size+10,square_size*8 +border_size);
                    }
        }

        private void Draw_Title(object sender, PaintEventArgs e)
            {
                // add tile
                string[] letters = { "C", "h", "e", "s", "s", "N", "u", "t" };
                for (int x = 0; x < letters.Length; x++) 
                    {
                        e.Graphics.DrawString(letters[x],new Font("Verdana",20), new SolidBrush(Color.Black),square_size*x+border_size+10,0);
                    }
        }

        private string Piece_Selection(object sender, PaintEventArgs e)
        {
            // Creating and setting the properties of label
            Label l = new Label();
            l.Location = new Point(8*square_size+2*border_size,border_size+10);
            l.AutoSize = true;
            l.Text = "Select Piece:";
    
            // Adding this label to the form
            this.Controls.Add(l);
    
            // Creating and setting the properties of comboBox
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(10*square_size+2*border_size,border_size+10);
            mybox.Size = new Size(100, 26);
            mybox.Items.Add("King");
            mybox.Items.Add("Queen");
            mybox.Items.Add("Rook");
            mybox.Items.Add("Bishop");
            mybox.Items.Add("Knight");
            // Adding this ComboBox to the form
            this.Controls.Add(mybox);

            var selected = mybox.GetItemText(mybox.SelectedItem);
           // MessageBox.Show(selected);
            return selected;
        }

        private string Row_Selection(object sender, PaintEventArgs e)
        {
            // Creating and setting the properties of label
            Label l = new Label();
            l.Location = new Point(8*square_size+2*border_size,border_size+50);
            l.AutoSize = true;
            l.Text = "Select Row:";
    
            // Adding this label to the form
            this.Controls.Add(l);
    
            // Creating and setting the properties of comboBox
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(10*square_size+2*border_size,border_size+50);
            mybox.Size = new Size(100, 26);
            mybox.Items.Add("1");
            mybox.Items.Add("2");
            mybox.Items.Add("3");
            mybox.Items.Add("4");
            mybox.Items.Add("5");
            mybox.Items.Add("6");
            mybox.Items.Add("7");
            mybox.Items.Add("8");
            // Adding this ComboBox to the form
            this.Controls.Add(mybox);

            var selected = mybox.GetItemText(mybox.SelectedItem);
           // MessageBox.Show(selected);
            return selected;
        }

        private string Column_Selection(object sender, PaintEventArgs e)
        {
            // Creating and setting the properties of label
            Label l = new Label();
            l.Location = new Point(8*square_size+2*border_size,border_size+90);
            l.AutoSize = true;
            l.Text = "Select Col:";
    
            // Adding this label to the form
            this.Controls.Add(l);
    
            // Creating and setting the properties of comboBox
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(10*square_size+2*border_size,border_size+90);
            mybox.Size = new Size(100, 26);
            mybox.Items.Add("A");
            mybox.Items.Add("B");
            mybox.Items.Add("C");
            mybox.Items.Add("D");
            mybox.Items.Add("E");
            mybox.Items.Add("F");
            mybox.Items.Add("G");
            mybox.Items.Add("H");
            // Adding this ComboBox to the form
            this.Controls.Add(mybox);

            var selected = mybox.GetItemText(mybox.SelectedItem);
           // MessageBox.Show(selected);
            return selected;
        }
        private void Draw_Piece(object sender, PaintEventArgs e, string piece)
        {
            string icon = "X";
            switch (piece)
            {
                case "K" or "King":
                    icon = "K";
                    break;

                case "Q" or "Queen":
                    icon = "Q";
                    break;

                case "R" or "Rook":
                    icon = "R";
                    break;

                case "k" or "Knight":
                    icon = "k";
                    break;

                case "B" or "Bishop":
                    icon = "B";
                    break;
            }
            
            for (int x = 0; x < 8; x++) 
            {
                for (int y = 0; y < 8; y++) 
                {
                    Square s = chessNutBoard.squares[x,y];
                    Console.Write(x.ToString()+y.ToString());

                    if (s.CurrentlyOccupied == true)
                    {
                        e.Graphics.DrawString(icon, new Font("Verdana",20), new SolidBrush(Color.Black),x*square_size+border_size, y*square_size+border_size);
                        
                    }
                    else if (s.LegalNextMove == true)
                    {
                        e.Graphics.DrawString("+",new Font("Verdana",20), new SolidBrush(Color.Black),x*square_size+border_size, y*square_size+border_size);
                        //Console.Write("| + ");new F
                    }
                    else
                    {
                        e.Graphics.DrawString(" ",new Font("Verdana",20), new SolidBrush(Color.Black),x*square_size+border_size, y*square_size+border_size);
                        //Console.Write("|   ");
                    }   
                }
            }
        }
        private void Refresh_Button(object sender, PaintEventArgs e)
        {
             // Creating and setting the properties of Button
        Button Mybutton = new Button();
        Mybutton.Location = new Point(10*square_size+2*border_size,border_size+130);
        Mybutton.Text = "Refresh";
        Mybutton.AutoSize = true;
        Mybutton.BackColor = Color.LightBlue;
        Mybutton.Click += (sender, e) =>
                       {
                           this.Controls.Clear();
                           this.InitializeComponent();
                       };
 
        // Adding this button to form
        this.Controls.Add(Mybutton);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw_Board(sender, e);
            Draw_Labels(sender, e);
            Draw_Title(sender, e);
            //Draw_Test_Piece(sender, e);
            string piece =Piece_Selection(sender, e);
            Column_Selection(sender, e);
            Row_Selection(sender,e);
            // var mybox_ = (mybox)sender;
            // string piece = "";
            chessNutBoard.squares[4,4].CurrentlyOccupied = true;
            chessNutBoard.MarkNextLegalMoves(chessNutBoard.squares[4,4], piece);
            Draw_Piece(sender, e, piece);
            Refresh_Button(sender,e);
        }
        
        // protected override void OnMouseDown(MouseEventArgs e)
        // {
        //     if (e.Button == MouseButtons.Left)
        //     {
        //         MouseDownLocation = e.Location;
        //     }
        // }

        // protected override void OnMouseMove(MouseEventArgs e)
        // {
        //     if ((e.Button == MouseButtons.Left) & ((rec.Left <= e.X) &( e.X <= rec.Right)) & ((rec.Top < e.Y) & (e.Y < rec.Bottom)))
        //     {
        //         rec.Location = new Point((e.X - MouseDownLocation.X) + rec.Left, (e.Y - MouseDownLocation.Y) + rec.Top);
        //         MouseDownLocation = e.Location;
        //         this.Invalidate();
        //     }
        // }

        // public class Piece
        // {
        //     private readonly PieceColor _color;
        //     private readonly PieceType _type;

        //     public Piece(PieceType type, PieceColor color)
        //     {
        //         _type = type;
        //         _color = color;
        //     }

        //     public PieceType Type
        //     {
        //         get { return _type; }
        //     }

        //     public PieceColor Color
        //     {
        //         get { return _color; }
        //     }

            // protected bool Equals(Piece other)
            // {
            //     return _color == other._color && _type == other._type;
            // }

            // public override bool Equals(object obj)
            // {
            //     if (ReferenceEquals(null, obj)) return false;
            //     if (ReferenceEquals(this, obj)) return true;
            //     if (obj.GetType() != GetType()) return false;
            //     return Equals((Piece) obj);
            // }

            // public override int GetHashCode()
            // {
            //     unchecked
            //     {
            //         return ((int) _color*397) ^ (int) _type;
            //     }
            // }

    //public static bool operator ==(Piece left, Piece right)
            // {
            //     return Equals(left, right);
            // }

            // public static bool operator !=(Piece left, Piece right)
            // {
            //     return !Equals(left, right);
            // }
        }

        // public enum PieceType
        // {
        //     Pawn
        // }

        // public enum PieceColor
        // {
        //     Black,
        //     White
        // }
    //}
}