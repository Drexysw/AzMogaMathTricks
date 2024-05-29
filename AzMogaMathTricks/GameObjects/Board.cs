using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzMogaMathTricks
{
    internal class Board
    {
        private int rows;
        private int cols;
        private string[,] board;
        private List<char> ArithmeticOperations = new List<char>() { '*', '/', '+', '-' };
        private Random rnd = new Random();
        private List<string> UsedArithmeticOperations = new List<string>();

        public Board(int row, int col)
        {
            Rows = row;
            Cols = col;
            InitializeBoard();
            PrintBoard();
        }

        private int Rows
        {
            get => rows;
            set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Value must be over 4!");
                }
                else rows = value;
            }
        }
        private int Cols
        {
            get => cols;
            set
            {
                if (value < 4)
                {
                    throw new ArgumentException("Value must be over 4!");
                }
                else cols = value;
            }
        }

        private void InitializeBoard()
        {
            board = new string[Rows, Cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    SetValueOfBoard(row, col);
                }
            }
        }

        internal string SetValueOfBoard(int row, int col)
        {
            string operation = ArithmeticOperations[rnd.Next(ArithmeticOperations.Count)].ToString();
            string checkAdd = operation == "+" ? string.Empty : operation;
            string valueOfBoard = rnd.Next(0, 10).ToString();
            if (valueOfBoard == "0" && operation == "/")
            {
                return board[row, col] = "0";
            }
            if (row == 0 && col == 0 || col == Cols - 1 && row == Rows - 1)
            {
                return board[row, col] = "0";
            }
            return operation + valueOfBoard;
        }

        private void PrintBoard()
        {
            board = new string[Rows, Cols];
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        internal string GetValue(int row, int col) => board[row, col];
        private void AddArithmeticOperations(string operation)
        {
            UsedArithmeticOperations.Add(operation);
        }
        internal List<string> ReturnArithmeticOperations() => UsedArithmeticOperations;
        internal bool IsNotBoard(int row, int col) => row < 0 && col < 0 && row >= Rows && col >= Cols;
    }
}
