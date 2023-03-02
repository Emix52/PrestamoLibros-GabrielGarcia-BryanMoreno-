using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LibroCD
    {

        public static List<CP_ListarLibroResult> ListarLibroFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarLibro(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Libro", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void InsertarLibro(Entidades.Libro oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarLibro(oa.Codigo, oa.Nombre, oa.Autor, oa.Id_Categoria, oa.Id_Editorial);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Libro", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void ModificarLibro(Entidades.Libro oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarLibro(oa.Codigo, oa.Nombre, oa.Autor, oa.Id_Categoria, oa.Id_Editorial);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar tabla Libro", ex);
            }
            finally
            {
                DB = null;
            }


        }

        public static void EliminarLibro(Entidades.Libro oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarLibro(oa.Codigo);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar un registro de la tabla Libro", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
