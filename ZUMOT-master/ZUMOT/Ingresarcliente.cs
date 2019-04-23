using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas_de_clientes
{
    public partial class Ingresarcliente : Form
    {
        public Ingresarcliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnediusuinfo_Click(object sender, EventArgs e)
        {
            modificarcliente modificarcliente = new modificarcliente();
            modificarcliente.Show();
        }

        private void btnsubinfo_Click(object sender, EventArgs e)
        {
            ingresardocs documentos = new ingresardocs();
            documentos.Show();
        }
    }
}
