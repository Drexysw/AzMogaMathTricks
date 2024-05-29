using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzMogaMathTricks.Core.Engine
{
    internal class Engine
    {
        private FirstPlayer firstPlayer;
        private SecondPlayer secondPlayer;
        ct
        internal void Run()
        {
            string direction;
            bool IsFirstPlayer;
            int countOfTurns = 0;
            while (true)
            {
                IsFirstPlayer = countOfTurns % 2 == 0 ? true : false;
                Console.WriteLine(IsFirstPlayer == true ? "Its firstPlayer turn" : "Its secondPlayer turn");
                if (IsFirstPlayer)
                {
                    
                }
                else
                {
                    
                }
                direction = Console.ReadLine();
            }
        }
    }
}
