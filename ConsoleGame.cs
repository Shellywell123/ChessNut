//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChessNut
//{
//    internal class ConsoleGame
//    {
//        static Board chessNutBoard = new Board(8);
//        public static void printBoard(Board board, string piece)
//        {
//            // piece icon 
//            string icon = "X";
//            switch (piece)
//            {
//                case "King":
//                    icon = "K";
//                    break;

//                case "Queen":
//                    icon = "Q";
//                    break;

//                case "Rook":
//                    icon = "R";
//                    break;

//                case "Knight":
//                    icon = "k";
//                    break;

//                case "Bishop":
//                    icon = "B";
//                    break;
//            }

//            // print chess board to terminal
//            for (int i = 0; i < board.Size; i++)
//            {
//                Console.WriteLine("  .---.---.---.---.---.---.---.---.");
//                Console.Write((8 - i).ToString() + " ");

//                for (int j = 0; j < board.Size; j++)
//                {
//                    Square s = board.squares[i, j];

//                    if (s.CurrentlyOccupied == true)
//                    {
//                        Console.Write("| " + icon + " ");
//                    }
//                    else if (s.LegalNextMove == true)
//                    {
//                        Console.Write("| + ");
//                    }
//                    else
//                    {
//                        Console.Write("|   ");
//                    }
//                }
//                Console.Write("|");
//                Console.WriteLine();
//            }
//            Console.WriteLine("  .---.---.---.---.---.---.---.---.");
//            Console.WriteLine("    A   B   C   D   E   F   G   H ");
//        }

//        private static bool ValidateInput(string input)
//        {
//            int value = 0;
//            if (int.TryParse(input, out value))
//            {
//                if ((0 <= value) & (value < 8))
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        private static Square setCurrentSquare()
//        {
//            int currentRow;
//            int currentColumn;

//            // get x + y coord from user and return a square loc
//            Console.WriteLine("\nEnter the current row number:\n 1, 2, 3, 4, 5, 6, 7, 8");
//            string inputRow = Console.ReadLine();
//            currentRow = 8 - int.Parse(inputRow);

//            // if (ValidateInput("8-"+inputRow) == true)
//            // {
//            //     currentRow = 8-int.Parse(inputRow);
//            // }
//            // else
//            // {
//            //     Console.WriteLine(inputRow
//            //     Console.WriteLine("Invalid input - set to default of 5 (3).");
//            //     currentRow = 3;
//            // }

//            Console.WriteLine("\nEnter the current square Letter:\n - A, B, C, D, E, F, G, H");

//            // to c sharpify
//            string letters = "ABCDEFGH";
//            string inputColumn = (letters.IndexOf((Console.ReadLine()).ToUpper())).ToString();

//            if (ValidateInput(inputColumn) == true)
//            {
//                currentColumn = int.Parse(inputColumn);
//            }
//            else
//            {
//                Console.WriteLine("Invalid input - set to default of D (3).");
//                currentColumn = 3;
//            }

//            chessNutBoard.squares[currentRow, currentColumn].CurrentlyOccupied = true;
//            return chessNutBoard.squares[currentRow, currentColumn];
//        }

//        static void OldMain(string[] args)
//        {
//            // show empty chess board
//            //printBoard(chessNutBoard);

//            // // ask user for piece of choice - clean up input checks
//            // Console.WriteLine("\nEnter the Piece to place:\n - K, King (being fixed)\n - Q, Queen\n - B, Bishop\n - R, Rook\n - k, Knight");
//            // string piece = Console.ReadLine();

//            // // ask user for x any coord - clean up input checks
//            // Square currentSquare = setCurrentSquare();
//            // currentSquare.CurrentlyOccupied = true;


//            // // calc all legal moves for piece
//            // chessNutBoard.MarkNextLegalMoves(currentSquare, piece);

//            // print chess board with piece + legal moves
//            //printBoard(chessNutBoard, piece);



//            //Application.EnableVisualStyles();
//            //Application.SetCompatibleTextRenderingDefault(false);
//            //Application.Run(new Table());

//            // enter key to close program
//            //Console.ReadLine();
//        }
//    }
//}
