using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeLib.Model
{
    public class Game
    {
        ResultAnalyzer ResultAnalyzer;
        Board board;
        private Player[] player=new Player[2];
        private Player _currentPlayer;
        private ResultType status;
        int move = 9;
        public Game(Player[] player,Board board,ResultAnalyzer resultAnalyzer)
        {
            this.player = player;
            this.board = board;
            this.ResultAnalyzer = resultAnalyzer;
            this.CurrentPlayer = player[0];
        }
        
        public ResultType Status
        {
            get { return ResultAnalyzer.AnalyerResult(); }
        }
        public void Play(int cellLoaction)
        {
            board.MarkCell(cellLoaction, _currentPlayer.Mark);
            if (!(Status == ResultType.WIN))
            {
                if (_currentPlayer == player[0])
                {
                    _currentPlayer = player[1];
                }
                else
                {
                    _currentPlayer = player[0];
                }
            }
          
        }
        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set { _currentPlayer = value; }
        }

    }
}
