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
    public partial class MisExamenes : Form
    {
        Usuario usuario = Proceso.usuarioLogeado;
        public MisExamenes()
        {
            InitializeComponent();
            Proceso.llenarExamenes(dgvExamenes, usuario);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.editarExamen(idSeleccionado());
                Proceso.llenarExamenes(dgvExamenes, usuario);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ningún examen seleccionado", "Error: referencia nula");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.eliminarExamen(idSeleccionado());
                Proceso.llenarExamenes(dgvExamenes, usuario);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ningún examen seleccionado", "Error: referencia nula");
            }
            
        }
        public string idSeleccionado()
        {
            string idSeleccionado = Convert.ToString(dgvExamenes.CurrentRow.Cells[0].Value);
            return idSeleccionado;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbrirEnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                Proceso.abrirPdf(idSeleccionado());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ningún examen seleccionado", "Error: referencia nula");
            }
        }
    }
}
