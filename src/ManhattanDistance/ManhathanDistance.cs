namespace ManhattanDistance
{
    public class ManhathanDistanceCalculator
    {
        public ManhathanDistanceCalculator(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }

        private Point Point1 { get; }
        private Point Point2 { get; }

        public int GetDistance()
        {
            return 
                Math.Abs(Point1.GetAbscissa() - Point2.GetAbscissa()) + 
                Math.Abs(Point1.GetOrdinate() - Point2.GetOrdinate());
        }
    }
}