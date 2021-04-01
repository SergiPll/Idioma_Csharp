using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        String texto;
        String texto2;
        int cambio = 0, coma = 0;
        float i;
        float j;
        Boolean resta = false, suma = false, multi = false, divi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto = texto + "1";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto = texto + "2";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto = texto + "3";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "3";
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            texto = texto + "4";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texto = texto + "5";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            texto = texto + "6";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            texto = texto + "7";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            texto = texto + "8";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            texto = texto + "9";
            textBox1.Text = texto;
            if (cambio != 0)
            {
                texto2 = texto2 + "9";
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (texto != null)
            { if (texto != "") 
                {
                    texto = texto + "0";
                    textBox1.Text = texto;
                    if (cambio != 0)
                    {
                        texto2 = texto2 + "0";
                    }
                }
            }
            else
            {
                textBox1.Text = "0";
                texto = null;
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            { if (texto != null)
                {
                    cambio++;
                    i = float.Parse(texto);
                    texto = texto + "-";
                    textBox1.Text = texto;
                    resta = true;
                }
            else
                {
                    texto = texto + "-";
                    textBox1.Text = texto;
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                cambio++;
                i = float.Parse(texto);
                texto = texto + "x";
                textBox1.Text = texto;
                multi = true;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                cambio++;
                i = float.Parse(texto);
                texto = texto + "/";
                textBox1.Text = texto;
                divi = true;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                if (coma == 0)
                {
                    coma++;
                    texto = texto + ",";
                    textBox1.Text = texto;
                } else if (coma == 1 && texto2 != null)
                {
                    coma++;
                    texto2 = texto2 + ",";
                    textBox1.Text = texto2;
                }
                
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                i = float.Parse(texto);
                i = -i;
                texto = i.ToString();
                textBox1.Text = texto;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                i = float.Parse(texto);
                i = (float)Math.Sqrt(i);
                texto = i.ToString();
                textBox1.Text = texto;
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            texto = null;
            texto2 = null;
            textBox1.Text = null;
            cambio = 0;
            suma = false;
            resta = false;
            multi = false;
            divi = false;
            coma = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (cambio == 0)
            {
                cambio++;
                i = float.Parse(texto);
                texto = texto + "+";
                textBox1.Text = texto;
                suma = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cambio = 0;
            if (texto2 != null)
            {
                j = float.Parse(texto2);
            }
            
            if (suma)
            {
                i = i + j;
                texto = i.ToString();
                textBox1.Text = texto;
                texto2 = null;
                suma = false;
                cambio = 0;
            }
            if (resta)
            {
                i = i - j;
                texto = i.ToString();
                textBox1.Text = texto;
                texto2 = null;
                resta = false;
                cambio = 0;
            }
            if (multi)
            {
                i = i * j;
                texto = i.ToString();
                textBox1.Text = texto;
                texto2 = null;
                multi = false;
                cambio = 0;
            }
            if (divi)
            {
                i = i / j;
                texto = i.ToString();
                textBox1.Text = texto;
                texto2 = null;
                divi = false;
                cambio = 0;
            }
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
        }
    }
}