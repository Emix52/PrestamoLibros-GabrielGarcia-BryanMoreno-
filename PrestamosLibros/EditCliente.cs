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
    public partial class EditCliente : Form
    {
        public EditCliente()
        {
            InitializeComponent();
        }

        private void EditCliente_Load(object sender, EventArgs e)
        {

        }
        public Entidades.Estudiante auxiliar = new Entidades.Estudiante();
        public void verDatos()
        {
            textBox1.Text = auxiliar.Cedula.ToString();
            textBox2.Text = auxiliar.Nombre;
            textBox3.Text = auxiliar.Apellido;
            comboBox1.SelectedItem = auxiliar.Sexo.ToString();
            dateTimePicker1.Value = auxiliar.Fecha_Nacimiento;
           



        }
        public Entidades.Estudiante crearObjeto()
        {
            Entidades.Estudiante op;
            string ced = textBox1.Text;
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string sexo = comboBox1.SelectedItem.ToString();
            DateTime fecha = dateTimePicker1.Value;
            op = new Entidades.Estudiante(ced, nombre, apellido, char.Parse(sexo), fecha);
            return op;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
