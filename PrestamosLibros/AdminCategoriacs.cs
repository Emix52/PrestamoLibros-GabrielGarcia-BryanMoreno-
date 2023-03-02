using Datos;
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
    public partial class AdminCategoriacs : Form
    {
        public AdminCategoriacs()
        {
            InitializeComponent();
        }
        //Global
        CategoriaLN oc = new CategoriaLN();

        public void ListarCategoria(string var)
        {
            dataGridView1.DataSource = oc.ViewCategoriarFiltro(var).ToList();
        }
        private void AdminCategoriacs_Load(object sender, EventArgs e)
        {
            ListarCategoria(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListarCategoria(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCategoria frm = new EditCategoria();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Entidades.Categoria oa = frm.CrearObjeto();
                oc.CreateCategoria(oa);
                frm.Hide();
                ListarCategoria(textBox1.Text);
            }
        }
    }
}
