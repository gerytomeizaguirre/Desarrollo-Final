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
using System.Windows.Forms;

namespace administracion1
{

    public partial class FacturaAdmi : Form
    {
        conexion cn = new conexion();
        public FacturaAdmi()
        {
            InitializeComponent();
        }

        private void FacturaAdmi_Load(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Restart_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || dateTimePicker1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Favor llenar todos los datos");
            }
            else
            {
                /*if (cn.RegFactAdm(textBox1.Text, dateTimePicker1.Text, textBox3.Text, textBox4.Text, decimal.Parse(textBox5.Text)) > 0)
                {
                    MessageBox.Show("Factura Registrada con Exito");
                    //cn.USUARIOLOGIN2(lbIDEmpleado, Convert.ToInt16(txtUsuario.Text));
                    this.Hide();
                    Menu_admi regre = new Menu_admi();
                    regre.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la factura");
                }*/
                string query = "INSERT INTO gastos_administrativos (Id_Factura_administrativa,Fecha,Casa_comercial,Descripcion_gasto,Valor_gasto) VALUES (@id_fact,@fecha,@comercio,@desc,@valor)";
                conexion.enlace();
                SqlCommand comando = new SqlCommand(query, conexion.enlace());
                comando.Parameters.AddWithValue("@id_fact", textBox1.Text);
                comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date.ToString("yy//mm//dd"));
                comando.Parameters.AddWithValue("@comercio", textBox3.Text);
                comando.Parameters.AddWithValue("@desc", textBox4.Text);
                comando.Parameters.AddWithValue("@valor", textBox5.Text);
                comando.ExecuteNonQuery();

                MessageBox.Show("Factura Registrada");

            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
