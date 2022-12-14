namespace TicTacToeTests
{
    public class GameEndedTests
    {
        [Fact]
        public void ShouldReturnFalseByDefaultCaseForGivenGrid()
        {
            Grid grid = new Grid();
            GameEnded gameEnded = new GameEnded(grid);

            Boolean result = gameEnded.IsGameFinished();
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueIfFirstColAreFillWithSameToken()
        {
            Grid grid = new Grid();
            grid.TakeCell(new int[2]{0,0});
            grid.TakeCell(new int[2]{0,1});
            grid.TakeCell(new int[2]{1,0});
            grid.TakeCell(new int[2]{1,1});
            grid.TakeCell(new int[2]{2,0});
            GameEnded gameEnded = new GameEnded(grid);

            Boolean result = gameEnded.IsGameFinished();
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseIfFirstColAreFillWithNotSameToken()
        {
            Grid grid = new Grid();
            grid.TakeCell(new int[2]{0,0});
            grid.TakeCell(new int[2]{1,0});
            grid.TakeCell(new int[2]{0,1});
            grid.TakeCell(new int[2]{1,1});
            grid.TakeCell(new int[2]{2,0});
            GameEnded gameEnded = new GameEnded(grid);

            Boolean result = gameEnded.IsGameFinished();
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueIfFirstRowAreFillWithSameToken()
        {
            Grid grid = new Grid();
            grid.TakeCell(new int[2]{0,0});
            grid.TakeCell(new int[2]{1,0});
            grid.TakeCell(new int[2]{0,1});
            grid.TakeCell(new int[2]{1,1});
            grid.TakeCell(new int[2]{0,2});
            GameEnded gameEnded = new GameEnded(grid);

            Boolean result = gameEnded.IsGameFinished();
            Assert.True(result);
        }
    }
}