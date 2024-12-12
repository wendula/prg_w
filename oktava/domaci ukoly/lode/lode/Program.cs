using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Vytvořte konzolový program, který bude simulovat hru Lodě (hráč vs počítač)
-Hrací pole je velké 10 x 10, Řádky značeny čísly 1 - 10, Sloupce značeny písmeny A - J
- Lodě
- 1x Letadlová loď (velikost 1 x 5)
-1x Bitevní loď (velikost 1 x 4)
-1x Křižník(velikost 1 x 3)
-1x Ponorka(velikost 1 x 3)
-1x Torpédoborec(velikost 1 x 2)
-Před začátkem hry si hráč rozmístí lodě, počítač je rozmístí náhodně, Kontrolujte korektnost - lodě se nepřekrývají a jsou buď vodorovně, nebo svisle
*/
/*
 * V každém kroku vykreslujte aktuální stav hráčova pole a aktuální pohled pole počítače (jak ho doteď vidí hráč)
- Lodě budou značeny na poli písmeny (např. L L L L L je horizontální letadlová loď)
- Začíná hráč
- Tah hráče:
- Volí souřadnice, kam vystřelí
- Pole počítače se hráči zaktualizuje
podle toho, jestli zasáhl, nebo minul
- Tah počítače:
- Náhodně vybere souřadnice, kam
vystřelí
- Hráči se zaktualizuje stav jeho vlastního
pole
- Hra končí, pokud hráč nebo počítač má všechny lodě plně potopené
*/
/*
Možná vylepšení a rozšíření:
-Počítač nebude střílet náhodně, ale bude mít nějakou strategii
- Když zasáhne, zkusí příště vystřelit do okolních míst
- Když najde “směr”, jakým loď stojí, zkusí tímto směrem střílet (horizontálně, nebo vertikálně)
-Více typů střel(příklady)
-Základní střela(zasáhne 1 místo)
- Bomba(zasáhne plochu 3 x 3)
- Kobercové bombardování(zasáhne plochu 1 x 2)
- Umožněte volbu směru
- Lepší střely by měly být v omezeném množství
- Omezené množství munice a doplňování
- Stanovte pevný počet munice, kterou si lze částečně doplnit např. vynecháním kola
Možná vylepšení a rozšíření (pokračování):
- Sonar (objevení části pole soupeře, třeba 3 x 3) jednou za hru
- Možnost volby rozměrů pole
- Může být i obdélníkové nebo třeba kruhové
- Nové typy lodí
- třeba “odolná” loď, která potřebuje na každou svoji část 2 zásahy
- Cokoliv dalšího vás napadne
- Napište mi a domluvíme se
*/
namespace lode
{
    internal class Program
    {
        static string[,] player_board;
        static string[,] comp_board;
        static int board_size = 10;
        static int ships = 5;
        static int row_coor;//coordinates
        static int col_coor;
        static string bad_input = "uhhhhhhh this doesn't seem like the right input, maybe try again";
        static Dictionary<string, int> ship_sizes = new Dictionary<string, int>
        {
            { "carrier", 5 },
            { "battleship", 4 },
            { "cruiser", 3 },
            { "submarine", 3 },
            { "destroyer", 2 }
        };

