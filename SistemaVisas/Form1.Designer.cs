namespace SistemaVisas
{
    partial class Form1
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
            this.dtgVisas = new System.Windows.Forms.DataGridView();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtNacionalidadCliente = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.grpDatosVisa = new System.Windows.Forms.GroupBox();
            this.lblTipoVisa = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblNacionalidadVisa = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboTipoVisa = new System.Windows.Forms.ComboBox();
            this.lblNumeroVisa = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAgregarVisa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisas)).BeginInit();
            this.grpDatosCliente.SuspendLayout();
            this.grpDatosVisa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVisas
            // 
            this.dtgVisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisas.Location = new System.Drawing.Point(184, 259);
            this.dtgVisas.Name = "dtgVisas";
            this.dtgVisas.Size = new System.Drawing.Size(604, 179);
            this.dtgVisas.TabIndex = 0;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(12, 265);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(166, 173);
            this.lstClientes.TabIndex = 1;
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosCliente.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosCliente.Controls.Add(this.lblNacionalidad);
            this.grpDatosCliente.Controls.Add(this.txtNacionalidadCliente);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grpDatosCliente.Location = new System.Drawing.Point(12, 12);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(220, 201);
            this.grpDatosCliente.TabIndex = 2;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos del Cliente";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(6, 131);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(6, 115);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(6, 68);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // txtNacionalidadCliente
            // 
            this.txtNacionalidadCliente.Location = new System.Drawing.Point(6, 84);
            this.txtNacionalidadCliente.Name = "txtNacionalidadCliente";
            this.txtNacionalidadCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNacionalidadCliente.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(6, 40);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(200, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // grpDatosVisa
            // 
            this.grpDatosVisa.Controls.Add(this.lblTipoVisa);
            this.grpDatosVisa.Controls.Add(this.dateTimePicker2);
            this.grpDatosVisa.Controls.Add(this.lblFechaVencimiento);
            this.grpDatosVisa.Controls.Add(this.dateTimePicker1);
            this.grpDatosVisa.Controls.Add(this.lblFechaRegistro);
            this.grpDatosVisa.Controls.Add(this.txtNacionalidad);
            this.grpDatosVisa.Controls.Add(this.lblNacionalidadVisa);
            this.grpDatosVisa.Controls.Add(this.textBox3);
            this.grpDatosVisa.Controls.Add(this.cboTipoVisa);
            this.grpDatosVisa.Controls.Add(this.lblNumeroVisa);
            this.grpDatosVisa.Location = new System.Drawing.Point(238, 12);
            this.grpDatosVisa.Name = "grpDatosVisa";
            this.grpDatosVisa.Size = new System.Drawing.Size(252, 201);
            this.grpDatosVisa.TabIndex = 3;
            this.grpDatosVisa.TabStop = false;
            this.grpDatosVisa.Text = "Datos de Generales Visado";
            // 
            // lblTipoVisa
            // 
            this.lblTipoVisa.AutoSize = true;
            this.lblTipoVisa.Location = new System.Drawing.Point(3, 23);
            this.lblTipoVisa.Name = "lblTipoVisa";
            this.lblTipoVisa.Size = new System.Drawing.Size(66, 13);
            this.lblTipoVisa.TabIndex = 12;
            this.lblTipoVisa.Text = "Tipo de Visa";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(113, 175);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(113, 159);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFechaVencimiento.TabIndex = 10;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(6, 159);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(94, 13);
            this.lblFechaRegistro.TabIndex = 7;
            this.lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(6, 128);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 20);
            this.txtNacionalidad.TabIndex = 9;
            // 
            // lblNacionalidadVisa
            // 
            this.lblNacionalidadVisa.AutoSize = true;
            this.lblNacionalidadVisa.Location = new System.Drawing.Point(3, 112);
            this.lblNacionalidadVisa.Name = "lblNacionalidadVisa";
            this.lblNacionalidadVisa.Size = new System.Drawing.Size(69, 13);
            this.lblNacionalidadVisa.TabIndex = 8;
            this.lblNacionalidadVisa.Text = "Nacionalidad";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 7;
            // 
            // cboTipoVisa
            // 
            this.cboTipoVisa.FormattingEnabled = true;
            this.cboTipoVisa.Location = new System.Drawing.Point(6, 39);
            this.cboTipoVisa.Name = "cboTipoVisa";
            this.cboTipoVisa.Size = new System.Drawing.Size(200, 21);
            this.cboTipoVisa.TabIndex = 0;
            // 
            // lblNumeroVisa
            // 
            this.lblNumeroVisa.AutoSize = true;
            this.lblNumeroVisa.Location = new System.Drawing.Point(3, 68);
            this.lblNumeroVisa.Name = "lblNumeroVisa";
            this.lblNumeroVisa.Size = new System.Drawing.Size(82, 13);
            this.lblNumeroVisa.TabIndex = 7;
            this.lblNumeroVisa.Text = "Número de Visa";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 219);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(220, 34);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarVisa
            // 
            this.btnAgregarVisa.Location = new System.Drawing.Point(238, 219);
            this.btnAgregarVisa.Name = "btnAgregarVisa";
            this.btnAgregarVisa.Size = new System.Drawing.Size(252, 34);
            this.btnAgregarVisa.TabIndex = 5;
            this.btnAgregarVisa.Text = "Agregar Visa";
            this.btnAgregarVisa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(496, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 201);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Visado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de Visa";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(113, 175);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de Vencimiento";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(6, 175);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha de Registro";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nacionalidad";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Número de Visa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarVisa);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.grpDatosVisa);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.dtgVisas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Visas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisas)).EndInit();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.grpDatosVisa.ResumeLayout(false);
            this.grpDatosVisa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVisas;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.GroupBox grpDatosVisa;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAgregarVisa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNacionalidadCliente;
        private System.Windows.Forms.Label lblNumeroVisa;
        private System.Windows.Forms.ComboBox cboTipoVisa;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblNacionalidadVisa;
        private System.Windows.Forms.Label lblTipoVisa;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
    }
}

