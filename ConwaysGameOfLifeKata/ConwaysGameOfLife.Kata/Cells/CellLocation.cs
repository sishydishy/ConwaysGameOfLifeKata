using System;
using System.Collections;
using System.Collections.Generic;

namespace ConwaysGameOfLifeKata.Kata
{
    public class CellLocation
    {
        public int X { get; }
        public int Y { get; }
        private string Key => string.Format("{0},{1}", X, Y);

        public CellLocation()
        {
            X = 0;
            Y = 0;
        }

        public CellLocation(CellLocation updateCellLocation, int x, int y) : this(updateCellLocation.X + x,
            updateCellLocation.Y + y)
        {
        }

        public CellLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return Key;
        }
    }
}