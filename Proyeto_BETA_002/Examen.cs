using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_BETA_002
{
    public class Examen
    {
        public Examen() { }
        private string id_examen, id_creador, nombre, profesor, creador, curso, grupo, privacidad;

        private bool preguntasCompletas;
        public static int n;

        //la variable k es un contador de preguntas
        public int k, numeroDePreguntas;

        private DateTime fechaDeCreacion, ultimaFechaDeModificacion;

        public Pregunta[] preguntas = new Pregunta[20];

        //ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS
        public Examen(string id, string nombre, string id_creador, string curso, string profesor, string grupo, DateTime fechaDeCreacion, DateTime fechaDeModificacion, int numeroDePreg)
        {
            ingresaDatos(id, nombre, id_creador, curso, profesor, grupo, fechaDeCreacion, fechaDeModificacion, numeroDePreg);
        }

        public Examen(string nombre, string curso, string profesor, string grupo, int numeroDePreg, string idCreador)
        {
            bool nombreDeExamenExiste = false;

            for (int i = 0; i < n; i++)
            {
                if (Proceso.examenes[i].Nombre == nombre)
                {
                    nombreDeExamenExiste = true;
                    break;
                }
            }

            if (nombreDeExamenExiste)
            {
                throw new DatosInvalidosExamenException("NombreDeExamenExistente");
            }
            else if (nombre == "" || curso == "" || profesor == "" || grupo == "" || idCreador == "" )
            {
                throw new DatosInvalidosExamenException("DatosIncompletos");
            }
            else if (nombre.Length < 3)
            {
                throw new DatosInvalidosExamenException("NombrePequeño");
            }
            else if (curso.Length < 3)
            {
                throw new DatosInvalidosExamenException("CursoPequeño");
            }
            else
            {

                ingresaDatos(nombre, curso, profesor, grupo, numeroDePreg, idCreador);

                id_examen = Convert.ToString(DateTime.Now.Year) + Proceso.cerosOpcionales(Proceso.contadorExamenes) + ((Proceso.contadorExamenes) + 1) +/* this.curso.Substring(0, 3) +*/ nombre.Substring(0, 3) + grupo;

                FechaDeCreacion = DateTime.Now;
                UltimaFechaDeModificacion = FechaDeCreacion;

                Proceso.examenes[n] = this;

                Proceso.contadorExamenes++;
                n++;
            }
        }
        public int PuntosPorPregunta()
        {
            int puntosPorPregunta =20 / numeroDePreguntas;
            return puntosPorPregunta;

        }
        public void ingresaDatos(string id, string nombre, string id_creador, string curso, string profesor, string grupo, DateTime fechaDeCreacion, DateTime fechaDeModificacion, int numeroDePreg)
        {
            ingresaDatos(nombre, curso, profesor, grupo, numeroDePreg, id_creador);
            Id_examen = id;
            FechaDeCreacion = fechaDeCreacion;
            UltimaFechaDeModificacion = fechaDeModificacion;
        }
        public void ingresaDatos(string nombre, string curso, string profesor, string grupo, int numeroDePreg, string idCreador)
        {
            ingresaDatos(nombre, curso, profesor, grupo);
            numeroDePreguntas = numeroDePreg;
            id_creador = idCreador;
        }
        public void ingresaDatos(string nombre, string curso, string profesor, string grupo)
        {
            Nombre = nombre;
            Curso = curso;
            Profesor = profesor;
            Grupo = grupo;
        }
        public void agregarPregunta(string pregunta)
        {
            if (k < numeroDePreguntas)
            {
                preguntas[k] = new Pregunta(k + 1, Id_examen, pregunta);
                k++;
                if (k == numeroDePreguntas)
                {
                    preguntasCompletas = true;
                    throw new PreguntasCompletas();
                }
            }
        }
        public void agregarPregunta(string pregunta, string a, string b, string c, string d)
        {
            if (k < numeroDePreguntas)
            {
                preguntas[k] = new Pregunta(k+1,Id_examen,pregunta, a, b, c, d);
                k++;
                if (k == numeroDePreguntas)
                {
                    preguntasCompletas = true;
                    throw new PreguntasCompletas();
                }
            }
        }
        

        public void editarDatos(string nombre, string curso, string profesor, string grupo)
        {
            if (nombre == "" || curso == "" || profesor == "" || grupo == "")
            {
                throw new DatosInvalidosExamenException("DatosIncompletos");
            }
            else if (nombre.Length < 3)
            {
                throw new DatosInvalidosExamenException("NombrePequeño");
            }
            else if (curso.Length < 3)
            {
                throw new DatosInvalidosExamenException("CursoPequeño");
            }
            else
            {
                ingresaDatos(nombre, curso, profesor, grupo);
            }
        }

        public void cambiarFechaDeModificacion()
        {
            UltimaFechaDeModificacion = DateTime.Now;
        }
        
        public void agregarPregunta(int numero, string pregunta, string a, string b, string c, string d)
        {
            preguntas[k] = new Pregunta(k + 1, Id_examen, pregunta, a, b, c, d);
            k++;
        }

        public void editarPregunta(string numero)
        {
            int num = Convert.ToInt32(numero);
            Pregunta p = preguntas[num-1];
            if (p.EsOM)
            {
                EditarPreguntaOM editarP = new EditarPreguntaOM(p);
                editarP.ShowDialog();
            }
            else
            {
                EditarPreguntaL editarPL = new EditarPreguntaL(p);
                editarPL.ShowDialog();
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

        public string Profesor
        {
            get
            {
                return profesor;
            }

            set
            {
                profesor = value;
            }
        }

        public string Curso
        {
            get
            {
                return curso;
            }

            set
            {
                curso = value;
            }
        }

        public string Grupo
        {
            get
            {
                return grupo;
            }

            set
            {
                grupo = value;
            }
        }

        public string Privacidad
        {
            get
            {
                return privacidad;
            }

            set
            {
                privacidad = value;
            }
        }

        public DateTime FechaDeCreacion
        {
            get
            {
                return fechaDeCreacion;
            }

            set
            {
                fechaDeCreacion = value;
            }
        }

        public DateTime UltimaFechaDeModificacion
        {
            get
            {
                return ultimaFechaDeModificacion;
            }

            set
            {
                ultimaFechaDeModificacion = value;
            }
        }

        public string Id_examen
        {
            get
            {
                return id_examen;
            }

            set
            {
                id_examen = value;
            }
        }

        public string Creador
        {
            get
            {
                for(int i =0; i < Usuario.n; i++)
                {
                    if (id_creador == Proceso.usuarios[i].Id_usuario)
                    {
                        creador = Proceso.usuarios[i].Nombre + " " + Proceso.usuarios[i].Apellidos;
                        break;
                    }
                }
                return creador;
            }

            set
            {
                creador = value;
            }
        }

        public string Id_creador
        {
            get
            {
                return id_creador;
            }

            set
            {
                id_creador = value;
            }
        }
        

        public bool PreguntasCompletas
        {
            get
            {
                return preguntasCompletas;
            }

            set
            {
                preguntasCompletas = value;
            }
        }

        public bool esPublico()
        {
            bool publico = false;

            if (Privacidad == "Publico")
            {
                publico = true;
            }

            return publico;
        }
    }
}
