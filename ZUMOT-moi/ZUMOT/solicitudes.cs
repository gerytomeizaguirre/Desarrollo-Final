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
    public partial class solicitudes : Form
    {

        
        
        public solicitudes()
        {
            InitializeComponent();

        }

        conexion database = new conexion();

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            database.SeleccionTipoMaterial(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if(comboBox1.SelectedIndex > 0)
            {
                comboBox2.Enabled = true;
                database.SeleccionMaterial(comboBox2, comboBox1.Text);

            }
            else
            {
                comboBox2.Enabled = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void mostrarEvento()
        {
          

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
