namespace ManhattanDistance.Tests
{
    public class ManhathanDistanceTests
    {
        [Fact]
        public void ShouldReturn0If2PointsAreSame()
        {
            int expected = 0;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(0,0,0,0); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldReturn1IfAbscissaDistanceAre1WithOnePointAtOrigin()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(1,0,0,0); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturn1IfAbscissaDistanceAre1WithOutPointAtOrigin()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(2,0,1,0); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturn1IfOrdinateDistanceAre1WithOnePointAtOrigin()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(0,1,0,0); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }
        [Fact]
        public void ShouldReturn1IfOrdinateDistanceAre1WithOutPointAtOrigin()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(0,2,0,1); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturn1IfOrdinateDistanceAre1WithOutPointAtOriginAndPoint2OrdinateGreater()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(0,1,0,2); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturn1IfAbscissaDistanceAre1WithOutPointAtOriginAndPoint2AbscissaGreater()
        {
            int expected = 1;

            ManhathanDistanceCalculator manhathanDistance = GetManhathanDistanceInstance(1,0,2,0); 

            int result = manhathanDistance.GetDistance();
            Assert.Equal(expected, result);
        }

        private ManhathanDistanceCalculator GetManhathanDistanceInstance(int x1, int y1, int x2, int y2) {
            Point point1 = new Point(x1,y1);
            Point point2 = new Point(x2,y2);
            return new ManhathanDistanceCalculator(point1, point2);            
        }
    }
}