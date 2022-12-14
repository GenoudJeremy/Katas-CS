namespace ManhattanDistance.Tests;

public class PointTests
{
    [Fact]
    public void PointShouldReturn0IfAbscissaIs0()
    {
        int expected = 0;
        Point point = new Point(0,0);

        int result = point.GetAbscissa();
        Assert.Equal(expected, result);
    }
    [Fact]
    public void PointShouldReturn1IfAbscissaIs1()
    {
        int expected = 1;
        Point point = new Point(1,0);

        int result = point.GetAbscissa();
        Assert.Equal(expected, result);
    }
    [Fact]
    public void PointShouldReturn0IfOrdinateIs0()
    {
        int expected = 0;
        Point point = new Point(0,0);

        int result = point.GetOrdinate();
        Assert.Equal(expected, result);
    }
    [Fact]
    public void PointShouldReturn1IfOrdinateIs1()
    {
        int expected = 1;
        Point point = new Point(0,1);
        int result = point.GetOrdinate();
        Assert.Equal(expected, result);
    }
}