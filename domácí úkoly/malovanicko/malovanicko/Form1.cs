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
                if (what == 1)//tužka
                {
                    current_location = e.Location;
                    g.DrawLine(pen, current_location, last_location);
                    g.FillEllipse(brush, current_location.X - (pen.Width / 2), current_location.Y - (pen.Width / 2), pen.Width, pen.Width);
                    last_location = current_location;
                }
                if (what == 2)//guma
                {
                    current_location = e.Location;
                    g.DrawLine(eraser, current_location, last_location);
                    g.FillEllipse(brush_eraser, current_location.X - (pen.Width / 2), current_location.Y - (pen.Width / 2), pen.Width, pen.Width);
                    last_location = current_location;
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
      
            if (what==3)
            {
                g.DrawEllipse(pen, startX, startY, sizeX, sizeY);
            }
            if (what == 4)
            {
                g.DrawRectangle(pen, startX, startY, sizeX, sizeY);
            }
            if (what == 6)
            {
                g.DrawLine(pen, startX, startY, endX, endY);
            }
            if (what==5 && A!=Point.Empty && B!=Point.Empty)
            {
                g.DrawLine(pen, A, B);
            }
            if (what==5 && A!=Point.Empty && B!=Point.Empty && C!=Point.Empty)
            {
                Point[] points = {A,B,C};
                g.DrawPolygon(pen, points);
                A = Point.Empty;
                B = Point.Empty;
                C = Point.Empty;
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
            button_currcolor.BackColor = rainbow.Color;
            pen.Color = rainbow.Color;
            Brush new_brush = new SolidBrush(rainbow.Color);
            brush = new_brush;
        }
        //tlačítka pro čtyři základní barvy
        private void button_color1_Click(object sender, EventArgs e)
        {
            button_currcolor.BackColor = Color.Red;
            pen.Color = Color.Red;
            Brush new_brush = new SolidBrush(Color.Red);
            brush = new_brush;
        }

        private void button_color2_Click(object sender, EventArgs e)
        {
            button_currcolor.BackColor = Color.Yellow;
            pen.Color = Color.Yellow;
            Brush new_brush = new SolidBrush(Color.Yellow);
            brush = new_brush;
        }

        private void button_color3_Click(object sender, EventArgs e)
        {
            button_currcolor.BackColor = Color.Blue;
            pen.Color = Color.Blue;
            Brush new_brush = new SolidBrush(Color.Blue);
            brush = new_brush;
        }

        private void button_color4_Click(object sender, EventArgs e)
        {
            button_currcolor.BackColor = Color.Green;
            pen.Color = Color.Green;
            Brush new_brush = new SolidBrush(Color.Green);
            brush = new_brush;
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
        private void picture_Paint(object sender, PaintEventArgs e) //dohledáno na youtube - pro zobrazení kreslících se tvarů během jejich kreslení (natažení)
        {
            if (paint)
            {
                Graphics g = e.Graphics;
                if (what == 3)
                {
                    g.DrawEllipse(pen, startX, startY, sizeX, sizeY);
                }
                if (what == 4)
                {
                    g.DrawRectangle(pen, startX, startY, sizeX, sizeY);
                }
                if (what == 6)
                {
                    g.DrawLine(pen, startX, startY, endX, endY);
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
            g = Graphics.FromImage(bitmap);//bitmapu jsem taky vytáhla z internetu, ale trochu jsem to pročetla a pochopila (snad)
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
