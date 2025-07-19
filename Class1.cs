using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class01_OOP
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Contstructors 
            public Point()
        {
            X = 1;
            Y = default;
        }

            public Point (int _x,int _y)
        {
            X = _x;
            Y = _y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
        #endregion
    }
}
