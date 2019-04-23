namespace ZUMOT
{
    partial class Pantalla_bodega
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_bodega));
            this.btnregresar = new System.Windows.Forms.Button();
            this.btnver_INVEN = new System.Windows.Forms.Button();
            this.btnver_soli = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(194, 289);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 16;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            // 
            // btnver_INVEN
            // 
            this.btnver_INVEN.Location = new System.Drawing.Point(65, 194);
            this.btnver_INVEN.Name = "btnver_INVEN";
            this.btnver_INVEN.Size = new System.Drawing.Size(204, 23);
            this.btnver_INVEN.TabIndex = 15;
            this.btnver_INVEN.Text = "Ver Inventario Existente";
            this.btnver_INVEN.UseVisualStyleBackColor = true;
            this.btnver_INVEN.Click += new System.EventHandler(this.btnver_INVEN_Click);
            // 
            // btnver_soli
            // 
            this.btnver_soli.Location = new System.Drawing.Point(65, 134);
            this.btnver_soli.Name = "btnver_soli";
            this.btnver_soli.Size = new System.Drawing.Size(204, 23);
            this.btnver_soli.TabIndex = 14;
            this.btnver_soli.Text = "Ver solicitudes pendientes";
            this.btnver_soli.UseVisualStyleBackColor = true;
            this.btnver_soli.Click += new System.EventHandler(this.btnver_soli_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(232, 30);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "Fecha";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(21, 30);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 12;
            this.lblusuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pantalla_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 339);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnver_INVEN);
            this.Controls.Add(this.btnver_soli);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pantalla_bodega";
            this.Text = "Pantalla_bodega";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnver_INVEN;
        private System.Windows.Forms.Button btnver_soli;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblusuario;
    }
}