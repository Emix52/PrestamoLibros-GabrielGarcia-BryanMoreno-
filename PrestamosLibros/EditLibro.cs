using Datos;
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
    public partial class EditLibro : Form
    {
        public EditLibro()
        {
            InitializeComponent();
        }

        private void EditPelicula_Load(object sender, EventArgs e)
        {
            MostrarComboBoxCategoria();
            MostrarComboBoxEditorial();
        }

        public Entidades.Libro auxiliar = new Entidades.Libro();
        public void verDatos()
        {
            textBox1.Text = auxiliar.Codigo.ToString();
            textBox2.Text = auxiliar.Nombre;
            textBox3.Text = auxiliar.Autor;
            comboBox1.SelectedValue = auxiliar.Id_Categoria;
            comboBox2.SelectedValue = auxiliar.Id_Editorial;
            


        }
        public Entidades.Libro crearObjeto()
        {
            Entidades.Libro op;
            int codigo = int.Parse(textBox1.Text);
 
            string nombre = textBox2.Text;
            string autor = textBox3.Text;
            int categoria = (int)comboBox1.SelectedValue;
            int editorial = (int)comboBox2.SelectedValue;
            op = new Entidades.Libro(codigo,nombre, autor, categoria,editorial);
            return op;
        }
        public void MostrarComboBoxCategoria()
        {
            CategoriaLN oaln = new CategoriaLN();
            comboBox1.DataSource = oaln.ViewCategoriarFiltro("");
            comboBox1.SelectedIndex = 0;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Categoria";
        }

        public void MostrarComboBoxEditorial()
        {
            EditorialLN oaln = new EditorialLN();
            comboBox2.DataSource = oaln.ViewEditorialFiltro("");
            comboBox2.SelectedIndex = 0;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "Id_Editorial";
        }




        private void Codigo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
