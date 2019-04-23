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
using administracion1;

namespace ZUMOT
{
    public partial class datosCliente : Form
    {
        public datosCliente()
        {
            InitializeComponent();
        }
        

        private void datosCliente_Load(object sender, EventArgs e)
        {
            informacionPersonal();
        }
        //------------------MUESTRA LA INFORMACION TOTAL DE UN CLIENTE ESPECIFICADO EN LA PANTALLA DE CONSULTADEINFORMACIONCLIENTE
        public void informacionPersonal()
        {
            string identidad = consultadeinformacioncliente.idCliente;
            conexion.enlace();
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select a.nombre_cliente, a.apellido_cliente, a.celular, a.correo_electronico, a.rtn, b.decripcion_genero, c.decripcion, a.nombre_trabajo, a.direccion_trabajo, a.telefono_trabajo, a.antiguedad_laboral, a.ingreso_extra, a.monto_proyecto, a.institucion_financiera, d.decripcion_estatus, a.fecha_de_nacimiento from proyecto a inner join genero b on a.id_genero = b.id_genero inner join estado_civil c on a.id_estado_civil = c.id_estado_civil inner join estatus_laboral d on a.id_estatus = d.id_estatus where a.identidad_cliente ='" + identidad + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if (tabla.Rows.Count > 0)

                idCliente.Text = identidad;
                lbNombre.Text = tabla.Rows[0][0].ToString() +" "+ tabla.Rows[0][1].ToString();
                
                lbCelular.Text = tabla.Rows[0][2].ToString();
                lbCorreo.Text = tabla.Rows[0][3].ToString();
                lbRtn.Text = tabla.Rows[0][4].ToString();
                lbGenero.Text = tabla.Rows[0][5].ToString();
                lbCivil.Text = tabla.Rows[0][6].ToString();
                lbTrabajo.Text = tabla.Rows[0][7].ToString();
                lbDirtrabajo.Text = tabla.Rows[0][8].ToString();
                lbTeltrabajo.Text = tabla.Rows[0][9].ToString();
                lbAntiguedad.Text = tabla.Rows[0][10].ToString() +" Años";
                lbIngreso.Text = tabla.Rows[0][11].ToString();
                lbMonto.Text = tabla.Rows[0][12].ToString();
                lbFinanciera.Text = tabla.Rows[0][13].ToString();
                lbEstatus.Text = tabla.Rows[0][14].ToString();
                lbNacimiento.Text = tabla.Rows[0][15].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No pudo Conectarse > "+ ex.ToString());
            }
        }

        private void grupPersonal_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
