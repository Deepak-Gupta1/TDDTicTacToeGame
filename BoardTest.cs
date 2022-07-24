using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void NewBoardShouldHave9EmptyCells()
        {
            int expectResult = 9;
            Board bord = new Board(new Cell[9]);
            int actualResult=bord.LengthOfCell();
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void ShouldMarkZeroLocationWithX()
        {
            MarkType expectMark=MarkType.X;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0,MarkType.X);
            MarkType actualMark = board.getCell(0).getMark();
            Assert.AreEqual(expectMark, actualMark);
        }
        [TestMethod]
        public void BoardShouldBeFull()
        {
            bool expectResult = true;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0, MarkType.X);
            board.MarkCell(1, MarkType.O);
            board.MarkCell(2, MarkType.O);
            board.MarkCell(3, MarkType.X);
            board.MarkCell(4, MarkType.O);
            board.MarkCell(5, MarkType.X);
            board.MarkCell(6, MarkType.O);
            board.MarkCell(7, MarkType.X);
            board.MarkCell(8, MarkType.O);
            bool actualResult = board.IsBoardFull()
;            Assert.AreEqual(expectResult, actualResult);
        }
    }
}
 