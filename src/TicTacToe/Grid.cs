namespace TicTacToe
{
    public class Grid
    {
        private const int TALL_GRID = 3;
        private const string FIRST_TOKEN = "X";
        private const string SECOND_TOKEN = "O";
        private List<List<TokenCell>> cells = new List<List<TokenCell>>();
        private string actualTokenTurn;
        public Grid() {
            this.cells = InitGrid();
            this.actualTokenTurn = FIRST_TOKEN;
        }
        public string?[,] GetGrid() {
            string?[,] grid = new string[TALL_GRID,TALL_GRID];

            int indexRow = 0;
            int indexCol = 0;
            foreach( List<TokenCell> row in cells) {
                foreach ( TokenCell cell in row ) {

                    grid[indexRow, indexCol] = cell.GetToken();
                    indexCol++;
                    if (indexCol == TALL_GRID) {
                        indexCol = 0;
                    }
                }
                indexRow++;
            }

            return grid;
        }

        public void TakeCell(int[] coordinates) {
            TokenCell cell = cells[coordinates[0]][coordinates[1]];
            if (cell.GetToken() == null) {
                cell.SetToken(actualTokenTurn);
                ChangePlayerAfterTakenCell();
            }
        }

        public string GetToken() {
            return this.actualTokenTurn;
        }
        private List<List<TokenCell>> InitGrid(){
            List<List<TokenCell>> tmpCells = new List<List<TokenCell>>();

            for ( int index = 0; index < TALL_GRID; index++) {
                tmpCells.Add(GenerateRow());

            }
            return tmpCells;
        }

        private List<TokenCell> GenerateRow(){
            List<TokenCell> row = new List<TokenCell>();

            for ( int index = 0; index < TALL_GRID; index++) 
            {
                row.Add(new TokenCell());
            }

            return row;
        }

        private void ChangePlayerAfterTakenCell(){
            if ( this.actualTokenTurn == FIRST_TOKEN) {
                this.actualTokenTurn = SECOND_TOKEN;
                return;
            }

            this.actualTokenTurn = FIRST_TOKEN;
        }
    }
}