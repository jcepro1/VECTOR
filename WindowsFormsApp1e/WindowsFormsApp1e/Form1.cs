using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1EXAMEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        vector v1, v2, v3;


        nent n1, n2, n3;

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = v1.descargar();
        }

        private void cARGARRNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.Cargar_rnd(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = v1.descargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new vector();
            v2 = new vector();
            v3 = new vector();
            n1 = new nent();
            n2 = new nent();
            n3 = new nent();
        }


        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.ejercicio1(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox8.Text = v1.descargar();
        }


    }
}
