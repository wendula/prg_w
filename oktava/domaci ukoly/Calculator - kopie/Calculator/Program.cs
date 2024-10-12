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
        static float Add(float number1, float number2)
        {
            return number1 + number2;
        }
        static float Subtract(float number1, float number2)
        {
            return number1 - number2;
        }
        static float Multiply(float number1, float number2)
        {
            return number1 * number2;
        }
        static float Divide(float number1, float number2, bool control)
        {
            //zkontroluji zda dělitelem není nula
            while (number2 == 0)
            {
                Console.WriteLine("Nelze dělit nulou. Zadej jiného dělitele.");
                do
                {
                    control = float.TryParse(Console.ReadLine(), out number2);
                    if (control == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (control == false);
                //pokud číslo není nula, pokračuji ve výpočtu
                if (number2 != 0)
                {
                    break;
                }
            }
            return number1 / number2;
        }
        static float Logarithm(float number1, float number2)
        {
            return (float)Math.Log(number2, number1);
        }
        static float Power(float number1, float number2)
        {
            return (float)Math.Pow(number1, number2);
        }
        static float Root(float number1, float number2, bool control)
        {
            //zkontroluji nezápornou hodnotu čísla 2
            while (number2 < 0)
            {
                Console.WriteLine("Nelze odmicnit záporná čísla. Zadej jiné číslo.");
                do
                {
                    control = float.TryParse(Console.ReadLine(), out number2);
                    if (control == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (control == false);
                if (number2 >= 0)
                {
                    break;
                }
            }
            //zkontroluji nenulovou hodnotu čísla 1
            while (number1 == 0)
            {
                Console.WriteLine("Nelze počítat s nulou. Zadej jiné číslo.");
                do
                {
                    control = float.TryParse(Console.ReadLine(), out number1);
                    if (control == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (control == false);
                if (number1 != 0)
                {
                    break;
                }
            }
            return (float)Math.Pow(number2, 1 / number1);
        }
        static float Factorial(float number1, float number2, bool control)
        {
            float result;
            //zkontroluji nezápornou hodnotu čísla
            while (number1 < 0)
            {
                Console.WriteLine("Nelze vytvořit faktoriál záporného čísla. Zadej nové.");
                do
                {
                    control = float.TryParse(Console.ReadLine(), out number1);
                    if (control == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (control == false);
                if (number1 >= 0)
                {
                    break;
                }
            }
            result = 1;
            for (int i = 1; i < number1 + 1; i++)
            {
                result = result * i;
            }
            return result;
        }
        static float Binary (string option, float result)
        {
            switch (option)
            {
                case "ano":
                    string result2 = result.ToString("X");
                    Console.WriteLine("Převedený výsledek je " + Convert.ToString(Convert.ToInt32(result), 2));
                    break;
                case "ne":
                    Console.WriteLine("Okej, v tom případě jsme spolu skončili. Čuuus");
                    break;
                default:
                    Console.WriteLine("Tak to nebylo ani ano ani ne, takže se smíříš s tím, že máš výsledek a končíme.");
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

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
            string operation = Console.ReadLine();
            float number1 = 0;
            float number2 = 0;
            bool control = true;
            string option;
            float result = 0;
            //zadám čísla potřebná k výpočtu
            Console.WriteLine("Perfektní! Zadej první číslo výpočtu.");
            do
            {
                //zkontroluji, zda uživatel zadal platné číslo
                control = float.TryParse(Console.ReadLine(), out number1); //přečte console.readline, zkusí, zda se jedná o float, vyhodí float hodnotu number1
                if (control == false)
                {
                    Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                }
            } while (control == false);
            if (operation != "faktoriál")
            {
                do
                {
                    Console.WriteLine("Perfektní! Zadej druhé číslo výpočtu.");
                    //zkontroluji, zda uživatel zadal platné číslo
                    control = float.TryParse(Console.ReadLine(), out number2); //přečte console.readline, zkusí, zda se jedná o float, vyhodí float hodnotu number2
                    if (control == false)
                    {
                        Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    }
                } while (control == false);
            }
            //podle zadané operace vypočítám výsledek
            switch (operation)
            {
                case "součet":
                case "+":
                    result = Add(number1, number2);
                    break;
                case "rozdíl":
                case "-":
                    result = Subtract(number1, number2);
                    break;
                case "násobek":
                case "*":
                    result = Multiply(number1, number2);
                    break;
                case "podíl":
                case "/":
                    result = Divide(number1, number2, control);
                    break;
                case "logaritmus":
                case "log":
                    result = Logarithm(number1, number2);
                    break;
                case "mocnina":
                    result = Power(number1, number2);
                    break;
                case "odmocnina":
                    result = Root(number1, number2, control);
                    break;
                case "faktoriál":
                    result = Factorial(number1, number2, control);
                    break;
                default:
                    Console.WriteLine("Neplatná operace. Zadej novou.");
                    operation = Console.ReadLine();
                    break;
            }
            //vypíšu výsledek a pracuji s doplňující možností
            Console.WriteLine("Výsledek je " + result + " Chceš tento výsledek převést na binární soustavu? ano/ne?");
            option = Console.ReadLine();
            Binary(option, result);
            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.
        }
    }
}
