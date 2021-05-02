using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;
using System.Windows.Forms;

namespace negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos;
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, C.Descripcion Categoria, M.Descripcion Marca, ImagenUrl, Precio from ARTICULOS A, CATEGORIAS C ,MARCAS M WHERE A.IdMarca = M.Id and A.IdCategoria = C.Id ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.categoria = new Categoria((string)datos.Lector["Categoria"]);
                    aux.marca = new Marca((string)datos.Lector["Marca"]);
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
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

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Codigo + "', '" + nuevo.Descripcion + "', '" + nuevo.Nombre + "', '" + nuevo.ImagenUrl + "', '" + nuevo.marca.Id + "', " + nuevo.Precio + ", '" + nuevo.categoria.Id + "')";
                datos.setearConsulta("insert into articulos (Codigo, Descripcion, Nombre, ImagenUrl, IdMarca, Precio, IdCategoria) " + valores);

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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagenUrl, Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria, Codigo = @codigo WHERE Id = @id");
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@imagenUrl", modificar.ImagenUrl);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@idMarca", modificar.marca.Id);
                datos.setearParametro("@idCategoria", modificar.categoria.Id);
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@id", modificar.Id);

                datos.ejectutarAccion();

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

        public void eliminar(int id)
        {
            datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = " + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                datos = null;
            }
        }

    }
}
