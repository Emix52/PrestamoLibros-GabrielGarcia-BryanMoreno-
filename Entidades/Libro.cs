using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {

        private int codigo;
        private string nombre;
        private string autor;
        private int id_Categoria;
        private int id_Editorial;
        private string estado;

        public Libro() { }

        public Libro(int codigo, string nombre, string autor, int id_Categoria, int id_Editorial, string estado)
        {
            this.estado = estado;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Autor = autor;
            this.Id_Categoria = id_Categoria;
            this.Id_Editorial = id_Editorial;
            
        }

        public Libro(int codigo, string nombre, string autor, int id_Categoria, int id_Editorial)
        {
           
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Autor = autor;
            this.Id_Categoria = id_Categoria;
            this.Id_Editorial = id_Editorial;

        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
        public int Id_Editorial { get => id_Editorial; set => id_Editorial = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
