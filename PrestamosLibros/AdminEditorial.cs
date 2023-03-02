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
    public partial class AdminEditorial : Form
    {
        public AdminEditorial()
        {
            InitializeComponent();
        }
        EditorialLN oe = new EditorialLN();

        public void listarEditorial(string var)
        {
            dataGridView1.DataSource = oe.ViewEditorialFiltro(var);
        }
        private void AdminEditorial_Load(object sender, EventArgs e)
        {
            listarEditorial(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listarEditorial(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditEditorial frm = new EditEditorial();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Entidades.Editorial oa = frm.CrearObjeto();
                oe.CreateEditorial(oa);
                frm.Hide();
                listarEditorial(textBox1.Text);
            }
        }
    }
}
