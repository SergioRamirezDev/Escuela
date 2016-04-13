using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Color color;
        Pen p;
        int forma,y,x;
        public Form1()
        {
            InitializeComponent();
            forma = 0;
            y = 50;
            x = 50;
            color = Color.Black;
            g = this.CreateGraphics();
        }

        private void Crear_Forma(object sender, MouseEventArgs e)
        {
            p = new Pen(color, int.Parse(numericUpDown1.Value.ToString()));
            if (forma == 0)
            {
                g.DrawEllipse(p, y, x, e.X, e.Y);
            }else
            {
                g.DrawRectangle(p, x, y, e.X, e.Y);
            }
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK){
                color = colorDialog1.Color;
            }
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma = 0;
        }

        private void cuadroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forma = 1;
        }

       


        

        

       
    }
}
