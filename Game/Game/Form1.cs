using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Tablero t;
        int turno;
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(10);
            label2.Text = "Celulas vivas:" + t.nvivas;
            label1.Text = "Turno: " + turno;
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void click(object sender, MouseEventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
        }

        private void paint(object sender, PaintEventArgs e)
        {
            t.cuantas_vacinas_vivas(0, 0);
            t.Dibuja(this);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            t.next();
            label2.Text = "Celulas vivas:" + t.nvivas;
            t.update();
            this.Invalidate();
            turno++;
            label1.Text = "Turno: " + turno;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Empezar"){
                timer1.Enabled = true;
                button1.Text = "Parar";
            }
            else{
            button1.Text = "Empezar";
            timer1.Enabled = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e){
            //t = new Tablero((int)numericUpDown1.Value);
            timer1.Enabled = true;
            //turno = 0;
            button1.Text = "Parar";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
