using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    public class Point
    {
        private int x;
        private int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int coordX
        {
            get
            {
                return x;
            }
        }
        public int coordY
        {
            get
            {
                return y;
            }
        }
    }
}
