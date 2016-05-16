using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Figuras
{

    public partial class Form1 : Form
    {
        protected int X;
        protected int Y;
        protected Pen pluma;
        protected int ancho,largo;
        protected int penheight;
        protected Color pen,brush;
        private List<Figura> rectangulos;

        public Form1()
        {
            InitializeComponent();
            rectangulos = new List<Figura>();
            pen = Color.Black;
            brush = Color.Black;
            ancho = 10;
            largo = 10;
            penheight = 10;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Polimorfismo
            foreach (Figura r in rectangulos)
                r.Draw(this);
        }
        private void click(object sender, MouseEventArgs e)
        {
            this.ancho = Int32.Parse(rellenarnum.Text);
            this.penheight = Int32.Parse(contornonum.Text);
            
            if (rectangulo.Checked == true) {
                Rectangulo a = new Rectangulo(e.X, e.Y, this.pen, this.penheight, this.ancho, this.ancho, this.brush);
                a.Draw(this);
                rectangulos.Add(a);
            }
            if(circulo.Checked== true){
                Circulo b = new Circulo(e.X, e.Y, this.pen, this.penheight, this.ancho, this.ancho, this.brush);
                b.Draw(this);
                rectangulos.Add(b);
            }
            if (recta.Checked == true)
            {
                Recta c = new Recta(e.X, e.Y, this.pen, this.penheight, 0, 0, this.brush);
                c.Draw(this);
                rectangulos.Add(c);
            }
           
        }

        private void Contorno(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                button2.ForeColor = colorDialog1.Color;
                this.pen = colorDialog1.Color;
            }
        }
        private void Rellenar(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                button1.ForeColor = colorDialog2.Color;
                this.brush = colorDialog2.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ancho = Int32.Parse(rellenarnum.Text);
            this.penheight = Int32.Parse(contornonum.Text);
            if (dibujar.Checked == true)
            {
                Rectangulo a = new Rectangulo(X, Y, this.pen, this.ancho, this.ancho, this.ancho, this.brush);
                a.Draw(this);
                rectangulos.Add(a);
            }
           
        }

        private void colorear(object sender, MouseEventArgs e)
        {
            this.X = e.X;
            this.Y = e.Y;
        }

        private void check(object sender, EventArgs e)
        {
            if (dibujar.Checked == true)
            {
                timer1.Enabled = true;
            }
            else {
                timer1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            rectangulos.Clear();
        }

        


       


       

        
       
    }
}
