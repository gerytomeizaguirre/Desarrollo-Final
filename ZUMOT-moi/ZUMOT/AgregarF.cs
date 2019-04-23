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

namespace pantallas
{
    public partial class AgregarF : Form
    {
        int posicion;
        double total = 0;
        private long tipo_fac = 1;
        conexion material = new conexion();
        public AgregarF()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }



        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Existencia Nuevo = new Existencia();
            Nuevo.ShowDialog();
        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listaMateriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            string fac = txtfactura.Text;
            if (txtfactura.Text == "" || txtcasacomercial.Text == "" || listaMateriales.Rows.Count == 0)
            {
                MessageBox.Show("No puede Guardar la Factura por Falta de Información.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fac.StartsWith("0"))
            {
                MessageBox.Show("No se acepta el 0 como primer elemento en el numero de factura.\nFavor ingresar un numero de factura mayor a 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtfactura.Clear();
            }
            else
            {


                conexion.enlace();
                long factura = Convert.ToInt64(txtfactura.Text);
                string casa = txtcasacomercial.Text;
                string identidad = txtidentidad.Text;
                string fecha = fechaTime.Text;
                try
                {

                    SqlCommand comando = new SqlCommand("insert into compra (id_factura, nombre_casa_comercial, id_tipo_compra, identidad_cliente, fecha_factura) values ('" + factura + "', '" + casa + "', '" + tipo_fac + "',  '" + identidad + "', '" + fecha + "')", conexion.enlace());
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            SqlDataAdapter data = new SqlDataAdapter("select id_factura from compra where id_factura = '" + factura + "'", conexion.enlace());
                            DataTable tabla = new DataTable();
                            data.Fill(tabla);
                            long fact = Convert.ToInt64(tabla.Rows[0][0].ToString());

                            SqlCommand comando2 = new SqlCommand("insert into detalle_compra (id_factura, id_material, cantidad, precio, subtotal_compra) values ('" + fact + "', @idmaterial, @cantidad, @precio, @subtotal)", conexion.enlace());

                            foreach (DataGridViewRow row in listaMateriales.Rows)
                            {

                                comando2.Parameters.Clear();

                                comando2.Parameters.AddWithValue("@idmaterial", Convert.ToInt64(row.Cells["cod"].Value));
                                comando2.Parameters.AddWithValue("@cantidad", Convert.ToInt64(row.Cells["cantidad"].Value));
                                comando2.Parameters.AddWithValue("@precio", Convert.ToDouble(row.Cells["precio"].Value));
                                comando2.Parameters.AddWithValue("@subtotal", Convert.ToDouble(row.Cells["subtotal"].Value));

                                comando2.ExecuteNonQuery();

                            }

                            for (int i = 0; i < listaMateriales.RowCount; i++)
                            {
                                long bodega = 0;
                                SqlDataAdapter datos = new SqlDataAdapter("select cantidad_bodega from material where id_material = '" + Convert.ToInt64(listaMateriales.Rows[i].Cells["cod"].Value) + "'", conexion.enlace());
                                DataTable tablero = new DataTable();
                                datos.Fill(tablero);
                                bodega = Convert.ToInt64(tablero.Rows[0][0].ToString());
                                SqlCommand cm = new SqlCommand("update material set cantidad_bodega = '" + (Convert.ToInt64(listaMateriales.Rows[i].Cells["cantidad"].Value) + bodega) + "' where id_material = '" + Convert.ToInt64(listaMateriales.Rows[i].Cells["cod"].Value) + "'", conexion.enlace());
                                cm.ExecuteNonQuery();

                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un Error> " + ex.ToString());

                        }

                        MessageBox.Show("Ingreso de Factura Exitosamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiar();
                        txtfactura.Clear();
                        txtcasacomercial.Clear();
                        txtidentidad.Clear();
                        labNombre.Text = "";
                        grupoDato.Enabled = false;
                        grupoDetalle.Enabled = false;
                        listaMateriales.Rows.Clear();
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



        private void AgregarF_Load(object sender, EventArgs e)
        {
            material.SeleccionTipoMaterial(combTipomaterial);
            listaMateriales.Enabled = false;
            combMaterial.Enabled = true;
            grupoDato.Enabled = false;
            grupoDetalle.Enabled = false;
            btnSave.Enabled = false;
            btnModificar.Enabled = false;
            btnDelete.Enabled = false;
            grupo2datos.Enabled = false;
            btn2Enviar.Enabled = false;


        }
        public void BuscarCliente(int pagina, TextBox identidad)
        {
            if (identidad.Text == "")
            {
                MessageBox.Show("Campo Identidad Vacio. \nIngrese un numero de identidad Existente.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conexion.enlace();
                try
                {
                    SqlDataAdapter data = new SqlDataAdapter("select nombre_cliente, apellido_cliente from proyecto where identidad_cliente = '" + identidad.Text + "'", conexion.enlace());
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    if (tabla.Rows.Count > 0)
                    {
                        if (pagina == 1)
                        {
                            labNombre.Text = tabla.Rows[0][0].ToString() + " " + tabla.Rows[0][1].ToString();
                            grupoDato.Enabled = true;
                            grupoDetalle.Enabled = true;
                            btnSave.Enabled = true;
                            listaMateriales.Enabled = true;
                        }
                        else if (pagina == 2)
                        {
                            lab2Nombre.Text = tabla.Rows[0][0].ToString() + " " + tabla.Rows[0][1].ToString();
                            grupo2datos.Enabled = true;
                            btn2Enviar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Se encontro registro de la identidad ingresada", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente(1, txtidentidad);
        }

        private void combTipomaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            combMaterial.Items.Clear();

            if (combTipomaterial.SelectedIndex > 0)
            {
                combMaterial.Enabled = true;
                material.SeleccionMaterial(combMaterial, combTipomaterial.Text);

            }
            else
            {
                combMaterial.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo, tipo, material, cantidad, precio;
            double subtotal = 0;
            tipo = combTipomaterial.Text;
            material = combMaterial.Text;
            cantidad = txtCantidad.Text;
            precio = txtPrecio.Text;
            if (precio.Contains(".") == false)
            {
                precio = precio + ".00";
            }
            if (combTipomaterial.SelectedIndex == 0 || combMaterial.SelectedIndex == 0 || txtCantidad.Text == "" || txtPrecio.Text == "")
            {
                MessageBox.Show("Campos Vacios. \nPor Favor Llenar los Campos del Detalle de Factura.", "ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cantidad.StartsWith("0"))
            {
                MessageBox.Show("No se aceptan cantidades en 0.\n Favor ingresar cantidades mayores a 0.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Clear();
            }
            else if (conexion.validarPuntoReal(precio) == false || precio.StartsWith("0"))
            {
                MessageBox.Show("El precio no es un dígito Decimal o tiene más de dos decimales.\nFavor cambiar los valores del precio.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion.enlace();
                SqlDataAdapter adapter = new SqlDataAdapter("select id_material from material where nombre_material = '" + material + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);
                codigo = tabla.Rows[0][0].ToString();
                if (VerificacionMaterial(codigo) == false)
                {
                    subtotal = Convert.ToDouble(cantidad) * Convert.ToDouble(precio);
                    listaMateriales.Rows.Add(codigo, material, cantidad, precio, Convert.ToString(subtotal), tipo);
                    total = subtotal + total;
                    labtotal.Text = Convert.ToString(total);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No puede repetir Material en el detalle de compra. \nFavor elegir otro material.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiar();
                }

            }
        }

        public void limpiar()
        {
            combTipomaterial.SelectedIndex = 0;
            combMaterial.Text = "";
            txtCantidad.Clear();
            txtPrecio.Clear();
        }

        private void listaMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = listaMateriales.CurrentRow.Index;

            combTipomaterial.Text = listaMateriales[5, posicion].Value.ToString();
            combMaterial.Text = listaMateriales[1, posicion].Value.ToString();
            txtCantidad.Text = listaMateriales[2, posicion].Value.ToString();
            txtPrecio.Text = listaMateriales[3, posicion].Value.ToString();
            
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string cod, tipo, material, cantidad, precio;
            double subtotal;
            total = total - Convert.ToDouble(listaMateriales.Rows[posicion].Cells[4].Value);
            tipo = combTipomaterial.Text;
            material = combMaterial.Text;
            cantidad = txtCantidad.Text;
            precio = txtPrecio.Text;
            if(precio.Contains(".") == false)
            {
                precio = precio + ".00";
            }
            if (tipo == "" || material == "" || cantidad == "" || precio == "" || precio == ".")
            {
                MessageBox.Show("Campos Vacios. \nPor Favor Llenar los Campos del Detalle de Factura.", "ADVERTENCIA!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cantidad.StartsWith("0"))
            {
                MessageBox.Show("No se aceptan cantidades en 0.\n Favor ingresar cantidades mayores a 0.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Clear();
            }
            else if(conexion.validarPuntoReal(precio) == false || precio.StartsWith("0"))
            {
                MessageBox.Show("El precio no es un dígito Decimal o tiene más de dos decimales.\nFavor cambiar los valores del precio.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
                conexion.enlace();
                SqlCommand comando = new SqlCommand("select id_material from material where nombre_material = '" + material + "'", conexion.enlace());
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatable = new DataTable();
                dtadapter.Fill(datatable);
                cod = datatable.Rows[0][0].ToString();
                if (cod == Convert.ToString(listaMateriales.Rows[posicion].Cells["cod"].Value))
                {
                    subtotal = Convert.ToDouble(cantidad) * Convert.ToDouble(precio);
                    listaMateriales[0, posicion].Value = cod;
                    listaMateriales[1, posicion].Value = combMaterial.Text;
                    listaMateriales[2, posicion].Value = txtCantidad.Text;
                    listaMateriales[3, posicion].Value = txtPrecio.Text;
                    listaMateriales[4, posicion].Value = Convert.ToString(subtotal);
                    listaMateriales[5, posicion].Value = combTipomaterial.Text;
                    total = total + subtotal;
                    labtotal.Text = Convert.ToString(total);
                    limpiar();
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else if(VerificacionMaterial(cod) == false)
                {   
                    subtotal = Convert.ToDouble(cantidad) * Convert.ToDouble(precio);
                    listaMateriales[0, posicion].Value = cod;
                    listaMateriales[1, posicion].Value = combMaterial.Text;
                    listaMateriales[2, posicion].Value = txtCantidad.Text;
                    listaMateriales[3, posicion].Value = txtPrecio.Text;
                    listaMateriales[4, posicion].Value = Convert.ToString(subtotal);
                    listaMateriales[5, posicion].Value = combTipomaterial.Text;
                    total = total + subtotal;
                    labtotal.Text = Convert.ToString(total);
                    limpiar();
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No puede repetir Material en el detalle de compra. \nFavor elegir otro material.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listaMateriales.Rows.Count == 0)
            {
                total = 0;
            }
            else
            {
                total = total - Convert.ToDouble(listaMateriales.Rows[posicion].Cells[4].Value);
                labtotal.Text = Convert.ToString(total);
                listaMateriales.Rows.RemoveAt(posicion);
                limpiar();
                btnAgregar.Enabled = true;
                btnDelete.Enabled = false;
                btnModificar.Enabled = false;
            }
           
            
        }
        public bool VerificacionMaterial(string codigo) {
            bool rep = false;
            for (int i = 0; i < listaMateriales.Rows.Count; i++)
            {

                if (codigo == Convert.ToString(listaMateriales.Rows[i].Cells["cod"].Value))
                {
                    rep = true;
                    return rep;
                }
                else
                {
                    rep = false;
                }
            }
            return rep;

        }
     

        private void button_Restart_Click(object sender, EventArgs e)
        {
            
            limpiar();
            txtcasacomercial.Clear();
            txtfactura.Clear();
            txtidentidad.Clear();
            labNombre.Text = "Nombre del Cliente";
            grupoDato.Enabled = false;
            grupoDetalle.Enabled = false;
            listaMateriales.Rows.Clear();
        }

        private void brnHome_Click(object sender, EventArgs e)
        {
            if(txtidentidad.Text != "" || listaMateriales.Rows.Count > 0)
            {
                home();   
            }
            else
            {
                this.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn2Buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente(2, txt2Identidad);
        }

        private void btn2Enviar_Click(object sender, EventArgs e)
        {
            if (txt2Valor.Text.Contains(".") == false)
            {
                txt2Valor.Text = txt2Valor.Text + ".00";
            }
            if (txt2Factura.Text == "" || txt2Mano.Text == "" || txt2Detalle.Text == "" || txt2Valor.Text == "")
            {
                MessageBox.Show("No puede Guardar la Factura por Falta de Informacion.", "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt2Factura.Text.StartsWith("0"))
            {
                MessageBox.Show("No se acepta el 0 como primer elemento en el numero de factura.\nFavor ingresar un numero de factura mayor a 0", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt2Factura.Clear();
            }
            else if (conexion.validarPuntoReal(txt2Valor.Text) == false || txt2Valor.Text.StartsWith("0"))
            {
                MessageBox.Show("El valor no es un dígito Decimal o tiene más de dos decimales.\nFavor cambiar los valores del precio.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion.enlace();
                long factura = Convert.ToInt64(txt2Factura.Text);
                string mano = txt2Mano.Text;
                string identidad = txt2Identidad.Text;
                string fecha = tiempo2.Text;
                string detalle = txt2Detalle.Text;
                double valor = Convert.ToDouble(txt2Valor.Text);

                try
                {

                    SqlCommand comando = new SqlCommand("insert into compra (id_factura, nombre_casa_comercial, id_tipo_compra, identidad_cliente, fecha_factura) values ('" + factura + "', '" + mano + "', '" + tipo_fac + "',  '" + identidad + "', '" + fecha + "')", conexion.enlace());
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        try
                        {
                            SqlDataAdapter data = new SqlDataAdapter("select id_factura from compra where id_factura = '" + factura + "'", conexion.enlace());
                            DataTable tabla = new DataTable();
                            data.Fill(tabla);
                            long fact = Convert.ToInt64(tabla.Rows[0][0].ToString());
                            SqlCommand comando2 = new SqlCommand("insert into mano_obra (id_facturaMano, descripcion_mano_de_obra, monto) values ('" + fact + "', '" + detalle + "', '" + valor + "')", conexion.enlace());
                            comando2.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un Error> " + ex.ToString());

                        }

                        MessageBox.Show("Ingreso de Factura Exitosamente.", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txt2Identidad.Clear();
                        txt2Factura.Clear();
                        txt2Mano.Clear();
                        txt2Detalle.Clear();
                        txt2Valor.Clear();
                        lab2Nombre.Text = "Nombre del Cliente";
                        grupo2datos.Enabled = false;
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

        public void home()
        {
                if (MessageBox.Show("Seguro que quiere Salir. \nPerdera la informacion que ingreso.", "ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
        }
        private void btn2Refresh_Click(object sender, EventArgs e)
        {
            txt2Identidad.Clear();
            txt2Factura.Clear();
            txt2Mano.Clear();
            txt2Detalle.Clear();
            txt2Valor.Clear();
            lab2Nombre.Text = "Nombre del Cliente";
            grupo2datos.Enabled = false;
            btn2Enviar.Enabled = false;
        }

        private void btn2Home_Click(object sender, EventArgs e)
        {
            if (txt2Identidad.Text != "" || txt2Factura.Text != "")
            {
                home();
            }
            else
            {
                this.Close();
            }
        }

        private void txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void txt2Identidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txt2Factura_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txt2Mano_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txt2Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }
    }
}
