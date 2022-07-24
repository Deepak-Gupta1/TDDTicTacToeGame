using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeLib.Model;
namespace TicTacToeLibTests
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void MarkShouldBeEmptyWhenACellCreated()
        {
            bool expectResult = true;
            Cell[] cells=new Cell[9];
            cells[0] = new Cell();
            bool actualResult=cells[0].IsCellEmpty();
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void ShouldBeAbleToMarkCrossInACell()
        {
            MarkType expectMark = MarkType.X;
            Cell[] cell = new Cell[9];
            cell[4] = new Cell(MarkType.X);
            MarkType actualMrak = cell[4].getMark();
            Assert.AreEqual(expectMark, actualMrak);
        }
        [TestMethod]
        public void ShouldBeAbleToMarkNoughtInACell()
        {
            MarkType expectMark = MarkType.O;
            Cell[] cell = new Cell[9];
            cell[3] = new Cell(MarkType.O);
            MarkType actualMrak = cell[3].getMark();
            Assert.AreEqual(expectMark, actualMrak);
        }
        [TestMethod]
        public void CellShouldNotBeMarkedTwice()
        {
            string expectExceptionMessage = "Cell Already Markd Expecption";
            Cell[] cell = new Cell[9];
            cell[3] = new Cell(MarkType.O);
            var ex = Assert.ThrowsException<CellAlreadyMarkdExpecption>(() =>cell[3].SetMark(MarkType.X));
            Assert.AreEqual(expectExceptionMessage, ex.Message);
        }
    }
}
