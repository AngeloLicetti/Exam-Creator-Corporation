using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_BETA_002
{
    class DatosInvalidosUsuarioException: Exception
    {
        string msg;
        public DatosInvalidosUsuarioException(string tipo)
        {
            switch (tipo)
            {
                case "NombreDeUsuarioExistente":
                    msg = "El nombre de usuario ya existe. Por favor intente con otro.";
                    break;
                case "ContraseñaPequeña":
                    msg = "ELa contraseña debe contener como mínimo 8 caracteres alfanuméricos.";
                    
                    break;
                case "ApellidosPequeños":
                    msg = "Su apelido debe tener como mìnimo 2 letras, payaso.";
                    break;
                case "DatosIncompletos":
                    msg = "Debe completar todos los campos.";
                    break;
            }
        }

        public string Msg
        {
            get
            {
                return msg;
            }

            set
            {
                msg = value;
            }
        }
    }
}
