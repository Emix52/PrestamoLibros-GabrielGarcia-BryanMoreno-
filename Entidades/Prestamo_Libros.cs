using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo_Libros
    {

        private int id_Prestamo;
        private string cedula_Estudiante;
        private int codigo_Libro_Retirado;
        private DateTime fecha_Prestamo;
        private DateTime fecha_Entrega;
        private DateTime fecha_Devolucion;

        
        public Prestamo_Libros() { }

        public Prestamo_Libros(int id_Prestamo, string cedula_Estudiante, int codigo_Libro_Retirado, DateTime fecha_Prestamo, DateTime fecha_Entrega)
        {
            this.Id_Prestamo = id_Prestamo;
            this.Cedula_Estudiante = cedula_Estudiante;
            this.Codigo_Libro_Retirado = codigo_Libro_Retirado;
            this.Fecha_Prestamo = fecha_Prestamo;
            this.Fecha_Entrega = fecha_Entrega;
            
        }

        public Prestamo_Libros(int id_Prestamo, DateTime fecha_Devolucion) {

            this.Id_Prestamo = id_Prestamo;
            this.Fecha_Devolucion = fecha_Devolucion;


        }

        public int Id_Prestamo { get => id_Prestamo; set => id_Prestamo = value; }
        public string Cedula_Estudiante { get => cedula_Estudiante; set => cedula_Estudiante = value; }
        public int Codigo_Libro_Retirado { get => codigo_Libro_Retirado; set => codigo_Libro_Retirado = value; }
        public DateTime Fecha_Prestamo { get => fecha_Prestamo; set => fecha_Prestamo = value; }
        public DateTime Fecha_Entrega { get => fecha_Entrega; set => fecha_Entrega = value; }
        public DateTime Fecha_Devolucion { get => fecha_Devolucion; set => fecha_Devolucion = value; }
    }
}
