using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SistemaVisas
{
    public partial class Form1 : Form
    {
        private readonly ArchivoSecuencialSerealizadoBinario<Cliente> miArchivo =
            new ArchivoSecuencialSerealizadoBinario<Cliente>("C:\\Datos\\Archivo.dat");

        #region CONTROLES DINAMICOS

        private Label lblNombreEscuela = new Label();
        private TextBox txtNombreEscuela = new TextBox();
        private Label lblNombreEmpresa = new Label();
        private TextBox txtNombreEmpresa = new TextBox();
        private Label lblFechaLlegada = new Label();
        private Label lblFechaRegreso = new Label();
        private DateTimePicker dtmFechaIda = new DateTimePicker();
        private DateTimePicker dtmFechaRegreso = new DateTimePicker();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipoVisa.Items.Add("Visa de trabajo");
            cboTipoVisa.Items.Add("Visa de estudiante");
            cboTipoVisa.Items.Add("Visa temporal");

            dtgVisasEstudiante.Columns.Add("numeroVisa", "Numero de Visa");
            dtgVisasEstudiante.Columns.Add("nacionalidad", "Nacionalidad");
            dtgVisasEstudiante.Columns.Add("fechaRegistro", "Fecha de Registro");
            dtgVisasEstudiante.Columns.Add("fechaVencimiento", "Fecha de Vencimiento");
            dtgVisasEstudiante.Columns.Add("precioBase", "Precio Base");
            dtgVisasEstudiante.Columns.Add("nombreEscuela", "Nombre de la Escuela");
            dtgVisasEstudiante.Columns.Add("costoTotal", "Costo Total");

            dtgVisasTrabajo.Columns.Add("numeroVisa", "Numero de Visa");
            dtgVisasTrabajo.Columns.Add("nacionalidad", "Nacionalidad");
            dtgVisasTrabajo.Columns.Add("fechaRegistro", "Fecha de Registro");
            dtgVisasTrabajo.Columns.Add("fechaVencimiento", "Fecha de Vencimiento");
            dtgVisasTrabajo.Columns.Add("precioBase", "Precio Base");
            dtgVisasTrabajo.Columns.Add("nombreEscuela", "Nombre de la Empresa");
            dtgVisasTrabajo.Columns.Add("costoTotal", "Costo Total");

            dtgVisasTemporales.Columns.Add("numeroVisa", "Numero de Visa");
            dtgVisasTemporales.Columns.Add("nacionalidad", "Nacionalidad");
            dtgVisasTemporales.Columns.Add("fechaRegistro", "Fecha de Registro");
            dtgVisasTemporales.Columns.Add("fechaVencimiento", "Fecha de Vencimiento");
            dtgVisasTemporales.Columns.Add("precioBase", "Precio Base");
            dtgVisasTemporales.Columns.Add("cantidadTiempo", "Cantidad de Meses");
            dtgVisasTemporales.Columns.Add("costoTotal", "Costo Total");

            if (lstClientes.Items.Count <= 0)
                grpDatosVisa.Enabled = false;
            else grpDatosVisa.Enabled = true;

            MostrarDatos();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new Cliente();
            try
            {
                nuevoCliente.Nombre = txtNombreCliente.Text;
                nuevoCliente.Nacionalidad = txtNacionalidadCliente.Text;
                nuevoCliente.FechaNacimiento = dtpFechaNacimiento.Value;

                //lstClientes.Items.Add(nuevoCliente);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            try
            {
                miArchivo.AbrirEnModoEscritura();
                miArchivo.GrabarObjeto(nuevoCliente);
                MessageBox.Show("Cliente agregado exitosamente", "Exito", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            finally
            {
                miArchivo.Cerrar();
            }

            MostrarDatos();
        }

        private void btnAgregarVisa_Click(object sender, EventArgs e)
        {
            
        }

        private void MostrarDatos()
        {
            var miCliente = new Cliente();
            lstClientes.Items.Clear();
            try
            {
                miArchivo.AbrirEnModoLectura();
                while (!miArchivo.FinArchivo)
                {
                    miCliente = miArchivo.LeerObjeto();
                    lstClientes.Items.Add(miCliente);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
            }
        }

        #region MUESTREO DE DATOS DE LA VISA EN EL DATAGRIDVIEW
        private void MostrarVisaEstudiante(Cliente cliente)
        {
            dtgVisasEstudiante.Rows.Clear();
            foreach (var clienteListaVisaEstudiante in cliente.ListaVisaEstudiantes)
            {
                dtgVisasEstudiante.Rows.Clear();
            }
        }

        private void MostrarVisaTrabajo(Cliente cliente)
        {
            dtgVisasTrabajo.Rows.Clear();
            foreach (var clienteListaVisaTrabajo in cliente.ListaVisaTrabajo)
            {
                dtgVisasTrabajo.Rows.Clear();
            }
        }

        private void MostrarVisaTemporal(Cliente cliente)
        {
            dtgVisasTemporales.Rows.Clear();
            foreach (var clienteListaVisaTemporal in cliente.ListaVisaTemporal)
            {
                dtgVisasTemporales.Rows.Clear();
            }
        }
        #endregion

        private void lstClientes_Click(object sender, EventArgs e)
        {
            grpDatosVisa.Enabled = true;
            Cliente clienteSeleccionado = new Cliente();
            clienteSeleccionado = (Cliente)lstClientes.SelectedItem;

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe de seleccionar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MostrarVisaEstudiante(clienteSeleccionado);
            MostrarVisaTrabajo(clienteSeleccionado);
            MostrarVisaTemporal(clienteSeleccionado);
        }

        private void cboTipoVisa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoVisa.Text == "Visa de estudiante")
            {
                grpDatosEspecialesVisa.Controls.Clear();

                lblNombreEscuela.Text = "Escuela:";
                lblNombreEscuela.Location = new System.Drawing.Point(10, 30);
                txtNombreEscuela.Location = new System.Drawing.Point(10, 55);

                grpDatosEspecialesVisa.Controls.Add(lblNombreEscuela);
                grpDatosEspecialesVisa.Controls.Add(txtNombreEscuela);
            }

            if (cboTipoVisa.Text == "Visa de trabajo")
            {
                grpDatosEspecialesVisa.Controls.Clear();

                lblNombreEmpresa.Text = "Empresa:";
                lblNombreEmpresa.Location = new System.Drawing.Point(10, 30);
                txtNombreEmpresa.Location = new System.Drawing.Point(10, 55);

                grpDatosEspecialesVisa.Controls.Add(lblNombreEmpresa);
                grpDatosEspecialesVisa.Controls.Add(txtNombreEmpresa);
            }

            if (cboTipoVisa.Text == "Visa temporal")
            {
                grpDatosEspecialesVisa.Controls.Clear();

                lblFechaLlegada.Text = "Llegada:";
                lblFechaLlegada.Location = new System.Drawing.Point(10, 30);
                dtmFechaIda.Location = new System.Drawing.Point(10, 55);

                lblFechaRegreso.Text = "Regreso:";
                lblFechaRegreso.Location = new System.Drawing.Point(10, 90);
                dtmFechaRegreso.Location = new System.Drawing.Point(10, 115);

                grpDatosEspecialesVisa.Controls.Add(lblFechaLlegada);
                grpDatosEspecialesVisa.Controls.Add(lblFechaRegreso);
                grpDatosEspecialesVisa.Controls.Add(dtmFechaIda);
                grpDatosEspecialesVisa.Controls.Add(dtmFechaRegreso);
            }
        }
    }
}