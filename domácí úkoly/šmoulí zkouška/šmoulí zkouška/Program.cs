using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace šmoulí_zkouška
{
    internal class Program
    {
        static void blank() //funkce pro prázdný řádek, páč už mě to nebavilo psát
        {
            Console.WriteLine();
        }
        static void ask_question(int number, string question, string correct_answer, params string[] options) //otázka s možnostmi (params poradil chat)
        {
            Console.WriteLine(question);
            foreach (string option in options)//vypsání možností
            {
                Console.WriteLine(option);
            }
            string user_choice = Console.ReadLine();
            if (string.IsNullOrEmpty(user_choice))//zkontroluje input
            {
                Console.WriteLine("Nezadal jsi ani jednu z možností, zkus to ještě jednou.");

            }
            else if (user_choice.ToUpper() == correct_answer)//správná odpověď
            {
                Console.WriteLine("Skvělé! To je přesně to co jsem chtěl slyšet. Pokračuješ dál.");
            }
            else
            {
                Console.WriteLine("To jsi tedy nevyšmoulil... Mrzí mě to, ale takhle to nepůjde. Tady tvoje cesta končí.");//špatná odpověď, různé možnosti konce pro různé špatné odpovědi
                if (number == 1 || number == 3 || number == 6)
                {
                    end1();
                }
                else if (number == 2 || number == 5)
                {
                    end2();
                }
                else if (number == 4)
                {
                    end3();
                }
                else if (number == 7)
                {
                    end4();
                }
            }
        }
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
        static void measure()//výška 
        {
            string input = Console.ReadLine();
            bool control;
            int height;
            do
            {
                //zkontroluji, zda uživatel zadal platné číslo
                control = int.TryParse(input, out height); //přečte console.readline, zkusí, zda se jedná o int, vyhodí int hodnotu height
                if (control == false)
                {
                    Console.WriteLine("To úplně není číslo toto...");
                    input = Console.ReadLine();//nový pokus o zadání
                }
            } while (control == false);
            if (height < 70 && height > 30)//správná výška
            {
                Console.WriteLine("Úžasné, začínáš mi být sympatický*. Ještě jednu rychlou otázku.");
            }
            else
            {
                end1();
            }
        }
        static void Main(string[] args)
        {
            string[] words = { "chameleon", "xylofon", "encyklopedie", "expedice", "samostatnost", "generace", "hromosvod", "lentilka", "strategie", "neuroviróza", "pantomima", "hospoda", "řeřicha", "institut", "kuriozita", "propaganda", "dezertifikace", "kolonizace", "mateřídouška", "dvacetikoruna", "struktura", "krakatice", "chobotnice", "lupínek", "pukanec", "samohláska", "šmoulinka", "muchormůrka", "azrael", "gargamel", "silák", "mlsoun", "fešák", "mrzout", "kutil", "čepeček", "vesnička", "schovávaná", "šmorůvka", "kocour", "šmoula", "vynález", "šprýmař", "lumpárna", "koumák", "taťka šmoula" };

            //jednotlivé úkoly a otázky

            //1
            Console.WriteLine("Vítej ve šmoulí vesničce! Tebe jsme tu ještě neviděli! Jsi tu nový*? To je vskutku šmoulovaté, máme nového nájemníka! Je to veliká radost, když můžeme přijmout do komunity někoho nového. Většina totiž neprojde příjímací zkouškou. Ale to ty jistě zvládneš! Je to jen pár snadných úkolů. Pojď, Koumák se tě nejprve zeptá na pár otázek a pak už to bude raz dva.");
            blank();
            Console.WriteLine("*Koumákova muchomůrka je na konci hlavní avenue. Neznámý šmoula vejde dovnitř a po několika vteřinách vyjde a jen tě prostrčí dveřmi a zmizí. Chaloupka je plná knihoven a knih mimo knihovny a zpoza jedné knihy na tebe vykoukne brýlatý obličej.*");
            Console.WriteLine("Vítej nováčku! Prý chceš podstoupit příjímací řízení. Přeji ti hodně štěstí! Ale nejprve si tě tady zaznamenám. Jaká je tvá přirozená barva kůže?");
            blank();
            ask_question(1, "Jaká je tvá přirozená barva kůže?", "B", "A. zelená", "B. modrá", "C. růžová");
            blank();

            //2
            Console.WriteLine("Pak bych potřeboval vědět, jak jsi vysoký*.");
            Console.WriteLine("Jak jsi vysoký?");
            blank();
            measure();
            blank();

            //3
            Console.WriteLine("Teď už jen potřebuji vědět, jaký je tvůj oblíbený styl oblečení.");
            blank();
            ask_question(2, "Jaký je tvůj oblíbený styl oblečení?", "A", "A. dupačky s čepečkem", "B. hábit s kapucí", "C. skautský kroj", "D. kilt a matfyzácké brýle", "E. každý den je středa, nosím jenom růžovou");
            Console.WriteLine();
            blank();

            //4
            Console.WriteLine("*Koumák zvedl sluchátko svého muchomůrkofonu a rychle zaúkoloval Siláka, aby si tě přišel vyzvednout. Ten tě vskutku energicky chytil za loket a významně tě odtáhl do lesa.*");
            blank();
            Console.WriteLine("Teď už se budeš muset trochu předvést, nováčku. Řekni mi jen kontrolně, na čem rostou šmorůvky?");
            blank();
            ask_question(3, "Jak se jmenuje rostlina, na které rostou šmorůvky?", "B", "A. šmorovice", "B. šmorůvkový keř", "C. lesník šmorůvkový");
            Console.WriteLine();
            blank();
            Console.WriteLine("Dobrá, tak tady máš dva košíky, a běž si nějaký ten šmorůvkový keř najít. Máš na to hodinu, jinak jsi šmoula k ničemu.");
            blank();
            šibenice hangman = new šibenice();
            hangman.sibenice(words, 1);
            blank();

            //5
            Console.WriteLine("Překvapivé, to jsi zvládl. Jsi si ale jistý tím, jakou barvu mají šmorůvky? Přeju ti mnoho zdaru, tvým dalším úkolem je totiž ty dva košíky sníst do dvaceti minut.");
            blank();
            ask_question(4, "Jakou barvu mají šmorůvky?", "C", "A. modrou", "B. černou", "C. červenou");
            blank();
            hangman.sibenice(words, 2);
            Console.WriteLine("Gratuluji, pošlu tě k někomu dalšímu kdo tě posoudí.");
            blank();

            //6
            string[] words2 = { "sašetka", "filuta", "čiloun", "šikula" };
            Console.WriteLine("*Když tě Silák vyzvedl z lesa, už tam na vás čekal Nešika, který vyrazil rázným krokem skrz vesničku. Zastavil tě až na menším prostranství mezi pěti muchomůrkami. Za pár vteřin začínal být slyšet dětský smích a za minutku už se zpoza muchomůrky s růžovou střechou vyřítila šmoulata. Nešika ti to rychle vysvětlil.*");
            Console.WriteLine("Tady se šmoulaty si zahraješ na schovku. Budeš je muset najít, okruh je stanoven na 300 metrů. Myslím, že za 40 minut byste tu měli všichni být. Počítáš do 100.");
            blank();
            hangman.sibenice(words2, 3);
            blank();

            //7
            Console.WriteLine("Luxusní, teď jsi zaválel! Teď bych od tebe potřeboval laskavost. Tak trochu jsem během hlídání ztratil Šmoulíčka. Pomohl* bys mi ho najít? U koho myslíš, že by se mohl schovávat?");
            ask_question(5, "U koho se bude Šmoulíček nejpravděpodobněji schovávat?", "A", "A. u Šmoulinky", "B. u Bručouna", "C. u Gargamela");
            blank();
            Console.WriteLine("Kouzelné, pojďme to tam prohlédnout.");
            Console.WriteLine("*Šmoulinka tvrdí, že s ní Šmoulíček není, ale není, kde jinde by se mohl nacházet, tak začnete hledat po okolí*");
            blank();
            hangman.sibenice(words, 4);
            blank();
            Console.WriteLine("Uff, to jsem rád, že jsme ho našli. Teď ale utíkej na hlavní náměstí, už tě tam určitě čeká Poeta.");
            blank();

            //8
            Console.WriteLine("Vítej odvážlivče, v větě plném melodií \n pár posledních úkolů před tebou teď ční\n v otázce o šmoulích písních zvídavě se ptám\n který úryvek z žádné hymny nezaznívá\n z těch všech které znám?");
            blank();
            ask_question(6, "Který z úryvků nenajdeme v žádné šmoulí hymně? Případné nápovědy najdeš tady: \n https://www.youtube.com/watch?v=VJeEoZrxpRU \n https://www.youtube.com/watch?v=vpEYbZhiR5w&list=PL5Xre7IxKcUvA1yiSAHraqyWyDodH9elj \n https://www.youtube.com/watch?v=P2HJUg5CuqI \n https://www.youtube.com/watch?v=9gwoCdTN4pQ \n https://www.youtube.com/watch?v=YctXcY8ujQQ&list=PLh-nxTBfzQDEfNu7NvZ0udxssPIengrs5&index=17", "D", "A.ve dne ztratil klid, a v noci nemoh spát, myslel na šmouly, jak je v lese pochytat", "B. všechno se zvládnout dá, každý občas má den zlý, vždyť na to nejsi sám, máš nás kamarády modrý", "C. každý ví, že žádný šmoula nemá strach, žádný strach, nebojí se, odvážný je, kamarád", "D. šmoulové jsou nej, hrajou si každý den, mají hodně kamarádů, každého se ptaj o radu, jak na Gargamela, aby zas nebyla mela", "E. tak jenom tancuj, nebuď sám a přidej se k nám, užívej si s náma bál");
            blank();

            //9
            Console.WriteLine("*Poeta ti lehounce zatleskal a nechal tě stát upřostřed náměstí. Když jsi se zmateně rozhlédl*, na druhé straně na tebe mávl Taťka Šmoula. Naznačil ať jdeš s ním.*");
            Console.WriteLine("Jsi velmi šikovný šmoula. Teď už tě čeká poslední, zato nejtěžší úkol. Musíš se utkat s jedním z našich nepřítel. Výběr je na tobě, ale pamatuj, jaké vlastnosti jsou u šmouly důležité.");
            blank();
            ask_question(7, "Kterého ze šmoulích nepřátel zvládneš porazit?", "A", "A. Oktopián",  "B. Marco Šmoulo", "C. Don Šmoulič");
            blank();
            Console.WriteLine("Dobrá, přeji ti v boji mnoho zdaru.");
            blank();

            string[] words3 = { "důvtip", "inteligence", "sounáležitost", "kreativita", "otevřenost", "analytické myšlení", "vynalézavost", "odolnost", "spolupráce" };
            hangman.sibenice(words3, 5);
            blank();

            //10
            Console.WriteLine("Tak to je nevídané! Tys to dokázal*! Gratuluji ti! Pověz mi, jaká je tvá výrazná vlastnost, jak ti máme říkat?");
            string name = Console.ReadLine();
            blank();
            Console.WriteLine($"Vítej ve šmoulí vesničce! Haló všichni! Tohle je {name}, náš nejnovější občan!");
            blank();
            Console.WriteLine("*Úspěšně jsi dohrál* celý přijímací rituál, gratuluju. Doufám, že jsi si tento příběh užil* a třeba někdy příště. Zatím, šmoulové*");

            Console.ReadKey();
        }
    }
}
