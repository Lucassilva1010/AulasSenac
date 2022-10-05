using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesMetodosNameSpaceFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroPessoaabutton1_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.nome = textBox1.Text;
       
            objPessoa.Nomes();

            label2.Text = objPessoa.teste1();

            listBox1.Items.Add(objPessoa.Nomes());
            
            Console.WriteLine(objPessoa.Nomes());
        }
    }
}
