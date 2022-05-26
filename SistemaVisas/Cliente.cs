using System;
using System.Collections.Generic;

namespace SistemaVisas
{
    [Serializable]
    class Cliente
    {
        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        private readonly List<VisaEstudiante> lstVisaEstudiantes = new List<VisaEstudiante>();
        private readonly List<VisaTrabajo> lstVisaTrabajos = new List<VisaTrabajo>();
        private readonly List<VisaTemporal> lstVisaTemporales = new List<VisaTemporal>();

        public IEnumerable<VisaEstudiante> ListaVisaEstudiantes
        {
            get
            {
                foreach (var visa in lstVisaEstudiantes)
                    yield return visa;
            }
        }

        public IEnumerable<VisaTrabajo> ListaVisaTrabajo
        {
            get
            {
                foreach (var visa in lstVisaTrabajos)
                    yield return visa;
            }
        }

        public IEnumerable<VisaTemporal> ListaVisaTemporal
        {
            get
            {
                foreach (var visa in lstVisaTemporales)
                    yield return visa;
            }
        }

        public void AgregarVisaEstudiante(VisaEstudiante obj)
        {
            lstVisaEstudiantes.Add(obj);
        }

        public void AgregarVisaTrabajo(VisaTrabajo obj)
        {
            lstVisaTrabajos.Add(obj);
        }

        public void AgregarVisaTemporal(VisaTemporal obj)
        {
            lstVisaTemporales.Add(obj);
        }
    }
}