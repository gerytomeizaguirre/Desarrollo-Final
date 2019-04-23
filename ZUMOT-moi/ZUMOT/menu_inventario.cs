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
using pantallas_de_clientes;
using PANTALLASVENDEDORES;


namespace ZUMOT
{
    public partial class menu_inventario : Form
    {
        public menu_inventario()
        {
            InitializeComponent();
        }

        private void inventariDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO_SESION viewinicio = new INICIO_SESION();
            this.Close();
            viewinicio.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresarcliente newcliente = new Ingresarcliente();
            newcliente.Show();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarcliente modcliente = new modificarcliente();
            modcliente.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultadeinformacioncliente cliente = new consultadeinformacioncliente();
            cliente.Show();
        }
    }
}
