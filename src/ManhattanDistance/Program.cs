using System;

namespace ManhattanDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {

                Point point1 = GeneratePoint();
                Point point2 = GeneratePoint();
                ManhathanDistanceCalculator manhattanDistance = new ManhathanDistanceCalculator(point1, point2);

                Console.WriteLine($"Manhattan Distance for provided points are : {manhattanDistance.GetDistance()}");
            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        private static Point GeneratePoint() {
            Console.WriteLine("Please provide point coordinattes : ");
            Console.WriteLine("Abcsissa :");

            int x = FormatInput(Console.ReadLine() ?? "");
            
            Console.WriteLine("Ordinate :");
            int y = FormatInput(Console.ReadLine() ?? "");

            return new Point(x, y);
        }

        private static int FormatInput(string input) {
            try {
                int x = Int32.Parse(input);
                return x;
            } catch( FormatException) {
                throw new Exception("Invalid Format");
            }
        }
    }
}
