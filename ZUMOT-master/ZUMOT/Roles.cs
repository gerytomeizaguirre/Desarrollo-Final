using administracion1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUMOT
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }
        conexion database = new conexion();
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Roles_Load(object sender, EventArgs e)
        {
            tabla();
        }

        public void tabla()
        {
            SqlConnection cn = conexion.enlace();
            DataTable dw = new DataTable();
            {
                string query = " select id_rol, descripcion_puesto from rol";

                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dw);
                dgvroles.DataSource = dw;
            }

            cn.Close();
        }
        

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtcodigorol.Text = "";
            txtnombrerol.Text = "";
            lblad.Visible = false;
        }

        private void txtcodigorol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigorol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros mayores a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            lblad.Visible = true;
        }
        
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            if (txtcodigorol.Text == "")
                MessageBox.Show("NO SE INGRESO NINGUN CODIGO", "ALERTA");
            else
            {
                try
                {
                    SqlConnection cn = conexion.enlace();
                    {
                        string queryn = "SELECT descripcion_puesto FROM rol WHERE id_rol= @id";
                        SqlCommand cmd = new SqlCommand(queryn, cn);
                        cmd.Parameters.AddWithValue("@id", txtcodigorol.Text);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtnombrerol.Text = Convert.ToString(reader["descripcion_puesto"]);

                        }
                        cn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    MessageBox.Show("NO SE ENCONTRO REGISTRO", "ALERTA");
                }
                lblad.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtcodigorol.Text == "")
            {
                MessageBox.Show("CODIGO VACIO", "ALERTA");
            }
            else
            {
                try
                {
                    SqlConnection cn = conexion.enlace();
                    {
                        string elim = @"DELETE from rol WHERE id_rol= @id";
                        SqlCommand cmd = new SqlCommand(elim, cn);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtcodigorol.Text));
                        cmd.ExecuteNonQuery();
                        tabla();

                    }
                    cn.Close();
                    MessageBox.Show("ELIMINADO DE LA BASE DE DATOS", "REALIZADO");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    MessageBox.Show("NO SE PUDO ELIMINAR", "ALERTA");
                }
            }
            lblad.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
             id_general.idx = Convert.ToInt32(txtcodigorol.Text);
            conexion cn = new conexion();
            if (txtcodigorol.Text == "")
                MessageBox.Show("NO SE INGRESO NINGUN CODIGO", "ALERTA");
            else if (cn.Actualizarrol((txtnombrerol.Text), id_general.idx) > 0)
            {

                MessageBox.Show("ROL ACTUALIZADO");
                tabla();
            }
            lblad.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conexion cn = new conexion();
            cn.guardarrol(txtnombrerol.Text);
            tabla();
            lblad.Visible = false;
        }

        private void brnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

