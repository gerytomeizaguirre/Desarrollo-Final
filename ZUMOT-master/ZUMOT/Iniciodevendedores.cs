using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using administracion1;

namespace PANTALLASVENDEDORES
{
    public partial class Iniciodevendedores : Form
    {
        public Iniciodevendedores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modificarRegistroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallas_de_clientes.modificarcliente modificar = new pantallas_de_clientes.modificarcliente();
            modificar.Show();
        }

        private void modificarRegistroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultadeinformacioncliente clienteinfo = new consultadeinformacioncliente();
            clienteinfo.Show();
        }

        private void visualizarListaActualClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pantallas_de_clientes.Ingresarcliente nuevocliente = new pantallas_de_clientes.Ingresarcliente();
            nuevocliente.Show();
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO_SESION viewinicio = new INICIO_SESION();
            this.Close();
            viewinicio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
