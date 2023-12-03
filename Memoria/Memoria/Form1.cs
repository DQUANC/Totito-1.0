using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memoria
{
    public partial class Form1 : Form
    {
        Button[] b = new Button[8];
        Stopwatch oSw = new Stopwatch();

        string jugador1 = "";
        string jugador2 = "";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Memoria";
            b[0] = button1;
            b[1] = button2;
            b[2] = button3;
            b[3] = button4;
            b[4] = button5;
            b[5] = button6;
            b[6] = button7;
            b[7] = button8;
            
        }

        public void aleatorio ()
        {
            int n = new Random().Next(1, 4);

            switch(n){
                case 1:
                    int[] a = { 3, 4, 1, 2, 1, 2, 3, 4 };
                    asignacion(a);
                    break;
                case 2:
                    int[] a1 = { 3, 4, 2, 1, 1, 2, 3, 4 };
                    asignacion(a1);
                    break;
                case 3:
                    int[] a2 = { 3, 4, 1, 2, 1, 2, 3, 4 };
                    asignacion(a2);
                    break;
                case 4:
                    int[] a4 = { 3, 4, 1, 2, 1, 2, 3, 4 };
                    asignacion(a4);
                    break;
            }
        }

        public void asignacion(int[] aa)
        {
            for (int i = 0; i < aa.Length; i++)
            {
                b[i].ImageIndex = aa[i];
            }
        }

        public void juego()
        {
            jugador1 = textBox1.Text;
            jugador2 = textBox2.Text;
            
            Random rnFigura = new Random();
            int figura = rnFigura.Next(2);

            Random rnjugador = new Random();
            int jugador = rnjugador.Next(2);

            if (jugador == 0)
            {
                label5.Text = jugador1;
                label6.Text = jugador2;
                turno(1);
            }

            else
            {
                label6.Text = jugador1;
                label5.Text = jugador2;
                turno(2);
            }
        }

        public void turno(int valor)
        {
            if (valor == 1)
            {
                label7.Text = "TURNO";
                label8.Text = "";
                label7.Font = new System.Drawing.Font(label7.Font, FontStyle.Bold);
            }


            else
            {
                label8.Text = "TURNO";
                label7.Text = "";
                label8.Font = new System.Drawing.Font(label8.Font, FontStyle.Bold);
            }
        }

        public void cambioTurno()
        {

            if (label7.Text == "TURNO")
            {
                label8.Text = "TURNO";
                label7.Text = "";
            }

            else
            {
                label7.Text = "TURNO";
                label8.Text = "";
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSw.ElapsedMilliseconds);

            textBox3.Text = ts.Minutes.ToString();
            textBox4.Text = ts.Seconds.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            juego();

            oSw.Start();
            timer1.Enabled = true;

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            oSw.Restart();
            oSw.Stop();
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
