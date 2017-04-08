using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Program
    {
        ////Waarden aan maken voor verschillende classes
        //public string bewaar1;
        //public string bewaar2;
        //public string bewaar3;
        //public string bewaar4;
        //public string bewaar5;

        static void Main(string[] args)
        {
            //Variabele voor aantal worpen 
            int worp = 0;

            //Intro text
            Console.WriteLine("Druk op enter om de dobbelstenen te werpen.");
            Console.ReadKey();

            //Max 3x werpen
            while (worp < 3) //Class hier beginnen voor werpen?
            {
                //De nodige variabelen aanmaken voor:
                //Variabele voor keuze speler
                int bewaar1, bewaar2, bewaar3, bewaar4, bewaar5;

                //Variabele voor de dobbelstenen
                int dobbelsteen1, dobbelsteen2, dobbelsteen3, dobbelsteen4, dobbelsteen5;

                //Classes aanroepen
                dobbelsteenHandeling d = new dobbelsteenHandeling();

                //Aanmaken van 5 random dobbelstenen
                Random dobbelen = new Random();
                if (worp == 0)
                {
                    bewaar1 = 0;
                    bewaar2 = 0;
                    bewaar3 = 0;
                    bewaar4 = 0;
                    bewaar5 = 0;

                    dobbelsteen1 = dobbelen.Next(1, 7);
                    dobbelsteen2 = dobbelen.Next(1, 7);
                    dobbelsteen3 = dobbelen.Next(1, 7);
                    dobbelsteen4 = dobbelen.Next(1, 7);
                    dobbelsteen5 = dobbelen.Next(1, 7);
                }
                else
                {

                }


                dobbelsteen1 = dobbelen.Next(1, 7);
                dobbelsteen2 = dobbelen.Next(1, 7);
                dobbelsteen3 = dobbelen.Next(1, 7);
                dobbelsteen4 = dobbelen.Next(1, 7);
                dobbelsteen5 = dobbelen.Next(1, 7);

                worp++;

                //Resultaten per worp laten zien
                Console.WriteLine("Worp {0}:", worp);
                Console.Write(dobbelsteen1 + "\t");
                Console.Write(dobbelsteen2 + "\t");
                Console.Write(dobbelsteen3 + "\t");
                Console.Write(dobbelsteen4 + "\t");
                Console.WriteLine(dobbelsteen5);


                d.bewaarFunctie(ref bewaar1, ref nummer2, ref bewaar3, ref bewaar4, ref bewaar5);
                
                //Alleen eerste twee worpen vragen om bewaar
                if (worp < 3)
                {
                    Console.WriteLine("Welke dobbelstenen wil je bewaren?");
                    Console.WriteLine("Steen 1: ");
                    //bewaar1 = Console.ReadLine();
                    bewaar1 = 1;
                    Console.WriteLine("Steen 2: ");
                    //bewaar2 = Console.ReadLine();
                    bewaar2 = 1;
                    Console.WriteLine("Steen 3: ");
                    //bewaar3 = Console.ReadLine();
                    bewaar3 = 1;
                    Console.WriteLine("Steen 4: ");
                    //bewaar4 = Console.ReadLine();
                    bewaar4 = 1;
                    Console.WriteLine("Steen 5: ");
                    bewaar5 = 1;
                    //bewaar5 = Console.ReadLine();
                } //Class hier eindigen voor werpen


                //Welk tekstbericht bij worp 1, 2 en 3
                if (worp == 1)
                {
                    Console.WriteLine("\nDruk op enter voor de tweede worp.");
                    Console.ReadKey();
                }
                else if (worp == 2)
                {
                    Console.WriteLine("\nDruk op enter voor de laatste worp.");
                    Console.ReadKey();
                }
                else //worp == 3
                {

                }


            }
            //Na het einde van 3x werpen
            Console.WriteLine("\nYahtzee!!!!... Toch niet.");
            Console.WriteLine("\nSpel is afgelopen.");
            Console.ReadKey();
        }
    }

    class dobbelsteenHandeling
    {
        public int FindMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;

            return result;
        }

        public void bewaarFunctie(ref int a, ref int b, ref int c, ref int d, ref int e)
        {
            
            
            ////De waarden zijn hier net geimporteert uit de main
            ////Console.WriteLine("swap_ref nummer1 before= {0}", x);
            ////Console.WriteLine("swap_ref nummer2 before= {0}", y);

            //int temp;
            ////De regels hieronder zijn om x en y van waarde te swappen.
            //temp = x;
            //x = y;
            //y = temp;

            ////De waarden zijn aangepast in the method, maar onveranderd in de main.
            ////Console.WriteLine("swap_ref nummer1 after = {0}", x);
            ////Console.WriteLine("swap_ref nummer2 after = {0}", y);
        }

        //public void getValues(out int x, out int y)
        //{
        //    Console.WriteLine("Typ waarde van o in getValues: ");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Typ waarde van z in getValues: ");
        //    y = Convert.ToInt32(Console.ReadLine());

        //}

        //public void getNummers(out int x, out int y)
        //{
        //    Console.WriteLine("Typ waarde van nummer1 in getNummers: ");
        //    x = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Typ waarde van nummer2 in getNummers: ");
        //    y = Convert.ToInt32(Console.ReadLine());
        }
    }
}

