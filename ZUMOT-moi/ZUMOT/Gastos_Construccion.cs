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

namespace administracion1
{
    public partial class Gastos_Construccion : Form
    {
        private double total;
        public Gastos_Construccion()
        {
            InitializeComponent();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gastos_Construccion_Load(object sender, EventArgs e)
        {
            datos();
        }

        public void datos()
        {
            conexion.enlace();
            total = 0;
            SqlDataAdapter data = new SqlDataAdapter("select a.fecha_factura, a.id_factura, a.nombre_casa_comercial, a.identidad_cliente, b.subtotal_compra, c.nombre_material from compra a inner join detalle_compra b on a.id_factura = b.id_factura inner join material c on b.id_material = c.id_material", conexion.enlace());
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            SqlDataAdapter datos2 = new SqlDataAdapter("select a.fecha_factura, a.id_factura, a.nombre_casa_comercial, a.identidad_cliente, b.monto, b.descripcion_mano_de_obra from compra a inner join mano_obra b on a.id_factura = b.id_facturaMano", conexion.enlace());
            DataTable tabla2 = new DataTable();
            datos2.Fill(tabla2);
            if (tabla.Rows.Count > 0)
            {

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    string fecha = tabla.Rows[i][0].ToString();
                    string idfactura = tabla.Rows[i][1].ToString();
                    string nombre = tabla.Rows[i][2].ToString();
                    string identidad = tabla.Rows[i][3].ToString();
                    string material = tabla.Rows[i][5].ToString();
                    double subtotal = Convert.ToDouble(tabla.Rows[i][4].ToString());
                    total = total + subtotal;
                    dataConstruccion.Rows.Add(fecha, idfactura, nombre, material, identidad, subtotal);
                }
               
            }
            if(tabla2.Rows.Count > 0)
            {
                for(int i=0; i < tabla2.Rows.Count; i++)
                {
                    string fecha = tabla2.Rows[i][0].ToString();
                    string idfactura = tabla2.Rows[i][1].ToString();
                    string nombre = tabla2.Rows[i][2].ToString();
                    string identidad = tabla2.Rows[i][3].ToString();
                    string descripcion = tabla2.Rows[i][5].ToString();
                    double monto = Convert.ToDouble(tabla2.Rows[i][4].ToString());
                    dataConstruccion.Rows.Add(fecha, idfactura, nombre, descripcion, identidad, monto);
                    total = total + monto;
                }
            }

            labTotal.Text = Convert.ToString(total);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm2 = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm2, new Rectangle(0, 0, this.pictureBox2.Width, this.pictureBox2.Height));
            e.Graphics.DrawImage(bm2, 600, 10);
            e.Graphics.DrawString(label1.Text, new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(250, 50));
            e.Graphics.DrawString("Estado de Resultado", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(320, 120));
            Bitmap bm = new Bitmap(this.dataConstruccion.Width, this.dataConstruccion.Height);
            dataConstruccion.DrawToBitmap(bm, new Rectangle(0, 0, this.dataConstruccion.Width, this.dataConstruccion.Height));
            e.Graphics.DrawImage(bm, 50, 260);
            e.Graphics.DrawString(label7.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(300, 630));
            e.Graphics.DrawString(labTotal.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(620, 630));
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
