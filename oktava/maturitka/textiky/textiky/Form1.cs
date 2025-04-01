using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace textiky
{
    public partial class Form1 : Form
    {
        StreamWriter file1;
        StreamReader file2;

        public Form1()
        {
            InitializeComponent();
        }
        string yapp;
        private void button_velky_Click(object sender, EventArgs e)
        {
            yapp = textBox_yapp.Text;
            textBox_ende.Text = yapp.ToUpper();
        }

        private void button_mezery_Click(object sender, EventArgs e)
        {
            yapp = textBox_yapp.Text;
            textBox_ende.Text = yapp.Trim().Replace(" ", "");
        }

        private void button_split_Click(object sender, EventArgs e)
        {
            string[] array;
            yapp = textBox_yapp.Text;
            array = yapp.Split(' ');
            foreach (string h in array)
            {
                textBox_ende.Text += h + Environment.NewLine;
            }
        }

        private void button_pridej_Click(object sender, EventArgs e)
        {
            yapp = textBox_yapp.Text;
            string h = yapp.Insert(Convert.ToInt32(textBox_pozice.Text), textBox_znak.Text);
            textBox_ende.Text = h;
        }

        private void button_seber_Click(object sender, EventArgs e)
        {
            yapp = textBox_yapp.Text;
            string h = yapp.Remove(Convert.ToInt32(textBox_pozice.Text)-1, 1);
            textBox_ende.Text = h;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            file1 = new StreamWriter("jmena.txt");
            file1.Write("");
            file1.Close();
        }

        private void button_pridat_Click(object sender, EventArgs e)
        {
            file1 = new StreamWriter("jmena.txt", true);
            file1.WriteLine(textBox1.Text);
            textBox1.Text = "";
            file1.Close();
        }

        private void button_vypis_Click(object sender, EventArgs e)
        {
            file2 = new StreamReader("jmena.txt");
            string line = file2.ReadLine();
            while(line != null)
            {
                listBox1.Items.Add(line);
                line = file2.ReadLine();
            }
            file2.Close();
        }
    }
}
