using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TicTacToeLib.Model;

namespace TicTacToeLibTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void WhenGameStartsCurrentPlayerHasToPlayer1()
        {
            Player[] p = new Player[2];
            p[0] = new Player("Player1", MarkType.O);
            p[1] = new Player("Player2", MarkType.X);
            Board board = new Board(new Cell[9]);
            Game game = new Game(p, board, new ResultAnalyzer(board));
            Player expectPlayer = p[0];
            Player actualPlayer=game.CurrentPlayer;
            Assert.AreEqual(expectPlayer, actualPlayer);

        }
        [TestMethod]
        public void AfterFirstMarkingCurrentPlayerHasToBePlayer2()
        {
            Player[] p = new Player[2];
            p[0] = new Player("Player1", MarkType.O);
            p[1] = new Player("Player2", MarkType.X);
            Board board = new Board(new Cell[9]);
            Game game = new Game(p, board, new ResultAnalyzer(board));
            game.Play(4);
            Player expectPlayer = p[1];
            Player actualPlayer = game.CurrentPlayer;
            Assert.AreEqual(expectPlayer, actualPlayer);

        }
        [TestMethod]
        public void CheckGameStatusIsInProgressAterFirstMove()
        {
            Player[] p = new Player[2];
            p[0] = new Player("Player1", MarkType.O);
            p[1] = new Player("Player2", MarkType.X);
            Board board = new Board(new Cell[9]);
            Game game = new Game(p, board, new ResultAnalyzer(board));
            game.Play(4);
            ResultType expectResultType = ResultType.NO_RESULT;
            ResultType actualResultType = game.Status;
            Assert.AreEqual(expectResultType, actualResultType);
        }
        [TestMethod]
        public void CheckGameStatusForWiningGame()
        {
            Player[] p = new Player[2];
            p[0] = new Player("Player1", MarkType.O);
            p[1] = new Player("Player2", MarkType.X);
            Board board = new Board(new Cell[9]);
            Game game = new Game(p, board, new ResultAnalyzer(board));
            game.Play(0);
            game.Play(8);
            game.Play(1);
            game.Play(6);
            game.Play(2);
            ResultType expectResultType = ResultType.WIN;
            ResultType actualResultType = game.Status;
            Assert.AreEqual(expectResultType, actualResultType);
        }

    }
}
