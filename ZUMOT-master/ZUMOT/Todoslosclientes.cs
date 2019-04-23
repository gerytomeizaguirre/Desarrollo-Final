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
using System.Data.SqlClient;
using pantallas_de_clientes;
using PANTALLASVENDEDORES;

namespace PANTALLASVENDEDORES
{
    public partial class Todoslosclientes : Form
    {
        public Todoslosclientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantallas_de_clientes.Ingresarcliente clientenuevo = new pantallas_de_clientes.Ingresarcliente();
            clientenuevo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ingresarcliente viewcliente = new Ingresarcliente();
            viewcliente.Show();
            this.Close();
        }

        private void Todoslosclientes_Load(object sender, EventArgs e)
        {
            clientesRegistrados(tablaClientes);
        }

        public void clientesRegistrados(DataGridView cliente)
        {
            conexion.enlace();
            try
            {
                SqlDataAdapter dtadapter = new SqlDataAdapter("select identidad_cliente, nombre_cliente, apellido_cliente, celular, correo_electronico from proyecto", conexion.enlace());
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);
                cliente.DataSource = datatabla;
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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Iniciodevendedores viewmenuVendedores = new Iniciodevendedores();
            this.Close();

        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
