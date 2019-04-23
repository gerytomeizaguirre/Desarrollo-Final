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

namespace pantallas_de_clientes
{
    public partial class Ingresarcliente : Form
    {
        conexion database = new conexion();
        public Ingresarcliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            database.Seleccionestado(cbCivil);
            database.Seleccionestatus(cbEstatus);
            database.Selecciongenero(cbgenero);
            database.SeleccionVENDEDOR(cbVendedor);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnediusuinfo_Click(object sender, EventArgs e)
        {
            modificarcliente modificarcliente = new modificarcliente();
            modificarcliente.Show();
        }

        private void btnsubinfo_Click(object sender, EventArgs e)
        {
            ingresardocs documentos = new ingresardocs();
            documentos.Show();
        }

        public int obtener(ComboBox valor, int tipo)
        {
            int resp = 0;
            //---------------TIPO GENERO--------
            if(tipo == 1)
            {
                SqlDataAdapter data = new SqlDataAdapter("select id_genero from genero where decripcion_genero = '"+valor.Text+"'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if(tabla.Rows.Count > 0)
                {
                    resp =Convert.ToInt32(tabla.Rows[0][0].ToString());
                }
            }
            else if(tipo == 2)
            {
                SqlDataAdapter data = new SqlDataAdapter("select id_estado_civil from estado_civil where decripcion = '" + valor.Text + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    resp = Convert.ToInt32(tabla.Rows[0][0].ToString());
                }
            }
            else if(tipo == 3)
            {
                SqlDataAdapter data = new SqlDataAdapter("select id_estatus from estatus_laboral where decripcion_estatus = '" + valor.Text + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    resp = Convert.ToInt32(tabla.Rows[0][0].ToString());
                }
            }
            else
            {
                SqlDataAdapter data = new SqlDataAdapter("select id_vendedores from vendedores where nombre_vendedor = '" + valor.Text + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    resp = Convert.ToInt32(tabla.Rows[0][0].ToString());
                }
            }

            return resp;
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtAntiguedad.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtdireccion.Clear();
            txtFinanciera.Clear();
            txtIdentidad.Clear();
            txtIngreso.Clear();
            txtLugar.Clear();
            txtMonto.Clear();
            txtRtn.Clear();
            txtTelefono.Clear();
            cbgenero.SelectedIndex = 0;
            cbCivil.SelectedIndex = 0;
            cbEstatus.SelectedIndex = 0;
            cbVendedor.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

           
            if (txtMonto.Text.Contains(".") == false)
            {
                txtMonto.Text = txtMonto.Text + ".00";
            }
            if(txtIngreso.Text.Contains(".") == false)
            {
                txtIngreso.Text = txtIngreso.Text + ".00";
            }
            if (cbCivil.SelectedIndex == 0 || cbEstatus.SelectedIndex == 0 || cbgenero.SelectedIndex == 0 || cbVendedor.SelectedIndex == 0 || txtNombre.Text == "" || txtApellido.Text == "" || txtdireccion.Text == "" || cbtiempo.Text == "" || txtIdentidad.Text == "" || txtLugar.Text == "" || txtMonto.Text == "" || txtFinanciera.Text == "")
            {
                MessageBox.Show("Campo Vacio. \nVerifique que todos los campos esten llenos.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            else if (conexion.validarIdentidad(txtIdentidad.Text) == false)
            {
                MessageBox.Show("Campo identidad incorrecto.\n Favor cambiar el formato de la identidad", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (conexion.validarTelefono(txtCelular.Text) == false && txtCelular.Text != "")
            {
                MessageBox.Show("Campo Celular Incorrecto.\nFavor cambiar los datos del celular.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (conexion.validaremail(txtCorreo.Text) == false && txtCorreo.Text != "")
            {
                MessageBox.Show("El correo que Ingreso no tiene el formato Correcto.\nVerifique su correo.\n Ej.(nombre@dominio.com)");
            }
            
            else if(conexion.validarTelefono(txtTelefono.Text) == false && txtTelefono.Text != "")
            {
                MessageBox.Show("El telefono de trabajo Incorrecto.\nIngrese un numero de telefono Correcto.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(conexion.validarPuntoReal(txtIngreso.Text) == false && txtIngreso.Text != "")
            {
                MessageBox.Show("Ingreso Extra Incorrecto.\nFavor cambiar el ingreso Extra.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(conexion.validarPuntoReal(txtMonto.Text) == false || txtMonto.Text.StartsWith("0"))
            {
                MessageBox.Show("Campo Monto Incorrecto.\nIngrese un numero real, con dos decimales.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    SqlCommand comando = new SqlCommand("insert into proyecto (identidad_cliente, nombre_cliente, apellido_cliente, nombre_trabajo, direccion_trabajo, monto_proyecto, institucion_financiera, id_genero, id_estado_civil, id_estatus, id_vendedor, fecha_de_nacimiento) values ('" + txtIdentidad.Text + "', '" + txtNombre.Text + "', '" + txtApellido.Text +"','" + txtLugar.Text + "', '" + txtdireccion.Text + "','" + Convert.ToDouble(txtMonto.Text) + "', '" + txtFinanciera.Text + "', '" + obtener(cbgenero, 1) + "', '" + obtener(cbCivil, 2) + "', '" + obtener(cbEstatus, 3) + "' , '" + obtener(cbVendedor, 4) + "', '" + cbtiempo.Text + "')", conexion.enlace());
                    comando.ExecuteNonQuery();
                    if(txtCelular.Text != "")
                    {
                        SqlCommand comando1 = new SqlCommand("update proyecto set celular = '" + Convert.ToInt64(txtCelular.Text) + "' where identidad_cliente = '"+txtIdentidad.Text+"'", conexion.enlace());
                        comando1.ExecuteNonQuery();
                    }
                    if (txtCorreo.Text != "")
                    {
                        SqlCommand comando2 = new SqlCommand("update proyecto set correo_electronico = '" +txtCorreo.Text+ "' where identidad_cliente = '" + txtIdentidad.Text + "'", conexion.enlace());
                        comando2.ExecuteNonQuery();
                    }
                    if (txtRtn.Text != "")
                    {
                        SqlCommand comando3 = new SqlCommand("update proyecto set rtn = '" + txtRtn.Text + "' where identidad_cliente = '" + txtIdentidad.Text + "'", conexion.enlace());
                        comando3.ExecuteNonQuery();
                    }
                    if (txtAntiguedad.Text != "")
                    {
                        SqlCommand comando4 = new SqlCommand("update proyecto set antiguedad_laboral = '" + txtAntiguedad.Text + "' where identidad_cliente = '" + txtIdentidad.Text + "'", conexion.enlace());
                        comando4.ExecuteNonQuery();
                    }
                    if (txtTelefono.Text != "")
                    {
                        SqlCommand comando5 = new SqlCommand("update proyecto set telefono_trabajo = '" + Convert.ToInt64(txtTelefono.Text) + "' where identidad_cliente = '" + txtIdentidad.Text + "'", conexion.enlace());
                        comando5.ExecuteNonQuery();
                    }
                    if (txtIngreso.Text != "")
                    {
                        SqlCommand comando6 = new SqlCommand("update proyecto set ingreso_extra = '" + Convert.ToDouble(txtIngreso.Text) + "' where identidad_cliente = '" + txtIdentidad.Text + "'", conexion.enlace());
                        comando6.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se Ingreso Cliente con Exito.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error > " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }
        public void home()
        {
            if (MessageBox.Show("Seguro que quiere Salir. \nPerdera la informacion que ingreso.", "ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void brnHome_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtCelular.Text != "" || txtCorreo.Text != "" || txtdireccion.Text != "" || cbtiempo.Text != "" || txtFinanciera.Text != "" || txtIdentidad.Text != "" || txtIngreso.Text != "" || txtLugar.Text != "" || txtMonto.Text != "" || txtRtn.Text != "" || txtTelefono.Text != "" || txtAntiguedad.Text != "")
            {
                home();
            }
            else
            {
                this.Close();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.Validarfecha(e);
        }

        private void txtRtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtAntiguedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void txtFinanciera_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

       

        

    }
}
