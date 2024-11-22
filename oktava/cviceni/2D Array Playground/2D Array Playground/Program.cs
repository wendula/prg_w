using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void DefaultArray(int[,] arrayToSet)
        {

            for (int i = 0; i < arrayToSet.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToSet.GetLength(1); j++)
                {
                    arrayToSet[i, j] = i * 5 + j + 1;
                }
            }
        }

        static void PrintArray(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    Console.Write(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] array = new int[5, 5];
            DefaultArray(array);
            PrintArray(array);


            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            Console.WriteLine(nRow + 1 + ". řádek");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write(array[nRow, i] + " ");
            }
            Console.WriteLine();

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 0;
            Console.WriteLine("");
            Console.WriteLine(nColumn + 1 + ". sloupec");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i, nColumn] + "\n");
            }
            Console.WriteLine();

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int rowFirst, colFirst, rowSecond, colSecond;
            rowFirst = colFirst = colSecond = 2;
            rowSecond = 3;

            int backup = array[rowFirst, colFirst];
            array[rowFirst, colFirst] = array[rowSecond, colSecond];
            array[rowSecond, colSecond] = backup;

            PrintArray(array);
            DefaultArray(array);

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            Console.WriteLine("Prohození " + nRowSwap+1 + ". řádku s " + mRowSwap+1 + ". řádkem");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                backup = array[nRowSwap, i];
                array[nRowSwap, i] = array[mRowSwap, i];
                array[mRowSwap, i] = backup;
            }
            PrintArray(array);
            DefaultArray(array);

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;
            Console.WriteLine("Prohození " + nColSwap+1 + ". sloupce s " + mColSwap+1 + ". sloupcem");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                backup = array[i, nColSwap];
                array[i, nColSwap] = array[i, mColSwap];
                array[i, mColSwap] = backup;
            }
            PrintArray(array);
            DefaultArray(array);

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            Console.WriteLine("Prohození prvků na hlavní diagonále.");
            Console.WriteLine("");
            for (int i = 0; i < array.GetLength(0) / 2; i++)
            {
                
            }
            PrintArray(array);
            DefaultArray(array);

            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}
