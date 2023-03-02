using Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CategoriaLN
    {

        public List<Entidades.Categoria> ViewCategoriarFiltro(string valor)
        {
            List<Entidades.Categoria> lista = new List<Entidades.Categoria>();
            Entidades.Categoria oa;

            try
            {
                List<CP_ListarCategoriaResult> auxLista = CategoriaCD.ListarCategoriaFiltro(valor);
                foreach (CP_ListarCategoriaResult obj in auxLista)
                {
                    oa = new Entidades.Categoria(obj.Id_Categoria, obj.Nombre, obj.Descripcion);
                    lista.Add(oa);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar Categoria con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }

       


        public bool CreateCategoria(Entidades.Categoria oa)
        {

            try
            {
                CategoriaCD.InsertarCategoria(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Categoria en la BD");
            }
        }

       

    }
}
