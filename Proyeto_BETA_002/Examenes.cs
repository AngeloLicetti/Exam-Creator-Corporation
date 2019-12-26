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
    public partial class Examenes : Form
    {
        public Examenes()
        {
            InitializeComponent();
        }

        private void Examenes_Load(object sender, EventArgs e)
        {
            Usuario usuario = Proceso.usuarioLogeado;

            if (!usuario.EsAdmin)
            {
                btnTodosLosExamenes.Enabled = false;
            }
        }

        private void btnNuevoExamen_Click(object sender, EventArgs e)
        {
            NuevoExamen nuevoExam = new NuevoExamen();
            nuevoExam.ShowDialog(this);
        }

        private void btnTodosLosExamenes_Click(object sender, EventArgs e)
        {
            TodosLosExamenes todos = new TodosLosExamenes();
            todos.ShowDialog(this);
        }

        private void btnMisExamenes_Click(object sender, EventArgs e)
        {
            MisExamenes misExams = new MisExamenes();
            misExams.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
