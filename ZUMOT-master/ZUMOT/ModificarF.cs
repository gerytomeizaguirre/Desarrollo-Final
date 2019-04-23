using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pantallas
{
    public partial class ModificarF : Form
    {
        public ModificarF()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AgregarD Nuevo = new AgregarD();
            Nuevo.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarF Nuevo = new AgregarF();
            Nuevo.ShowDialog();
        }
    }
}
