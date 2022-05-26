using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVisas
{
    public partial class Form1 : Form
    {
        private readonly ArchivoSecuencialSerealizadoBinario<Cliente> miArchivo =
            new ArchivoSecuencialSerealizadoBinario<Cliente>("C:\\Datos\\Archivo.dat");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboTipoVisa.Items.Add("Visa de trabajo");
            cboTipoVisa.Items.Add("Visa de estudiante");
            cboTipoVisa.Items.Add("Visa temporal");

            if (lstClientes.Items.Count <= 0)
                grpDatosVisa.Enabled = false;
            else grpDatosVisa.Enabled = true;

            MostrarDatos();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
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
                MessageBox.Show("Cliente agregado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MostrarDatos()
        {
            Cliente miCliente = new Cliente();
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
    }
}
