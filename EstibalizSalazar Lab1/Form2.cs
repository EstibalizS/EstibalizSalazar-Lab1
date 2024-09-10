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
    public partial class Form2 : Form
    {
        public Form2(string nombreEmpleado, string cedulaEmpleado, double salario)
        {
            InitializeComponent();

            double seguroSocial = salario * 0.0975;
            double seguroEducativo = salario * 0.0125;
            double salarioNeto = salario - seguroSocial - seguroEducativo;

            lblNombreEmpleado.Text = $"Nombre del Empleado: \n{nombreEmpleado}";
            lblCedulaEmpleado.Text = $"Cédula: \n{cedulaEmpleado}";
            lblSeguroSocial.Text = $"Pago de Seguro Social: \n{seguroSocial:C}";
            lblSeguroEducativo.Text = $"Pago de Seguro Educativo: \n{seguroEducativo:C}";
            lblSalario.Text = $"Salario Mensual Neto: \n{salarioNeto:C}";


        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
