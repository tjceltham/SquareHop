﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SquareHop
{
    class Board
    {
        // 0 - empty
        // 1- counter Blue
        // 2 - Counter red( if implement 2-player game)
        private int[] board = new int[6];

        public Board()
        {
            for(int x=1; x<6; x++)
            {
                // empty positions
                board[x] = 0;
            }
            // counter at start;
            board[0] = 1;
        }
        
        public void updateBoard(int x)
        {

        }

        public int[] getBoard()
        {
            return board;
        }
    }
}
