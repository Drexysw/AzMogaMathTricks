using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzMogaMathTricks.GameObjects;

namespace AzMogaMathTricks.ServiceModels
{
    internal class FirstPlayer : Player
    {
        public FirstPlayer(Board board) 
            : base(board)
        {
            CurrentRowPos = 0;
            CurrentColPos = 0;
        }
    }
}
