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
    public partial class Gastos_Administrativos : Form
    {
        double total = 0;
        public Gastos_Administrativos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gastos_Administrativos_Load(object sender, EventArgs e)
        {
            mostrarGastos(GastosAdmi);
            
        }

        public void mostrarGastos(DataGridView gastos)
        {
            SqlDataAdapter data = new SqlDataAdapter("select fecha, id_Factura_administrativa, Casa_comercial, Descripcion_gasto, Valor_gasto from gastos_administrativos", conexion.enlace());
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            if(tabla.Rows.Count > 0)
            {
                for(int i=0; i<tabla.Rows.Count; i++)
                {
                    string fecha = tabla.Rows[i][0].ToString();
                    string idfactura = tabla.Rows[i][1].ToString();
                    string casa = tabla.Rows[i][2].ToString();
                    string descripcion = tabla.Rows[i][3].ToString();
                    double valor = Convert.ToDouble(tabla.Rows[i][4].ToString());
                    total = total + valor;
                    GastosAdmi.Rows.Add(fecha, idfactura, casa, descripcion, valor);
                }
                
            }
            labTotal.Text =Convert.ToString(total);
        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            Bitmap bm2 = new Bitmap(this.imagenZumot.Width, this.imagenZumot.Height);
            imagenZumot.DrawToBitmap(bm2, new Rectangle(0, 0, this.imagenZumot.Width, this.imagenZumot.Height));
            e.Graphics.DrawImage(bm2, 600, 10);
            e.Graphics.DrawString(labGastos.Text, new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new PointF(250, 50));
            e.Graphics.DrawString("Estado de Resultado", new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(320, 120));
            Bitmap bm = new Bitmap(this.GastosAdmi.Width, this.GastosAdmi.Height);
            GastosAdmi.DrawToBitmap(bm, new Rectangle(0, 0, this.GastosAdmi.Width, this.GastosAdmi.Height));
            e.Graphics.DrawImage(bm, 25, 160);
            e.Graphics.DrawString(label7.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(300, 670));
            e.Graphics.DrawString(labTotal.Text, new Font("Times New Roman", 16, FontStyle.Bold), Brushes.Black, new PointF(640, 670));

        }
        

        private void button_Print_Click(object sender, EventArgs e)
        {

           if (printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GastosAdmi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
