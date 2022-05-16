using System;
using System.Collections.Generic;
using System.Text;

namespace SquareHop
{
    class SnakesAndLadders
    {
        Board b;
        public void start()
        {
            b = new Board();
        }
        // returns win code
        // O - still playing
        // 1 - player 1 wins
        // 2- player  wins
        public int roll()
        {
            int WinCode = 0;

            return WinCode;
        }

        public Board getBoard()
        {
            return b;
        }
    }
}
