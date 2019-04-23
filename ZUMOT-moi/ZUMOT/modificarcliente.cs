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

namespace pantallas_de_clientes
{
    public partial class modificarcliente : Form
    {
        conexion conectar = new conexion();
        public modificarcliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardarmodi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios Guardados!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void modificarcliente_Load(object sender, EventArgs e)
        {
            grupolabor.Enabled = false;
            Seleccionestado(cbCivil);
            Seleccioestatus(cbLaboral);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarUser(this.txtid_cli.Text);

        }
        //Metodo para verificar si existe el usuario para la modificacion del password
        public void buscarUser(string user)
        {
            if (user == "")
            {
                MessageBox.Show("Campo de Usuario Vacio, Ingresar Usuario.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtid_cli.Clear();
                return;
            }
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("Select identidad_cliente from proyecto where identidad_cliente = @user", conexion.enlace());
                comando.Parameters.AddWithValue("user", user);
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);

                if (datatabla.Rows.Count == 1)
                {
                    txtid_cli.Enabled = false;
                    gclientes.Enabled = true;
                    grupolabor.Enabled = true;

                    string[] valores = conectar.captar_info(txtid_cli.Text);
                    txtnom_cli.Text = valores[0];
                    txtapellido.Text = valores[1];
                    txtcelular.Text = valores[2];
                    txtcorreo.Text = valores[3];
                    txtluga_tra.Text = valores[4];
                    fecha.Text = valores[5];
                    cbCivil.Text = valores[6];
                    cbLaboral.Text = valores[7];
                    txtanti_lab.Text = valores[8];
                    txttele_traba.Text = valores[9];
                    txtdic_tra.Text = valores[10];
                    txtin_ex.Text = valores[11];
                    txtRTN.Text = valores[12];

                }
                else
                {
                    MessageBox.Show("Usuario no encontrado, Verifique datos de Usuario.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtid_cli.Clear();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Sistema> " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtid_cli_Keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtedad_Keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtcelular_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloDecimales(e);
        }

        private void txtcorreo_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void txtluga_tra_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }

        private void txte_c_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtes_la_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtanti_lab_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txttele_traba_keypress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNumeros(e);
        }

        private void txtin_ex_keyprees(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloDecimales(e);
        }

        private void btnguardarmodi_Click_1(object sender, EventArgs e)
        {
            if(txtin_ex.Text.Contains(".") == false)
            {
                txtin_ex.Text = txtin_ex + ".00";
            }
            if (txtluga_tra.Text == "" || txtdic_tra.Text == "")
            {
                MessageBox.Show("Campos Vacios, Favor Llenar Todos los campos", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (conexion.validarTelefono(txtcelular.Text) == false && txtcelular.Text != "")
            {
                MessageBox.Show("Numero de Telefono Incorrecto\nIngrese un numero de telefono real.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcelular.Clear();
            }
            else if (conexion.validaremail(txtcorreo.Text) == false && txtcorreo.Text != "")
            {
                MessageBox.Show("El correo que Ingreso no tiene el formato Correcto.\nVerifique su correo.\n Ej.(nombre@dominio.com)");
            }

            else if (conexion.validarTelefono(txttele_traba.Text) == false && txttele_traba.Text != "")
            {
                MessageBox.Show("El telefono de trabajo Incorrecto.\nIngrese un numero de telefono Correcto.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (conexion.validarPuntoReal(txtin_ex.Text) == false && txtin_ex.Text != "")
            {
                MessageBox.Show("Ingreso Extra Incorrecto.\nFavor cambiar el ingreso Extra.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                SqlCommand comando = new SqlCommand("update proyecto set fecha_de_nacimiento = '" + fecha.Text + "', nombre_trabajo = '" + txtluga_tra.Text + "', direccion_trabajo = '" + txtdic_tra.Text + "'", conexion.enlace());
                comando.ExecuteNonQuery();
                if (txtcelular.Text != "")
                {
                    SqlCommand comando1 = new SqlCommand("update proyecto set celular = '" + Convert.ToInt64(txtcelular.Text) + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando1.ExecuteNonQuery();
                }
                if (txtcorreo.Text != "")
                {
                    SqlCommand comando2 = new SqlCommand("update proyecto set correo_electronico = '" + txtcorreo.Text + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando2.ExecuteNonQuery();
                }
                if (txtRTN.Text != "")
                {
                    SqlCommand comando3 = new SqlCommand("update proyecto set rtn = '" + txtRTN.Text + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando3.ExecuteNonQuery();
                }
                if (txtanti_lab.Text != "")
                {
                    SqlCommand comando4 = new SqlCommand("update proyecto set antiguedad_laboral = '" + txtanti_lab.Text + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando4.ExecuteNonQuery();
                }
                if (txttele_traba.Text != "")
                {
                    SqlCommand comando5 = new SqlCommand("update proyecto set telefono_trabajo = '" + Convert.ToInt64(txttele_traba.Text) + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando5.ExecuteNonQuery();
                }
                if (txtin_ex.Text != "")
                {
                    SqlCommand comando6 = new SqlCommand("update proyecto set ingreso_extra = '" + Convert.ToDouble(txtin_ex.Text) + "' where identidad_cliente = '" + txtid_cli.Text + "'", conexion.enlace());
                    comando6.ExecuteNonQuery();
                }
                MessageBox.Show("Se Realizaron los Cambios Correctamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

            }
        }

        public void Seleccionestado(ComboBox t)
        {
            conexion.enlace();
            SqlCommand comando = new SqlCommand(string.Format("SELECT decripcion FROM estado_civil"), conexion.enlace());
            SqlDataReader dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conexion.enlace().Close();
            return;
        }


        public void Seleccioestatus(ComboBox t)
        {
            conexion.enlace();
            SqlCommand comando = new SqlCommand(string.Format("SELECT decripcion_estatus FROM estatus_laboral"), conexion.enlace());
            SqlDataReader dataleer = comando.ExecuteReader();

            while (dataleer.Read())
            {
                t.Items.Add(dataleer[0].ToString());
            }

            conexion.enlace().Close();
            return;
        }

        public void limpiar()
        {
            txtid_cli.Clear();
            txtid_cli.Enabled = true;
            txtin_ex.Clear();
            txtluga_tra.Clear();
            txtnom_cli.Clear();
            txtRTN.Clear();
            txttele_traba.Clear();
            txtdic_tra.Clear();
            txtapellido.Clear();
            txtcelular.Clear();
            txtcorreo.Clear();
            txtanti_lab.Clear();
            grupolabor.Enabled = false;
            gclientes.Enabled = false;
            cbLaboral.SelectedIndex = 0;
            cbCivil.SelectedIndex = 0;

            
        }
        private void btnatrasmodi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txttele_traba_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtluga_tra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdic_tra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtes_la_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtanti_lab_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_cli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buscarUser(txtid_cli.Text);
        }

        private void txtid_cli_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtedad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtcelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtanti_lab_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtin_ex_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void txtcorreo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txttele_traba_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }
    }
}
    
