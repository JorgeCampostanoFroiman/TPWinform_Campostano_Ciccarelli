using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    lista.Add(new Categoria((int)datos.Lector["Id"], (string)datos.Lector["Descripcion"]));
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

        public void agregarCategoria(string nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nueva + "')";
                datos.setearConsulta("insert into CATEGORIAS (Descripcion) " + valores);
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
