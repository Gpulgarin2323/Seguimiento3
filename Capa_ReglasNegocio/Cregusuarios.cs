using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidades;
using System.Data;

namespace Capa_ReglasNegocio
{
    public class Cregusuarios
    {
        Cdatusuarios odatusuarios = new Cdatusuarios();

        public DataSet ver_usuarios(Centusuarios oentusuarios)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = odatusuarios.ver_usuarios(oentusuarios);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }

        public bool eliminar_usuarios(Centusuarios oentusuarios)
        {
            try
            {
                odatusuarios.eliminar_usuarios(oentusuarios);
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }

        public DataSet buscar_usuario(Centusuarios oentusuarios)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = odatusuarios.buscar_usuario(oentusuarios);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }


        public bool alta_usuarios(Centusuarios oentusuarios)
        {
            try
            {
                odatusuarios.alta_usuarios(oentusuarios);
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }


    }
}
