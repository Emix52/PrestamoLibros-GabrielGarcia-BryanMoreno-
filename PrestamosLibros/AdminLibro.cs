using Entidades;
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
    public partial class AdminLibro : Form
    {
        public AdminLibro()
        {
            InitializeComponent();
        }
        LibroLN ol = new LibroLN();
        public void ListarLibro(string var)
        {
            dataGridView1.DataSource = ol.ViewLibroFiltro(var).ToList();
        }
        private void AdminLibro_Load(object sender, EventArgs e)
        {
            ListarLibro(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListarLibro(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditLibro frm = new EditLibro();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Entidades.Libro oa = frm.crearObjeto();
                ol.CreateLibro(oa);
                frm.Hide();
                ListarLibro(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Libro oa = dataGridView1.CurrentRow.DataBoundItem as Entidades.Libro;
                EditLibro frm = new EditLibro();
                frm.auxiliar = oa;
                frm.verDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    ol.UpdateLibro(frm.crearObjeto());
                    frm.Hide();
                    ListarLibro(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ol.DeleteLibro(dataGridView1.CurrentRow.DataBoundItem as Entidades.Libro);
                ListarLibro(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
