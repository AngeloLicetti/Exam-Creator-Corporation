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
    public partial class AñadirPreguntas : Form
    {
        Examen examen = Proceso.examenes[Examen.n - 1];
        public AñadirPreguntas()
        {
            InitializeComponent();
            lblPregunta.Text = "Pregunta " + (examen.k + 1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbOpcionMultiple.Checked == true)
            {
                try
                {
                    examen.agregarPregunta(txtPregunta.Text, txtOpcionA.Text, txtOpcionB.Text, txtOpcionC.Text, txtOpcionD.Text);
                    lblPregunta.Text = "Pregunta " + (examen.k + 1);
                    limpiar();
                    txtPreguntaL.Clear();
                }
                catch (PreguntaIncompleta)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Payaso");
                }
                catch (PreguntasCompletas)
                {
                    MessageBox.Show("Ingresó las preguntas satisfactoriamente", "Listo");
                    this.Close();
                    this.Owner.Close();
                }
            }
            else if (rbSimple.Checked == true)
            {
                try
                {
                    examen.agregarPregunta(txtPreguntaL.Text);
                    lblPregunta.Text = "Pregunta " + (examen.k + 1);
                    limpiar();
                    txtPreguntaL.Clear();
                    txtPreguntaL.Focus();
                }
                catch (PreguntaIncompleta)
                {
                    MessageBox.Show("Debe completar todos los campos.", "Payaso");
                }
                catch (PreguntasCompletas)
                {
                    MessageBox.Show("Ingresó las preguntas satisfactoriamente", "Listo");
                    this.Close();
                    this.Owner.Close();
                }
            }
                
        }

        public void limpiar()
        {
            txtOpcionA.Clear();
            txtOpcionB.Clear();
            txtOpcionC.Clear();
            txtOpcionD.Clear();
            txtPregunta.Clear();
            txtPregunta.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void AñadirPreguntas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!examen.PreguntasCompletas)
            {
                Proceso.usuarioLogeado.eliminarExamen(examen.Id_examen);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (examen.k == 0)
            {
                Close();
            }
            else
            {
                examen.k--;
                lblPregunta.Text = "Pregunta " + (examen.k + 1);
                txtPreguntaL.Clear();
                limpiar();
                if (rbOpcionMultiple.Checked == true)
                {
                    txtPregunta.Focus();
                }
                else if (rbSimple.Checked == true)
                {
                    txtPreguntaL.Focus();
                }


            }
        }

        private void rbOpcionMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOpcionMultiple.Checked == true)
            {
                gbLineal.Hide();
                gbOpcionMultiple.Show();
                txtPregunta.Focus();
            }
            else
            {
                gbLineal.Show();
                gbOpcionMultiple.Hide();
                txtPreguntaL.Focus();
            }
        }
    }
}
