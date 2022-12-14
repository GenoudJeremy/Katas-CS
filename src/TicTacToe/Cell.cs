namespace TicTacToe
{
    public class TokenCell
    {
        private string? Token;
        public string? GetToken() {
            return Token;
        }

        public void SetToken(string token)
        {
            Token = Token ?? token;
        }
    }
}