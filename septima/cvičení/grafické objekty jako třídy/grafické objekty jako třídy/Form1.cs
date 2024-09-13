using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafické_objekty_jako_třídy
{
    public partial class Form1 : Form
    {
        Rectangle rectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rectangle = new Rectangle(100, 100, 100, 100, Brushes.SkyBlue, Pens.BlueViolet, false);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rectangle.Draw(e.Graphics);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'f')
            {
                rectangle.isFilled = false;
                Refresh();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                rectangle.Reposition(e.X, e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Refresh();
            }
        }
    }
}
