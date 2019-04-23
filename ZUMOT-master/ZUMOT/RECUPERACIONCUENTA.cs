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
using ZUMOT;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class RECUPERACIONCUENTA : Form
    {

        conexion cn = new conexion();

        public RECUPERACIONCUENTA()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            INICIO_SESION inicio = new INICIO_SESION();
            inicio.Show();

        }

        private void btnrecu_Click(object sender, EventArgs e)
        {
            
            int contador = 0;

            if (txtpreguuno.Text == "" || txtpregudos.Text == "")
            {
                MessageBox.Show("Favor llenar todos los datos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cn.VerificarPreguntas(txtpreguuno.Text, txtusuariorecu.Text) > 0)
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Respuesta Correcta";
                    lblerror.ForeColor = System.Drawing.Color.Green;
                    contador++;
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Respuesta Incorrecta";
                    lblerror.ForeColor = System.Drawing.Color.Red;
                    txtpreguuno.Clear();
                }

                if (cn.VerificarPreguntas2(txtpregudos.Text, txtusuariorecu.Text) > 0)
                {
                    lblerror1.Visible = true;
                    lblerror1.Text = "Respuesta Correcta";
                    lblerror1.ForeColor = System.Drawing.Color.Green;
                    contador++;
                }
                else
                {
                    lblerror1.Visible = true;
                    lblerror1.Text = "Respuesta Incorrecta";
                    lblerror1.ForeColor = System.Drawing.Color.Red;
                    txtpregudos.Clear();
                }
            }


           if (contador == 2)
            {
                gpregunta.Enabled = false;
                grobox2.Enabled = true;
                button2.Enabled = true;
                
                

            }
           
        }

        public void recuperarContra()
        {


            if (txtConfirmar.Text == "" || txtContrasenia.Text == "")
            {
                MessageBox.Show("Campos Contraseña Vacios.\nFavor llenar los campos Vacios", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(conexion.verificarcontra(txtContrasenia.Text) == false)
            {
                MessageBox.Show("Contraseña Incorrecta.\nLa Contraseña debe de tener letras mayusculas y minusculas, tambien numeros y tener 8 o mas caracteres.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(txtConfirmar.Text != txtContrasenia.Text)
            {
                MessageBox.Show("La Contraseña no coincide con la anterior.\nFavor verifique que sea la misma.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                    conexion.enlace();
                    SqlCommand comando = new SqlCommand("Update empleados set contraseña_empleado = '" + txtContrasenia.Text + "' where usuario_empleado = '" + txtusuariorecu.Text+"'", conexion.enlace());
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas != 0)
                    {
                        lblerror.Visible = false;
                        MessageBox.Show("Contraseña Actualizada", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        INICIO_SESION regre = new INICIO_SESION();
                        regre.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("NO se Pudo hacer la Actualizacion.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }


        private void lbltitulorecu_Click(object sender, EventArgs e)
        {

        }

        private void RECUPERACIONCUENTA_Load(object sender, EventArgs e)
        {
            gpregunta.Enabled = false;
            grobox2.Enabled = false;
            button2.Enabled = false;
        }

        private void txtpreguuno_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        //Metodo para verificar si existe el usuario para la modificacion del password
        public void buscarUser(string user)
        {
            if (user == "")
            {
                MessageBox.Show("Campo de Usuario Vacio, Ingresar Usuario.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusuariorecu.Clear();
                return;
            }
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("Select usuario_empleado from empleados where usuario_empleado = @user", conexion.enlace());
                comando.Parameters.AddWithValue("user", user);
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);
                
                if (datatabla.Rows.Count == 1)
                {
                    txtusuariorecu.Enabled = false;
                    gpregunta.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado, Verifique datos de Usuario.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtusuariorecu.Clear();
                }


            }
            catch(Exception e)
            {
                MessageBox.Show("Error de Sistema> " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buscarUser(this.txtusuariorecu.Text);
            
        }

        private void txtpregudos_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void grobox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            recuperarContra();
        }

        public void enviarCorreo(string correo, string contra)
        {
            string contraseña = this.Contrasena;
            string mensaje = string.Empty;
            string destino = correo;
            string origen = "moyporti15@gmail.com";
            string asunto = "Cambio de Contraseña. Sistema ZUMOT";
            string cuerpo = "ATENCION. Se ha hecho un cambio de contraseña en el Sitema ZUMOT. Su nueva contraseña: " + contra;
            MailMessage ms = new MailMessage(origen, destino, asunto, cuerpo);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("moyporti15@gmail.com", contraseña);

            try
            {
                Task.Run(() =>
                {

                    smtp.Send(ms);
                    ms.Dispose();
                    MessageBox.Show("Correo enviado, Verifique su bandeja de entrada");
                }
                );

                MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo electronico: " + ex.Message);
            }
        }

        public string Contrasena
        {
            get
            { return "18231129Mt"; }
        }

        public string generarUSer(string usuario)
        {
            string usuar = usuario;
            return usuar;

        }

        private void txtpreguuno_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtpregudos_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtusuariorecu_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetrasynumero(e);
        }
    }
}
