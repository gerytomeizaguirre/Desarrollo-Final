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
    public partial class solicitudes : Form
    {
        //SqlConnection conexiondata = new SqlConnection("Data Source=USER1-PC\\DAVID;Initial Catalog=Data_ZUMOT;Integrated Security=True");
        conexion conectar = new conexion();
        List<int[]> cmbRef = new List<int[]>();
        int soli = 1;
        int soli1 = 0,cmax;
        string desc = "Envio de Materiales";
        SqlDataReader dr;

        

        public solicitudes()
        {
            InitializeComponent();

        }

        conexion database = new conexion();
        
        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Solicitudes_Load(object sender, EventArgs e)
        {
            //lblcan.Visible = false;
            lblcan.Enabled = false;
            database.SeleccionTipoMaterial(comboBox1);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox1.Enabled = false;
            textBox2.Enabled = false;
            

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if(comboBox1.SelectedIndex > 0)
            {
                comboBox2.Enabled = true;
                database.SeleccionMaterial(comboBox2, comboBox1.Text);

            }
            else
            {
                comboBox2.Enabled = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void buscarUser(string user)
        {
            if (user == "")
            {
                MessageBox.Show("Campo de Usuario Vacio, Ingresar Usuario.");
                textBox1.Clear();
                return;
            }
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("Select identidad_cliente from proyecto where identidad_cliente = @user", conexion.enlace());
                comando.Parameters.AddWithValue("user", user);
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);

                if (datatabla.Rows.Count == 1)
                {
                   // id_general.idx = Convert.ToInt32(textBox1.Text);
                    textBox1.Enabled = false;
                    textBox2.Enabled = true;
                    comboBox1.Enabled = true;
                    string[] valores = conectar.captar(textBox1.Text);
                    label10.Text = valores[0];
                    label7.Text = textBox1.Text;
                    /*comboBox2.Enabled = true;*/

                }
                else
                {
                    MessageBox.Show("Usuario no encontrado, Verifique datos de Usuario.");
                    textBox1.Clear();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error de Sistema> " + e.ToString());
            }
            finally
            {
                conexion.enlace().Close();
            }
        }

        private void mostrarEvento()
        {
          

        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Campos Vacios, Revise su seleccion");
            }
            else
            {
                dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, textBox2.Text);

            }

            string tipom = comboBox1.Text;
            string mat = comboBox2.Text;

            MessageBox.Show("" + tipom + " " + mat, "Material");

            int contador = 0;
            conexion.enlace();
            try
            {


                SqlCommand comand = new SqlCommand("Select id_material, id_tipomaterial from material where nombre_material = '" + mat + "'", conexion.enlace());
                //SqlCommand cmd = new SqlCommand("Select id_material from material where nombre_material like '%'" + @mat + "", conexion.enlace());
                SqlDataAdapter data = new SqlDataAdapter(comand);
                DataTable tabla = new DataTable();
                data.Fill(tabla);

                if (tabla.Rows.Count > 0)
                {
                    MessageBox.Show("tipo Material: " + tipom + "Codigo tipo: " + tabla.Rows[0][1].ToString() + " ,Material: " + mat + " Codigo Material: " + tabla.Rows[0][0].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien:  " + ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((Convert.ToInt32(row.Cells[0].Value)) < 0)
                {
                    for (int i = 0; i < cmbRef.Count; i++)
                    {
                        int[] reg = cmbRef[i];
                        if (reg[0] == (int)row.Cells[0].Value)
                        {
                            cmbRef.Remove(reg);
                            i--;
                        }
                    }
                }


            }
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            buscarUser(this.textBox1.Text);
            //database.USUARIOLOGIN(label4, id_general.idx);      /*NOMBRE DE USUARIO*/
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Campos Vacios, Revise su seleccion");

            }

            string query = "Insert into solicitud (id_material, id_tipo_solicitud, fecha, comentario, id_tipo_material, identidad_cliente) values(@id_material, @id_tipo_solicitud, @fecha, @comentario, @id_tipo_material, @identidad_cliente)";
            conexion.enlace();
            SqlCommand agregar = new SqlCommand(query, conexion.enlace());

            //DataSet ds = new DataSet();

            //dataGridView1.DataSource = ds.Tables[0];

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              
                agregar.Parameters.Clear();

                //agregar.Parameters.AddWithValue("@id_solicitud", soli);
                //agregar.Parameters.AddWithValue("@id_fact",int.Parse(label10.Text));
                string[] valores = conectar.obte_mate(Convert.ToString(row.Cells["Material"].Value));
                agregar.Parameters.AddWithValue("@id_material", valores[0]);
                agregar.Parameters.AddWithValue("@id_tipo_solicitud", soli);
                agregar.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                agregar.Parameters.AddWithValue("@comentario", desc);
                string[] valore = conectar.obte_tipo(Convert.ToString(row.Cells["Tipo"].Value));
                agregar.Parameters.AddWithValue("@id_tipo_material",  valore[0]);
                agregar.Parameters.AddWithValue("@identidad_cliente", textBox1.Text);
                agregar.ExecuteNonQuery();
            }
            MessageBox.Show("Datos Agregados");

            this.Show();
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            solicitudes so = new solicitudes();
            so.Show();
            this.Close();
        }
        public static string Clamp(string text, int max)
        {
            if (String.IsNullOrWhiteSpace(text))
                return text;

            int val = Convert.ToInt16(text);

            if (val > max)
                val = max;

            return val.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string[] valore= conectar.cantidad(comboBox2.Text);
            lblcan.Text = valore[0];
            cmax =int.Parse( lblcan.Text);
            textBox2.Text = Clamp(textBox2.Text, cmax);
        }
        

    }
}
