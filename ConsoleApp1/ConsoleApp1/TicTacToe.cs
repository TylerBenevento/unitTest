using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class TicTacToe
    {

        public string[] board = new string[9];
        

        public TicTacToe()
        {
          
        }

        //string array is imagined to number the board going like  1|2|3
        //                                                         4|5|6
        //                                                         7|8|9 



        public string[] CreateBoard()
        {

            return board;
        }



        public string CurrentPlayer(int count)
        {
            string s = "";

            if (count == 1)
            {
                s = "it is player 1's turn. You will be 'X'";
            }
            if(count ==2)
            {
                s = "it is player 2's turn. you will be 'O'";
            }
            return s;

        }



        public string[] MakeMove(int count, int space)
        {
            if (count == 1)
            {
                board[space] = "x";
            }
            if (count == 2)
            {
                board[space] = "o";
            }

            return board;

        }

        public void ChangePlayer(int count)
        {
            if (count == 1)
            {
                count++;
            }
            if (count == 2)
            {
                count--;
            }
        }

        public string SpaceInUse(int space)
        {
            string s = "";
           
            
            
                
                if (board[space] == "" )
                {
                    s = "this space is open";
                }
            

            return s;
        }


    }
}
