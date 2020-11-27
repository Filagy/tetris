using System;

namespace TetrisNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);




            Square s = new Square(2, 5, '#');
            s.Draw();

            Stick b = new Stick(6, 8, '#');
            b.Draw();


            Console.ReadKey();

        }
      
    }
}
