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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }
        Prestamo_LibrosLN op= new Prestamo_LibrosLN();

        public void listardevo(string var)
        {
            dataGridView1.DataSource = op.ViewPrestamo_LibrosFiltro(var).ToList();
        }
        private void Devolucion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.ViewPrestamo_LibrosFiltro(textBox1.Text).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = op.ViewPrestamo_LibrosFiltro(textBox1.Text).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Prestamo_Libros ob = dataGridView1.CurrentRow.DataBoundItem as Entidades.Prestamo_Libros;
            FechaDevo frm = new FechaDevo();
            frm.auxiliar = ob;
        }
    }
}
