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
using administracion1;
using PANTALLASVENDEDORES;
using ZUMOT;

namespace PANTALLASVENDEDORES
{
    public partial class consultadeinformacioncliente : Form
    {
        public static string  idCliente;
        public consultadeinformacioncliente()
        {
            InitializeComponent();
        }

        private void codigoconcli_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultadeinformacioncliente_Load(object sender, EventArgs e)
        {
            mostrarClientes(dtvcliconsu);

        }

        //---------------------FUNCION PARA BUSCAR UN CLIENTE Y MOSTRAR EN EL DATAGRID
        public void consulta(TextBox Cconsulta)
        {
            conexion.enlace();
            try
            {
                if (txtcodiconsucli.Text == "")
                {
                    MessageBox.Show("No Ingreso la Identidad de ningun Cliente.", "ERROR", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                }
                else {
                    SqlDataAdapter dtadapter = new SqlDataAdapter("select identidad_cliente, nombre_cliente, apellido_cliente, correo_electronico from proyecto where identidad_cliente ='" + Cconsulta.Text + "'", conexion.enlace());
                    DataTable datatabla = new DataTable();
                    dtadapter.Fill(datatabla);
                    if(datatabla.Rows.Count > 0) { 
                    dtvcliconsu.DataSource = datatabla;
                    }
                    else
                    {
                        MessageBox.Show("El numero que ingreso no es Valido. Ingrese un numero de Identidad Existente.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtcodiconsucli.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Pudo mostrar la Lista de Clientes." + ex);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void btncliconsu_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcodiconsucli_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            consulta(txtcodiconsucli);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodiconsucli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //---------------------FUNCION QUE MUESTRA LA LISTA DE TODOS LOS CLIENTES EN LA BASE DE DATOS DESDE QUE SE ABRE LA PANTALLA
        public void mostrarClientes(DataGridView tablaclientes)
        {
            conexion.enlace();

            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("select identidad_cliente, nombre_cliente, apellido_cliente, correo_electronico from proyecto", conexion.enlace());
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                tablaclientes.DataSource = tabla;
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se puede mostrar la informacion> " + ex.ToString());
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void dtvcliconsu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
        //-----------------METODO QUE CUANDO SE HACE DOBLE CLICK MOSTRARA OTRA PANTALLA CON LA INFORMACION DEL CLIENTE SELECCIONADO
        private void dtvcliconsu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dtvcliconsu.CurrentRow.Index;
            idCliente = dtvcliconsu[0, posicion].Value.ToString();
            datosCliente viewCliente = new datosCliente();
            viewCliente.ShowDialog();
        }
        //------------------FUNCION PARA REFRESCAR LA PANTALLA 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtcodiconsucli.Clear();
            mostrarClientes(dtvcliconsu);
        }
    }
}
