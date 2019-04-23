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
    public partial class AgregarF : Form
    {
        public AgregarF()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarD Nuevo = new AgregarD();
            Nuevo.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Existencia Nuevo = new Existencia();
            Nuevo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarD Nuevo = new AgregarD();
            Nuevo.ShowDialog();
        }
    }
}
