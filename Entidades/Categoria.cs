using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {

        private int id_Categoria;
        private string nombre;
        private string descripcion;

        public Categoria() { }

        public Categoria(int id_Categoria, string nombre, string descripcion)
        {
            this.Id_Categoria = id_Categoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
