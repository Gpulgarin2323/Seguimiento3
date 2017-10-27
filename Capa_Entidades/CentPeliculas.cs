using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class CentPeliculas
    {
        private string micodpelicula;
        public string codpelicula
        {
            get { return micodpelicula; }
            set { micodpelicula = value; }
        }

        private string mdescripcion;
        public string descripcion
        {
            get { return mdescripcion; }
            set { mdescripcion = value; }
        }

        private string migenero;
        public string genero
        {
            get { return migenero; }
            set { migenero = value; }
        }

        private string mautor;
        public string autor
        {
            get { return mautor; }
            set { mautor = value; }
        }

        private string mnombre;
        public string nombre
        {
            get { return mnombre; }
            set { mnombre = value; }
        }

        private Byte[] mfoto;
        public Byte[] foto
        {
            get { return mfoto; }
            set { mfoto = value; }
        }

        private string mid;
        public string id
        {
            get { return mid; }
            set { mid = value; }
        }
        private string mprecio;
        public string precio
        {
            get { return mprecio; }
            set { mprecio = value; }
        }

        private string mdato;
        public string dato
        {
            get { return mdato; }
            set { mdato = value; }
        }

        private string mtipo;
        public string tipo
        {
            get { return mtipo; }
            set { mtipo = value; }
        }

    }

    //public class Precio
    //{
    //    public string Nombre { get; set; }
    //}

}
