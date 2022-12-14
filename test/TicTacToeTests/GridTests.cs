namespace TicTacToeTests
{
    public class GridTests
    {
        [Fact]
        public void ShouldReturnEmptyGrid3x3()
        {
            string[,] expected = new string[3,3];
            Grid grid = new Grid();

            string?[,] result = grid.GetGrid();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnGridWithXAtPosition0_0WhenCell0_0AreTaken() {

            string[,] expected = new string[3,3];
            string firstToken = "X";
            expected[0,0] = firstToken;

            Grid grid = new Grid();
            Assert.Equal(firstToken, grid.GetToken());
            int[] coordinates = new int[2] {0,0};
            grid.TakeCell(coordinates);

            string?[,] result = grid.GetGrid();
            Assert.Equal("O", grid.GetToken());
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnGridWithXThenOAtPosition0_0Then0_1WhenCell0_0Then0_1AreTaken() {

            string[,] expected = new string[3,3];
            expected[0,0] = "X";
            expected[0,1] = "O";

            Grid grid = new Grid();

            grid.TakeCell(new int[2] {0,0});
            grid.TakeCell(new int[2] {0,1});

            string?[,] result = grid.GetGrid();
            Assert.Equal(expected, result);
        }
    }
}