using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_BETA_002
{
    public class Pregunta
    {
        int numero;
        string id_Examen, preguntaS, opcionA, opcionB, opcionC, opcionD;
        bool esOM;

        string[] respuestas = new string[4];

        public Pregunta(int num, string id_examen, string pregunta, string a, string b, string c, string d)
        {
            Numero = num;
            Id_Examen = id_examen;
            editarDatos(pregunta, a, b, c, d);
            esOM = true;
        }

        public Pregunta(int num , string id_examen, string pregunta)
        {
            Numero = num;
            Id_Examen = id_examen;
            editarDatos(pregunta);
            esOM = false;
        }

        public void editarDatos(string pregunta, string a, string b, string c, string d)
        {
            if (pregunta == "" || a == "" || b == "" || c == "" || d == "")
            {
                throw new PreguntaIncompleta();
            }
            PreguntaS = pregunta;
            OpcionA = a;
            OpcionB = b;
            OpcionC = c;
            OpcionD = d;
        }
        public void editarDatos(string pregunta)
        {
            if (pregunta == "")
            {
                throw new PreguntaIncompleta();
            }
            PreguntaS = pregunta;
        }

        public string Id_Examen
        {
            get
            {
                return id_Examen;
            }

            set
            {
                id_Examen = value;
            }
        }

        public string OpcionA
        {
            get
            {
                return opcionA;
            }

            set
            {
                opcionA = value;
            }
        }

        public string OpcionB
        {
            get
            {
                return opcionB;
            }

            set
            {
                opcionB = value;
            }
        }

        public string OpcionC
        {
            get
            {
                return opcionC;
            }

            set
            {
                opcionC = value;
            }
        }

        public string OpcionD
        {
            get
            {
                return opcionD;
            }

            set
            {
                opcionD = value;
            }
        }

        public string PreguntaS
        {
            get
            {
                return preguntaS;
            }

            set
            {
                preguntaS = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public bool EsOM
        {
            get
            {
                return esOM;
            }

            set
            {
                esOM = value;
            }
        }
    }
}
