using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Berekenen uitkomsten dobbelen
            int TelDobbelsteen = 0;
            int Aantal1 = 0;
            int Aantal2 = 0;
            int Aantal3 = 0;
            int Aantal4 = 0;
            int Aantal5 = 0;
            int Aantal6 = 0;
            string Score = "NULL";

            //Variabele voor aantal worpen 
            int Worp = 0;

            //Intro text
            Console.WriteLine("Druk op enter om de dobbelstenen te werpen.");
            Console.ReadKey();

            //De nodige variabelen aanmaken voor:
            //Variabele voor keuze speler
            int Bewaar1, Bewaar2, Bewaar3, Bewaar4, Bewaar5, NextGame;

            //Variabele voor de dobbelstenen
            int Dobbelsteen1, Dobbelsteen2, Dobbelsteen3, Dobbelsteen4, Dobbelsteen5;

            //Andere classes importeren
            Bewaren Bewaren = new Bewaren();
            StartOrEndGame StartOrEndGame = new StartOrEndGame();
            Conclusie Conclusie = new Conclusie();
            Random RandomDobbelen = new Random();

            //Aanmaken van 5 random dobbelstenen en keuzes
            Bewaar1 = 0;
            Bewaar2 = 0;
            Bewaar3 = 0;
            Bewaar4 = 0;
            Bewaar5 = 0;
            NextGame = 2;

            //Dobbelstenen voor de eerste keer berekenen
            Dobbelsteen1 = RandomDobbelen.Next(1, 7);
            Dobbelsteen2 = RandomDobbelen.Next(1, 7);
            Dobbelsteen3 = RandomDobbelen.Next(1, 7);
            Dobbelsteen4 = RandomDobbelen.Next(1, 7);
            Dobbelsteen5 = RandomDobbelen.Next(1, 7);

            //Max 3x werpen
            while (NextGame == 2 || NextGame == 1)
            {
                //Als speler kiest voor een nieuw spel, bereken dobbelstenen opnieuw
                if (NextGame == 1)
                {
                    Worp = 0;
                    Dobbelsteen1 = RandomDobbelen.Next(1, 7);
                    Dobbelsteen2 = RandomDobbelen.Next(1, 7);
                    Dobbelsteen3 = RandomDobbelen.Next(1, 7);
                    Dobbelsteen4 = RandomDobbelen.Next(1, 7);
                    Dobbelsteen5 = RandomDobbelen.Next(1, 7);

                    Console.WriteLine("\nDruk op enter om de dobbelstenen te werpen.");
                    Console.ReadKey();
                }

                while (Worp < 3) //Class hier beginnen voor werpen?
                {
                    Bewaar1 = 3;
                    Bewaar2 = 3;
                    Bewaar3 = 3;
                    Bewaar4 = 3;
                    Bewaar5 = 3;

                    //Waarde van worp verhogen doordat er gedobbeld is
                    Worp++;

                    //Resultaten per worp laten zien
                    Console.WriteLine("Worp {0}:", Worp);
                    Console.Write(Dobbelsteen1 + "\t");
                    Console.Write(Dobbelsteen2 + "\t");
                    Console.Write(Dobbelsteen3 + "\t");
                    Console.Write(Dobbelsteen4 + "\t");
                    Console.WriteLine(Dobbelsteen5);


                    //Alleen eerste twee worpen vragen om bewaar
                    if (Worp < 3)
                    {
                        Console.WriteLine("Welke dobbelstenen wil je bewaren?");
                        Console.Write("Steen 1: ");
                        Bewaren.UserInput(ref Bewaar1);
                        Bewaren.Dobbelsteen(ref Bewaar1, ref Dobbelsteen1);
                        Console.Write("Steen 2: ");
                        Bewaren.UserInput(ref Bewaar2);
                        Bewaren.Dobbelsteen(ref Bewaar2, ref Dobbelsteen2);
                        Console.Write("Steen 3: ");
                        Bewaren.UserInput(ref Bewaar3);
                        Bewaren.Dobbelsteen(ref Bewaar3, ref Dobbelsteen3);
                        Console.Write("Steen 4: ");
                        Bewaren.UserInput(ref Bewaar4);
                        Bewaren.Dobbelsteen(ref Bewaar4, ref Dobbelsteen4);
                        Console.Write("Steen 5: ");
                        Bewaren.UserInput(ref Bewaar5);
                        Bewaren.Dobbelsteen(ref Bewaar5, ref Dobbelsteen5);
                    }

                    //Welk tekstbericht bij worp 1, 2 en 3
                    if (Worp == 1)
                    {
                        Console.WriteLine("\nDruk op enter voor de tweede worp.");
                        Console.ReadKey();
                    }
                    else if (Worp == 2)
                    {
                        Console.WriteLine("\nDruk op enter voor de laatste worp.");
                        Console.ReadKey();
                    }
                }
                int[] gegooideDobbelstenen = { Dobbelsteen1, Dobbelsteen2, Dobbelsteen3, Dobbelsteen4, Dobbelsteen5 };

                //Aantal dezelfde dobbelstenen optellen
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal1, ref TelDobbelsteen);
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal2, ref TelDobbelsteen);
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal3, ref TelDobbelsteen);
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal4, ref TelDobbelsteen);
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal5, ref TelDobbelsteen);
                TelDobbelsteen++;
                Conclusie.Worp(ref gegooideDobbelstenen, ref Aantal6, ref TelDobbelsteen);
                TelDobbelsteen = 0;

                Conclusie.Uitkomst(Aantal1, Aantal2, Aantal3, Aantal4, Aantal5, Aantal6, ref Score);
                Console.WriteLine("\n\t\tJouw score:");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("\t\t" + Score);
                Console.WriteLine("\n---------------------------------------------");

                //Na het einde van 3x werpen
                Console.WriteLine("\nSpel is afgelopen.\nWil je een nieuw spel starten?");
                StartOrEndGame.StartGame(ref NextGame);

                //Reset aantal gegooide dobbelstenen
                Aantal1 = 0;
                Aantal2 = 0;
                Aantal3 = 0;
                Aantal4 = 0;
                Aantal5 = 0;
                Aantal6 = 0;

                if (NextGame == 0)
                {
                    Console.WriteLine("Weet je zeker dat je de applicatie wilt afsluiten?");
                    StartOrEndGame.CloseGame(ref NextGame);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}




