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
    public partial class EditarPreguntaL : Form
    {
        Pregunta preg;
        public EditarPreguntaL(Pregunta preg)
        {
            InitializeComponent();
            this.preg = preg;
            txtPregunta.Text = preg.PreguntaS;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtPregunta.Enabled = true;
            txtPregunta.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                preg.editarDatos(txtPregunta.Text);
                this.Close();
            }
            catch (PreguntaIncompleta)
            {
                MessageBox.Show("Debe completar todos los campos.", "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
