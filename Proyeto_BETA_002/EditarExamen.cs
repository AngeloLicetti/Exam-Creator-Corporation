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
    public partial class EditarExamen : Form
    {
        Examen examen;
        public EditarExamen(Examen exam)
        {
            InitializeComponent();
            examen = exam;
        }

        private void EditarExamen_Load(object sender, EventArgs e)
        {
            txtIdExamen.Text = examen.Id_examen;
            txtIdCreador.Text = examen.Id_creador;
            txtNombre.Text = examen.Nombre;
            txtCurso.Text = examen.Curso;
            txtProfesor.Text = examen.Profesor;
            txtGrupo.Text = examen.Grupo;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCurso.Enabled = true;
            txtProfesor.Enabled = true;
            txtGrupo.Enabled = true;
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                examen.editarDatos(txtNombre.Text, txtCurso.Text, txtProfesor.Text, txtGrupo.Text);
                txtNombre.Enabled = false;
                txtCurso.Enabled = false;
                txtProfesor.Enabled = false;
                txtGrupo.Enabled = false;
            }
            catch (DatosInvalidosExamenException error)
            {
                MessageBox.Show(error.Msg, "Error");
            }
        }

        private void btnEditarPreguntas_Click(object sender, EventArgs e)
        {
            EditarPreguntas edit = new EditarPreguntas(examen);
            edit.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditarExamen_FormClosed(object sender, FormClosedEventArgs e)
        {
            examen.cambiarFechaDeModificacion();
        }
    }
}
