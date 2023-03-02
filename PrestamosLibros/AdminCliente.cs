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
    public partial class AdminCliente : Form
    {
        public AdminCliente()
        {
            InitializeComponent();
        }
        EstudianteLN oe = new EstudianteLN();

        public void ListarEstudiante(string var)
        {
            dataGridView1.DataSource = oe.ViewEstudianterFiltro(var);
        }
        private void AdminCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oe.ViewEstudianterFiltro(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oe.ViewEstudianterFiltro(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditCliente frm = new EditCliente();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Entidades.Estudiante oa = frm.crearObjeto();
                oe.CreateEstudiante(oa);
                frm.Hide();
                ListarEstudiante(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Estudiante oa = dataGridView1.CurrentRow.DataBoundItem as Entidades.Estudiante;
                EditCliente frm = new EditCliente();
                frm.auxiliar = oa;
                frm.verDatos();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    oe.UpdateEstudiante(frm.crearObjeto());
                    frm.Hide();
                    ListarEstudiante(textBox1.Text);
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
                oe.DeleteEstudiante(dataGridView1.CurrentRow.DataBoundItem as Entidades.Estudiante);
                ListarEstudiante(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
