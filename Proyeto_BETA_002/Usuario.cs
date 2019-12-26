using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_BETA_002
{
    public class Usuario
    {
        protected string id_usuario, nombre, apellidos, nombre_de_usuario, contraseña, tipo;

        protected bool esAdmin;

        public static int n;


        public virtual void añadirNuevoUsuario(string nombre, string apellidos, string nombreDeUsuario, string contraseña, string tipo, Form formulario) { }

        public virtual void eliminarUsuario(string idSeleccionado) { }

        public virtual void editarusuario(string id) { }




        public void EditarDatos(string nombre, string apellidos, string nombreDeusuario, string contraseña, Form cuenta)
        {
            if (nombre == "" || apellidos == "" || nombreDeusuario == "" || contraseña == "")
            {
                throw new DatosInvalidosUsuarioException("DatosIncompletos");
            }
            else if (contraseña.Length < 8)
            {
                throw new DatosInvalidosUsuarioException("ContraseñaPequeña");
            }
            else if (apellidos.Length < 2)
            {
                throw new DatosInvalidosUsuarioException("ApellidosPequeños");
            }
            else
            {
                ingresaDatos(id_usuario, nombre, apellidos, nombreDeusuario, contraseña, tipo);

                cuenta.Close();
            }
        }

        public void ingresaDatos(string id, string nombre, string apellidos, string nombreDeUsuario, string contraseña, string tipo)
        {
            Id_usuario = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Nombre_de_usuario = nombreDeUsuario;
            Contraseña = contraseña;
            Tipo = tipo;
        }

        public void crearExamen(string nombre, string curso, string profesor, string grupo, int numeroDePreguntas, string idCreador)
        {
            Examen e = new Examen(nombre,curso,profesor,grupo,numeroDePreguntas, idCreador);
        }
        public void eliminarExamen(string idSeleccionado)
        {
            int indexDelEliminado = 0;
            for(int i=0; i < Examen.n; i++)
            {
                if (idSeleccionado == Proceso.examenes[i].Id_examen)
                {
                    indexDelEliminado = i;
                    Proceso.eliminarExamen(i);
                    break;
                }
            }
            for (int i = 0; i < Examen.n; i++)
            {
                if (i >= indexDelEliminado)
                {
                    Proceso.examenes[i] = Proceso.examenes[i + 1];
                }
            }
            Examen.n--;
        }

        public void editarExamen(string idExamen)
        {
            for (int i = 0; i < Proceso.n; i++)
            {
                if (idExamen == Proceso.examenes[i].Id_examen)
                {
                    EditarExamen edit = new EditarExamen(Proceso.examenes[i]);
                    edit.ShowDialog();
                    break;
                }
            }
        }

        public string Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Nombre_de_usuario
        {
            get
            {
                return nombre_de_usuario;
            }

            set
            {
                nombre_de_usuario = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public bool EsAdmin
        {
            get
            {
                return esAdmin;
            }

            set
            {
                esAdmin = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
