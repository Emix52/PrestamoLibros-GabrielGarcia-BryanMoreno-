using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrestamosLibros
{
    public partial class EditCategoria : Form
    {
        public EditCategoria()
        {
            InitializeComponent();
        }
        public Categoria CrearObjeto()
        {
            Categoria ob;
            int idcategoria = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string descripcion = textBox3.Text;
            ob = new Categoria(idcategoria,nombre,descripcion);
            return ob;

        }
        private void EditCategoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
