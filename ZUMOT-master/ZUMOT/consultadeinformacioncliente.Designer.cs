namespace PANTALLASVENDEDORES
{
    partial class consultadeinformacioncliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultadeinformacioncliente));
            this.txtcodiconsucli = new System.Windows.Forms.TextBox();
            this.lblcodigoconcli = new System.Windows.Forms.Label();
            this.dtvcliconsu = new System.Windows.Forms.DataGridView();
            this.lbltituconsu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvcliconsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodiconsucli
            // 
            this.txtcodiconsucli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodiconsucli.Location = new System.Drawing.Point(182, 344);
            this.txtcodiconsucli.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodiconsucli.MaxLength = 13;
            this.txtcodiconsucli.Name = "txtcodiconsucli";
            this.txtcodiconsucli.Size = new System.Drawing.Size(251, 26);
            this.txtcodiconsucli.TabIndex = 0;
            this.txtcodiconsucli.TextChanged += new System.EventHandler(this.txtcodiconsucli_TextChanged);
            this.txtcodiconsucli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodiconsucli_KeyPress);
            // 
            // lblcodigoconcli
            // 
            this.lblcodigoconcli.AutoSize = true;
            this.lblcodigoconcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoconcli.Location = new System.Drawing.Point(43, 347);
            this.lblcodigoconcli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcodigoconcli.Name = "lblcodigoconcli";
            this.lblcodigoconcli.Size = new System.Drawing.Size(123, 20);
            this.lblcodigoconcli.TabIndex = 1;
            this.lblcodigoconcli.Text = "Id. de cliente: ";
            this.lblcodigoconcli.Click += new System.EventHandler(this.codigoconcli_Click);
            // 
            // dtvcliconsu
            // 
            this.dtvcliconsu.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtvcliconsu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtvcliconsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtvcliconsu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtvcliconsu.Location = new System.Drawing.Point(11, 430);
            this.dtvcliconsu.Margin = new System.Windows.Forms.Padding(2);
            this.dtvcliconsu.Name = "dtvcliconsu";
            this.dtvcliconsu.RowHeadersVisible = false;
            this.dtvcliconsu.RowTemplate.Height = 24;
            this.dtvcliconsu.Size = new System.Drawing.Size(588, 114);
            this.dtvcliconsu.TabIndex = 8;
            // 
            // lbltituconsu
            // 
            this.lbltituconsu.AutoSize = true;
            this.lbltituconsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituconsu.ForeColor = System.Drawing.Color.Black;
            this.lbltituconsu.Location = new System.Drawing.Point(134, 410);
            this.lbltituconsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltituconsu.Name = "lbltituconsu";
            this.lbltituconsu.Size = new System.Drawing.Size(361, 18);
            this.lbltituconsu.TabIndex = 10;
            this.lbltituconsu.Text = "INFORMACIÓN DE CLIENTE SELECCIONADO";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(477, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 58);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(199, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Buscar Cliente";
            // 
            // btnlogin
            // 
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.Location = new System.Drawing.Point(11, 11);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 59);
            this.btnlogin.TabIndex = 26;
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZUMOT.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 228);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // consultadeinformacioncliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltituconsu);
            this.Controls.Add(this.dtvcliconsu);
            this.Controls.Add(this.lblcodigoconcli);
            this.Controls.Add(this.txtcodiconsucli);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consultadeinformacioncliente";
            this.Text = "Consulta por cliente";
            this.Load += new System.EventHandler(this.consultadeinformacioncliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvcliconsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodiconsucli;
        private System.Windows.Forms.Label lblcodigoconcli;
        private System.Windows.Forms.DataGridView dtvcliconsu;
        private System.Windows.Forms.Label lbltituconsu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}