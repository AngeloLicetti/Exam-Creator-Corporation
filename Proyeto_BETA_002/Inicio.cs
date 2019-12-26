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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
            actualizar();
        }

        public void btnExamenes_Click(object sender, EventArgs e)
        {
            Examenes examenes = new Examenes();
            examenes.ShowDialog(this);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta(Proceso.usuarioLogeado);
            cuenta.ShowDialog(this);
        }

        private void btnAdministrarusuarios_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios admin = new AdministrarUsuarios();
            admin.ShowDialog(this);
        }


        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void timerFechaYHora_Tick(object sender, EventArgs e)
        {

            actualizar();
        }

        public void actualizar()
        {

            Usuario usuario = Proceso.usuarioLogeado;

            lblBienvenido.Text = "Bienvenido " + usuario.Nombre + " " + usuario.Apellidos;

            if (!usuario.EsAdmin)
            {
                btnAdministrarUsuarios.Enabled = false;
            }

            lblFecha.Text = "Lima, " + DateTime.Now.ToString("D");
            lblHora.Text = DateTime.Now.ToString("T");
        }
    }
}
