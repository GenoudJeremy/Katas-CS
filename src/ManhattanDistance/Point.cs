namespace ManhattanDistance
{
    public class Point
    {
        private int Abscissa;
        private int Ordinate;

        public Point(int Abscissa, int Ordinate)
        {
            this.Abscissa = Abscissa;
            this.Ordinate = Ordinate;
        }

        public int GetAbscissa()
        {
            return this.Abscissa;
        }

        public int GetOrdinate()
        {
            return this.Ordinate;
        }
    }
}