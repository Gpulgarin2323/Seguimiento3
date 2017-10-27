using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Centusuarios
    {

        private string midusuarios;
        public string id
        {
            get { return midusuarios; }
            set { midusuarios = value; }
        }

        private string mnomusuarios;
        public string nom
        {
            get { return mnomusuarios; }
            set { mnomusuarios = value; }
        }

        private string memailusuarios;
        public string email
        {
            get { return memailusuarios; }
            set { memailusuarios = value; }
        }

        private string mpassusuarios;
        public string pass
        {
            get { return mpassusuarios; }
            set { mpassusuarios = value; }
        }
    }
}
