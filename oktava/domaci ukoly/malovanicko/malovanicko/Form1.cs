using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovanicko
{//s tím, kolik je tady tlačítek, tak mám pocit, že je to chaos, ale líp to asi neumím
    public partial class Form1 : Form
    {
        bool paint = false;//kreslím nebo nekreslím
        Graphics g;
        Point current_location, last_location, A, B, C;
        int what;//pro rozpoznání momentální akce
        Pen pen = new Pen(Color.Black, 1);
        Brush brush = new SolidBrush(Color.Black);
        Pen eraser = new Pen(Color.White, 3);
        Brush brush_eraser = new SolidBrush(Color.White);
        Bitmap bitmap;
        int startX, startY, endX, endY, sizeX, sizeY;//souřadnice
        Random rnd = new Random();
        bool rainbow_bool;

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            startX = e.X;
            startY = e.Y;
            last_location = e.Location;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint == true)
            {
                if (rainbow_bool == true)//barevná tužka pokradená od filipa (s dovolením)
                {
                    Color rainbow_color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));//náhodné barvy
                    pen.Color = rainbow_color;
                    brush = new SolidBrush(rainbow_color);
                    button_currcolor.BackColor = rainbow_color;
                }
                switch (what)
                {
                    case 1://tužka
                        current_location = e.Location;
                        g.DrawLine(pen, current_location, last_location);
                        g.FillEllipse(brush, current_location.X - (pen.Width / 2), current_location.Y - (pen.Width / 2), pen.Width, pen.Width);
                        last_location = current_location;
                        break;
                    case 2://guma
                        current_location = e.Location;
                        g.DrawLine(eraser, current_location, last_location);
                        g.FillEllipse(brush_eraser, current_location.X - (pen.Width / 2), current_location.Y - (pen.Width / 2), pen.Width, pen.Width);
                        last_location = current_location;
                        break;
                    case 7:
                        current_location = e.Location;
                        int pf = Convert.ToInt32(pen.Width);

                        for (int i = 0; i < 5; i++)//víc teček pro jedno místo
                        {
                            int offX = rnd.Next(-pf, pf);//rozptyl teček
                            int offY = rnd.Next(-pf, pf);
                            int dot_size = rnd.Next(1, (pf / 2) + 1); //náhodné velikosti
                            g.FillEllipse(brush, current_location.X + offX, current_location.Y + offY, dot_size, dot_size);
                        }
                        last_location = current_location;
                        break;
                }
            }
            sizeX = e.X - startX;
            sizeY = e.Y - startY;
            endX = e.X;
            endY = e.Y;
            picture.Refresh();
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            if (what == 5)//trojúhelník
            {
                if (A==Point.Empty)
                {
                    A = e.Location;
                }
                else if (B==Point.Empty)
                {
                    B = e.Location;
                }
                else if (C==Point.Empty)
                {
                    C = e.Location;
                }
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            
            switch(what)
            {
                case 3:
                    g.DrawEllipse(pen, startX, startY, sizeX, sizeY);
                    break;
                case 4:
                    g.DrawRectangle(pen, startX, startY, sizeX, sizeY);
                    break;
                case 6:
                    g.DrawLine(pen, startX, startY, endX, endY);
                    break;
                case 5:
                    if (A != Point.Empty && B != Point.Empty)
                    {
                        g.DrawLine(pen, A, B);
                    }
                    if (what == 5 && A != Point.Empty && B != Point.Empty && C != Point.Empty)
                    {
                        Point[] points = { A, B, C };
                        g.DrawPolygon(pen, points);
                        A = Point.Empty;
                        B = Point.Empty;
                        C = Point.Empty;
                    }
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)//velikost štětce
        {
            pen.Width = trackBar1.Value;
            eraser.Width = trackBar1.Value;
        }

        private void button_colors_Click(object sender, EventArgs e)//výběr barev
        {
            ColorDialog rainbow = new ColorDialog();
            rainbow.ShowDialog();
            rainbow_bool = false;
            button_currcolor.BackColor = rainbow.Color;
            pen.Color = rainbow.Color;
            brush = new SolidBrush(rainbow.Color);
        }
        //tlačítka pro čtyři základní barvy
        private void button_color1_Click(object sender, EventArgs e)
        {
            rainbow_bool = false;
            button_currcolor.BackColor = Color.Red;
            pen.Color = Color.Red;
            brush = new SolidBrush(Color.Red);
        }

        private void button_color2_Click(object sender, EventArgs e)
        {
            rainbow_bool = false;
            button_currcolor.BackColor = Color.Yellow;
            pen.Color = Color.Yellow;
            brush = new SolidBrush(Color.Yellow);
        }

        private void button_color3_Click(object sender, EventArgs e)
        {
            rainbow_bool = false;
            button_currcolor.BackColor = Color.Blue;
            pen.Color = Color.Blue;
            brush = new SolidBrush(Color.Blue);
        }

        private void button_color4_Click(object sender, EventArgs e)
        {
            rainbow_bool = false;
            button_currcolor.BackColor = Color.Green;
            pen.Color = Color.Green;
            brush = new SolidBrush(Color.Green);
        }

        private void button_save_Click(object sender, EventArgs e)//ukládání
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.gif)|*.gif";//konkrétní syntax dohledávána
            if (save.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(save.FileName);
            }
        }

        private void button_triangle_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("To draw a triangle, click on three points. After clicking on two, a line will show up. With the third point it will connect into a triangle.");//vysvětlivka pro kreslení trojúhelníku
        }

        



        //tlačítka s určením what proměnné
        private void button_pencil_Click(object sender, EventArgs e)
        {
            what = 1;
        }

        private void button_erase_Click(object sender, EventArgs e)
        {
            what = 2;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);//found on youtube
            picture.Image = bitmap;
        }

        private void button_ellipse_Click(object sender, EventArgs e)
        {
            what = 3;
        }
        private void button_rectangle_Click(object sender, EventArgs e)
        {
            what = 4;
        }
        private void button_triangle_Click(object sender, EventArgs e)
        {
            what = 5;
        }
        private void button_line_Click(object sender, EventArgs e)
        {
            what = 6;
        }
        private void button_spray_Click(object sender, EventArgs e)
        {
            what = 7;
        }
        private void button_rainbow_Click(object sender, EventArgs e)
        {
            rainbow_bool = true;
        }
        private void picture_Paint(object sender, PaintEventArgs e) //dohledáno na youtube - pro zobrazení kreslících se tvarů během jejich kreslení (natažení)
        {
            if (paint)
            {
                Graphics g = e.Graphics;
                switch(what)
                {
                    case 3:
                        g.DrawEllipse(pen, startX, startY, sizeX, sizeY);
                        break;
                    case 4:
                        g.DrawRectangle(pen, startX, startY, sizeX, sizeY);
                        break;
                    case 6:
                        g.DrawLine(pen, startX, startY, endX, endY);
                        break;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            //nápověda pro nakreslení trojúhleníku
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(button_triangle, "To draw a triangle, click on three points. After clicking on two, a line will appear, with the third one, the points will connect into a triangle.");

            bitmap = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            picture.Image = bitmap;

            //určení trackbaru
            trackBar1.Maximum = 30;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 5;
            trackBar1.TickFrequency = 5;
            button_currcolor.BackColor = Color.Black;//momentální barva pro začátek
        }
    }
}
