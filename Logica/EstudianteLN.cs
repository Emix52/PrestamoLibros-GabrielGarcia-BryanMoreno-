using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EstudianteLN
    {

            public List<Entidades.Estudiante> ViewEstudianterFiltro(string valor)
            {
                List<Entidades.Estudiante> lista = new List<Entidades.Estudiante>();
                Entidades.Estudiante oa;

                try
                {
                    List<CP_ListarEstudianteResult> auxLista = EstudianteCD.ListarEstudianteFiltro(valor);
                    foreach (CP_ListarEstudianteResult obj in auxLista)
                    {
                        oa = new Entidades.Estudiante(obj.Cedula, obj.Nombre, obj.Apellido, obj.Sexo, obj.Fecha_Nacimiento,obj.Estado);
                        lista.Add(oa);
                    }
                }
                catch (Exception ex)
                {
                    throw new LogicaExcepciones("Error al mostrar Estudiante con procedimiento almacenado", ex);
                }
                finally
                {

                }
                return lista;
            }



            public bool CreateEstudiante(Entidades.Estudiante oa)
            {

                try
                {
                EstudianteCD.InsertarEstudiante(oa);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new LogicaExcepciones("Error al insertar Estudiante en la BD");
                }
            }

            public bool UpdateEstudiante(Entidades.Estudiante oa)
            {

                try
                {
                EstudianteCD.ModificarEstudiante(oa);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new LogicaExcepciones("Error al modificar Estudiante en la BD");
                }
            }

            public bool DeleteEstudiante(Entidades.Estudiante oa)
            {

                try
                {
                EstudianteCD.EliminarEstudiante(oa);
                    return true;
                }
                catch (Exception ex)
                {
                    throw new LogicaExcepciones("Error al borrar Estudiante en la BD");
                }
            }

        }
}
