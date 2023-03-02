using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaCD
    {
        public static List<CP_ListarCategoriaResult> ListarCategoriaFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarCategoria(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void InsertarCategoria(Entidades.Categoria oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarCategoria(oa.Id_Categoria, oa.Nombre, oa.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Categoria", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
