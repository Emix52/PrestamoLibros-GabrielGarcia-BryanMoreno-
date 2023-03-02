using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {

        private string cedula;
        private string nombre;
        private string apellido;
        private char sexo;
        private DateTime fecha_Nacimiento;
        private string estado;

        public Estudiante() { }

        public Estudiante(string cedula, string nombre, string apellido, char sexo, DateTime fecha_Nacimiento, string estado)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Fecha_Nacimiento = fecha_Nacimiento;
            this.estado = estado;
            
        }
        public Estudiante(string cedula, string nombre, string apellido, char sexo, DateTime fecha_Nacimiento)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Fecha_Nacimiento = fecha_Nacimiento;

        }




        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public DateTime Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
