using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeLib.Model
{
    public class Board
    {
        private Cell[] cell;

        public Board(Cell[] cells)
        {
            this.cell = cells;
            for (int i = 0; i < cell.Length; i++)
            {
                cell[i] = new Cell();
            }
        }
        public void MarkCell(int cellLocation,MarkType markType)
        {
            cell[cellLocation].SetMark(markType);
        }
        public Cell getCell(int cellLocation)
        {
            return cell[cellLocation];
        }
        public int LengthOfCell()
        {
            return cell.Length;
        }
        public bool IsBoardFull()
        {
            for(int i = 0; i < cell.Length; i++)
            {
                if (cell[i].IsCellEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        public Cell[] getBoard
        {
            get { return this.cell; }
        }
        
    }
}
