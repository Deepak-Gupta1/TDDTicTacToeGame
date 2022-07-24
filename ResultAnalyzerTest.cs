using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class ResultAnalyzerTest
    {
        [TestMethod]
        public void ShowWinForDiagonalY()
        {
            ResultType expectResult = ResultType.WIN;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0, MarkType.O);  //0
            board.MarkCell(1, MarkType.X);
            board.MarkCell(2, MarkType.X);
            board.MarkCell(4, MarkType.O);  //4
            board.MarkCell(8, MarkType.O);  //8
            ResultAnalyzer res = new ResultAnalyzer(board);
            ResultType actualResult = res.AnalyerResult();
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void ShowWinForHorizontalCondition()
        {
            ResultType expectResult = ResultType.WIN;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0, MarkType.X);
            board.MarkCell(8, MarkType.O);
            board.MarkCell(1, MarkType.X);
            board.MarkCell(4, MarkType.O);  
            board.MarkCell(2, MarkType.X);  
            ResultAnalyzer res = new ResultAnalyzer(board);
            ResultType actualResult = res.AnalyerResult();
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void ShowWinForVerticalCondition()
        {
            ResultType expectResult = ResultType.WIN;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0, MarkType.X);
            board.MarkCell(8, MarkType.O);
            board.MarkCell(3, MarkType.X);
            board.MarkCell(7, MarkType.O);
            board.MarkCell(6, MarkType.X);
            ResultAnalyzer res = new ResultAnalyzer(board);
            ResultType actualResult = res.AnalyerResult();
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void ShowWinForDrawCondition()
        {
            ResultType expectResult = ResultType.DRAW;
            Board board = new Board(new Cell[9]);
            board.MarkCell(0, MarkType.X);
            board.MarkCell(1, MarkType.O);
            board.MarkCell(2, MarkType.X);
            board.MarkCell(3, MarkType.O);
            board.MarkCell(4, MarkType.O);
            board.MarkCell(5, MarkType.X);
            board.MarkCell(6, MarkType.X);
            board.MarkCell(7, MarkType.X);
            board.MarkCell(8, MarkType.O);
            ResultAnalyzer res = new ResultAnalyzer(board);
            ResultType actualResult = res.AnalyerResult();
            Assert.AreEqual(expectResult, actualResult);
        }
        
    }
}
