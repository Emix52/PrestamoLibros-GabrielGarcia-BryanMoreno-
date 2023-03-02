using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Prestamo_LibrosLN
    {

        public List<Entidades.Prestamo_Libros> ViewPrestamo_LibrosFiltro(string valor)
        {
            List<Entidades.Prestamo_Libros> lista = new List<Entidades.Prestamo_Libros>();
            Entidades.Prestamo_Libros oa;

            try
            {
                List<CP_ListarPrestamoResult> auxLista = Prestamo_LibrosCD.ListarPrestamo(valor);
                foreach (CP_ListarPrestamoResult obj in auxLista)
                {
                    oa = new Entidades.Prestamo_Libros(obj.Id_Prestamo, obj.Cedula_Estudiante, obj.Codigo_Libro_Retirado, obj.Fecha_Prestamo, obj.Fecha_Entrega);
                    lista.Add(oa);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar prestamos con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }



        public bool CreatePrestamo(Entidades.Prestamo_Libros oa)
        {

            try
            {
                Prestamo_LibrosCD.InsertarPrestamo(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar prestamo en la BD");
            }
        }

        public bool DevolucionLibro (Entidades.Prestamo_Libros oa)
        {

            try
            {
                Prestamo_LibrosCD.Devolucion(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al modificar prestamo en la BD");
            }
        }

    }
}
