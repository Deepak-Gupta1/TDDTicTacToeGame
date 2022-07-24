using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeLib.Model
{
    public class Cell
    {
        private MarkType mark;

        public Cell()
        {
            this.mark = MarkType.EMPTY;
        }
        public Cell(MarkType mark)
        {
            this.mark = mark;
        }
        public MarkType getMark()
        {
            return mark;
        }
        public void SetMark(MarkType setMark)
        {
            if(mark == MarkType.EMPTY)
            {
                mark = setMark;
            }
            else
            {
                throw new CellAlreadyMarkdExpecption("Cell Already Markd Expecption");
            }
        }
        public Boolean IsCellEmpty()
        {
            if (MarkType.EMPTY == mark)
            {
                return true;
            }
            return false;
        }
    }
}
