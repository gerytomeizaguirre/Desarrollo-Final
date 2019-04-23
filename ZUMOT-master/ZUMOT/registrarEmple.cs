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

namespace ZUMOT
{
    public partial class registrarEmple : Form
    {
        conexion database = new conexion();
        public registrarEmple()
        {
            InitializeComponent();
        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtResp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtResp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void registrarEmple_Load(object sender, EventArgs e)
        {
            database.SeleccionPuesto(cbpuesto);
        }

        private void txtidentidad_TextChanged(object sender, EventArgs e)
        {
            if(txtidentidad.Text == "")
            {
                picErid.Visible = false;
                picCid.Visible = false;
            }
            else if(conexion.validarIdentidad(txtidentidad.Text) == false)
            {
                picCid.Visible = false;
                picErid.Visible = true;
            }
            else
            {
                picErid.Visible = false;
                picCid.Visible = true;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if(txtnombre.Text == "")
            {
                picErnome.Visible = false;
                picCnombre.Visible = false;
            }
            else if (txtnombre.Text.StartsWith(" ") == true)
            {
                picCnombre.Visible = false;
                picErnome.Visible = true;
            }
            else
            {
                picErnome.Visible = false;
                picCnombre.Visible = true;
            }
        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {
            if(txtapellido.Text == "")
            {
                picErapellido.Visible = false;
                picCapellido.Visible = false;
            }
            else if (txtapellido.Text.StartsWith(" ") == true)
            {
                picCapellido.Visible = false;
                picErapellido.Visible = true;
            }
            else
            {
                picErapellido.Visible = false;
                picCapellido.Visible = true;
            }
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            if(txttelefono.Text == "")
            {
                picErtelefono.Visible = false;
                picCtelefono.Visible = false;
            }
            else if (conexion.validarTelefono(txttelefono.Text) == false)
            {
                picCtelefono.Visible = false;
                picErtelefono.Visible = true;
            }
            else
            {
                picErtelefono.Visible = false;
                picCtelefono.Visible = true;
            }
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            if(txtcorreo.Text == "")
            {
                picCcorreo.Visible = false;
                picErcorreo.Visible = false;
            }
            else if (conexion.validaremail(txtcorreo.Text) == false)
            {
                picCcorreo.Visible = false;
                picErcorreo.Visible = true;
            }
            else
            {
                picErcorreo.Visible = false;
                picCcorreo.Visible = true;
            }
        }

        private void cbpuesto_TextChanged(object sender, EventArgs e)
        {
            if(cbpuesto.SelectedIndex > 0)
            {
                picCpuesto.Visible = true;
            }
            else
            {
                picCpuesto.Visible = false;
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            
            if(txtusuario.Text == "")
            {
                picCusuario.Visible = false;
                picErusuario.Visible = false;
            }
            else if (conexion.verificaruser(txtusuario.Text) == false)
            {
                picCusuario.Visible = false;
                picErusuario.Visible = true;
            }
            else
            {
                picErusuario.Visible = false;
                picCusuario.Visible = true;
            }
        }


        public void agregar()
        {
            conexion.enlace();
            SqlDataAdapter datos2 = new SqlDataAdapter("select usuario_empleado from empleados where usuario_empleado = '"+txtusuario.Text+"'", conexion.enlace());
            DataTable tablas2 = new DataTable();
            datos2.Fill(tablas2);
            SqlDataAdapter datos3 = new SqlDataAdapter("select id_empleado from empleados where id_empleado = '" + txtidentidad.Text + "'", conexion.enlace());
            DataTable tablas3 = new DataTable();
            datos3.Fill(tablas3);
            if (txtidentidad.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || cbpuesto.SelectedIndex == 0 || txtusuario.Text == "" || txtcontra.Text == "" || txtrecontra.Text =="" || txtResp1.Text == "" || txtResp2.Text == "")
            {
                MessageBox.Show("Campos Vacios en el formulario.\nFalta de informacion en los campos del empleado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tablas3.Rows.Count > 0)
            {
                MessageBox.Show("El Numero de Identidad ya existe como empleado.\n Ingrese otro numero de identidad.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtidentidad.Clear();
            }
            else if (picErid.Visible == true)
            {
                MessageBox.Show("Identidad Incorrecta\nFavor ingrese un numero de identidad", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (picErnome.Visible == true)
            {
                MessageBox.Show("Nombre Incorrecto\nFavor ingrese el nombre del Empleado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (picErapellido.Visible == true)
            {
                MessageBox.Show("Apellido Incorrecto\nFavor ingrese el Apellido del Empleado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (picErtelefono.Visible == true)
            {
                MessageBox.Show("Telefono Incorrecto\nFavor ingrese un numero de telefono", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (picErcorreo.Visible == true)
            {
                MessageBox.Show("Correo Electronico Incorrecto\nFavor ingrese un Correo Electronico", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(tablas2.Rows.Count > 0)
            {
                MessageBox.Show("Nombre de usuario ya existe.\nFavor ingrese un nuevo nombre de usuario", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusuario.Clear();
            }
            else if (picErusuario.Visible == true)
            {
                MessageBox.Show("Usuario Incorrecto.\nFavor ingrese un usuario.\nSe necesita tener letras minusculas y numeros, con una cantidad de 5 caracteres o mas.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(picErcontra.Visible == true)
            {
                MessageBox.Show("Contraseña Incorrecta.\nLa Contraseña debe de tener letras mayusculas y minusculas, tambien numeros y tener 8 o mas caracteres.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(txtrecontra.Text != txtcontra.Text)
            {
                MessageBox.Show("La Contraseña no coincide con la anterior.\nFavor verifique que sea la misma.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion.enlace();
                try
                {
                    SqlDataAdapter datos = new SqlDataAdapter("select id_puesto from puesto_empleado where descripcion_puesto = '"+cbpuesto.Text+"'", conexion.enlace());
                    DataTable tabla = new DataTable();
                    datos.Fill(tabla);
                    int idpuesto = Convert.ToInt16(tabla.Rows[0][0].ToString());
                    SqlCommand comando = new SqlCommand("insert into empleados (id_empleado, nombre_empleado, apellido_empleado, id_puesto, usuario_empleado, contraseña_empleado, id_vendedor) values ('"+txtidentidad.Text+"', '"+txtnombre.Text+"', '"+txtapellido.Text+"', '"+idpuesto+"', '"+txtusuario.Text+"', '"+txtcontra.Text+"', '5')", conexion.enlace());
                    comando.ExecuteNonQuery();
                    SqlCommand comando2 = new SqlCommand("insert into empleado_respuestas (id_empleado, Respuesta_Pregunta1, Respuesta_Pregunta2) values ('"+txtidentidad.Text+"', '"+txtResp1.Text+"', '"+txtResp2.Text+"')", conexion.enlace());
                    comando2.ExecuteNonQuery();
                    if(txttelefono.Text != "")
                    {
                        SqlCommand comando3 = new SqlCommand("update empleado set telefono = '" + Convert.ToInt64(txttelefono.Text) + "' where id_empleado = '"+txtidentidad.Text+"'", conexion.enlace());
                        comando3.ExecuteNonQuery();
                    }
                    if(txtcorreo.Text != "")
                    {
                        SqlCommand comando4 = new SqlCommand("update empleado set correo = '" + txtcorreo.Text + "' where id_empleado = '" + txtidentidad.Text + "'", conexion.enlace());
                        comando4.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se guardó el nuevo empleado.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error > " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void limpiar()
        {
            txtidentidad.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txttelefono.Clear();
            txtcorreo.Clear();
            cbpuesto.SelectedIndex = 0;
            txtusuario.Clear();
            txtcontra.Clear();
            txtrecontra.Clear();
            txtResp1.Clear();
            txtResp2.Clear();
            picCnombre.Visible = false;
            picCid.Visible = false;
            picCapellido.Visible = false;
            picCtelefono.Visible = false;
            picCcorreo.Visible = false;
            picCusuario.Visible = false;
            picCcontra.Visible = false;
            picCcon.Visible = false;
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            
            if (txtcontra.Text == "")
            {
                picErcontra.Visible = false;
                picCcontra.Visible = false;
            }
            else if (conexion.verificarcontra(txtcontra.Text) == false)
            {
                picCcontra.Visible = false;
                picErcontra.Visible = true;
            }
            else
            {
                picErcontra.Visible = false;
                picCcontra.Visible = true;
                
            }
        }

        private void txtrecontra_TextChanged(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")
            {
                picErcon.Visible = false;
                picCcon.Visible = false;
            }
            else if (txtrecontra.Text != txtcontra.Text)
            {
                picCcon.Visible = false;
                picErcon.Visible = true;
            }
            else
            {
                picErcon.Visible = false;
                picCcon.Visible = true;
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetrasynumero(e);
        }
    }
}
