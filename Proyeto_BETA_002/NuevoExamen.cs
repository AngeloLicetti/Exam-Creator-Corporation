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
    public partial class NuevoExamen : Form
    {
        Usuario usuario = Proceso.usuarioLogeado;
        public NuevoExamen()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string idCreador = usuario.Id_usuario;
            try
            {
                usuario.crearExamen(txtNombre.Text, txtCurso.Text, txtProfesor.Text, txtGrupo.Text, Convert.ToInt32(cbNumeroDePreguntas.Text), idCreador);
                MessageBox.Show("Ahora ingrese las preguntas", "¡Listo!");
                AñadirPreguntas añadirPregs = new AñadirPreguntas();
                añadirPregs.ShowDialog(this);
            }
            catch (FormatException)
            {
                MessageBox.Show("Selecciones un número de preguntas.", "Ups (payaso)");
            }
            catch (DatosInvalidosExamenException error)
            {
                MessageBox.Show(error.Msg, "ERROR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
