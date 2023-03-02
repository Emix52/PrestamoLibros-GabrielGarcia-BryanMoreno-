using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Editorial
    {
        private int id_Editorial;
        private string nombre;
        private string descripcion;
        public Editorial() { }

        public Editorial(int id_Editorial, string nombre, string descripcion)
        {
            this.Id_Editorial = id_Editorial;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Id_Editorial { get => id_Editorial; set => id_Editorial = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
