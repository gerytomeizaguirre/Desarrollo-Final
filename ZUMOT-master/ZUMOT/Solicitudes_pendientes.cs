using administracion1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZUMOT
{
    public partial class Solicitudes_pendientes : Form
    {
        public Solicitudes_pendientes()
        {
            InitializeComponent();
        }
        

        conexion database = new conexion();
        public string id;
        private void btnregresar_Click(object sender, EventArgs e)
        {
            Pantalla_bodega pabo = new Pantalla_bodega();
            this.Hide();
            pabo.Show();
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {

            Detalle_solicitud deso = new Detalle_solicitud(id);
            deso.ShowDialog();

        }

        private void Solicitudes_pendientes_Load(object sender, EventArgs e)
        {
            btndetalle.Enabled = false;
            dgv1.DataSource = database.mostarsoli();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int inde = dgv1.CurrentRow.Index;
            txtcli_sele.Text = dgv1[6, inde].Value.ToString();
            btndetalle.Enabled = true;
            id = txtcli_sele.Text;
            

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
