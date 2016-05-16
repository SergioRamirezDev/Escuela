using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
     
    abstract class Figura 
    {
        protected int X;
        protected int Y;
        protected Pen pluma;
        protected int ancho;
        protected int largo;
        //protected Color color;
        protected SolidBrush brocha;

        

        public Figura(int x, int y, Color pen,int penheight, int ancho, int largo,Color brush)
        {
            X = x;
            Y = y;
            brocha = new SolidBrush(brush);
            pluma = new Pen(pen, penheight);

            //Random rnd = new Random();
            //ancho = rnd.Next(10, 60);
            this.ancho = ancho;
            this.largo = largo;
        }

        public abstract void Draw(Form f);

        public int CompareTo(object obj)
        {

            return this.largo.CompareTo(((Figura)obj).largo);
        }
    }


    class Rectangulo : Figura
    {
        public Rectangulo(int x, int y, Color pen, int penheight, int ancho, int largo, Color brush)
            : base(x,y,pen,penheight,ancho,largo,brush)
        {
        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawRectangle(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
        }

    }

    class Circulo : Figura
    {
        public Circulo(int x, int y, Color pen, int penheight, int ancho, int largo, Color brush)
            : base(x, y, pen, penheight, ancho, largo, brush)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawEllipse(pluma, this.X, this.Y, ancho, largo);
            g.FillEllipse(brocha, this.X, this.Y, ancho, largo);
        }

    }

    class Recta : Figura
    {
        public Recta(int x, int y, Color pen, int penheight, int ancho, int largo, Color brush)
            : base(x, y, pen, penheight, ancho, largo, brush)
        {

        }

        public override void Draw(Form f)
        {
            Graphics g = f.CreateGraphics();
            g.DrawLine(pluma, this.X, this.Y, ancho, largo);
            g.FillRectangle(brocha, this.X, this.Y, ancho, largo);
        }

    }

}