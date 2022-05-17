using System;
using System.Collections.Generic;
using System.Text;

namespace SquareHop
{
    class SnakesAndLadders
    {
        private Board b;

        public SnakesAndLadders()
        {
            
        }
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
            // Complete this subroutine
            // it should generate a random number between 1 and 6 
            // and call updateBoard with that number


            return WinCode;
        }

        public Board getBoard()
        {
            return b;
        }
    }
}
