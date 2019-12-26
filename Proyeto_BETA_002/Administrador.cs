using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_BETA_002
{
    class Administrador:Usuario
    {
        public Administrador()
        {
            EsAdmin = true;
        }
        public override void añadirNuevoUsuario(string nombre, string apellidos, string nombreDeUsuario, string contraseña, string tipo, Form formulario)
        {
            bool nombreDeUsuarioExiste = false;

            for (int i = 0; i < Usuario.n; i++)
            {
                if (Proceso.usuarios[i].Nombre_de_usuario == nombreDeUsuario)
                {
                    nombreDeUsuarioExiste = true;
                    break;
                }
            }

            if (nombreDeUsuarioExiste)
            {
                throw new DatosInvalidosUsuarioException("NombreDeUsuarioExistente");
            }
            else if (nombre == "" || apellidos == "" || nombreDeUsuario == "" || contraseña == "" || tipo == "")
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
                if (tipo == "Administrador")
                {
                    Proceso.usuarios[n] = new Administrador();
                }
                else if (tipo == "Profesor")
                {
                    Proceso.usuarios[n] = new Profesor();
                }


                string id = Convert.ToString(DateTime.Now.Year) + Proceso.cerosOpcionales(Proceso.n) + ((Proceso.n) + 1) + nombre[0] + apellidos.Substring(0, 2);

                Proceso.usuarios[n].ingresaDatos(id, nombre, apellidos, nombreDeUsuario, contraseña, tipo);
                Proceso.n++;
                n++;

                MessageBox.Show("Usuario añadido satisfactoriamente.", "Listo.");

                formulario.Close();
            }
        }
        public override void eliminarUsuario(string idSeleccionado)
        {
            if(idSeleccionado!= Id_usuario)
            {
                int indexDelEliminado = 0;

                for (int i = 0; i < n; i++)
                {
                    if (idSeleccionado == Proceso.usuarios[i].Id_usuario)
                    {
                        indexDelEliminado = i;
                        break;
                    }
                }

                for (int i = 0; i < n - 1; i++)
                {
                    if (i >= indexDelEliminado)
                    {
                        Proceso.usuarios[i] = Proceso.usuarios[i + 1];
                    }
                }

                n--;
            }
            else
            {
                MessageBox.Show("No puede eliminar su propia cuenta.", "Payaso");
            }
        }
        public override void editarusuario(string id)
        {
            for (int i = 0; i < n; i++)
            {
                if (id == Proceso.usuarios[i].Id_usuario)
                {
                    Cuenta cuenta = new Cuenta(Proceso.usuarios[i]);
                    cuenta.ShowDialog();
                    break;
                }
            }
        }
    }
}
