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
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void Libro_Load(object sender, EventArgs e)
        {
            ListarLibro("");
        }
        public void ListarLibro(string var)
        {
            dataGridView1.DataSource = ol.ViewLibroFiltro(var);
        }
        //var
        LibroLN ol = new LibroLN();
        public string cod = "";
        public string estado = "";
        public int idcategoria=0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Estudiante ob = dataGridView1.CurrentRow.DataBoundItem as Estudiante;
            //MessageBox.Show(ob.Cedula);
            cod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            estado = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            idcategoria= int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (estado.Equals("Disponible")   )
            {
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("No se pudo realizar el prestamo");

        }
        

    }
}
