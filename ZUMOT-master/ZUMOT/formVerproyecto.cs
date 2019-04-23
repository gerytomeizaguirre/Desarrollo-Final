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

namespace administracion1
{
    public partial class formVerproyecto : Form
    {
        double total;
        public formVerproyecto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formVerproyecto_Load(object sender, EventArgs e)
        {
            datos();
        }


        //---------------METODO PARA MOSTRAR LA INFORMACION DE LAS FACTURAS POR PROYECTO
        public void datos()
        {
            conexion.enlace();
            string identidad = Form_CProyecto.idCliente;
            try
            {
                SqlDataAdapter data = new SqlDataAdapter("select nombre_cliente, apellido_cliente from proyecto where identidad_cliente = '"+identidad+"'", conexion.enlace());
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                if(tabla.Rows.Count > 0)
                {
                    labidentidad.Text = identidad;
                    labnombre.Text = tabla.Rows[0][0].ToString() + " " + tabla.Rows[0][1].ToString();
                }
                total = 0;
                SqlDataAdapter data2 = new SqlDataAdapter("select a.fecha_factura, a.id_factura, a.nombre_casa_comercial, b.subtotal_compra, c.nombre_material from compra a inner join detalle_compra b on a.id_factura = b.id_factura inner join material c on b.id_material = c.id_material where a.identidad_cliente = '"+identidad+"'", conexion.enlace());
                DataTable tabla2 = new DataTable();
                data2.Fill(tabla2);
                SqlDataAdapter datos3 = new SqlDataAdapter("select a.fecha_factura, a.id_factura, a.nombre_casa_comercial, b.monto, b.descripcion_mano_de_obra from compra a inner join mano_obra b on a.id_factura = b.id_facturaMano where a.identidad_cliente = '"+identidad+"'", conexion.enlace());
                DataTable tabla3 = new DataTable();
                datos3.Fill(tabla3);
                if (tabla2.Rows.Count > 0)
                {

                    for (int i = 0; i < tabla2.Rows.Count; i++)
                    {
                        string fecha = tabla2.Rows[i][0].ToString();
                        string idfactura = tabla2.Rows[i][1].ToString();
                        string nombre = tabla2.Rows[i][2].ToString();
                        string material = tabla2.Rows[i][4].ToString();
                        double subtotal = Convert.ToDouble(tabla2.Rows[i][3].ToString());
                        total = total + subtotal;
                        dataCosto.Rows.Add(fecha, idfactura, nombre, material, subtotal);
                    }

                }
                if (tabla3.Rows.Count > 0)
                {
                    for (int i = 0; i < tabla3.Rows.Count; i++)
                    {
                        string fecha = tabla3.Rows[i][0].ToString();
                        string idfactura = tabla3.Rows[i][1].ToString();
                        string nombre = tabla3.Rows[i][2].ToString();
                        string descripcion = tabla3.Rows[i][4].ToString();
                        double monto = Convert.ToDouble(tabla3.Rows[i][3].ToString());
                        dataCosto.Rows.Add(fecha, idfactura, nombre, descripcion, monto);
                        total = total + monto;
                    }
                }

                labtotal.Text = Convert.ToString(total);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se Produjo un Erro >" + ex.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.enlace().Close();
            }

            
    }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        

        private void button_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //--------------METODO PARA 
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm2= new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm2, new Rectangle(0, 0, this.pictureBox2.Width, this.pictureBox2.Height));
            e.Graphics.DrawImage(bm2, 600, 10);
            e.Graphics.DrawString(labcontrol.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(250, 50));
            e.Graphics.DrawString(labelIdentidad.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 120));
            e.Graphics.DrawString(labidentidad.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(190, 120));
            e.Graphics.DrawString(labelNombrecliente.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 170));
            e.Graphics.DrawString(labnombre.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(280, 170));
            e.Graphics.DrawString("Estado de Resultado", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(320, 230));
            Bitmap bm = new Bitmap(this.dataCosto.Width, this.dataCosto.Height);
            dataCosto.DrawToBitmap(bm, new Rectangle(0, 0, this.dataCosto.Width, this.dataCosto.Height));
            e.Graphics.DrawImage(bm, 60, 260);
            e.Graphics.DrawString(label1.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(320, 630));
            e.Graphics.DrawString(labtotal.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(620, 630));
        }
    }
}
