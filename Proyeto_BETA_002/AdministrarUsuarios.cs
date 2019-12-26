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
    public partial class AdministrarUsuarios : Form
    {
        Usuario usuario = Proceso.usuarioLogeado;
        public AdministrarUsuarios()
        {
            InitializeComponent();

            Proceso.llenarUsuarios(dgvUsuarios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario.eliminarUsuario(idSeleccionado());
            Proceso.llenarUsuarios(dgvUsuarios);    
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            AñadirUsuario añadir = new AñadirUsuario();
            añadir.ShowDialog(this);
            Proceso.llenarUsuarios(dgvUsuarios);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            usuario.editarusuario(idSeleccionado());
            Proceso.llenarUsuarios(dgvUsuarios);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string idSeleccionado()
        {
            string idSeleccionado = Convert.ToString(dgvUsuarios.CurrentRow.Cells[0].Value);
            return idSeleccionado;
        }
    }
}
