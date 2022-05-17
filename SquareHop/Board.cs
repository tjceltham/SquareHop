using System;
using System.Collections.Generic;
using System.Text;

namespace SquareHop
{
    class Board
    {
        // 0 - empty
        // 1- counter Blue
        // 2 - Counter red( if implement 2-player game)
        const int BOARD_SIZE = 6;
        private int[] board = new int[BOARD_SIZE];

        public Board()
        {
            for(int x=1; x<BOARD_SIZE; x++)
            {
                // empty positions
                board[x] = 0;
            }
            // counter at start;
            board[0] = 1;
        }
        
        public void updateBoard(int x)
        {
            // use a the number x to update the position 
            // of the counter on the board
            // a position with a counter 
            // is represented by a 1 in the booard array
            // you can add snakes and ladders if you wish


        }

        public int[] getBoard()
        {
            return board;
        }
    }
}
