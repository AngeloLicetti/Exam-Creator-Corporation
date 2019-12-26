using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyeto_BETA_002;

namespace Proyeto_BETA_002
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();
            Proceso.cargarTodo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool ingresar = Proceso.VerificarCuenta(txtUsuario.Text, txtContraseña.Text);
            if (ingresar)
            {
                MessageBox.Show("Ingresó satisfactoriamente", "Éxito");
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
                MessageBox.Show("Nunca entrarás en su corazón </3", "Datos incorrectos");
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proceso.sobreescribirTodo();
        }
    }
}
