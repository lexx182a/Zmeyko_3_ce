using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyko_3_ce
{
    public class Apple
    {
        public int x;
        public int y;

        public Apple()
        {
            Random r = new Random();
            this.x = r.Next(0, Console.WindowWidth);
            this.y = r.Next(0, Console.WindowHeight);
            Drawing.putSymbol(x, y, "@".ToCharArray()[0]);
        }
    }
}
