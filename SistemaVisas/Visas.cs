using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SistemaVisas
{
    [Serializable]
    abstract class Visa
    {
        private int _intNumeroVisa;

        public int NumeroVisa
        {
            get { return _intNumeroVisa; }
            set { _intNumeroVisa = value; }
        }

        private string _strNacionalidad;

        public string Nacionalidad
        {
            get { return _strNacionalidad; }
            set { _strNacionalidad = value; }
        }

        private DateTime _dtmFechaRegistro;

        public DateTime FechaRegistro
        {
            get { return _dtmFechaRegistro; }
            set { _dtmFechaRegistro = value; }
        }

        private DateTime _dtmFechaVencimiento;

        public DateTime FechaVencimiento
        {
            get { return _dtmFechaVencimiento; }
            set { _dtmFechaVencimiento = value; }
        }

        private double _dblPrecioBase;

        public double PrecioBase
        {
            get { return _dblPrecioBase; }
            set { _dblPrecioBase = value; }
        }

        public abstract double CalcularPrecio();
    }

    [Serializable]
    class VisaEstudiante : Visa
    {
        private string _strNombreEscuela;

        public string NombreEscuela
        {
            get { return _strNombreEscuela; }
            set { _strNombreEscuela = value; }
        }

        public override double CalcularPrecio()
        {
            double subTotal;
            subTotal = this.PrecioBase * 0.15;
            return this.PrecioBase + subTotal;
        }
    }

    [Serializable]
    class VisaTrabajo : Visa
    {
        private string _strNombreEmpresa;

        public string NombreEmpresa
        {
            get { return _strNombreEmpresa; }
            set { _strNombreEmpresa = value; }
        }

        public override double CalcularPrecio()
        {
            double subTotal;
            subTotal = this.PrecioBase * 0.20;
            return this.PrecioBase + subTotal;
        }
    }

    [Serializable]
    class VisaTemporal : Visa
    {
        private DateTime _dtmFechaLlegada;

        public DateTime FechaLlegada
        {
            get { return _dtmFechaLlegada; }
            set { _dtmFechaLlegada = value; }
        }

        private DateTime _dtmFechaIda;

        public DateTime FechaIda
        {
            get { return _dtmFechaIda; }
            set { _dtmFechaIda = value; }
        }

        public override double CalcularPrecio()
        {
            double subTotal;
            subTotal = this.PrecioBase * 30;
            return this.PrecioBase + subTotal;
        }
    }
}
