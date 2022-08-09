using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 10; x < 70; x = x + 1)

            {
                Console.SetCursorPosition(x, 5);
                Console.Write("A");
                Console.Beep(700, 100);

            }

            for (int y = 5; y < 20; y = y + 1)

            {
                Console.SetCursorPosition(69, y);
                Console.Write("B");
                Console.Beep(200, 50);

            }

            for (int x2 = 69; x2 > 10; x2 = x2 + -1)

            {
                Console.SetCursorPosition(x2,19);
                Console.Write("C");
                Console.Beep(100, 700);

            }

            for (int y2 = 19; y2 > 5; y2 = y2 + -1)

            {
                Console.SetCursorPosition(10, y2);
                Console.Write("D");
                Console.Beep(50, 200);
            }

            Thread.Sleep(200);
        }
    }
}
