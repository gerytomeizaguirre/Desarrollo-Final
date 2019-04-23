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
using System.Data.SqlClient;
using PANTALLASVENDEDORES;
using ZUMOT;

namespace WindowsFormsApp1
{
    public partial class INICIO_SESION : Form
    {

        

        public INICIO_SESION()
        {
            InitializeComponent();
        }

        public void login(string user, string password)
        {
   
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("select nombre_empleado, id_puesto from empleados where usuario_empleado = @user and contraseña_empleado = @pass", conexion.enlace());
                comando.Parameters.AddWithValue("user", user);
                comando.Parameters.AddWithValue("pass", password);
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);

                if (datatabla.Rows.Count == 1)
                {
                    this.Hide();
                    if (datatabla.Rows[0][1].ToString() == "1")
                    {

                    }
                    else if(datatabla.Rows[0][1].ToString() == "2")
                    {
                        Menu_admi admi = new Menu_admi();
                        admi.Show();

                    }
                        else if (datatabla.Rows[0][1].ToString() == "3")
                    {

                    }
                        else if(datatabla.Rows[0][1].ToString() == "4")
                    {
                        
                    }
                        else if (datatabla.Rows[0][1].ToString() == "5")
                    {

                    }
                            else if (datatabla.Rows[0][1].ToString() == "6")
                    {
                        Iniciodevendedores viewVendedor = new Iniciodevendedores();
                        viewVendedor.Show();

                    }

                }
                else
                {
                    MessageBox.Show("El Usuario y/o Contraseña son Incorrectos. Por Favor Verificar el ingreso de los Datos!");
                    txtusuario.Clear();
                    txtcontrasena.Clear();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("No se Encuentra informacion. " + e.Message);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblrecuperacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            RECUPERACIONCUENTA recupera = new RECUPERACIONCUENTA();
            recupera.Show();
        
       }

        private void button1_Click(object sender, EventArgs e)
        {
            login(this.txtusuario.Text, this.txtcontrasena.Text);
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pantalla_bodega fa = new Pantalla_bodega();
            fa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            solicitudes sol = new solicitudes();
            sol.Show();
            this.Hide();
        }
    }
}
