using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have these games available today: 1: Robber 2: Guild Manager 3: Platformer");
            GameSelect gameSelect = new GameSelect();
            gameSelect.GameSelectMenu();
        }
    }
    class GameSelect
    {
        public void GameSelectMenu()
        {
            int gameNum = int.Parse(Console.ReadLine());

            switch (gameNum)
            {
                case 1:
                    Console.WriteLine("Welcome to Robber");
                    break;

                case 2:
                    Console.WriteLine("Welcome to Guild Manager");
                    break;

                case 3:
                    Console.WriteLine("Welcome to my Platformer");
                    break;

                default:
                    Console.WriteLine("Please select a game from the list");
                    break;
            }

        }


        class DivNumbers
        {
            int result;

            DivNumbers()
            {
                result = 0;
            }
            public void division(int num1, int num2)
            {
                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Exception caught: {0}", e);
                }
                finally
                {
                    Console.WriteLine("Result: {0}", result);
                }
            }
            static void Main(string[] args)
            {
                DivNumbers d = new DivNumbers();
                d.division(25, 0);
                Console.ReadKey();
            }
        }

    }
}
