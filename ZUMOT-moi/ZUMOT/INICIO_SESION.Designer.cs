namespace WindowsFormsApp1
{
    partial class INICIO_SESION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO_SESION));
            this.lbltitulo_inicio = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.lblrecuperacion = new System.Windows.Forms.Label();
            this.ingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo_inicio
            // 
            resources.ApplyResources(this.lbltitulo_inicio, "lbltitulo_inicio");
            this.lbltitulo_inicio.ForeColor = System.Drawing.Color.Black;
            this.lbltitulo_inicio.Name = "lbltitulo_inicio";
            this.lbltitulo_inicio.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusuario
            // 
            resources.ApplyResources(this.lblusuario, "lblusuario");
            this.lblusuario.ForeColor = System.Drawing.Color.Brown;
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtusuario, "txtusuario");
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // lblcontrasena
            // 
            resources.ApplyResources(this.lblcontrasena, "lblcontrasena");
            this.lblcontrasena.ForeColor = System.Drawing.Color.Brown;
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txtcontrasena, "txtcontrasena");
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.TextChanged += new System.EventHandler(this.txtcontrasena_TextChanged);
            // 
            // lblrecuperacion
            // 
            resources.ApplyResources(this.lblrecuperacion, "lblrecuperacion");
            this.lblrecuperacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblrecuperacion.Name = "lblrecuperacion";
            this.lblrecuperacion.Click += new System.EventHandler(this.lblrecuperacion_Click);
            // 
            // ingresar
            // 
            this.ingresar.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.ingresar, "ingresar");
            this.ingresar.Name = "ingresar";
            this.ingresar.UseVisualStyleBackColor = false;
            this.ingresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcontrasena);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblrecuperacion);
            this.groupBox1.Controls.Add(this.txtusuario);
            this.groupBox1.Controls.Add(this.txtcontrasena);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // INICIO_SESION
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltitulo_inicio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ingresar);
            this.Name = "INICIO_SESION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo_inicio;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Label lblrecuperacion;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

