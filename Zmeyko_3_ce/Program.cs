using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Zmeyko_3_ce
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = Console.WindowWidth;
            Console.SetWindowSize(40, 20);
            Console.CursorVisible = false;

            //Console.SetCursorPosition(20, 10);
            //Console.Write("O");
            //Console.ReadKey();

            /*Timer t = new Timer();
            t.Elapsed += OnTimedEvent;
            t.Interval = 10000;
            
            t.AutoReset = true;*/

            Game.snakeMain = new Snake();
            Game.apple4s = new Apple();

            Game.current_direction = Ways.right;

            ThreadStart movs = new ThreadStart(Movements);
            Thread movementsThread = new Thread(movs);

            ThreadStart gcontrols = new ThreadStart(GameControls);
            Thread gamecontrols = new Thread(gcontrols);

            gamecontrols.Start();
            movementsThread.Start();
        }

        public static void Movements()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Game.snakeMain.Move();
            } 
        }

        public static void GameControls()
        {
            while (true)
            {
                
                Game.controlListen();
            }
        }

        

    }
}