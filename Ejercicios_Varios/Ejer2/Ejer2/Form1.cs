﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 4)
            {
                MessageBox.Show("Suspendido");
            } else if (numericUpDown1.Value == 5)
            {
                MessageBox.Show("Aprobado");
            }
            else if (numericUpDown1.Value == 6)
            {
                MessageBox.Show("Bien");
            }
            else if (numericUpDown1.Value == 7 || numericUpDown1.Value == 8)
            {
                MessageBox.Show("Notable");
            }
            else if (numericUpDown1.Value == 9 || numericUpDown1.Value == 10)
            {
                MessageBox.Show("Sobresaliente");
            }
        }
    }
}
