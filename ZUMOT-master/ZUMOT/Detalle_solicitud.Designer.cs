namespace ZUMOT
{
    partial class Detalle_solicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_solicitud));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtId_cli = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txttiposoli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(115, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 55;
            // 
            // txtId_cli
            // 
            this.txtId_cli.Enabled = false;
            this.txtId_cli.Location = new System.Drawing.Point(112, 68);
            this.txtId_cli.Name = "txtId_cli";
            this.txtId_cli.Size = new System.Drawing.Size(100, 20);
            this.txtId_cli.TabIndex = 54;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(389, 68);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 53;
            // 
            // txttiposoli
            // 
            this.txttiposoli.Enabled = false;
            this.txttiposoli.Location = new System.Drawing.Point(389, 106);
            this.txttiposoli.Name = "txttiposoli";
            this.txttiposoli.Size = new System.Drawing.Size(100, 20);
            this.txttiposoli.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nombre cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Tipo de solicitud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Id de cliente:";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(605, 366);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 47;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(486, 366);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 46;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 165);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(477, 175);
            this.dgv1.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Detalle_solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 397);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtId_cli);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txttiposoli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Detalle_solicitud";
            this.Text = "Detalle_solicitud";
            this.Load += new System.EventHandler(this.Detalle_solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtId_cli;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txttiposoli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}