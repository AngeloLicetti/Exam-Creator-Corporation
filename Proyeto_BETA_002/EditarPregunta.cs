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
    public partial class EditarPreguntaOM : Form
    {
        Pregunta preg;
        public EditarPreguntaOM(Pregunta preg)
        {
            InitializeComponent();
            this.preg = preg;
            txtPregunta.Text = preg.PreguntaS;
            txtOpcionA.Text = preg.OpcionA;
            txtOpcionB.Text = preg.OpcionB;
            txtOpcionC.Text = preg.OpcionC;
            txtOpcionD.Text = preg.OpcionD;
            lblPregunta.Text = "Pregunta " + Convert.ToString(preg.Numero);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtPregunta.Enabled = true;
            txtOpcionA.Enabled = true;
            txtOpcionB.Enabled = true;
            txtOpcionC.Enabled = true;
            txtOpcionD.Enabled = true;
            txtPregunta.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                preg.editarDatos(txtPregunta.Text, txtOpcionA.Text, txtOpcionB.Text, txtOpcionC.Text, txtOpcionD.Text);
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
