using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisNew
{
    class Point
    {
        public int x;
        public int y;
        public char z;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(z);
        }
    }
}
