using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LibroLN
    {

        public List<Entidades.Libro> ViewLibroFiltro(string valor)
        {
            List<Entidades.Libro> lista = new List<Entidades.Libro>();
            Entidades.Libro oa;

            try
            {
                List<CP_ListarLibroResult> auxLista = LibroCD.ListarLibroFiltro(valor);
                foreach (CP_ListarLibroResult obj in auxLista)
                {
                    oa = new Entidades.Libro(obj.Codigo, obj.Nombre, obj.Autor, obj.Id_Categoria, obj.Id_Editorial,obj.Estado);
                    lista.Add(oa);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar Libro con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }



        public bool CreateLibro(Entidades.Libro oa)
        {

            try
            {
                LibroCD.InsertarLibro(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Libro en la BD");
            }
        }

        public bool UpdateLibro(Entidades.Libro oa)
        {

            try
            {
                LibroCD.ModificarLibro(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al modificar Libro en la BD");
            }
        }

        public bool DeleteLibro(Entidades.Libro oa)
        {

            try
            {
                LibroCD.EliminarLibro(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al borrar Libro en la BD");
            }
        }

    }
}
