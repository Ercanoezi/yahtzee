using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Bewaren
    {
        public void Dobbelsteen(ref int a, ref int b)
        {
            if (a == 0)
            {
                Random x = new Random();
                b = x.Next(1, 7);
                //Console.WriteLine("de dobbelsteen met 0 is nu: {0}", b);
            }
        }

        public void UserInput(ref int a)
        {
            while (a == 3)
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Je moet 0 of 1 invullen");
                }
        }
    }
}
