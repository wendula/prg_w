using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            Random rng = new Random(); //instance tridy Random pro generovani nahodnych cisel

            int skore_hrac = 0;
            int skore_pocitac = 0;
            while (skore_hrac < 3 && skore_pocitac < 3)
            {
                string vstup_hrac = Convert.ToString(Console.ReadLine());
                int hra_hrac = 0;
                switch (vstup_hrac)
                {
                    case "kámen":
                        hra_hrac = 1;
                        break;
                    case "papír":
                        hra_hrac = 2;
                        break;
                    case "nůžky":
                        hra_hrac = 3;
                        break;
                    default:
                        Console.WriteLine("Neplatný vstup.");
                        break;
                }
                int hra_pocitac = rng.Next(1,3);
                if (hra_pocitac==1)
                {
                    if (hra_hrac == 1)
                    {
                        Console.WriteLine("Remíza.");
                    }
                    else if (hra_hrac == 2)
                    {
                        skore_hrac++;
                        Console.WriteLine("Vyhrál jsi, získáváš bod.");
                    }
                    else if (hra_hrac == 3)
                    {
                        skore_pocitac++;
                        Console.WriteLine("Vyhrál počítač, získává bod.");
                    }
                }
                if (hra_pocitac == 2)
                {
                    if (hra_hrac == 2)
                    {
                        Console.WriteLine("Remíza.");
                    }
                    else if (hra_hrac == 3)
                    {
                        skore_hrac++;
                        Console.WriteLine("Vyhrál jsi, získáváš bod.");
                    }
                    else if (hra_hrac == 1)
                    {
                        skore_pocitac++;
                        Console.WriteLine("Vyhrál počítač, získává bod.");
                    }
                }
                if (hra_pocitac == 3)
                {
                    if (hra_hrac == 3)
                    {
                        Console.WriteLine("Remíza.");
                    }
                    else if (hra_hrac == 1)
                    {
                        skore_hrac++;
                        Console.WriteLine("Vyhrál jsi, získáváš bod.");
                    }
                    else if (hra_hrac == 2)
                    {
                        skore_pocitac++;
                        Console.WriteLine("Vyhrál počítač, získává bod.");
                    }
                }
            }
            string vysledek;
            if (skore_hrac>skore_pocitac)
            {
                vysledek = "Vyhrál jsi!";
            }
            else
            {
                vysledek = "Prohrál jsi.";
            }
            Console.WriteLine("Konec hry! " + vysledek + " Tvoje skóre je " + skore_hrac + " a skóre soupeře je " + skore_pocitac + ".");
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}
