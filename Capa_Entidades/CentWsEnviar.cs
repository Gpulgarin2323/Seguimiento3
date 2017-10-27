using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
  public class CentWsEnviar
    {


        private string mpelicula;
        public string peliculas
        {
            get { return mpelicula; }
            set { mpelicula = value; }

        }

        private string mprecio;
        public string precio
        {
            get { return mprecio; }
            set { mprecio = value; }

        }

        private string mnombre;
        public string nombre
        {
            get { return mnombre; }
            set { mnombre = value; }
        }

        private string mapellidos;
        public string apellidos
        {
            get { return mapellidos; }
            set { mapellidos = value; }

        }
        private string mdireccion;
        public string direccion
        {
            get { return mdireccion; }
            set { mdireccion = value; }

        }

        private string mciudad;
        public string ciudad
        {
            get { return mciudad; }
            set { mciudad = value; }

        }

        private string mdepartamento;
        public string departamento
        {
            get { return mdepartamento; }
            set { mdepartamento = value; }

        }

        private string mtelefono;
        public string telefono
        {
            get { return mtelefono; }
            set { mtelefono = value; }
        }

        private string mbanco;
        public string banco
        {
            get { return mbanco; }
            set { mbanco = value; }
        }

        private string mreferencia;
        public string referencia
        {
            get { return mreferencia; }
            set { mreferencia = value; }
        }

        //private string GenerarReferencia()
        //{

        //    System.Random obj = new System.Random();
        //    string sCadena = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        //    int longitud = sCadena.Length;
        //    char cletra;
        //    int nlongitud = 7;
        //    string sNuevacadena = string.Empty;
        //    for (int i = 0; i < nlongitud; i++)
        //    {
        //        cletra = [obj.Next(nlongitud)];
        //        sNuevacadena += cletra.ToString();

        //    }
        //    return sNuevacadena;


        //}



    }
}
