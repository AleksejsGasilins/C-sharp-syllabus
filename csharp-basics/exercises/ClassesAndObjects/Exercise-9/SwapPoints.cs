using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SwapPoints(Point p2)
        {
            (_x, p2._x) = (p2._x, _x);
            (_y, p2._y) = (p2._y, _y);
        }

        public string getPoint()
        {
            return $"{_x}, {_y}";
        }
    }
}
