using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyko_3_ce
{
    public static class Drawing
    {
        public static void putSymbol(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public static void eraseSymbol(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
