using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace array_homework
{
    internal class Program
    {
        static int check_input (string input)
        {
            bool control = true;
            int res;
            do
            {
                //zkontroluji, zda uživatel zadal platné číslo
                control = int.TryParse(input, out res); //přečte console.readline, zkusí, zda se jedná o int, vyhodí int hodnotu res
                if (control == false)
                {
                    Console.WriteLine("Kamaráde, já jsem chtěla číslo...");
                    input = Console.ReadLine();//nový pokus o zadání
                }
            } while (control == false);
            return res;//dále určíme jako námi požadovanou proměnnou
        }
        static void fill_array(int[,] array, int rows, int columns, Random rnd) //naplnění pole zadaného uživatelem náhodnými prvky
        {
            for (int i = 0; i < array.GetLength(0); i++)//řádky
            {
                for (int j = 0; j < array.GetLength(1); j++)//sloupce
                {
                    array[i, j] = rnd.Next(10,101);//prvky od 10 do 100
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void switch_elements(int[,] array, int nrowA, int ncolA, int nrowB, int ncolB)//prohodí dva prvky jejichž pozici zadá uživatel
        {
            int first = array[nrowA, ncolA];//uložení čísla
            array[nrowA, ncolA] = array[nrowB, ncolB];
            array[nrowB, ncolB] = first;
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void switch_rows(int[,] array, int nrA, int nrB, int columns)//prohození dvou řádků, které zadá uživatel
        {
            int temporary;
            for (int i = 0; i < columns; i++)
            {
                temporary = array[nrA, i];//uložení řádku
                array[nrA, i] = array[nrB, i];
                array[nrB, i] = temporary;
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void switch_columns(int[,] array, int ncA, int ncB, int rows)//prohodí dva sloupce vybrané uživatelem
        {
            int temporary;
            for (int i = 0; i < rows; i++)
            {
                temporary = array[i, ncA];//uložení sloupce
                array[i, ncA] = array[i, ncB];
                array[i, ncB] = temporary;
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void switch_diagonals(int[,]array, int rows, int columns)//prohodí obě diagonály navzájem (důsledek prvotního nepochopení zadání)
        {
            int temporary;
            for (int i = 0; i < rows&& i < columns; i++)
            {
                temporary = array[i, i];//uloží prvek
                array[i, i] = array[i, array.GetLength(1) - i - 1];//nahradí prvek prvkem druhé diagonály
                array[i, array.GetLength(1) - i - 1] = temporary;//doplní druhou diagonálu prvním prvkem
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void switch_main_diagonal(int[,] array, int rows, int columns)//protočí pořadí prvků na hlavní diagonále
        {
            int temporary;
            if (rows <= columns)
            {
                for (int i = 0; i < rows/2; i++)//i je menší než řádky i sloupce
                {
                    temporary = array[i, i];//uložení
                    array[i, i] = array[rows - i - 1, rows - i - 1];
                    array[rows - i - 1, rows - i - 1] = temporary;
                }
            }
            else if (columns < rows)
            {
                for (int i = 0; i < columns/2; i++)//i je menší než řádky i sloupce
                {
                    temporary = array[i, i];//uložení
                    array[i, i] = array[columns - i - 1, columns - i - 1];
                    array[columns - i - 1, columns - i - 1] = temporary;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void switch_side_diagonal(int[,] array, int rows, int columns)//protočí pořadí prvků na vedlejší diagonále
        {
            int temporary;
            if (rows <= columns)
            {
                for (int i = 0; i < rows / 2; i++)//i je menší než řádky i sloupce
                {
                    temporary = array[i, rows-i-1];//uložení
                    array[i, rows-i - 1] = array[rows - i - 1, i];
                    array[rows - i - 1, i] = temporary;
                }
            }
            else if (columns < rows)
            {
                for (int i = 0; i < columns / 2; i++)//i je menší než řádky i sloupce
                {
                    temporary = array[i, columns - i - 1];//uložení
                    array[i, columns - i - 1] = array[columns - i - 1, i];
                    array[columns - i - 1, i] = temporary;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void multiply_by_number(int[,] array, int number)//vynásobí pole zadaným číslem
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] *= number;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void multiply_row(int[,]array,int row,int columns, int number)//vynásobí zadaný řádek dříve zadaným číslem
        {
            for (int i = 0; i < columns; i++)
            {
                array[row,i] *= number;
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void multiply_column(int[,] array, int column, int rows, int number)//vynásobí zadaný sloupec dříve zadaným číslem
        {
            for (int i = 0; i < rows; i++)
            {
                array[i, column] *= number;
            }
            for (int i = 0; i < array.GetLength(0); i++)//vypsání pole
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void addition(int[,]array2, int[,]array3)//odečítá dvě nově vytvořená pole o stejné velikosti jako pole předchozí
        {
            int[,] result = new int[array2.GetLength(0), array2.GetLength(1)];//pomocná proměnná bránící modifikace pole array2(rada od chatgpt po hodině nechápání problému a lehkém emočním zhroucení)
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    result[i,j]= array2[i,j] + array3[i, j];//početní operace
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void subtraction(int[,] array2, int[,] array3)//odečítá druhé nové pole od prvního 
        {
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] -= array3[i, j];
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
        static void transposition(int[,]array, int rows, int columns)//přetočení pole dle hlavní diagonály
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)//otočení délky (nuly a jedničky v závorkách)(řádky a sloupce)
                {
                    Console.Write(array[j, i] + " ");//otočení souřadnic
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet řádků.");
            string input = Console.ReadLine();//počet řádků
            int rows = check_input(input);
            Console.WriteLine("Zadej počet sloupců.");
            input = Console.ReadLine();
            int columns = check_input(input);//počet sloupců
            int[,] array = new int[rows, columns];//vytvoření pole
            Random rnd = new Random(); 
            fill_array(array, rows, columns, rnd);
            Console.Write("\n");
            
            Console.WriteLine("Zadej postupně pozice dvou různých prvků, které chceš prohodit.");//uživatel zadává pozice, ne souřadnice, číslujeme od 1
            input = Console.ReadLine();
            int nrowA = check_input(input) - 1;
            input = Console.ReadLine();
            int ncolA = check_input(input) - 1;
            input = Console.ReadLine();
            int nrowB = check_input(input) - 1;
            input = Console.ReadLine();
            int ncolB = check_input(input) - 1;
            switch_elements(array, nrowA, ncolA, nrowB, ncolB);
            Console.Write("\n");

            Console.WriteLine("Zadej dvě čísla řádků, které chceš prohodit.");//uživatel zadává pozice, ne souřadnice, číslujeme od 1
            input = Console.ReadLine();
            int nrA = check_input(input) - 1;
            input = Console.ReadLine();
            int nrB = check_input(input) - 1;
            switch_rows(array, nrA, nrB, columns);
            Console.Write("\n");

            Console.WriteLine("Zadej dvě čísla sloupců, které chceš prohodit.");//uživatel zadává pozice, ne souřadnice, číslujeme od 1
            input = Console.ReadLine();
            int ncA = check_input(input) - 1;
            input = Console.ReadLine();
            int ncB = check_input(input) - 1;
            switch_columns(array, ncA, ncB, rows);
            Console.Write("\n");

            Console.WriteLine("Prohození diagonál.");
            switch_diagonals(array, rows, columns);
            Console.Write("\n");

            Console.WriteLine("Prohození prvků na hlavní diagonále.");
            switch_main_diagonal(array, rows, columns);
            Console.Write("\n");

            Console.WriteLine("Prohození prvků na vedlejší diagonále.");
            switch_side_diagonal(array, rows, columns);
            Console.Write("\n");

            Console.WriteLine("Zadej číslo, kterým chceš vynásobit pole.");
            input = Console.ReadLine();
            int number = check_input(input);
            multiply_by_number(array, number);
            Console.Write("\n");

            Console.WriteLine("Chceš číslem vynásobit i jen konkrétní řádek? (ano/ne)");
            string answer = Console.ReadLine();
            do {//řešení možností odpovědi uživatele
                if (answer == "ano")
                {
                    Console.WriteLine("Který řádek?");//uživatel zadává číslo řádku, ne souřadnici (-1)
                    input = Console.ReadLine();
                    int row = check_input(input) - 1;
                    multiply_row(array, row, columns, number);
                    break;
                }
                else if (answer == "ne")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná odpověď. Zkus zadat novou.");
                    answer = Console.ReadLine(); 
                }
            }while(answer!= null);
            Console.WriteLine("Chceš číslem vynásobit i jen konkrétní sloupec? (ano/ne)");
            answer = Console.ReadLine();
            do//řešení možností odpovědi uživatele
            {
                if (answer == "ano")
                {
                    Console.WriteLine("Který sloupec?");//uživatel zadává číslo řádku, ne souřadnici (-1)
                    input = Console.ReadLine();
                    int column = check_input(input) - 1;
                    multiply_column(array, column, rows, number);
                    break;
                }
                else if (answer == "ne")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná odpověď. Zkus zadat novou.");
                    answer = Console.ReadLine();
                }
            } while (answer != null);
            Console.Write("\n");

            //vytvoření dvou nových polí o stejné velikosti pro sčítání a odčítání
            Console.WriteLine("Vytvoření dvou nových polí pro další operace.");
            int[,] array2 = new int[rows, columns];
            int[,] array3 = new int[rows, columns];
            fill_array(array2, rows, columns, rnd);
            Console.Write("\n");
            fill_array(array3, rows, columns, rnd);
            Console.Write("\n");
            Console.WriteLine("Součet předchozích dvou polí.");
            addition(array2, array3);
            Console.Write("\n");
            Console.WriteLine("Rozdíl předchozích dvou polí. (první-druhé)");
            subtraction(array2, array3);

            Console.WriteLine("Nové pole pro transpozici.");
            int[,] array5 = new int[rows, columns];
            fill_array(array5, rows, columns, rnd);
            Console.Write("\n");
            Console.WriteLine("Transpozice pole.");
            transposition(array2, rows, columns);
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
