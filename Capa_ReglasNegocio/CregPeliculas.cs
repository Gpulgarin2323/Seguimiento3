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
   public class CregPeliculas
    {
        CadtPeliculas odatpelicula = new CadtPeliculas();


        public DataSet consulta_pelicula1(CentPeliculas oentpelicula)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = odatpelicula.consulta_pelicula1(oentpelicula);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public bool eliminar_pelicula(CentPeliculas oentpelicula)
        {
            try
            {
                odatpelicula.eliminar_pelicula(oentpelicula);
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }




        public void agregar_pelicula(CentPeliculas oentpelicula)
        {
            try
            {
                odatpelicula.agregar_pelicula(oentpelicula);

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }

        public DataSet consulta_peliculaddl(CentPeliculas oentpelicula)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = odatpelicula.consulta_peliculadll(oentpelicula);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public DataSet consulta_preciopelicula(CentPeliculas oentpelicula)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = odatpelicula.consulta_preciopelicula(oentpelicula);
                if(ds != null)
                {
                    return ds;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }

    }

    }

