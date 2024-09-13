using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] nums = { 10, 20, 30, 40, 50 };

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Vypíšeme array for cyklem.");
            for (int i = 0;i < nums.Length; i++) 
            {
                Console.WriteLine(nums[i]);
            }
            foreach (int num in nums)//num=nums[i]
            {
                Console.WriteLine(num);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Console.WriteLine("Výpissoučtu všech prvků je " + sum);


            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / nums.Length;
            Console.WriteLine("Průměr všech prvků je " + average);



            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = nums[0];
            for (int i = 1;i < nums.Length; i++) 
            {
                if (nums[i]>max)
                    max = nums[i];
            }
            Console.WriteLine("Maximum je " + max);



            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = nums.Min();
            Console.WriteLine("Minimum je " + min);


            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index;
            int number_input = Convert.ToInt32(Console.ReadLine());
            index = Array.IndexOf(nums, number_input);
            if (index == -1)
            {
                Console.WriteLine("Prvek v poli neexistuje.");
            }
            else
            {
                Console.WriteLine($"Prvek {number_input} je na indexu {index}.");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rnd = new Random();
            nums = new int[100];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 10);
                Console.WriteLine($"{i}. prvek pole je {nums[i]}");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int num in nums)
            {
                counts[num]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Četnost {i} je {counts[i]}.");
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] reversedArray = new int[100];
            for(int i = reversedArray.Length; i >= 0; i--)
            {
                reversedArray[i] = nums[99 - i];
            }
            for(int i = 0;i < reversedArray.Length; i++)
            {
                Console.Write($"{reversedArray[i]}");
            }

            Console.ReadKey();
        }
    }
}
