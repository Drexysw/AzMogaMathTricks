namespace AzMogaMathTricks.GameObjects
{
    internal class Player : Poll
    {
        public Board board { get; set; }
        public Player(Board board)
        {
            this.board = board;
        }

        public int PlayerPoints { get; set; }

        public bool CanPlayerMove(int row, int col)
        {
            if (IsSurroundedByUsedOperations())
            {
                return false;
            }
            if (!board.IsOnBoard(row, col))
            {
                return false;
            }
            GetNextPosition(row, col);
            string operation = board.GetValue(row, col);
           
            IncreasePlayerPoints();
            return true;
        }

        private bool IsSurroundedByUsedOperations()
        {

        }

        private void IncreasePlayerPoints()
        {

        }

        private void GetNextPosition(int row,int col)
        {
            CurrentRowPos = row;
            CurrentColPos = col;
        }

    }
}
