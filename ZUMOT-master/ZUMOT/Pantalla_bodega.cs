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
    public partial class Pantalla_bodega : Form
    {
        public Pantalla_bodega()
        {
            InitializeComponent();
        }

        private void btnver_soli_Click(object sender, EventArgs e)
        {
            Solicitudes_pendientes soli = new Solicitudes_pendientes();
            soli.Show();
            this.Hide();
        }

        private void btnver_INVEN_Click(object sender, EventArgs e)
        {
            inventario_bodega inb = new inventario_bodega();
            inb.Show();
            this.Hide();
        }
    }
}
