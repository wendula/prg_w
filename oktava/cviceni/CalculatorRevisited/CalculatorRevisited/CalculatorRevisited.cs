﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Dnes bude vasim ukolem vytvorit formularovou reprezentaci kalkulacky. Priblizny vzhled si nakreslime na tabuli
 * (Pokud jsem to nenakreslil, pripomente mi to prosim!)
 * Inspirujte se kalkulackou ve Windows.
 * Pozadovane prvky/funkcionality:
 * - Tlacitka pro kazde z cisel 0-9
 * - Tlacitka pro operace +, -, *, a /
 * - Tlacitko pro = (vypsani vysledku)
 * - Textbox, do ktereho se propisou cisla/operace pri stisku jejich tlacitek
 * - Textbox s vysledkem operace (mozne sloucit s predeslym, nechavam na vas)
 * - Tlacitko pro vymazani textu v textboxu s cisly a operaci
 * 
 * Volitelne prvky/funkcionality:
 * - Tlacitko pro mazani cisel a operaci v textboxu zprava vzdy po jednom znaku
 * - Pokud mam vypsany vysledek a hned po tom stisknu tlacitko nejake operace, vysledek se vezme jako prvni cislo a
 *   rovnou mohu po zadani operace zadat druhe cislo
 * - Moznost ulozeni vysledku do nekolika preddefinovanych labelu/neinteraktivnich textboxu (treba kombinaci comboboxu a tlacitka, kde
 *   v comboboxu vyberu do ktereho labelu/textboxu se mi to ulozi a tlacitkem provedu ulozeni)
 *   + pridat tlacitko pro kazdy label/neint. textbox, kterym ulozeny vysledek pouziju jako cislo do vypoctu
 * - Pridani mocnin/odmocnin atd. (napr. pomoci dalsich tlacitek, ktere rovnou misto daneho cisla daji jeho (popr. zaokrouhlenou) odmocninu apod.)
 * - Cokoliv dalsiho vas napadne! :)
 * 
 * Snazte se o to, aby byla kalkulacka v ramci moznosti hezka, a aby bylo jeji ovladani intuitivni a aby mel kazdy prvek v okne dobre vyuziti
 */

namespace CalculatorRevisited
{
    public partial class CalculatorRevisited : Form
    {
        double number;
        public CalculatorRevisited()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            number = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            number = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            number = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            number = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            number = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            number = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            number = 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            number = 0;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonIs_Click(object sender, EventArgs e)
        {

        }
    }
}
