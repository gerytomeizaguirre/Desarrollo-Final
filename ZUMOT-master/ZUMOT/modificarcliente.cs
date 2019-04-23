using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas_de_clientes
{
    public partial class modificarcliente : Form
    {
        public modificarcliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardarmodi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cambios Guardados!", "MENSAJE");
        }

        private void modificarcliente_Load(object sender, EventArgs e)
        {

        }

            
        
          
    }
}
