using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosLibros
{
    public partial class FechaDevo : Form
    {
        public FechaDevo()
        {
            InitializeComponent();
        }
        public Prestamo_Libros auxiliar;
        Prestamo_LibrosLN ob = new Prestamo_LibrosLN();
        private void FechaDevo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            auxiliar.Fecha_Devolucion = dateTimePicker1.Value;
            ob.DevolucionLibro(auxiliar);
        }
    }
}
