namespace ZUMOT
{
    partial class Solicitudes_pendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitudes_pendientes));
            this.btndetalle = new System.Windows.Forms.Button();
            this.txtcli_sele = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(27, 115);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(75, 23);
            this.btndetalle.TabIndex = 45;
            this.btndetalle.Text = "Detalle";
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // txtcli_sele
            // 
            this.txtcli_sele.Enabled = false;
            this.txtcli_sele.Location = new System.Drawing.Point(131, 31);
            this.txtcli_sele.Name = "txtcli_sele";
            this.txtcli_sele.Size = new System.Drawing.Size(121, 20);
            this.txtcli_sele.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Id cliente selecionado:";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(337, 355);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 42;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(240, 355);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(75, 23);
            this.btnregresar.TabIndex = 41;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(27, 166);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(385, 150);
            this.dgv1.TabIndex = 40;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Solicitudes_pendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 381);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.txtcli_sele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Solicitudes_pendientes";
            this.Text = "Solicitudes_pendientes";
            this.Load += new System.EventHandler(this.Solicitudes_pendientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.TextBox txtcli_sele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}