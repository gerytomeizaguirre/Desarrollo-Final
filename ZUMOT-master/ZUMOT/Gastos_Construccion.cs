using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administracion1
{
    public partial class Gastos_Construccion : Form
    {
        public Gastos_Construccion()
        {
            InitializeComponent();
        }

        private void button_Home_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
