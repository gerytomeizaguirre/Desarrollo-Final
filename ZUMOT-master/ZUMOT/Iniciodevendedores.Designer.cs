namespace PANTALLASVENDEDORES
{
    partial class Iniciodevendedores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iniciodevendedores));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarListaActualClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(903, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.modificarRegistroClienteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Clientes";
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = "Ingresar nuevo cliente";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // modificarRegistroClienteToolStripMenuItem
            // 
            this.modificarRegistroClienteToolStripMenuItem.Name = "modificarRegistroClienteToolStripMenuItem";
            this.modificarRegistroClienteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.modificarRegistroClienteToolStripMenuItem.Text = "Modificar registro de cliente";
            this.modificarRegistroClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroClienteToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarListaActualClientesToolStripMenuItem,
            this.modificarRegistroDeClienteToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.registrosToolStripMenuItem.Text = "Consultas";
            // 
            // visualizarListaActualClientesToolStripMenuItem
            // 
            this.visualizarListaActualClientesToolStripMenuItem.Name = "visualizarListaActualClientesToolStripMenuItem";
            this.visualizarListaActualClientesToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.visualizarListaActualClientesToolStripMenuItem.Text = "Visualizar lista actual clientes";
            this.visualizarListaActualClientesToolStripMenuItem.Click += new System.EventHandler(this.visualizarListaActualClientesToolStripMenuItem_Click);
            // 
            // modificarRegistroDeClienteToolStripMenuItem
            // 
            this.modificarRegistroDeClienteToolStripMenuItem.Name = "modificarRegistroDeClienteToolStripMenuItem";
            this.modificarRegistroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.modificarRegistroDeClienteToolStripMenuItem.Text = "Visualizar información de un cliente";
            this.modificarRegistroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroDeClienteToolStripMenuItem_Click);
            // 
            // Iniciodevendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Iniciodevendedores";
            this.Text = "PANTALLA DE INICIO VENDEDORES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarListaActualClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroDeClienteToolStripMenuItem;
    }
}

