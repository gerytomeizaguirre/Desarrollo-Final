namespace administracion1
{
    partial class formVerproyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVerproyecto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelIdentidad = new System.Windows.Forms.Label();
            this.labelNombrecliente = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 131);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(458, 82);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(288, 33);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Detalle de Proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Control de Gastos por Proyecto";
            // 
            // labelIdentidad
            // 
            this.labelIdentidad.AutoSize = true;
            this.labelIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdentidad.Location = new System.Drawing.Point(89, 70);
            this.labelIdentidad.Name = "labelIdentidad";
            this.labelIdentidad.Size = new System.Drawing.Size(102, 24);
            this.labelIdentidad.TabIndex = 3;
            this.labelIdentidad.Text = "Identidad:";
            // 
            // labelNombrecliente
            // 
            this.labelNombrecliente.AutoSize = true;
            this.labelNombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombrecliente.Location = new System.Drawing.Point(89, 105);
            this.labelNombrecliente.Name = "labelNombrecliente";
            this.labelNombrecliente.Size = new System.Drawing.Size(197, 24);
            this.labelNombrecliente.TabIndex = 4;
            this.labelNombrecliente.Text = "Nombre del Cliente:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(967, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 141);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total de Gastos del Proyecto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Back
            // 
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(78, 714);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(75, 60);
            this.button_Back.TabIndex = 7;
            this.button_Back.UseVisualStyleBackColor = true;
            // 
            // button_Print
            // 
            this.button_Print.Image = ((System.Drawing.Image)(resources.GetObject("button_Print.Image")));
            this.button_Print.Location = new System.Drawing.Point(1092, 708);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(85, 73);
            this.button_Print.TabIndex = 8;
            this.button_Print.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelIdentidad);
            this.groupBox1.Controls.Add(this.labelNombrecliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(78, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 519);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // formVerproyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 823);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formVerproyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelIdentidad;
        private System.Windows.Forms.Label labelNombrecliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}