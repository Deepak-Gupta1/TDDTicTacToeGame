using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeLib.Model
{
    public class ResultAnalyzer
    {
        Board board;
        public ResultAnalyzer(Board board)
        {
            this.board = board;
        }
        public ResultType AnalyerResult()
        {
            if (checkVertical() || checkHorizontal() || checkDiagonal() )
            {
                return ResultType.WIN;
            }
            if (!board.IsBoardFull())
            {
                return ResultType.NO_RESULT;
            }
            else {
                return ResultType.DRAW;
            }
            
        }
        private bool checkVertical()
        {
            MarkType v00 = board.getCell(0).getMark();
            MarkType v03 = board.getCell(3).getMark();
            MarkType v06 = board.getCell(6).getMark();
            MarkType v11 = board.getCell(0).getMark();
            MarkType v14 = board.getCell(3).getMark();
            MarkType v17 = board.getCell(6).getMark();
            MarkType v22 = board.getCell(0).getMark();
            MarkType v25 = board.getCell(3).getMark();
            MarkType v28 = board.getCell(6).getMark();

            if ((v00 == v03)&& (v03 == v06)){
                if (v00 == MarkType.EMPTY){return false;}
                return true;
            }
            if ((v11 == v14)&& (v14 == v17))
            {
                if (v11 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            if ((v22 == v25)&& (v25 == v28))
            {
                if (v22 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private bool checkHorizontal()
        {
            MarkType v00 = board.getCell(0).getMark();
            MarkType v10 = board.getCell(1).getMark();
            MarkType v20 = board.getCell(2).getMark();
            MarkType v31 = board.getCell(3).getMark();
            MarkType v41 = board.getCell(4).getMark();
            MarkType v51 = board.getCell(5).getMark();
            MarkType v62 = board.getCell(6).getMark();
            MarkType v72 = board.getCell(7).getMark();
            MarkType v82 = board.getCell(8).getMark();
            if ((v00 == v10)&& (v20 == v10))
            {
                if (v00 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            if ((v31 == v41)&& (v51 == v41))
            {
                if (v31 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            if ((v62 == v72)&& (v82 == v72))
            {
                if (v62 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private bool checkDiagonal()
        {
            MarkType v0 = board.getCell(0).getMark();
            MarkType v4 = board.getCell(4).getMark();
            MarkType v8 = board.getCell(8).getMark();
            MarkType v2 = board.getCell(2).getMark();
            MarkType v6 = board.getCell(6).getMark();
            if ((v0==v4)&&(v4==v8))
            {
                if (v0 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            if ((v2 == v4)&& (v4 == v6))
            {
                if (v2 == MarkType.EMPTY)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}

