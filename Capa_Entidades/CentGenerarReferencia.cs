using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
   public class CentGenerarReferencia
    {
        public string GenerarReferencia( )
        {

            Random obj = new Random();
            
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            
            int longitud = posibles.Length;
            
            char letra;
            
            int longitudnuevacadena = 7;
            
            string nuevacadena = "";
            
            for (int i = 0; i < longitudnuevacadena; i++)
                
            {
                
               letra = posibles[obj.Next(longitud)];
                
               nuevacadena += letra.ToString();
                
            }
            return nuevacadena;
                        
        }
    }
}
