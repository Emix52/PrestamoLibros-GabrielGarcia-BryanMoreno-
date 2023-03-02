using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EstudianteCD
    {

        public static List<CP_ListarEstudianteResult> ListarEstudianteFiltro(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarEstudiante(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Estudiante", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void InsertarEstudiante(Entidades.Estudiante oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarEstudiante(oa.Cedula, oa.Nombre, oa.Apellido, oa.Sexo, oa.Fecha_Nacimiento);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla Estudiante", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void ModificarEstudiante(Entidades.Estudiante oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_ModificarEstudiante(oa.Cedula, oa.Nombre, oa.Apellido, oa.Sexo, oa.Fecha_Nacimiento);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al actualizar tabla estudiante", ex);
            }
            finally
            {
                DB = null;
            }


        }

        public static void EliminarEstudiante(Entidades.Estudiante oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_EliminarEstudiante(oa.Cedula);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al eliminar un registro de la tabla estudiante", ex);
            }
            finally
            {
                DB = null;
            }
        }

    }
}
