using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        int a = 0, b = 1, otro;
        List<Object> lista = new List<Object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    otro = a;
                    a = b;
                    b = otro + a;
                    lista.Add(a);
                }
                MessageBox.Show(string.Join(Environment.NewLine, lista));
                lista.Clear();
                a = 0;
                b = 1;
                otro = 0;
            }
        }
    }
}
