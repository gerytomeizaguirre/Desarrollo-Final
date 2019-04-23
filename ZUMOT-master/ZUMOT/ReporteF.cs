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
    public partial class ReporteF : Form
    {
        int posicion;
        public ReporteF()
        {
            InitializeComponent();
        }

        private void ReporteF_Load(object sender, EventArgs e)
        {
            facturas();
            btnDelete.Enabled = false;
        }

        public void facturas()
        {
            conexion.enlace();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("select id_factura, fecha_factura, identidad_cliente, nombre_casa_comercial from compra", conexion.enlace());
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                dataFactura.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error> " +ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        public void limpiar()
        {
            txtFactura.Clear();
            facturas();

        }

        public void Buscar()
        {
            conexion.enlace();
            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("select id_factura, fecha_factura, identidad_cliente, nombre_casa_comercial from compra where id_factura = '"+txtFactura.Text+"'", conexion.enlace());
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                if(tabla.Rows.Count > 0)
                {
                    dataFactura.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("Numero de Factura no Existe. \nIngrese un numero de Factura.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtFactura.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error> "+ ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtFactura.Text == "")
            {
                MessageBox.Show("Campo Factura Vacio. \nIngrese un numero de factura existente.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Buscar();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dataFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataFactura.Rows.Count > 0) {
                posicion = dataFactura.CurrentRow.Index;
                btnDelete.Enabled = true;
            }
            
        }

        private void dataFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long Nfactura = 0;
            Nfactura = Convert.ToInt64(dataFactura.Rows[posicion].Cells[0].Value);
            if (MessageBox.Show("Seguro que quiere eliminar la Factura N#: " + Nfactura + "\n Presione SI para Eliminar y NO para cancelar la eliminacion.", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlDataAdapter datos = new SqlDataAdapter("select id_material, cantidad from detalle_compra where id_factura ='" + Nfactura + "'", conexion.enlace());
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                if (tabla.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        long idMaterial = 0, cantidadMaterial = 0;
                        idMaterial = Convert.ToInt64(tabla.Rows[i][0].ToString());
                        cantidadMaterial = Convert.ToInt64(tabla.Rows[i][1].ToString());
                        SqlDataAdapter datosMaterial = new SqlDataAdapter("select cantidad_bodega from material where id_material = '" + idMaterial + "'", conexion.enlace());
                        DataTable tabla2 = new DataTable();
                        datosMaterial.Fill(tabla2);
                        if (tabla2.Rows.Count > 0)
                        {
                            
                            long cantidadb = 0;
                            cantidadb = Convert.ToInt64(tabla2.Rows[0][0].ToString());
                            long cantidadBodega = 0;
                            cantidadBodega = cantidadb - cantidadMaterial;
                            SqlCommand contenedor = new SqlCommand("update material set cantidad_bodega = '" +cantidadBodega + "' where id_material = '" + idMaterial + "'", conexion.enlace());
                            contenedor.ExecuteNonQuery();
                            SqlCommand comando2 = new SqlCommand("delete from detalle_compra where id_factura = '" + Nfactura + "'", conexion.enlace());
                            comando2.ExecuteNonQuery();
                        }
                    }
                    SqlCommand comando = new SqlCommand("delete from compra where id_factura = '" + Nfactura + "'", conexion.enlace());
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado la Factura #:" + Nfactura + " Correctamente", "CORRECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    facturas();


                }
                else
                {
                    SqlCommand comando = new SqlCommand("delete from mano_obra where id_facturaMano = '" + Nfactura + "'", conexion.enlace());
                    comando.ExecuteNonQuery();
                    SqlCommand comando2 = new SqlCommand("delete from compra where id_factura = '" + Nfactura + "'", conexion.enlace());
                    comando2.ExecuteNonQuery();
                    MessageBox.Show("Se ha eliminado la Factura #:" + Nfactura + " Correctamente", "CORRECTO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    facturas();
                }
            }
            
        }

        private void dataFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }
    }
}
