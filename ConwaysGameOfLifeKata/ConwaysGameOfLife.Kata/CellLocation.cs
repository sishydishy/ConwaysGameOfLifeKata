using System;
using System.Collections;
using System.Collections.Generic;

namespace ConwaysGameOfLifeKata.Kata
{
    public class CellLocation
    {
        //private readonly string _key;
        private string Key => string.Format("{0},{1}", X, Y);

        public int X { get; set; }
        public int Y { get; set; }


        public CellLocation()
        {
            X = 0;
            Y = 0;


        }


        public CellLocation(int x, int y)
        {
            X = x;
            Y = y;
            
            
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        public override string ToString()
        {
            return Key;
        }
    }
}