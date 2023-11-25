using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] array2D = new int[5, 5];
            int number = 1;
            for (int i = 0; i < array2D.GetLength(0); i++)//řádky
            {
                for (int j = 0; j < array2D.GetLength(1); j++)//sloupce
                {
                    array2D[i, j] = number;//5*i+j
                    number++;
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 4;
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                Console.Write(array2D[nRow, j] + " ");
            }
            Console.WriteLine("\n");

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 3;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i, nColumn] + "\n");
            }
            Console.WriteLine("\n");

            //BONUS TODO: HLAVNÍ DIAGONÁLA
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                Console.Write(array2D[i, i] + " ");
            }
            Console.WriteLine("\n");

            //BONUS TODO 2: VEDLEJŠÍ DIAGONÁLA 
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(array2D[i, array2D.GetLength(1) - i - 1] + " ");
            }
            Console.WriteLine("\n");

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            /*
            int xFirst, yFirst, xSecond, ySecond;
            xFirst = yFirst = 0;
            xSecond = ySecond = 4;
            int first = array2D[xFirst, yFirst];
            //int second = array2D[xSecond, ySecond];
            array2D[xFirst, yFirst] = array2D[xSecond, ySecond];
            array2D[xSecond, ySecond] = first;
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            */
            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            /*int nRowSwap = 0;
            int mRowSwap = 1;
            int temporary;
            for (int i = 0; i < array2D.GetLength(1); i++)
            {
                temporary = array2D[nRowSwap, i];
                array2D[nRowSwap, i] = array2D[mRowSwap, i];
                array2D[mRowSwap, i] = temporary;
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            */
            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            /*for (int i = 0; i < array2D.GetLength(0)/2; i++)
            {
                int temp = array2D[i, i];
                int coordinate = array2D.GetLength(0) - 1 - i;
                array2D[i, i] = array2D[coordinate,coordinate];
                array2D[coordinate, coordinate] = temp;
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            */
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.
            for (int i = array2D.GetLength(0)-1; i > array2D.GetLength(0)/2; i++)
            {
                int j = array2D.GetLength(0) - 1 - i;
                int temp = array2D[i, j];
                array2D[i, j] = array2D[j, i];
                array2D[j, i] = temp;
                Console.Write(array2D[i, j] + " ");
            }
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}


