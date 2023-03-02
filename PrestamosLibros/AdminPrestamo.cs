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
    public partial class AdminPrestamo : Form
    {
        public AdminPrestamo()
        {
            InitializeComponent();
        }
        Prestamo_LibrosLN op = new Prestamo_LibrosLN();
        private void button1_Click(object sender, EventArgs e)
        {
            frmEstudiante frm = new frmEstudiante();


            
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                string id = frm.cod;
                textBox1.Text = id.ToString();
                edad = frm.edad_estudiante;
            }
            else
            {
                frm.Close();

            }
        }
        //global
        int categoria;
        int edad;
        private void AdminPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLibro frm = new frmLibro();



            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                string id = frm.cod;
                textBox2.Text = id.ToString();
                categoria = frm.idcategoria;
            }
            else
            {
                frm.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(categoria!=5 || edad >= 18) {

                int id = int.Parse(textBox3.Text);
                string ced = textBox1.Text;
                int cod = int.Parse(textBox2.Text);
                DateTime fechadevolucion = dateTimePicker1.Value;
                DateTime fechaentrega = dateTimePicker2.Value;
                Prestamo_Libros ob = new Prestamo_Libros(id, ced, cod, fechadevolucion, fechaentrega);
                op.CreatePrestamo(ob);
            }
            else
            {
                MessageBox.Show("Es menor de edad no pude alquilar eso");
            }

            
        }
    }
}
