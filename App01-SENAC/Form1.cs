using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01_SENAC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2;
            double resultado;
            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);

            resultado = numero1 + numero2;

            label4.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double numero1, numero2;
            double resultado;

            numero1 = double.Parse(textBox1.Text);
            numero2 = double.Parse(textBox2.Text);
            resultado = numero1 * numero2;
            label4.Text = resultado.ToString();
        }
    }
}
