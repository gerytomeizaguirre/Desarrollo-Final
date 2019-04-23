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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        conexion database = new conexion();
        private void Inventario_Load(object sender, EventArgs e)
        {
           
            database.SeleccionTipoMaterial(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            mostrarInventario();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedIndex > 0)
            {
                comboBox2.Enabled = true;
                database.SeleccionMaterial(comboBox2, comboBox1.Text);
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button_Buscar_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox2.Text == "SELECCIONE MATERIAL")
            {
                MessageBox.Show("Campo Tipo Material sin Seleccionar. \nFavor seleccionar un material", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                listaInventario.Visible = true;
                listaInventario.DataSource = database.Mostrarinventario(comboBox2.Text);

            }
        }

        public void mostrarInventario()
        {
            conexion.enlace();
            SqlDataAdapter da = new SqlDataAdapter("select id_material, nombre_material, cantidad_bodega from material where cantidad_bodega > 0", conexion.enlace());
            DataTable dt = new DataTable("tabla");
            da.Fill(dt);
            listaInventario.DataSource = dt;
        }

        private void button_Restart_Click_1(object sender, EventArgs e)
        {
            database.SeleccionTipoMaterial(comboBox1);
            mostrarInventario();
        }
    }
}
