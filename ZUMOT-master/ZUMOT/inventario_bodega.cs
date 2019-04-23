using administracion1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ZUMOT
{
    public partial class inventario_bodega : Form
    {
        public inventario_bodega()
        {
            InitializeComponent();
        }
        conexion database = new conexion();
        private void inventario_bodega_Load(object sender, EventArgs e)
        {
            database.SeleccionTipoMaterial(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            mostrarInventario();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnregre_Click(object sender, EventArgs e)
        {
            Pantalla_bodega pabo = new Pantalla_bodega();
            this.Hide();
            pabo.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            INICIO_SESION ini = new INICIO_SESION();
            ini.Show();
            this.Hide();

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
        public void mostrarInventario()
        {
            conexion.enlace();
            SqlDataAdapter da = new SqlDataAdapter("select id_material, nombre_material, cantidad_bodega from material where cantidad_bodega > 0", conexion.enlace());
            DataTable dt = new DataTable("tabla");
            da.Fill(dt);
            dgv1.DataSource = dt;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "" || comboBox2.Text == "SELECCIONE MATERIAL")
            {
                MessageBox.Show("Campo Tipo Material sin Seleccionar. \nFavor seleccionar un material", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                dgv1.Visible = true;
                dgv1.DataSource = database.Mostrarinventario(comboBox2.Text);

            }
        }
    }
}
