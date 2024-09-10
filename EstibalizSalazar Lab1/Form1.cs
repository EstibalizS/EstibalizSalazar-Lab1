using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstibalizSalazar_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            string nombreEmpleado = txtNombre.Text;
            string cedulaEmpleado = txtCedula.Text;
            double salario = 0;

            if (double.TryParse(txtSalario.Text, out salario))
            {
                Form2 form2 = new Form2(nombreEmpleado, cedulaEmpleado, salario);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor ingrese unicamente valores numericos");
            }
        }
    }
}
