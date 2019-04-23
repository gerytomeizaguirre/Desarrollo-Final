using administracion1;
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

namespace ZUMOT
{
    public partial class Detalle_solicitud : Form
    {
        string id;
        conexion conectar = new conexion();
        public Detalle_solicitud(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        
        private void btnregresar_Click(object sender, EventArgs e)
        {
            Solicitudes_pendientes solipe = new Solicitudes_pendientes();
            solipe.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            INICIO_SESION ini = new INICIO_SESION();
            ini.Show();
            this.Hide();
        }

        private void Detalle_solicitud_Load(object sender, EventArgs e)
        {
            try { 

            txtId_cli.Text = id;
            string[] valores = conectar.captar_detalle(txtId_cli.Text);
            txtnombre.Text = valores[0];
            txtfecha.Text = valores[1];
            txttiposoli.Text = valores[2];
            dgv1.DataSource = conectar.Mostrar_detalle(txtId_cli.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No pudo Conectarse > " + ex.ToString());
            }
        }


    }
}
