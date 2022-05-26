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
            this.dtgVisasTrabajo = new System.Windows.Forms.DataGridView();
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
            this.grpDatosEspecialesVisa = new System.Windows.Forms.GroupBox();
            this.dtgVisasTemporales = new System.Windows.Forms.DataGridView();
            this.dtgVisasEstudiante = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasTrabajo)).BeginInit();
            this.grpDatosCliente.SuspendLayout();
            this.grpDatosVisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasTemporales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasEstudiante)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVisasTrabajo
            // 
            this.dtgVisasTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisasTrabajo.Location = new System.Drawing.Point(184, 285);
            this.dtgVisasTrabajo.Name = "dtgVisasTrabajo";
            this.dtgVisasTrabajo.Size = new System.Drawing.Size(854, 82);
            this.dtgVisasTrabajo.TabIndex = 0;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(35, 292);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(124, 277);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.Click += new System.EventHandler(this.lstClientes_Click);
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosCliente.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosCliente.Controls.Add(this.lblNacionalidad);
            this.grpDatosCliente.Controls.Add(this.txtNacionalidadCliente);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grpDatosCliente.Location = new System.Drawing.Point(163, 12);
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
            this.grpDatosVisa.Location = new System.Drawing.Point(389, 12);
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
            this.cboTipoVisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVisa.FormattingEnabled = true;
            this.cboTipoVisa.Location = new System.Drawing.Point(6, 39);
            this.cboTipoVisa.Name = "cboTipoVisa";
            this.cboTipoVisa.Size = new System.Drawing.Size(200, 21);
            this.cboTipoVisa.TabIndex = 0;
            this.cboTipoVisa.SelectedValueChanged += new System.EventHandler(this.cboTipoVisa_SelectedValueChanged);
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
            this.btnAgregarCliente.Location = new System.Drawing.Point(163, 219);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(220, 34);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarVisa
            // 
            this.btnAgregarVisa.Location = new System.Drawing.Point(389, 219);
            this.btnAgregarVisa.Name = "btnAgregarVisa";
            this.btnAgregarVisa.Size = new System.Drawing.Size(510, 34);
            this.btnAgregarVisa.TabIndex = 5;
            this.btnAgregarVisa.Text = "Agregar Visa";
            this.btnAgregarVisa.UseVisualStyleBackColor = true;
            this.btnAgregarVisa.Click += new System.EventHandler(this.btnAgregarVisa_Click);
            // 
            // grpDatosEspecialesVisa
            // 
            this.grpDatosEspecialesVisa.Location = new System.Drawing.Point(647, 12);
            this.grpDatosEspecialesVisa.Name = "grpDatosEspecialesVisa";
            this.grpDatosEspecialesVisa.Size = new System.Drawing.Size(252, 201);
            this.grpDatosEspecialesVisa.TabIndex = 13;
            this.grpDatosEspecialesVisa.TabStop = false;
            this.grpDatosEspecialesVisa.Text = "Datos de Visado";
            // 
            // dtgVisasTemporales
            // 
            this.dtgVisasTemporales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisasTemporales.Location = new System.Drawing.Point(184, 386);
            this.dtgVisasTemporales.Name = "dtgVisasTemporales";
            this.dtgVisasTemporales.Size = new System.Drawing.Size(854, 82);
            this.dtgVisasTemporales.TabIndex = 14;
            // 
            // dtgVisasEstudiante
            // 
            this.dtgVisasEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisasEstudiante.Location = new System.Drawing.Point(184, 487);
            this.dtgVisasEstudiante.Name = "dtgVisasEstudiante";
            this.dtgVisasEstudiante.Size = new System.Drawing.Size(854, 82);
            this.dtgVisasEstudiante.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Visas de Trabajo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Visas Temporales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Visas de Estudiante";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Lista de Clientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 590);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtgVisasEstudiante);
            this.Controls.Add(this.dtgVisasTemporales);
            this.Controls.Add(this.grpDatosEspecialesVisa);
            this.Controls.Add(this.btnAgregarVisa);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.grpDatosVisa);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.dtgVisasTrabajo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Visas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasTrabajo)).EndInit();
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            this.grpDatosVisa.ResumeLayout(false);
            this.grpDatosVisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasTemporales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisasEstudiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVisasTrabajo;
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
        private System.Windows.Forms.GroupBox grpDatosEspecialesVisa;
        private System.Windows.Forms.DataGridView dtgVisasTemporales;
        private System.Windows.Forms.DataGridView dtgVisasEstudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

