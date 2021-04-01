using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == numericUpDown2.Value)
            {
                MessageBox.Show("Son iguales");
            } else if (numericUpDown1.Value > numericUpDown2.Value)
            {
                MessageBox.Show("El primer numero es mayor");
            }
            else if (numericUpDown1.Value < numericUpDown2.Value)
            {
                MessageBox.Show("El primer numero es menor");
            }
        }
    }
}
