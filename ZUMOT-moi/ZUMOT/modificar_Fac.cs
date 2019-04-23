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
using ZUMOT;

namespace administracion1
{
    public partial class modificar_Fac : Form
    {
        conexion conectar = new conexion();

        public modificar_Fac()
        {
            InitializeComponent();
        }

        private void Modificar_Fac_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            btnDelete.Enabled = false;
           
        }

       

        private void button_Home_Click(object sender, EventArgs e)
        {
            if(txtnf.Text != "")
            {
                home();
            }
            else
            {
                this.Close();
            }
        }

        public void Buscarf(string ID)
        {
            if (ID == "")
            {
                MessageBox.Show("Campo Factura Vacio. \nIngrese un numero de Factura.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtnf.Clear();
                return;
            }
            try
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("Select Id_Factura_administrativa ,Casa_comercial,Descripcion_gasto, Valor_gasto,fecha from gastos_administrativos where Id_Factura_administrativa = @id_fact", conexion.enlace());
                comando.Parameters.AddWithValue("id_fact", ID);
                SqlDataAdapter dtadapter = new SqlDataAdapter(comando);
                DataTable datatabla = new DataTable();
                dtadapter.Fill(datatabla);
                if (datatabla.Rows.Count == 1)
                {
                    txtca.Text = datatabla.Rows[0][1].ToString();
                    txtdet.Text = datatabla.Rows[0][2].ToString();
                    txtva.Text = datatabla.Rows[0][3].ToString();
                    datefecha.Text = datatabla.Rows[0][4].ToString();
                    groupBox2.Enabled = true;
                    btnDelete.Enabled = true;
                    txtnf.Enabled = false;

                }
                else
                {
                    groupBox2.Enabled = false;

                    MessageBox.Show("El Numero de Factura no Existe. \nIngrese una Factura Existente.", "ADVERTENCIA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnf.Clear();
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


        public void limpiar()
        {
            txtnf.Clear();
            txtca.Clear();
            txtdet.Clear();
            txtva.Clear();
            groupBox2.Enabled = false;
            btnDelete.Enabled = false;
            txtnf.Enabled = true;
            
        }

        
        private void button_Buscar_Click_1(object sender, EventArgs e)
        {
            Buscarf(txtnf.Text);
        }

        private void button_Restart_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txtva.Text.Contains(".") == false)
            {
                txtva.Text = txtva.Text + ".00";
            }
            if (txtnf.Text == "" || txtca.Text == "" || txtdet.Text == "" || txtva.Text == "")
            {
                MessageBox.Show("Favor llenar todos los datos");
            }
            else if(conexion.validarPuntoReal(txtva.Text) == false || txtva.Text.StartsWith("0"))
            {
                MessageBox.Show("Campo Valor Incorrecto.\nFavor cambiar el valor, porque no es un numero real, de dos decimales", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtva.Clear();
            }
            else
            {
                if (conectar.EditarFact(int.Parse(txtnf.Text), double.Parse(txtva.Text), datefecha.Text, txtca.Text, txtdet.Text) > 0)
                {
                    MessageBox.Show("Factura Modificada Exitosamente", "CORRECTO!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    limpiar();

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

        private void button_Home_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        

        private void txtnf_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarNumeros(e);
        }

        private void txtca_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.validarLetras(e);
        }

        private void txtva_KeyPress(object sender, KeyPressEventArgs e)
        {
            conexion.ValidarReal(e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea eliminar la factura # " + txtnf.Text + "\nPerdera toda la informacion.", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexion.enlace();
                SqlCommand comando = new SqlCommand("delete from gastos_administrativos where Id_Factura_administrativa = '" + txtnf.Text + "'", conexion.enlace());
                comando.ExecuteNonQuery();
                limpiar();
                MessageBox.Show("Se ha Eliminado la factura Exitosamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            
        }
    }
}

