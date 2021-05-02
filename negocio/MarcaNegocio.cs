using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Marca((int)datos.Lector["Id"], (string)datos.Lector["Descripcion"]));
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        


        public void agregarMarca(string nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nueva + "')";
                datos.setearConsulta("insert into MARCAS (Descripcion) " + valores);
                datos.ejectutarAccion();
               
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                datos.cerrarConexion();

            }

        }

    }
}
