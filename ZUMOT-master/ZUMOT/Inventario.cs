using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



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

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
