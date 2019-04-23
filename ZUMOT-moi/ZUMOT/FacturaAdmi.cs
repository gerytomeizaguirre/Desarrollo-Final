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
using ZUMOT;

namespace administracion1
{
    public partial class FacturaAdmi : Form
    {
        conexion conectar = new conexion();


        public FacturaAdmi()
        {
            InitializeComponent();
        }

        private void FacturaAdmi_Load(object sender, EventArgs e)
        {

        }
        //--------------FUNCION PARA LIMPIAR
        public void limpiar()
        {
            txtidfac.Clear();
            txtdetalle.Clear();
            txtcasaco.Clear();
            txtvalor.Clear();
        }

        //--------VALIDACION DE ENTRADAS LLAMAMIENTO EN LA CLASE CONEXION
        private void txtidfac_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtcasaco_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtdetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }
        //--------------------------------------------------------------------
        //---------FUNCION DEL BOTON GUARDAR, PARA LA FACTURA DE ADMINISTRACION CON SUS VALIDACIONES DE DATOS 
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtvalor.Text.Contains(".") == false)
            {
                txtvalor.Text = txtvalor.Text + ".00";
            }
            if (txtidfac.Text == "" || dateTimePicker1.Text == "" || txtcasaco.Text == "" || txtdetalle.Text == "" || txtvalor.Text == "")
            {
                MessageBox.Show("Campos Vacios.\nFavor LLenar todos los Campos de la factura.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(txtidfac.Text.StartsWith("0") == true)
            {
                MessageBox.Show("No puede ingresar 0 como primer dijito de la factura.\nFavor verificar el numero de factura.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (conexion.validarPuntoReal(txtvalor.Text) == false || txtvalor.Text.StartsWith("0"))
            {
                MessageBox.Show("El precio no es un dígito Decimal o tiene más de dos decimales.\nFavor cambiar los valores del precio.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string query = "INSERT INTO gastos_administrativos (Id_Factura_administrativa,Fecha,Casa_comercial,Descripcion_gasto,Valor_gasto) VALUES (@id_fact,@fecha,@comercio,@desc,@valor)";
                    conexion.enlace();
                    SqlCommand comando = new SqlCommand(query, conexion.enlace());
                    comando.Parameters.AddWithValue("@id_fact", Convert.ToInt64(txtidfac.Text));
                    comando.Parameters.AddWithValue("@fecha", dateTimePicker1.Text);
                    comando.Parameters.AddWithValue("@comercio", txtcasaco.Text);
                    comando.Parameters.AddWithValue("@desc", txtdetalle.Text);
                    comando.Parameters.AddWithValue("@valor", Convert.ToDouble(txtvalor.Text));
                    comando.ExecuteNonQuery();

                    MessageBox.Show("Factura Registrada Exitosamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un Error Inesperado, Favor volver a repetir > " + ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }
        //--------------------BOTON REFRESCAR---------
        private void button_Restart_Click(object sender, EventArgs e)
        {
            limpiar();
        }


        //------------------BOTON PARA VOLVER AL MENU
        private void button_Home_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
