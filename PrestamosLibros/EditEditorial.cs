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

namespace PrestamosLibros
{
    public partial class EditEditorial : Form
    {
        public EditEditorial()
        {
            InitializeComponent();
        }
        public Editorial CrearObjeto()
        {
            Editorial ob;
            int id = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string descripcion = textBox3.Text;
            ob = new Editorial(id, nombre, descripcion);
            return ob;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
