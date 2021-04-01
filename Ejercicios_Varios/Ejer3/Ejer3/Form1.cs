using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer3
{
    public partial class Form1 : Form
    {
        List<Object> myData = new List<Object>();
        int cont = 0;
        String palabra;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            myData.Sort();
            MessageBox.Show(string.Join(Environment.NewLine, myData));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                palabra = textBox1.Text;
                palabra = palabra.Trim();
                myData.Add(palabra);
                textBox1.Text = "";
            }
            cont++;
        }
    }
}
