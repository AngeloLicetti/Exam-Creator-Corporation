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
    public partial class AñadirUsuario : Form
    {
        Usuario usuario = Proceso.usuarioLogeado;
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.añadirNuevoUsuario(txtNombre.Text, txtApellidos.Text, txtNombreDeUsuario.Text, txtContraseña.Text, cbTipo.Text, this);
            }
            catch(DatosInvalidosUsuarioException error)
            {
                MessageBox.Show(error.Msg,"ERROR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
