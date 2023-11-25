using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou vysledek a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou vysledek do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            //Tento komentar smaz a misto nej zacni psat svuj prdacky kod.

            Console.WriteLine("Krásné matematické ráno! (nebo odpoledne. nebo večer. je to jedno) Tvůj požadavek bude bleskově vyslyšen, v první řadě je potřeba zadat operaci, kterou budeš provádět. Výčet možností v této pochybné kalkulačce házím zde: \n" +
                "- součet\n" +
                "- rozdíl\n" +
                "- násobek\n" +
                "- podíl\n" +
                "- logaritmus - první ze zadaných čísel bude základem logaritmu\n" +
                "- mocnina - první číslo se umocní na druhé číslo\n" +
                "- odmocnina - první číslo značí, kolikátou odmocninu druhého čísla chceme\n" +
                "- faktoriál - vypočte faktoriál zadaného čísla");
            //nadefinuji potřebné proměnné
            string operace = Console.ReadLine();
            float cislo1 = 0;
            float cislo2 = 0;
            bool kontrola = true;
            string soustava_moznost;
            float vysledek = 0;
            //zadám čísla potřebná k výpočtu
            Console.WriteLine("Perfektní! Zadej první číslo výpočtu.");
            do
            {
                //zkontroluji, zda uživatel zadal platné číslo
                kontrola = float.TryParse(Console.ReadLine(), out cislo1); //přečte console.readline, zkusí, zda se jedná o float, vyhodí float hodnotu cislo1
                if (kontrola == false)
                {
                    Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                }
            } while (kontrola == false);
            if (operace != "faktoriál")
            {
                do
                {
                    Console.WriteLine("Perfektní! Zadej druhé číslo výpočtu.");
                    //zkontroluji, zda uživatel zadal platné číslo
                    kontrola = float.TryParse(Console.ReadLine(), out cislo2); //přečte console.readline, zkusí, zda se jedná o float, vyhodí float hodnotu cislo2
                    if (kontrola == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (kontrola == false);
            }
            //podle zadané operace vypočítám výsledek
            switch (operace)
            {
                case "součet":
                case "+":
                    vysledek = cislo1 + cislo2;
                    break;
                case "rozdíl":
                case "-":
                    vysledek = cislo1 - cislo2;
                    break;
                case "násobek":
                case "*":
                    vysledek = cislo1 * cislo2;
                    break;
                case "podíl":
                case "/":
                    //zkontroluji zda dělitelem není nula
                    while (cislo2 == 0)
                    {
                        Console.WriteLine("Nelze dělit nulou. Zadej jiného dělitele.");
                        do
                        {
                            kontrola = float.TryParse(Console.ReadLine(), out cislo2);
                            if (kontrola == false)
                            {
                                Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                            }
                        } while (kontrola == false);
                        //pokud číslo není nula, pokračuji ve výpočtu
                        if (cislo2!=0)
                        {
                            break;
                        }
                    }
                    vysledek = cislo1 / cislo2;
                    break;
                case "logaritmus":
                case "log":
                    vysledek = (float)Math.Log(cislo2, cislo1);
                    break;
                case "mocnina":
                    vysledek = (float)Math.Pow(cislo1, cislo2);
                    break;
                case "odmocnina":
                    //zkontroluji nezápornou hodnotu čísla 2
                    while (cislo2 < 0)
                    {
                        Console.WriteLine("Nelze odmicnit záporná čísla. Zadej jiné číslo.");
                        do
                        {
                            kontrola = float.TryParse(Console.ReadLine(), out cislo2);
                            if (kontrola == false)
                            {
                                Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                            }
                        } while (kontrola == false);
                        if (cislo2 >= 0)
                        {
                            break;
                        }
                    }
                    //zkontroluji nenulovou hodnotu čísla 1
                    while (cislo1 == 0)
                    {
                        Console.WriteLine("Nelze počítat s nulou. Zadej jiné číslo.");
                        do
                        {
                            kontrola = float.TryParse(Console.ReadLine(), out cislo1);
                            if (kontrola == false)
                            {
                                Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                            }
                        } while (kontrola == false);
                        if (cislo1 != 0)
                        {
                            break;
                        }
                    }
                    vysledek = (float)Math.Pow(cislo2, 1 / cislo1);
                    break;
                case "faktoriál":
                    //zkontroluji nezápornou hodnotu čísla
                    while (cislo1 < 0)
                    {
                        Console.WriteLine("Nelze vytvořit faktoriál záporného čísla. Zadej nové.");
                        do
                        {
                            kontrola = float.TryParse(Console.ReadLine(), out cislo1);
                            if (kontrola == false)
                            {
                                Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                            }
                        } while (kontrola == false);
                        if (cislo1 >= 0)
                        {
                            break;
                        }
                    }
                    vysledek = 1;
                    for (int i = 1; i < cislo1 + 1; i++)
                    {
                        vysledek = vysledek * i;
                    }
                    break;
                default:
                    Console.WriteLine("Neplatná operace. Zadej novou.");
                    operace = Console.ReadLine();
                    break;
            }
            //vypíšu výsledek a pracuji s doplňující možností
            Console.WriteLine("Výsledek je " + vysledek + " Chceš tento výsledek převést na binární soustavu? ano/ne?");
            soustava_moznost = Console.ReadLine();
            switch (soustava_moznost)
            {
                case "ano":
                    string vysledek2 = vysledek.ToString("X");
                    Console.WriteLine("Převedený výsledek je " + Convert.ToString(Convert.ToInt32(vysledek), 2));
                    break;
                case "ne":
                    Console.WriteLine("Okej, v tom případě jsme spolu skončili. Čuuus");
                    break;
                default:
                    Console.WriteLine("Tak to nebylo ani ano ani ne, takže se smíříš s tím, že máš výsledek a končíme.");
                    break;
            }
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
