using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litros
{
    public partial class Form1 : Form
    {

        double dinero = 0;
        double valor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = (double) numericUpDown1.Value;
            if (valor <= 50)
            {
                dinero = 20;
                label2.Text = dinero + " €";
            } else if (valor > 50)
            {
                dinero = 20;
                if (valor <= 200)
                {
                    dinero = dinero + ((double)(valor - 50) * 0.20);
                } else if (valor > 200)
                {
                    //dinero = dinero + ((double)(valor - 50) * 0.20);
                    valor = valor - 200;
                    dinero = dinero + 30 + (valor * 0.10);
                }
                label2.Text = dinero + "€";
            }

        }
    }
}
