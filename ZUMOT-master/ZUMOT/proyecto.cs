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
            /*conectar = conexion.enlace();
            SqlDataAdapter mostrar = new SqlDataAdapter(string.Format("select identidad_cliente, nombre_cliente + apellido_cliente from proyecto identidad_cliente like '%" + id + "%'"), conectar);
            DataSet ds = new DataSet();
            mostrar.Fill(ds, "proyecto");*/

        }

        private void dgvProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Box_IdCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
