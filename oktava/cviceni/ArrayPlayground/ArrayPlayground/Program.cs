using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] array = { 7, 69, 420, 42, 13 };


            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický for, kde i využiješ jako index v poli, tak foreach.
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }


            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i]; 
            }
            Console.WriteLine("Součet všech prvků pole je " + sum);



            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average;
            average = sum / array.Length;
            Console.WriteLine("Průměr všech prvků je " + average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max;
            max = array.Max();
            Console.WriteLine("Maximální hodnota je " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min;
            min = array.Min();
            Console.WriteLine("Minimální hodnota je " + min);


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index = -1;
            int user;
            Console.WriteLine("Zadej číslo, jehož index chceš najít.");
            bool control = int.TryParse(Console.ReadLine(), out user);
            int j = 0;
            while (index == -1)
            {
                if (array[j]==user)
                {
                    index = j;
                }
                j++;
            }
            if (index==-1)
            {
                Console.WriteLine("Tebou zadané číslo není v poli.");
            }
            else
            {
                Console.WriteLine("Číslo " + user + " je na pozici " + index);
            }

            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();
            array = new int[100];
            for (int i = 0;i < 100; i++)
            {
                array[i] = rng.Next(0, 10);
            }
            foreach (int i in array)
            {
                Console.Write(i+", ");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];


            foreach (int number in array)
            {
                counts[number]++;
            }
            Console.WriteLine();
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine("Četnost číslice " + i + ": " + counts[i]);
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] array2 = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[array.Length - i - 1];

            }
            foreach (int i in array2)
            {
                Console.Write(i+", ");
            }


            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
