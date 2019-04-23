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

namespace administracion1
{
    public partial class Form_CProyecto : Form
    {

        public static string idCliente;
        public Form_CProyecto()
        {
            InitializeComponent();
        }


        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            formVerproyecto VerProyecto = new formVerproyecto();
            VerProyecto.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            buscarCliente();

        }

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Box_IdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_CProyecto_Load(object sender, EventArgs e)
        {
            proyectos();
        }
        public void proyectos()
        {
            try
            {
                conexion.enlace();
                SqlDataAdapter datos = new SqlDataAdapter("select identidad_cliente, nombre_cliente, apellido_cliente,correo_electronico from proyecto", conexion.enlace());
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dataProyecto.DataSource = tabla;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se Produjo un error" +ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.enlace().Close();
            }
            
        }

        public void buscarCliente()
        {
            if (identidad.Text == "")
            {
                MessageBox.Show("Campo Identidad Vacio. \nIngrese un numero de identidad Existente.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexion.enlace();
                try
                {
                    
                    SqlDataAdapter data = new SqlDataAdapter("select identidad_cliente, nombre_cliente, apellido_cliente,correo_electronico from proyecto where identidad_cliente = '" + identidad.Text + "'", conexion.enlace());
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    if (tabla.Rows.Count > 0)
                    {
                        dataProyecto.DataSource = tabla;
                    }
                    else
                    {
                        MessageBox.Show("No Se encontro registro de la identidad ingresada", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error> " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }

        public void limpiar()
        {
            
        }

        private void dataProyecto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dataProyecto.CurrentRow.Index;
            idCliente = dataProyecto[0, posicion].Value.ToString();
            formVerproyecto viewProyecto = new formVerproyecto();
            viewProyecto.ShowDialog();
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            identidad.Clear();
            proyectos();
        }

        private void identidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }
    }
}
