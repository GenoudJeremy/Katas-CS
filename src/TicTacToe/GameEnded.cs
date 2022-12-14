namespace TicTacToe
{
    public class GameEnded
    {
        public GameEnded(Grid grid)
        {
            Grid = grid;
        }

        public Grid Grid { get; }

        public bool IsThereAWinner()
        {
            string?[,] cellsValue = Grid.GetGrid();
            /* Column condition win */

            if (cellsValue[0,0] != null && cellsValue[1,0] == cellsValue[0,0] && cellsValue[2,0] == cellsValue[0,0]) {
                return true;
            }
            if (cellsValue[0,1] != null && cellsValue[1,1] == cellsValue[0,1] && cellsValue[2,1] == cellsValue[0,1]) {
                return true;
            }
            if (cellsValue[0,2] != null && cellsValue[1,2] == cellsValue[0,2] && cellsValue[2,2] == cellsValue[0,2]) {
                return true;
            }

            /* Row Condition win */
            if (cellsValue[0,0] != null && cellsValue[0,1] == cellsValue[0,0] && cellsValue[0,2] == cellsValue[0,0]) {
                return true;
            }
            if (cellsValue[1,0] != null && cellsValue[1,1] == cellsValue[1,0] && cellsValue[1,2] == cellsValue[1,0]) {
                return true;
            }
            if (cellsValue[2,0] != null && cellsValue[2,1] == cellsValue[2,0] && cellsValue[2,2] == cellsValue[2,0]) {
                return true;
            }

            /* Diagonal condition win */
            if (cellsValue[0,0] != null && cellsValue[1,1] == cellsValue[0,0] && cellsValue[2,2] == cellsValue[0,0]) {
                return true;
            }
            if (cellsValue[0,2] != null && cellsValue[1,1] == cellsValue[0,2] && cellsValue[0,2] == cellsValue[2,0]) {
                return true;
            }
            return false;
        }
    }
}