using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EditorialLN
    {

        public List<Entidades.Editorial> ViewEditorialFiltro(string valor)
        {
            List<Entidades.Editorial> lista = new List<Entidades.Editorial>();
            Entidades.Editorial oa;

            try
            {
                List<CP_ListarEditorialResult> auxLista = EditorialCD.ListarEditorialFiltro(valor);
                foreach (CP_ListarEditorialResult obj in auxLista)
                {
                    oa = new Entidades.Editorial(obj.Id_Editorial, obj.Nombre, obj.Descripcion);
                    lista.Add(oa);
                }
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al mostrar Editorial con procedimiento almacenado", ex);
            }
            finally
            {

            }
            return lista;
        }




        public bool CreateEditorial(Entidades.Editorial oa)
        {

            try
            {
                EditorialCD.InsertarEditorial(oa);
                return true;
            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Editorial en la BD");
            }
        }


    }
}
