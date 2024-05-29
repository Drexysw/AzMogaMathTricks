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
            if (board.IsNotBoard(row, col))
            {
                return false;
            }
            GetNextPosition(row, col);
            string operation = board.GetValue(row, col);
            IncreasePlayerPoints(operation);
            return true;
        }

        private void IncreasePlayerPoints(string operation)
        {
            int number = int.Parse(board.GetValue(CurrentRowPos, CurrentColPos).Skip(1).ToString());
            switch (operation)
            {
                case "+":
                    PlayerPoints += number;
                    break;
                case "-":
                    PlayerPoints -= number;
                    break;
                case "*":
                    PlayerPoints *= number;
                    break;
                case "/": 
                    PlayerPoints /= number;
                    break;
            }
        }

        private void GetNextPosition(int row,int col)
        {
            CurrentRowPos = row;
            CurrentColPos = col;
        }

        private bool IsSurroundedByUsedOperations()
        {

        }

    }
}