        static void FillBoards(string[,] board)//fils the array with empty squares
        {
            for (int i = 0; i < board_size; i++)
            {
                for (int j = 0; j < board_size; j++)
                {
                    board[i, j] = "[-]";

                }
            }
        }
        static void ShowBoards(string[,] board, bool hide_ships)//prints boards to console
        {
            Console.Write("     ");
            //writes letters to indicate columns
            for (char col = 'A'; col < 'A' + board_size; col++)//ai help, who could have guessed that you can make for cycles for characters?
            {
                Console.Write(col + "   ");
            }
            Console.WriteLine();

            //writes rest of the board, including row indicators
            for (int i = 0; i < board_size; i++)
            {
                Console.Write($"{i + 1,3} ");//margin for numbers
                for (int j = 0; j < board_size; j++)
                {
                    if (hide_ships == true && board[i,j]=="[S]")//hides ships in computer's board for the player
                    {
                        Console.Write("[-] ");
                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Refresh(string[,] player_board, string[,] comp_board)//actualizes board
        {
            Console.Clear();
            Console.WriteLine("your board");
            ShowBoards(player_board, false);
            Console.WriteLine("\n" + "oponent's board");
            ShowBoards(comp_board, true);
        }
        static void GetUserInput()
        {
            Console.WriteLine("Enter coordinates in format A1 (column then row)");

            List<char> alphabet = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            bool valid_input = false;
            while (valid_input == false)
            {
                string input = Console.ReadLine().ToUpper();
                if (input.Length < 2 || string.IsNullOrEmpty(input))//user input validation
                {
                    Console.WriteLine(bad_input);
                }
                else
                {
                    string coll = input.Substring(0, 1);
                    string roww = input.Substring(1);//allign number 10
                    if (!alphabet.Contains(coll[0]) || !int.TryParse(roww, out row_coor) || row_coor < 1 || row_coor > board_size)
                    {
                        Console.WriteLine(bad_input);
                    }
                    else
                    {
                        col_coor = alphabet.IndexOf(coll[0]);
                        row_coor--;
                        valid_input = true;
                    }
                }
            }
        }
        static bool CanShipBePlaced(string[,] board, int start_row, int start_col, bool orientation, int ship_size)//validation of ship placement
        {
            if (orientation && start_col + ship_size > board_size) return false;//coordinates is not inside the board
            if (!orientation && start_row + ship_size > board_size) return false;

            for (int i = 0; i < ship_size; i++)
            {
                int row = orientation ? start_row : start_row + i;//syntax with ? and : discovered through ai, it's really handy
                int col = orientation ? start_col + i : start_col;
                if (board[row,col]!= "[-]")return false;

                for (int r = row - 1; r <= row + 1; r++)
                {
                    for (int c = col - 1; c <= col + 1; c++)
                    {
                        if (c < 0 || r < 0 || r >= board_size || c >= board_size) continue;
                        if (board[r, c] == "[S]") return false;
                    }
                }
            }
            return true;
        }
        static void PlaceShip(int start_row, int start_col, int ship_length, bool orientation, string[,] board)//places ship in given place
        {
            for (int i = 0; i < ship_length; i++)
            {
                int row = orientation ? start_row : start_row + i;
                int col = orientation ? start_col + i : start_col;

                board[row, col] = "[S]";
            }
        }
        static void SetShipsComp(int ships, string[,] board)//randomly sets ships on computer board
        {
            Random rnd = new Random();
            foreach(var ship in ship_sizes)
            {
                string ship_name = ship.Key;
                int ship_size = ship.Value;
                bool set = false;
                while (set == false)
                {
                    int start_row = rnd.Next(board_size);
                    int start_col = rnd.Next(board_size);
                    bool orientation = rnd.Next(2) == 0;//random orientation - true horizontal, false vertical

                    if(CanShipBePlaced(board,start_row,start_col,orientation,ship_size))
                    {
                        PlaceShip(start_row, start_col, ship_size, orientation, board);
                        set = true;
                    }
                }
            }
        }
        static void SetShipsPlayer(int ships, string[,] board, Dictionary<string, int> ship_sizes)
        {
            Console.WriteLine("Let's place your ships for this game.");
            foreach(var ship in ship_sizes)
            {
                Console.WriteLine("The next one to set is " + ship.Key + ". It takes " + ship.Value + " squares.");
                bool done = false;//if ship is placed
                int ship_size = ship.Value;
                string ship_name = ship.Key;
                while(done == false)
                {
                    Console.WriteLine("Where is it gonna go?");
                    GetUserInput();
                    Console.WriteLine("And do you want it horizontal or vertical forom this point?");
                    string direction = Console.ReadLine().ToLower();
                    bool orientation = false;//same as before - horizontal is true

                    if (direction == "horizontal")
                    {
                        orientation = true;
                    }
                    else if (direction != "vertical")
                    {
                        Console.WriteLine(bad_input);
                        continue;
                    }
                    if (CanShipBePlaced(board, row_coor, col_coor, orientation, ship_size))
                    {
                        PlaceShip(row_coor, col_coor, ship_size, orientation, board);
                        done = true;
                        Console.WriteLine("The " + ship_name + " has been placed successfully.");
                        Refresh(player_board, comp_board);
                    }
                    else
                    {
                        Console.WriteLine("This ship cannot be placed here. Try a different position or orientation.");
                    }
                }
            }
            Console.WriteLine("Amazing!! Now let's get to the game, actually.");
            Console.ReadLine();
        }
        static void ActualGame()//hrajemeeeeee wohoooooo
        {
            int player_ships_left = ship_sizes.Values.Sum();
            int comp_ships_left = ship_sizes.Values.Sum();

            while (player_ships_left>0 && comp_ships_left>0)
            {
                Refresh(player_board, comp_board);

                //turn player
                GetUserInput();

                if (comp_board[row_coor, col_coor] == "[S]")
                {
                    //hit
                    comp_board[row_coor, col_coor] = "[X]";
                    Refresh(player_board, comp_board);
                    Console.WriteLine("Woohoo that's a hit!");
                    player_ships_left--;
                }
                else if (comp_board[row_coor, col_coor]=="[-]")
                {
                    //miss
                    comp_board[row_coor, col_coor] = "[O]";
                    Refresh(player_board, comp_board);
                    Console.WriteLine("Upsidupsi, that's a miss.");
                }
                else
                {
                    //problem?
                    Console.WriteLine("I am pretty sure you already guessed that???");
                }
                Console.ReadLine();

                Refresh(player_board, comp_board);

                //turn computer
                Console.WriteLine("Now it's your oponent's time.");
                Console.ReadLine();
                Random random = new Random();
                int comp_row, comp_col;

                do
                {
                    comp_row = random.Next(board_size);
                    comp_col = random.Next(board_size);
                }
                while (player_board[comp_row, comp_col] == "[X]" || player_board[comp_row, comp_col] == "[O]");//tries random squares until they find one that wasn't already guessed

                if (player_board[comp_row,comp_col]=="[S]")
                {
                    //hit
                    player_board[comp_row, comp_col] = "[X]";
                    Refresh(player_board, comp_board);
                    Console.WriteLine("Your ship was hit! That sucks.");
                    comp_ships_left--;
                }
                else
                {
                    //miss
                    char comp_col_try = (char)('A' + comp_col);
                    int comp_row_try = comp_row + 1;
                    player_board[comp_row, comp_col] = "[O]";
                    Refresh(player_board, comp_board);
                    Console.WriteLine("It's okay, he is not really the sharpest pencil in the pencilcase. He guessed " + comp_col_try + comp_row_try + ".");
                }
                Console.ReadLine();
            }
            Refresh(player_board, comp_board);

            //endgame
            if (player_ships_left==0)
            {
                Console.WriteLine("Holy shit you won! Well done!");
            }
            else if (comp_ships_left==0)
            {
                Console.WriteLine("Maybe your oponent isn't the sharpest, but he's sharper than you, ups...");
            }
        }
        static void Main(string[] args)
        {
            player_board = new string[board_size, board_size];
            comp_board = new string[board_size, board_size];
            FillBoards(player_board);
            FillBoards(comp_board);

            SetShipsComp(ships, comp_board);
            SetShipsPlayer(ships, player_board, ship_sizes);

            ActualGame();

            Console.ReadKey();
        }
    }
}
