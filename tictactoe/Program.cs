using System;

namespace tictactoe
{
    class Program
    {

        static void Main(string[] arg)
        {
            // Pre-Game Norms
            Console.WriteLine("Welcome to the tic-tac-toe.\nBefore we begin..");
            Console.WriteLine("Please provide user details.\n");
            Console.Write("First player's name :\t");
            string player1 = Console.ReadLine();

            Console.Write("Second player's name :\t");
            string player2 = Console.ReadLine();

            Console.WriteLine("Ready to begin....\nPreparing the board....");

            Board();

            //Conditions
            bool game = true;
            int playerTurn = 2;
            string winner = "";
            int turnCount = 1;

            

            //starting the game
            Console.WriteLine(player1 + " goes first.");

            // Board Engine
            string[] positions = new string[9];
            for (int i = 0; i < 9; i++)
            {
                positions[i] = Convert.ToString(i);
            }

            //Game engine
            while (game == true)
            {
                int counter = 0;
                if(playerTurn % 2 == 0)
                {
                    Console.WriteLine("============================================================\n");
                    Console.Write(player1 + " selects Position:\t");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if(positions[input] !="X" && positions[input] != "O")
                    {
                        positions[input] = "X";
                        playerTurn++;

                        for (int x = 0; x < 3; x++)
                        {
                            for (int y = 0; y < 3; y++)
                            {

                                Console.Write("\t" + positions[counter] + "\t");
                                counter++;
                            }
                            Console.WriteLine("\n");
                        }
                        turnCount++;
                     

                    }
                    else
                    {
                        Console.WriteLine("Position already marked.");
                    }
                }
                else
                {
                    Console.WriteLine("============================================================\n");
                    Console.Write(player2 + " Selects Position:\t");
                    int input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (positions[input] != "X" && positions[input] != "O")
                    {
                        positions[input] = "O";
                        playerTurn++;

                        for (int x = 0; x < 3; x++)
                        {
                            for (int y = 0; y < 3; y++)
                            {

                                Console.Write("\t" + positions[counter] + "\t");
                                counter++;
                            }
                            Console.WriteLine("\n");
                        }
                        turnCount++;
                    }
                    else
                    {
                        Console.WriteLine("Position already marked.");
                    }

                }

                if (((positions[0] == "X") && (positions[1] == "X") && (positions[2] == "X")) || ((positions[0] == "X") && (positions[3] == "X") && (positions[6] == "X")) || ((positions[0] == "X") && (positions[4] == "X") && (positions[8] == "X")) || ((positions[3] == "X") && (positions[4] == "X") && (positions[5] == "X")) || ((positions[1] == "X") && (positions[4] == "X") && (positions[7] == "X")) || ((positions[6] == "X") && (positions[4] == "X") && (positions[2] == "X")) || ((positions[6] == "X") && (positions[7] == "X") && (positions[8] == "X")) || ((positions[2] == "X") && (positions[5] == "X") && (positions[8] == "X")))
                {
                    game = false;
                    winner = player1;
                }
                else if (((positions[0] == "O") && (positions[1] == "O") && (positions[2] == "O")) || ((positions[0] == "0") && (positions[3] == "O") && (positions[6] == "O")) || ((positions[0] == "O") && (positions[4] == "O") && (positions[8] == "O")) || ((positions[3] == "O") && (positions[4] == "O") && (positions[5] == "O")) || ((positions[1] == "O") && (positions[4] == "O") && (positions[7] == "O")) || ((positions[6] == "O") && (positions[4] == "O") && (positions[2] == "O")) || ((positions[6] == "O") && (positions[7] == "O") && (positions[8] == "O")) || ((positions[2] == "O") && (positions[5] == "O") && (positions[8] == "O")))
                {
                    game = false;
                    winner = player2;
                }
                else if(turnCount > 9)
                {
                    game = false;
                    winner = "By none. IT'S A TIE.";
                } 




            }

            Console.WriteLine("\n");
            Console.Write("Game won by : \t" + winner);

            
            
        }


        static void Board()
        {
            int[] positions = new int[9];
            for (int i = 0; i < 9; i++)
            {
                positions[i] = i;
            }
            int counter = 0;
            for(int x=0; x<3; x++)
            {
                for(int y=0; y<3; y++)
                {
                    
                    Console.Write("\t" + positions[counter] + "\t" );
                    counter++;
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("=============================================================\n");
            Console.WriteLine("RULES: \n");
            Console.WriteLine("1. Player shall enter the same number that is on the board to mark the respective position.\n" +
                              "\tExample : if user intend to mark the 1st position(1st row, 1 column) input must be 0.\n" +
                              "2. User's turns will be alternatively.\n\n");
            Console.WriteLine("Starting the game......\n\n");   
        }

 
    }
}
