using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Uso de archivos
using System.IO;
// Para el uso de la serialización
using System.Runtime.Serialization.Formatters.Binary;

namespace SistemaVisas
{
    internal class ArchivoSecuencialSerealizadoBinario<Tipo>
    {
        //Declaración de flujo del archivo
        private FileStream flujo;
        private BinaryFormatter seriador;

        //Constructor
        public ArchivoSecuencialSerealizadoBinario(string strNombreArchivo)
        {
            NombreArchivo = strNombreArchivo;
        }

        private string _strNombreArchivo;
        public string NombreArchivo
        {
            get { return _strNombreArchivo; }
            private set { _strNombreArchivo = value; }
        }

        //Propiedad de sólo lectura para determinar si se alcanza el final del archivo
        public bool FinArchivo
        {
            get
            {
                if (flujo.Position >= flujo.Length)
                    return true;
                return false;
            }
        }

        //Destructor
        ~ArchivoSecuencialSerealizadoBinario()
        {
            Cerrar();
        }

        //Método para crear el archivo
        private void Crear()
        {
            flujo = new FileStream(NombreArchivo, FileMode.Create);
            seriador = new BinaryFormatter();
        }

        //Método para abrir el archivo en modo escritura
        public void AbrirEnModoEscritura()
        {
            if (File.Exists(NombreArchivo))
            {
                flujo = new FileStream(NombreArchivo, FileMode.Append);
                seriador = new BinaryFormatter();
            }
            else
            {
                Crear();
            }
        }

        //Método para abrir el archivo en modo lectura
        public void AbrirEnModoLectura()
        {
            if (File.Exists(NombreArchivo))
            {
                flujo = new FileStream(NombreArchivo, FileMode.Open);
                seriador = new BinaryFormatter();
            }
            else
            {
                throw new Exception(" No existe el archivo" + NombreArchivo);
            }
        }

        //Método para abrir el archivo en modo lectura y escritura
        public void AbrirEnModoLecturaYEscritura()
        {
            if (File.Exists(NombreArchivo))
                flujo = new FileStream(NombreArchivo, FileMode.Open, FileAccess.ReadWrite);
            else
                Crear();
            seriador = new BinaryFormatter();
        }

        //Método para grabar un objeto en el archivo
        public void GrabarObjeto(Tipo miObjeto)
        {
            seriador.Serialize(flujo, miObjeto);
        }

        //Método para leer un objeto del archivo
        public Tipo LeerObjeto()
        {
            var miObjeto = (Tipo)seriador.Deserialize(flujo);
            return miObjeto;
        }

        //Método para cerrar el archivo
        public void Cerrar()
        {
            if (flujo != null) flujo.Close();
        }

        //Método para eliminar el archivo
        public void EliminarArchivo()
        {
            Cerrar();
            File.Delete(NombreArchivo);
        }
    }
}
