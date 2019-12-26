using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_BETA_002
{
    public partial class Cuenta : Form
    {
        Usuario usuario = Proceso.usuarioLogeado;
        public Cuenta(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void Cuenta_Load(object sender, EventArgs e)
        {
            txtId.Text = usuario.Id_usuario;
            txtTipo.Text = usuario.Tipo;
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtNombreDeUsuario.Text = usuario.Nombre_de_usuario;
            txtContraseña.Text = usuario.Contraseña;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtNombreDeUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.EditarDatos(txtNombre.Text, txtApellidos.Text, txtNombreDeUsuario.Text, txtContraseña.Text, this);
            }
            catch (DatosInvalidosUsuarioException error)
            {
                MessageBox.Show(error.Msg, "Error.");
            }
        }
    }
}
