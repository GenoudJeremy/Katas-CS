using System;

namespace TicTacToe
{
    public class Program {

        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Tic Tac Toe");

            Grid grid = new Grid();
            GameEnded gameEnded = new GameEnded(grid);
            string winner = "";
            int count = 1;
            while (!gameEnded.IsGameFinished() && count <= 9){
                Console.WriteLine($"Player {grid.GetToken()} it's your turn - Turn {count}");
                ConsoleWriteGrid(grid);
                Console.WriteLine($"Provide Coordinate between 0,0 and 3,3 : ");

                var input = Console.ReadLine();
                if (input != null) {
                    string[] splitInput = input.Split(',');

                    if (splitInput.Length == 2) {
                        try {
                            int x = Int32.Parse(splitInput[0]);
                            int y = Int32.Parse(splitInput[1]);

                            winner = grid.GetToken();
                            grid.TakeCell(new int[2] {x, y});
                        } catch(FormatException e) {
                            Console.WriteLine("Please provide a valid format.");
                        }
                    } else {
                        Console.WriteLine("Please provide a valid format.");
                    }
                } else {
                    Console.WriteLine("Please provide a valid format.");
                }
            }
            
            ConsoleWriteGrid(grid);
            if (gameEnded.IsGameFinished()){
                
                Console.WriteLine($"Winner is : {winner}");
            }
        }

        static void ConsoleWriteGrid(Grid grid){

            string?[,] cells = grid.GetGrid();
            Console.WriteLine(" _ _ _ ");
            Console.WriteLine($"|{cells[0,2] ?? "_"}|{cells[1,2]?? "_"}|{cells[2,2]?? "_"}|");
            Console.WriteLine($"|{cells[0,1] ?? "_"}|{cells[1,1]?? "_"}|{cells[2,1]?? "_"}|");
            Console.WriteLine($"|{cells[0,0] ?? "_"}|{cells[1,0]?? "_"}|{cells[2,0]?? "_"}|");
        }
    }
}