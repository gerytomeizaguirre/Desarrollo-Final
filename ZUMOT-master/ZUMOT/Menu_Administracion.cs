using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PANTALLASVENDEDORES;
using pantallas;

namespace administracion1
{
    public partial class Menu_admi : Form
    {
        public Menu_admi()
        {
            InitializeComponent();
        }

        private void FacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GastosDeConstrucciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iniciodevendedores pantalla_principal = new Iniciodevendedores();
            pantalla_principal.Show();
        }

        private void ControlDeProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Menu_admi_Load(object sender, EventArgs e)
        {
            
        }

        private void ProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CProyecto viewProyecto = new Form_CProyecto();
            viewProyecto.Show();

        }

        private void RealizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solicitudes viewSolicitudes = new solicitudes();
            viewSolicitudes.Show();
        }

        private void EstadoDeSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            estado_soli viewEstado = new estado_soli();
            viewEstado.Show();
        }

        private void ReporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario viewInventario = new Inventario();
            viewInventario.Show();
        }

        private void FacturasAdministracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaAdmi viewFacturaAdmi = new FacturaAdmi();
            viewFacturaAdmi.Show();
        }

        private void ModificarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificar_Fac viewModificarAdmi = new modificar_Fac();
            viewModificarAdmi.Show();
        }

        private void DetalleDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastos_Administrativos viewGastosAdmi = new Gastos_Administrativos();
            viewGastosAdmi.Show();
        }

        private void GastosConstrucciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gastos_Construccion viewGastosConstruccion = new Gastos_Construccion();
            viewGastosConstruccion.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarF viewFactura = new AgregarF();
            viewFactura.Show();
            
        }

        private void entradaFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
