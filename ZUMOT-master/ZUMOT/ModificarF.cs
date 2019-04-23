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

namespace pantallas
{
    public partial class ModificarF : Form
    {
        private int estado = 0;
        public ModificarF()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarF Nuevo = new AgregarF();
            Nuevo.ShowDialog();
        }

        private void grupoFactura_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarF_Load(object sender, EventArgs e)
        {
            grupoDatos.Enabled = false;
            btnenviar.Enabled = false;

        }

        public void limpiar()
        {
            txtcasa.Clear();
            txtDetalle.Clear();
            txtFactura.Clear();
            txtFecha.Clear();
            txtidentidad.Clear();
            txtValor.Clear();
            labNombre.Text = "";
            listamateriales.DataSource = "";
            listamateriales.Enabled = false;
            grupoDatos.Enabled = false;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (txtFactura.Text == "")
            {
                MessageBox.Show("Campo N~ Factura Vacio. \nIngrese un numero de Factura Existente.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listamateriales.DataSource = "";
                txtValor.Clear();
                txtDetalle.Clear();
                conexion.enlace();
                try
                {
                    SqlDataAdapter data = new SqlDataAdapter("select a.id_facturaMano, a.descripcion_mano_de_obra, a.monto, b.nombre_casa_comercial, b.identidad_cliente, b.fecha_factura, c.nombre_cliente, c.apellido_cliente from mano_obra a inner join compra b on a.id_facturaMano = b.id_factura inner join proyecto c on b.identidad_cliente = c.identidad_cliente where id_facturaMano = '" + Convert.ToInt64(txtFactura.Text) + "'", conexion.enlace());
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    if (tabla.Rows.Count > 0)
                    {
                        listamateriales.Enabled = false;
                        grupoDatos.Enabled = true;
                        btnenviar.Enabled = true;
                        txtDetalle.Enabled = true;
                        txtValor.Enabled = true;
                        txtidentidad.Text = tabla.Rows[0][4].ToString();
                        labNombre.Text = tabla.Rows[0][6].ToString() + " " + tabla.Rows[0][7].ToString();
                        txtFecha.Text = tabla.Rows[0][5].ToString();
                        txtcasa.Text = tabla.Rows[0][3].ToString();
                        txtDetalle.Text = tabla.Rows[0][1].ToString();
                        txtValor.Text = tabla.Rows[0][2].ToString();
                        estado = 1;


                    }

                    else
                    {
                        SqlDataAdapter comando = new SqlDataAdapter("select a.id_factura, a.nombre_casa_comercial, a.identidad_cliente, a.fecha_factura, b.nombre_cliente, b.apellido_cliente from compra a inner join proyecto b on a.identidad_cliente = b.identidad_cliente where a.id_factura = '" + Convert.ToInt64(txtFactura.Text) + "'", conexion.enlace());
                        DataTable contenido = new DataTable();
                        comando.Fill(contenido);
                        if (contenido.Rows.Count > 0)
                        {
                            listamateriales.Enabled = true;
                            grupoDatos.Enabled = true;
                            btnenviar.Enabled = true;
                            txtDetalle.Enabled = false;
                            txtValor.Enabled = false;

                            txtidentidad.Text = contenido.Rows[0][2].ToString();
                            labNombre.Text = contenido.Rows[0][4].ToString() + " " + contenido.Rows[0][5].ToString();
                            txtFecha.Text = contenido.Rows[0][3].ToString();
                            txtcasa.Text = contenido.Rows[0][1].ToString();
                            SqlDataAdapter comando2 = new SqlDataAdapter("select a.id_material, b.nombre_material, a.cantidad, a.precio, a.subtotal_compra from detalle_compra a inner join material b on a.id_material = b.id_material where id_factura = '" + Convert.ToInt64(txtFactura.Text) + "'", conexion.enlace());
                            DataTable detalle = new DataTable();
                            comando2.Fill(detalle);
                            listamateriales.DataSource = detalle;
                            estado = 2;
                        }
                        else
                        {
                            MessageBox.Show("Numero de Factura No Encontrado.\nIngrese un Numero de Factura Existente.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtFactura.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error> " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    conexion.enlace().Close();
                }
            }
        }

        public void guardarFactura(int valor)
        {
            if(valor == 1)
            {
                if(txtValor.Text.Contains(".") == false)
                {
                    txtValor.Text = txtValor.Text + ".00";
                }
                if (txtidentidad.Text == "" || txtFecha.Text == "" || txtcasa.Text == "" || txtDetalle.Text == "" || txtValor.Text == "")
                {
                    MessageBox.Show("Campos Vacios.\n Favor llenar los campos de la factura.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (conexion.validarIdentidad(txtidentidad.Text) == false)
                {
                    MessageBox.Show("Formato de identidad incorrecto.\nFavor Ingresar un numero de identidad Valido.\nEj.(0801197412345)", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (conexion.validarPuntoReal(txtValor.Text) == false || txtValor.Text.StartsWith("0"))
                {
                    MessageBox.Show("El precio no es un dígito Decimal o tiene más de dos decimales.\nFavor cambiar los valores del precio.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtValor.Clear();
                }
                else
                {
                    conexion.enlace();
                    long factura = Convert.ToInt64(txtFactura.Text);
                    string mano = txtcasa.Text;
                    string identidad = txtidentidad.Text;
                    string fecha = txtFecha.Text;
                    string detalle = txtDetalle.Text;
                    double precio = Convert.ToDouble(txtValor.Text);

                    try
                    {

                        SqlCommand comando = new SqlCommand("update compra set nombre_casa_comercial = '"+mano+"', id_tipo_compra = '1', identidad_cliente = '"+identidad+"', fecha_factura = '"+fecha+"' where id_factura = '"+factura+"'", conexion.enlace());
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            try
                            {
                                SqlDataAdapter data = new SqlDataAdapter("select id_factura from compra where id_factura = '" + factura + "'", conexion.enlace());
                                DataTable tabla = new DataTable();
                                data.Fill(tabla);
                                long fact = Convert.ToInt64(tabla.Rows[0][0].ToString());
                                SqlCommand comando2 = new SqlCommand("update mano_obra set descripcion_mano_de_obra = '"+detalle+"', monto = '"+precio+"' where id_facturaMano = '"+fact+"'", conexion.enlace());
                                comando2.ExecuteNonQuery();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocurrio un Error> " + ex.ToString());

                            }

                            MessageBox.Show("Ingreso de Factura Exitosamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se Puedo Ingresar la Factura.", "ERRROR!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un Error> " + ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexion.enlace().Close();
                    }
                }

            }
            else
            {
                if (txtFecha.Text == "" || txtFactura.Text == "" || txtidentidad.Text == "" || txtcasa.Text == "")
                {
                    MessageBox.Show("No puede Guardar la Factura por Falta de Informacion.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (conexion.validarIdentidad(txtidentidad.Text) == false)
                {
                    MessageBox.Show("Formato de identidad incorrecto.\nFavor Ingresar un numero de identidad Valido.\nEj.(0801197412345)", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    conexion.enlace();
                    long factura = Convert.ToInt64(txtFactura.Text);
                    string casa = txtcasa.Text;
                    string identidad = txtidentidad.Text;
                    string fecha = txtFecha.Text;
                    try
                    {

                        SqlCommand comando = new SqlCommand("update compra set nombre_casa_comercial = '"+casa+"', id_tipo_compra = '1', identidad_cliente = '"+identidad+"', fecha_factura = '"+fecha+"' where id_factura = '"+factura+"'", conexion.enlace());
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Ingreso de Factura Exitosamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se Puedo Ingresar la Factura.", "ERRROR!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se produjo un Error> " + ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexion.enlace().Close();
                        

                    }
                }
            }
            

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            guardarFactura(estado);
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtidentidad_Leave(object sender, EventArgs e)
        {
            if (conexion.validarIdentidad(txtidentidad.Text) == false)
            {
                MessageBox.Show("Formato de identidad incorrecto.\nFavor Ingresar un numero de identidad Valido.\nEj.(0801197412345)", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labNombre.Text = "";
            }
            else
            {
                    conexion.enlace();
                    try
                    {
                        SqlDataAdapter data = new SqlDataAdapter("select nombre_cliente, apellido_cliente from proyecto where identidad_cliente = '" + txtidentidad.Text + "'", conexion.enlace());
                        DataTable tabla = new DataTable();
                        data.Fill(tabla);
                        if (tabla.Rows.Count > 0)
                        {
                        labNombre.Text = tabla.Rows[0][0].ToString() + " " + tabla.Rows[0][1].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No Se encontro registro de la identidad ingresada", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            txtidentidad.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrio un error> " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    finally
                    {
                        conexion.enlace().Close();
                    }
                
            }
        }
    }
}
