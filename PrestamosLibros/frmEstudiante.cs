using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosLibros
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }
        EstudianteLN oe = new EstudianteLN();
        public string cod = "";
        public string estado = "";
        public int edad_estudiante = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ListarEstudiante("");
        }
        public void ListarEstudiante(string var)
        {
            dataGridView1.DataSource = oe.ViewEstudianterFiltro(var);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Estudiante ob = dataGridView1.CurrentRow.DataBoundItem as Estudiante;
            //MessageBox.Show(ob.Cedula);
            cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            estado = dataGridView1.CurrentRow.Cells[5].Value.ToString(); ;
            edad_estudiante = edad( DateTime.Parse (dataGridView1.CurrentRow.Cells[4].Value.ToString()));
            if (estado.Equals("Disponible"))
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("No se pudo realizar el prestamo");
            
        }
        public int edad(DateTime fechaNaci)
        {
            TimeSpan ts = DateTime.Now - fechaNaci;
            return (int)ts.TotalDays / 365;
        }
    }
}
