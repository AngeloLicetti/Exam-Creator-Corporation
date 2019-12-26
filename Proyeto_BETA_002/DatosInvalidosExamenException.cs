using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyeto_BETA_002
{
    class DatosInvalidosExamenException:Exception
    {
        string msg;
        public DatosInvalidosExamenException(string tipo)
        {
            switch (tipo)
            {
                case "NombreDeExamenExistente":
                    
                    Msg="El nombre del examen ya existe. Por favor intente con otro.";
                    break;
                case "NombrePequeño":
                    Msg = "El nombre del examnen debe contener por lo menos 3 caracteres.";
                    break;
                case "CursoPequeño":
                    Msg = "El nombre del curso debe contener por lo menos 3 caracteres.";
                    break;
                case "DatosIncompletos":
                    Msg = "Debe completar todos los campos.";
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
