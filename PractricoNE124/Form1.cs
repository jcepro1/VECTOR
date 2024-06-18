using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractricoNE124
{
    public partial class Form1 : Form
    {
        NEnt n1;
        NEnt n2;
        NEnt n3;
        NEnt n4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new NEnt();
            n2 = new NEnt();
            n3 = new NEnt();
            n4 = new NEnt();
        }

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.Cargar(int.Parse(textBox1.Text));
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.Descargar());
        }

        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.Factorial());
        }

        private void eJERCICIO2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.verif_fibo());
        }

        private void eJERCICIO3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.ejercicio3());
        }

        private void eJERCICIO4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.Verif_num_mult((n2)));
        }

        private void eJERCICIO5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.Verif_num_submult((n2)));
        }

        private void eJERCICIO6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio8(n2);
            n3.Cargar(n1.Descargar());
            textBox5.Text = string.Concat(n3.Descargar());//
        }

        private void eJERCICIO7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio9(n2, n3);
            n4.Cargar(n1.Descargar());
            textBox5.Text = string.Concat(n1.Descargar()); //proocedimiento
        }

        private void eJERCICIO8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio10(n2, n3, n4);
            textBox5.Text = string.Concat(n4.Descargar());
        }

        private void eJERCICIO9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.ejercicio11());
        }

        private void eJERCICIO10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n1.ejercicio12());
        }


        //MUNU CARGAR 2,3Y4.

        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n2.Cargar(int.Parse(textBox2.Text));
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n2.Descargar());
        }

        private void cARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n3.Cargar(int.Parse(textBox3.Text));
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Concat(n3.Descargar());
        }

        private void cARGARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           //.Cargar(int.Parse(textBox4.Text));
        }

        private void dESCARGARToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //textBox5.Text = String.Concat(n4.Descargar());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
