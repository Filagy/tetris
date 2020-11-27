using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisNew
{
    public class Point
    {
        public int x;
        public int y;
        public char z;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(z);
        }
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            z = sym;
        }
        //public Point() { }
    }
}
