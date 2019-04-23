using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using administracion1;
using PANTALLASVENDEDORES;
using pantallas_de_clientes;
using ZUMOT;
using pantallas;
using WindowsFormsApp1;

namespace ZUMOT
{
    public partial class MenuGerencia : Form
    {
        public MenuGerencia()
        {
            InitializeComponent();
        }

        private void MenuGerencia_Load(object sender, EventArgs e)
        {

        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarF viewFactura = new AgregarF();
            viewFactura.Show();
        }

        private void modificarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarF viewModificar = new ModificarF();
            viewModificar.Show();
        }

        private void reporteFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteF viewRoporte = new ReporteF();
            viewRoporte.Show();
        }

        private void proyectosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_CProyecto viewProyecto = new Form_CProyecto();
            viewProyecto.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario viewInventario = new Inventario();
            viewInventario.Show();
        }

        private void gastosConstrucciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastos_Construccion viewGastosConstruccion = new Gastos_Construccion();
            viewGastosConstruccion.Show();
        }

        private void facturasAdministraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaAdmi viewFacturaAdmi = new FacturaAdmi();
            viewFacturaAdmi.Show();
        }

        private void modificarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_Fac viewModificarAdmi = new modificar_Fac();
            viewModificarAdmi.Show();
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastos_Administrativos viewGastosAdmi = new Gastos_Administrativos();
            viewGastosAdmi.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingresarcliente viewCliente = new Ingresarcliente();
            viewCliente.ShowDialog();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarcliente viewModificarcliente = new modificarcliente();
            viewModificarcliente.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultadeinformacioncliente viewcliente = new consultadeinformacioncliente();
            viewcliente.ShowDialog();
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrarEmple viewregistroEmpleado = new registrarEmple();
            viewregistroEmpleado.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            INICIO_SESION viewinicio = new INICIO_SESION();
            this.Close();
            viewinicio.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Roles viewroles = new Roles();
            viewroles.Show();
        }
    }
}
