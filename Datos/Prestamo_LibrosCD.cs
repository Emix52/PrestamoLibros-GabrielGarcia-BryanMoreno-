using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Prestamo_LibrosCD
    {

        public static List<CP_ListarPrestamoResult> ListarPrestamo(string val)
        {
            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    return DB.CP_ListarPrestamo(val).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al listar el procedimiento Listar Prestamo", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void InsertarPrestamo(Entidades.Prestamo_Libros oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_InsertarPrestamo(oa.Id_Prestamo, oa.Cedula_Estudiante, oa.Codigo_Libro_Retirado, oa.Fecha_Prestamo, oa.Fecha_Entrega);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al insertar tabla prestamo", ex);
            }
            finally
            {
                DB = null;
            }
        }


        public static void Devolucion(Entidades.Prestamo_Libros oa)
        {

            DataClasses1DataContext DB = null;
            try
            {

                using (DB = new DataClasses1DataContext())
                {
                    DB.CP_Devolucion(oa.Id_Prestamo, oa.Fecha_Devolucion);
                    DB.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new DatosExcepciones("Error al realizar la devolucion", ex);
            }
            finally
            {
                DB = null;
            }


        }

     

    }
}
