namespace pantallas
{
    partial class AgregarF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarF));
            this.Materiales = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listaMateriales = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.grupoDato = new System.Windows.Forms.GroupBox();
            this.txtcasacomercial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechaTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.grupoCliente = new System.Windows.Forms.GroupBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listaRegistro = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.casaExistencia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.datefecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.existenciaFactura = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.enviarExistencia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Materiales.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriales)).BeginInit();
            this.grupoDato.SuspendLayout();
            this.grupoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistro)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Materiales
            // 
            this.Materiales.Controls.Add(this.tabPage1);
            this.Materiales.Controls.Add(this.tabPage3);
            this.Materiales.Location = new System.Drawing.Point(0, 1);
            this.Materiales.Name = "Materiales";
            this.Materiales.SelectedIndex = 0;
            this.Materiales.Size = new System.Drawing.Size(912, 966);
            this.Materiales.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listaMateriales);
            this.tabPage1.Controls.Add(this.button_Buscar);
            this.tabPage1.Controls.Add(this.grupoDato);
            this.tabPage1.Controls.Add(this.grupoCliente);
            this.tabPage1.Controls.Add(this.button_Home);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 940);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyecto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lista de Materiales";
            // 
            // listaMateriales
            // 
            this.listaMateriales.AllowUserToAddRows = false;
            this.listaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.tipoM,
            this.Material,
            this.Cantidad,
            this.Precio});
            this.listaMateriales.Location = new System.Drawing.Point(22, 560);
            this.listaMateriales.Name = "listaMateriales";
            this.listaMateriales.Size = new System.Drawing.Size(813, 190);
            this.listaMateriales.TabIndex = 59;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 70;
            // 
            // tipoM
            // 
            this.tipoM.HeaderText = "Tipo de Material";
            this.tipoM.Name = "tipoM";
            this.tipoM.Width = 250;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.Width = 250;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("button_Buscar.Image")));
            this.button_Buscar.Location = new System.Drawing.Point(725, 197);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(64, 68);
            this.button_Buscar.TabIndex = 58;
            this.button_Buscar.UseVisualStyleBackColor = true;
            // 
            // grupoDato
            // 
            this.grupoDato.Controls.Add(this.txtcasacomercial);
            this.grupoDato.Controls.Add(this.label12);
            this.grupoDato.Controls.Add(this.label6);
            this.grupoDato.Controls.Add(this.fechaTime);
            this.grupoDato.Controls.Add(this.label7);
            this.grupoDato.Controls.Add(this.txtfactura);
            this.grupoDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoDato.Location = new System.Drawing.Point(81, 307);
            this.grupoDato.Name = "grupoDato";
            this.grupoDato.Size = new System.Drawing.Size(600, 178);
            this.grupoDato.TabIndex = 57;
            this.grupoDato.TabStop = false;
            this.grupoDato.Text = "DATOS DE FACTURA";
            // 
            // txtcasacomercial
            // 
            this.txtcasacomercial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcasacomercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcasacomercial.Location = new System.Drawing.Point(209, 123);
            this.txtcasacomercial.Name = "txtcasacomercial";
            this.txtcasacomercial.Size = new System.Drawing.Size(336, 26);
            this.txtcasacomercial.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Casa Comercial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha";
            // 
            // fechaTime
            // 
            this.fechaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaTime.Location = new System.Drawing.Point(209, 29);
            this.fechaTime.Name = "fechaTime";
            this.fechaTime.Size = new System.Drawing.Size(336, 26);
            this.fechaTime.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "N° Factura";
            // 
            // txtfactura
            // 
            this.txtfactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfactura.Location = new System.Drawing.Point(209, 75);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(336, 26);
            this.txtfactura.TabIndex = 34;
            // 
            // grupoCliente
            // 
            this.grupoCliente.BackColor = System.Drawing.Color.Transparent;
            this.grupoCliente.Controls.Add(this.labNombre);
            this.grupoCliente.Controls.Add(this.label3);
            this.grupoCliente.Controls.Add(this.label5);
            this.grupoCliente.Controls.Add(this.txtidentidad);
            this.grupoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCliente.Location = new System.Drawing.Point(81, 168);
            this.grupoCliente.Name = "grupoCliente";
            this.grupoCliente.Size = new System.Drawing.Size(600, 117);
            this.grupoCliente.TabIndex = 56;
            this.grupoCliente.TabStop = false;
            this.grupoCliente.Text = "DATOS DEL CLIENTE";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(213, 79);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(140, 20);
            this.labNombre.TabIndex = 30;
            this.labNombre.Text = "Nombre del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Identidad del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre del Cliente";
            // 
            // txtidentidad
            // 
            this.txtidentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentidad.Location = new System.Drawing.Point(217, 29);
            this.txtidentidad.MaxLength = 13;
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(336, 26);
            this.txtidentidad.TabIndex = 29;
            // 
            // button_Home
            // 
            this.button_Home.Image = ((System.Drawing.Image)(resources.GetObject("button_Home.Image")));
            this.button_Home.Location = new System.Drawing.Point(22, 824);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(75, 69);
            this.button_Home.TabIndex = 55;
            this.button_Home.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(773, 824);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(732, 439);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 56);
            this.button9.TabIndex = 53;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(117, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 131);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(639, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 129);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 31);
            this.label8.TabIndex = 48;
            this.label8.Text = "Registrar Para Proyecto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(703, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Agregar detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 49;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listaRegistro);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.enviarExistencia);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 940);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Existencia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listaRegistro
            // 
            this.listaRegistro.AllowUserToAddRows = false;
            this.listaRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.listaRegistro.Location = new System.Drawing.Point(33, 459);
            this.listaRegistro.Name = "listaRegistro";
            this.listaRegistro.Size = new System.Drawing.Size(813, 190);
            this.listaRegistro.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo de Material";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Material";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.casaExistencia);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.datefecha);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.existenciaFactura);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(63, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 252);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Factura";
            // 
            // casaExistencia
            // 
            this.casaExistencia.Location = new System.Drawing.Point(167, 180);
            this.casaExistencia.Name = "casaExistencia";
            this.casaExistencia.Size = new System.Drawing.Size(339, 26);
            this.casaExistencia.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 20);
            this.label14.TabIndex = 61;
            this.label14.Text = "Casa Comercial";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "Fecha";
            // 
            // datefecha
            // 
            this.datefecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefecha.Location = new System.Drawing.Point(167, 45);
            this.datefecha.Name = "datefecha";
            this.datefecha.Size = new System.Drawing.Size(339, 26);
            this.datefecha.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 51;
            this.label10.Text = "N° Factura";
            // 
            // existenciaFactura
            // 
            this.existenciaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existenciaFactura.Location = new System.Drawing.Point(167, 113);
            this.existenciaFactura.Name = "existenciaFactura";
            this.existenciaFactura.Size = new System.Drawing.Size(339, 26);
            this.existenciaFactura.TabIndex = 52;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(33, 728);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 69);
            this.button4.TabIndex = 68;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // enviarExistencia
            // 
            this.enviarExistencia.Image = ((System.Drawing.Image)(resources.GetObject("enviarExistencia.Image")));
            this.enviarExistencia.Location = new System.Drawing.Point(754, 728);
            this.enviarExistencia.Name = "enviarExistencia";
            this.enviarExistencia.Size = new System.Drawing.Size(75, 69);
            this.enviarExistencia.TabIndex = 67;
            this.enviarExistencia.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(734, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 56);
            this.button3.TabIndex = 66;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(652, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(222, 129);
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(105, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 131);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 31);
            this.label9.TabIndex = 62;
            this.label9.Text = "Registrar Para Existencia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(709, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "Agregar detalle";
            // 
            // AgregarF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 939);
            this.Controls.Add(this.Materiales);
            this.Name = "AgregarF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regstrar Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Materiales.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMateriales)).EndInit();
            this.grupoDato.ResumeLayout(false);
            this.grupoDato.PerformLayout();
            this.grupoCliente.ResumeLayout(false);
            this.grupoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRegistro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Materiales;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView listaMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.GroupBox grupoDato;
        private System.Windows.Forms.TextBox txtcasacomercial;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechaTime;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.GroupBox grupoCliente;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView listaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox casaExistencia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datefecha;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox existenciaFactura;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button enviarExistencia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}

