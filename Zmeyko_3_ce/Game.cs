using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeyko_3_ce
{
    public static class Game
    {
        public static void controlListen()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    current_direction = Ways.up;
                    break;
                case ConsoleKey.DownArrow:
                    current_direction = Ways.down;
                    break;
                case ConsoleKey.LeftArrow:
                    current_direction = Ways.left;
                    break;
                case ConsoleKey.RightArrow:
                    current_direction = Ways.right;
                    break;
            }
        }
        public static Ways current_direction;

        public static Snake snakeMain;

        public static Apple apple4s;
    }
}
