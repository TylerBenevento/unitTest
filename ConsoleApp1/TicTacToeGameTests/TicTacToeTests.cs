using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
       
        //create board tests
        [TestMethod()]
        public void CreateBoardTest()
        {
            int expected = 9; 
            TicTacToe test = new TicTacToe();
            int actual = test.CreateBoard().Length;

            Assert.AreEqual(expected, actual);

        }

        //current player tests. 
        [TestMethod()]
        public void CurrentPlayerXTest()
        {

            string expected = "it is player 1's turn. You will be 'X'";
            TicTacToe x = new TicTacToe();
            string actual= x.CurrentPlayer(1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CurrentPlayerOTest()
        {

            string expected ="it is player 2's turn. you will be 'O'";
            TicTacToe o = new TicTacToe();
            string actual = o.CurrentPlayer(2);
            Assert.AreEqual(expected, actual);
        }

        //tests that players make move on the board
        [TestMethod()]
        public void XMakeMoveTest()
        {
            string expected = "x";
            TicTacToe move = new TicTacToe();
            string [] actualArray = move.MakeMove(1, 0);
            string actual = actualArray[0];
            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void OMakeMoveTest()
        {
            string expected =  "o";
            TicTacToe move = new TicTacToe();
            string[] actualArray = move.MakeMove(2, 1);
            string actual = actualArray[1];
            Assert.AreEqual(expected, actual);
        }

       

        //tests that it is an unoccupied spot
        [TestMethod()]
        public void SpaceInUseTest()
        {
            
            string expected = "this space is open";
            TicTacToe free = new TicTacToe();
            string actual = free.SpaceInUse(4);
            Assert.AreEqual(expected, actual);
        }
    }
}