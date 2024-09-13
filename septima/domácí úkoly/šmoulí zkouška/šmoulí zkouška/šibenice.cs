using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace šmoulí_zkouška
{
    internal class šibenice
    {
        static void end1()
        {
            Console.WriteLine("Vypadá to, že se trochu naštvali. Možná jsi tam neměl* vůbec lézt, když vůbec nejsi šmoula. Odhalili tě a vyšmoulili tě pryč z lesa tak rychle, že ani nevíš, kudy jsi přišel*. Ale jednou určitě někam zapadneš, neboj.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void end2()
        {
            Console.WriteLine("To nedopadlo moc mile. Porota hlavních šmoulů rozhodla, že bys do vesničky nezapadl* a neudělila ti šmoulopas. Příště budeš muset asi pilněji studovat.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void end3()
        {
            Console.WriteLine("Byl* jsi moc šikovným jedincem, ale kvůli své neznalosti a neopatrnosti jsi během výkonu zkoušky zahynul* velmi dramatickou smrtí. Šmoulové ti vystrojili překrásný pohřeb a Šmoulinka uronila tolik slz, že by naplnily i Mlsounův největší hrnec. Asi jsi jí přirostl* k srdci. Navždy jsi zůstal* v jejich vzpomínkách. <3");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void end4()
        {
            Console.WriteLine("Bohužel, tenhle pán nepatří mezi šmoulí nepřátele. Šmoulové tě donutili si sbalit svých pět švestek a odejít. Příště se nad svými rozhodnutími budeš muset více zamyslet.");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static int lives, length;
        static string given_word, current_letter;
        public void sibenice(string[] words, int rank)
        {
            Console.WriteLine("Vyšmouli slovo pro splnění úkolu. Máš 11 životů.");
            given_word = words[new Random().Next(0, words.Length)];//vybrání náhodného slova ze seznamu
            length = given_word.Length;
            lives = 11;

            char[] guess_word = new char[length];//vypsání "délky" slova podtržítky
            for (int i = 0; i < length; i++)
            {
                guess_word[i] = '_';
            }

            while (lives > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Hádané slovo - " + string.Join(" ", guess_word));
                Console.Write("Zadej písmenko sem -> ");
                string user = Console.ReadLine();
                user_input(user);

                if (user.Length == 1)//jen jedno písmeno
                {
                    current_letter = user;
                    bool letter = false;

                    for (int i = 0; i < length; i++)//projede slovo a zjistí zda se tam nachází dané písmeno
                    {
                        if (given_word[i].ToString() == current_letter)
                        {
                            guess_word[i] = current_letter[0];
                            letter = true;
                        }
                    }

                    if (letter)
                    {
                        Console.WriteLine("Šmoulovatě! Písmeno '" + current_letter + "' je ve slově!");
                    }
                    else
                    {
                        Console.WriteLine("Smůla! Písmeno '" + current_letter + "' není ve slově.");
                        lives--;
                    }

                    if (string.Join("", guess_word) == given_word)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Skvělé! Vyšmoulil* jsi celé slovo " + given_word + "! Tím je tvůj úkol splněn a můžeš šmoulit dál.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Zadej písmenko sem -> ");
                }
                Draw(lives);
            }

            if (lives == 0)//prohrané kolo, možné konce podle části příběhu
            {
                Console.WriteLine();
                Console.WriteLine("Tak to jsi vůbec nevyšmoulil*. Prohrál jsi na slově " + given_word + ".");
                if (rank == 1 || rank == 2)
                {
                    end1();
                }
                else if (rank == 3 || rank == 4)
                {
                    end2();
                }
                else if (rank == 5)
                {
                    end3();
                }
            }
            Console.ReadKey();
        }
        static void user_input (string user)
        {
            if (string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Zadal* jsi něco jiného než písmeno. Zkus to ještě jednou.");
                return;
            }
        }
        static void Draw(int lives)//kreslení panáčka šibenice
        {
            Console.WriteLine();
            Console.WriteLine("Tady vidíš, kolik máš ještě pokusů.");

            switch (lives)
            {
                case 11:
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    break;
                case 10:
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("             ");
                    Console.WriteLine("_____________");
                    break;
                case 9:
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 8:
                    Console.WriteLine("_____________");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 7:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /          ");
                    Console.WriteLine("|/           ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 6:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/           ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 5:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 4:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|           |");
                    Console.WriteLine("|           |");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 3:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|          /|");
                    Console.WriteLine("|         / |");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 2:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|          /|\\");
                    Console.WriteLine("|         / | \\");
                    Console.WriteLine("|            ");
                    Console.WriteLine("|            ");
                    Console.WriteLine("_____________");
                    break;
                case 1:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|          /|\\");
                    Console.WriteLine("|         / | \\");
                    Console.WriteLine("|          / ");
                    Console.WriteLine("|         /  ");
                    Console.WriteLine("_____________");
                    break;
                default:
                    Console.WriteLine("_____________");
                    Console.WriteLine("| /         |");
                    Console.WriteLine("|/          O");
                    Console.WriteLine("|          /|\\");
                    Console.WriteLine("|         / | \\");
                    Console.WriteLine("|          / \\");
                    Console.WriteLine("|         /   \\");
                    Console.WriteLine("_____________");
                    break;//obrázky kopírovány z internetu
            }
        }
    }
}
