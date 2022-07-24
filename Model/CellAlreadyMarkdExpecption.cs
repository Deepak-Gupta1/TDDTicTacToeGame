using System;
using System.Runtime.Serialization;

namespace TicTacToeLib.Model
{
    [Serializable]
    public class CellAlreadyMarkdExpecption : Exception
    {
        public CellAlreadyMarkdExpecption()
        {
        }

        public CellAlreadyMarkdExpecption(string message) : base(message)
        {
        }

    }
}