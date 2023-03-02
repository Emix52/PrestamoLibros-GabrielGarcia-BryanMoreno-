using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EditorialCD
    {
        public static List<CP_ListarEditorialResult> ListarEditorialFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarEditorial(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Editorial", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void InsertarEditorial(Entidades.Editorial oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarEditorial(oa.Id_Editorial, oa.Nombre, oa.Descripcion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Editorial", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
