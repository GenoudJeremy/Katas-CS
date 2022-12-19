namespace TicTacToeTests;

public class CellTests
{
    [Fact]
    public void ShouldReturnNullForNoneTakenCell()
    {
        TokenCell cell = new TokenCell();

        var result = cell.GetToken();
        Assert.Null(result);
    }

    [Fact]
    public void ShouldReturnXForCellTakenWithXValue()
    {
        TokenCell cell = new TokenCell();
        cell.SetToken("X");

        var result = cell.GetToken();
        Assert.Equal("X", result);
    }

    [Fact]
    public void ShouldReturnOForCellTakenWithOValue()
    {
        TokenCell cell = new TokenCell();
        cell.SetToken("O");

        var result = cell.GetToken();
        Assert.Equal("O", result);
    }

    [Fact]
    public void CellCannotChangeAfterTaken()
    {
        // Given
        TokenCell cell = new TokenCell();
        // When
        cell.SetToken("O");
        cell.SetToken("X");
        var result = cell.GetToken();
        // Then
        Assert.Equal("O", result);
    }
}