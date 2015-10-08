using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pacman
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Add(Point delta)
        {
            X += delta.X;
            Y += delta.Y;
        }
    }
}
