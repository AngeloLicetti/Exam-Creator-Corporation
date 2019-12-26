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
    public partial class EditarPreguntas : Form
    {
        Examen exam;
        public EditarPreguntas(Examen e)
        {
            InitializeComponent();
            exam = e;
            Proceso.llenarPreguntas(dgvPreguntas, exam);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            exam.editarPregunta(numeroSeleccionado());
            Proceso.llenarPreguntas(dgvPreguntas, exam);
        }
        public string numeroSeleccionado()
        {
            string num = Convert.ToString(dgvPreguntas.CurrentRow.Cells[0].Value);
            return num;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
