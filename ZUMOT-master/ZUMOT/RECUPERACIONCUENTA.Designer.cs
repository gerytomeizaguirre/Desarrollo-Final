namespace WindowsFormsApp1
{
    partial class RECUPERACIONCUENTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RECUPERACIONCUENTA));
            this.lblusurecu = new System.Windows.Forms.Label();
            this.lbltitulorecu = new System.Windows.Forms.Label();
            this.lblpreguuno = new System.Windows.Forms.Label();
            this.lblpregudos = new System.Windows.Forms.Label();
            this.txtpregudos = new System.Windows.Forms.TextBox();
            this.txtpreguuno = new System.Windows.Forms.TextBox();
            this.txtusuariorecu = new System.Windows.Forms.TextBox();
            this.btnrecu = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.gpregunta = new System.Windows.Forms.GroupBox();
            this.lblerror1 = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grobox2 = new System.Windows.Forms.GroupBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblconfcont = new System.Windows.Forms.Label();
            this.lblnuecont = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gpregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grobox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusurecu
            // 
            this.lblusurecu.AutoSize = true;
            this.lblusurecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusurecu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusurecu.Location = new System.Drawing.Point(112, 181);
            this.lblusurecu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusurecu.Name = "lblusurecu";
            this.lblusurecu.Size = new System.Drawing.Size(80, 16);
            this.lblusurecu.TabIndex = 0;
            this.lblusurecu.Text = "USUARIO:";
            // 
            // lbltitulorecu
            // 
            this.lbltitulorecu.AutoSize = true;
            this.lbltitulorecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulorecu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitulorecu.Location = new System.Drawing.Point(79, 261);
            this.lbltitulorecu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulorecu.Name = "lbltitulorecu";
            this.lbltitulorecu.Size = new System.Drawing.Size(577, 25);
            this.lbltitulorecu.TabIndex = 1;
            this.lbltitulorecu.Text = "PREGUNTAS PARA RECUPERACIÓN DE LA CUENTA";
            this.lbltitulorecu.Click += new System.EventHandler(this.lbltitulorecu_Click);
            // 
            // lblpreguuno
            // 
            this.lblpreguuno.AutoSize = true;
            this.lblpreguuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreguuno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpreguuno.Location = new System.Drawing.Point(24, 13);
            this.lblpreguuno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpreguuno.Name = "lblpreguuno";
            this.lblpreguuno.Size = new System.Drawing.Size(237, 20);
            this.lblpreguuno.TabIndex = 2;
            this.lblpreguuno.Text = "¿Cuál es tu comida favorita?";
            this.lblpreguuno.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblpregudos
            // 
            this.lblpregudos.AutoSize = true;
            this.lblpregudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregudos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpregudos.Location = new System.Drawing.Point(24, 84);
            this.lblpregudos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpregudos.Name = "lblpregudos";
            this.lblpregudos.Size = new System.Drawing.Size(357, 20);
            this.lblpregudos.TabIndex = 3;
            this.lblpregudos.Text = "¿Cuál es el nombre de tu primera mascota?";
            // 
            // txtpregudos
            // 
            this.txtpregudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpregudos.Location = new System.Drawing.Point(28, 106);
            this.txtpregudos.Margin = new System.Windows.Forms.Padding(2);
            this.txtpregudos.MaxLength = 30;
            this.txtpregudos.Name = "txtpregudos";
            this.txtpregudos.Size = new System.Drawing.Size(318, 22);
            this.txtpregudos.TabIndex = 4;
            this.txtpregudos.TextChanged += new System.EventHandler(this.txtpregudos_TextChanged);
            // 
            // txtpreguuno
            // 
            this.txtpreguuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreguuno.Location = new System.Drawing.Point(27, 35);
            this.txtpreguuno.Margin = new System.Windows.Forms.Padding(2);
            this.txtpreguuno.MaxLength = 30;
            this.txtpreguuno.Name = "txtpreguuno";
            this.txtpreguuno.Size = new System.Drawing.Size(319, 22);
            this.txtpreguuno.TabIndex = 5;
            this.txtpreguuno.TextChanged += new System.EventHandler(this.txtpreguuno_TextChanged);
            // 
            // txtusuariorecu
            // 
            this.txtusuariorecu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuariorecu.Location = new System.Drawing.Point(196, 177);
            this.txtusuariorecu.Margin = new System.Windows.Forms.Padding(2);
            this.txtusuariorecu.MaxLength = 30;
            this.txtusuariorecu.Name = "txtusuariorecu";
            this.txtusuariorecu.Size = new System.Drawing.Size(244, 22);
            this.txtusuariorecu.TabIndex = 6;
            // 
            // btnrecu
            // 
            this.btnrecu.Location = new System.Drawing.Point(501, 84);
            this.btnrecu.Margin = new System.Windows.Forms.Padding(2);
            this.btnrecu.Name = "btnrecu";
            this.btnrecu.Size = new System.Drawing.Size(75, 59);
            this.btnrecu.TabIndex = 9;
            this.btnrecu.Text = "Verificar";
            this.btnrecu.UseVisualStyleBackColor = true;
            this.btnrecu.Click += new System.EventHandler(this.btnrecu_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(32, 681);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 59);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpregunta
            // 
            this.gpregunta.Controls.Add(this.lblerror1);
            this.gpregunta.Controls.Add(this.lblerror);
            this.gpregunta.Controls.Add(this.txtpreguuno);
            this.gpregunta.Controls.Add(this.lblpreguuno);
            this.gpregunta.Controls.Add(this.lblpregudos);
            this.gpregunta.Controls.Add(this.txtpregudos);
            this.gpregunta.Controls.Add(this.btnrecu);
            this.gpregunta.Location = new System.Drawing.Point(94, 305);
            this.gpregunta.Name = "gpregunta";
            this.gpregunta.Size = new System.Drawing.Size(623, 151);
            this.gpregunta.TabIndex = 11;
            this.gpregunta.TabStop = false;
            this.gpregunta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblerror1
            // 
            this.lblerror1.AutoSize = true;
            this.lblerror1.Location = new System.Drawing.Point(366, 111);
            this.lblerror1.Name = "lblerror1";
            this.lblerror1.Size = new System.Drawing.Size(0, 13);
            this.lblerror1.TabIndex = 7;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(366, 40);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recuperación de Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 133);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(485, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // grobox2
            // 
            this.grobox2.Controls.Add(this.lbuser);
            this.grobox2.Controls.Add(this.label2);
            this.grobox2.Controls.Add(this.lblconfcont);
            this.grobox2.Controls.Add(this.lblnuecont);
            this.grobox2.Controls.Add(this.txtContrasenia);
            this.grobox2.Controls.Add(this.txtConfirmar);
            this.grobox2.Location = new System.Drawing.Point(94, 474);
            this.grobox2.Name = "grobox2";
            this.grobox2.Size = new System.Drawing.Size(623, 162);
            this.grobox2.TabIndex = 24;
            this.grobox2.TabStop = false;
            this.grobox2.Enter += new System.EventHandler(this.grobox2_Enter);
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(81, 26);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(0, 13);
            this.lbuser.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(210, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "error";
            this.label2.Visible = false;
            // 
            // lblconfcont
            // 
            this.lblconfcont.AutoSize = true;
            this.lblconfcont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblconfcont.ForeColor = System.Drawing.Color.Brown;
            this.lblconfcont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblconfcont.Location = new System.Drawing.Point(18, 94);
            this.lblconfcont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblconfcont.Name = "lblconfcont";
            this.lblconfcont.Size = new System.Drawing.Size(190, 20);
            this.lblconfcont.TabIndex = 3;
            this.lblconfcont.Text = "Confirmar Contraseña:";
            // 
            // lblnuecont
            // 
            this.lblnuecont.AutoSize = true;
            this.lblnuecont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblnuecont.ForeColor = System.Drawing.Color.Brown;
            this.lblnuecont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnuecont.Location = new System.Drawing.Point(41, 42);
            this.lblnuecont.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnuecont.Name = "lblnuecont";
            this.lblnuecont.Size = new System.Drawing.Size(167, 20);
            this.lblnuecont.TabIndex = 1;
            this.lblnuecont.Text = "Nueva Contraseña: ";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtContrasenia.Location = new System.Drawing.Point(212, 40);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.MaxLength = 30;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(212, 22);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtConfirmar.Location = new System.Drawing.Point(212, 92);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmar.MaxLength = 30;
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(212, 22);
            this.txtConfirmar.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(613, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RECUPERACIONCUENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(775, 771);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grobox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpregunta);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtusuariorecu);
            this.Controls.Add(this.lbltitulorecu);
            this.Controls.Add(this.lblusurecu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RECUPERACIONCUENTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación Cuenta";
            this.Load += new System.EventHandler(this.RECUPERACIONCUENTA_Load);
            this.gpregunta.ResumeLayout(false);
            this.gpregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grobox2.ResumeLayout(false);
            this.grobox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusurecu;
        private System.Windows.Forms.Label lbltitulorecu;
        private System.Windows.Forms.Label lblpreguuno;
        private System.Windows.Forms.Label lblpregudos;
        private System.Windows.Forms.TextBox txtpregudos;
        private System.Windows.Forms.TextBox txtpreguuno;
        private System.Windows.Forms.TextBox txtusuariorecu;
        private System.Windows.Forms.Button btnrecu;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.GroupBox gpregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblerror1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grobox2;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblconfcont;
        private System.Windows.Forms.Label lblnuecont;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button button2;
    }
}