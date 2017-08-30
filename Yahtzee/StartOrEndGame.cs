using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class StartOrEndGame
    {
        public void StartGame(ref int a)
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Je moet 0 of 1 invullen");
            }
        }

        public void CloseGame(ref int a)
        {
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    a = 0;
                }
                else
                {
                    a = 1;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Je moet 0 of 1 invullen");
            }
        }
    }
}
