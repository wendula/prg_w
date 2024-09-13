using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class rectangle
    {
        public int width;
        public int height;

        public rectangle()
        {
        }

        public rectangle (int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public float Calculate_area()
        {
            float area = width * height;
            return area;
        }
        public string Calculate_aspect_ratio()
        {
            string ratio_string = " : 1";
            float ratio_float = width / height;
            if (ratio_float == 1)
            {
                return ratio_float + ratio_string + "Obdélník je čtverec.";
            }
            else if (ratio_float > 1)
            {
                return ratio_float + ratio_string + "Obdélník je široký.";
            }
            else
            {
                return ratio_float + ratio_string + "Obdélník je vysoký.";
            }
        }
        public bool Contains_point(int x, int y)
        {
            if (x < width || y < height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
/*1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x, y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
 *    */
