using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Proyeto_BETA_002
{
    public static class Proceso
    {
        //Variable n para contar todos los usuarios que han sido creados desde la creación del programa (incluyendo los eliminados)
        public static int n, contadorExamenes;

        public static Usuario usuarioLogeado;

        public static Usuario[] usuarios = new Usuario[100];

        public static Examen[] examenes = new Examen[1000];


        public static void CargarUsuarios()
        {
            try
            {
            
                StreamReader lector = new StreamReader("Usuarios.txt");
                lector.ReadLine();

                string usuario = "";

                while (lector.Peek() != (-1))
                {
                    usuario = lector.ReadLine();
                    string[] datosUsuario = usuario.Split(',');

                    if (datosUsuario[5] == "Administrador")
                    {
                        usuarios[Usuario.n] = new Administrador();
                        usuarios[Usuario.n].ingresaDatos(datosUsuario[0], datosUsuario[1], datosUsuario[2], datosUsuario[3], datosUsuario[4], datosUsuario[5]);
                    }
                    else if (datosUsuario[5] == "Profesor")
                    {
                        usuarios[Usuario.n] = new Profesor();
                        usuarios[Usuario.n].ingresaDatos(datosUsuario[0], datosUsuario[1], datosUsuario[2], datosUsuario[3], datosUsuario[4], datosUsuario[5]);
                    }
                    Usuario.n++;
                }

                lector.Close();

            }

            catch
            {
                MessageBox.Show("No se encontró el archivo dónde se almacenan los usuarios. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }
        }

        public static void cargarN()
        {
            try
            {

                StreamReader lector = new StreamReader("NumeroUsuarios.txt");
                n = Convert.ToInt32(lector.ReadLine());
                

                lector.Close();

            }

            catch
            {
                MessageBox.Show("No se encontró un archivo. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }
        }

        public static void cargarContadorExamenes()
        {
            try
            {

                StreamReader lector = new StreamReader("NumeroExamenes.txt");
                contadorExamenes = Convert.ToInt32(lector.ReadLine());


                lector.Close();

            }

            catch
            {
                MessageBox.Show("No se encontró un archivo. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }
        }

        //ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS
        public static void cargarExamenes()
        {
            try
            {

                StreamReader lector = new StreamReader("Examenes.txt");
                lector.ReadLine();

                string examen = "";

                while (lector.Peek() != (-1))
                {
                    examen = lector.ReadLine();
                    string[] datosExamen = examen.Split(',');

                    examenes[Examen.n] = new Examen(datosExamen[0], datosExamen[1], datosExamen[2], datosExamen[3],datosExamen[4], datosExamen[5], Convert.ToDateTime(datosExamen[6]), Convert.ToDateTime(datosExamen[7]), Convert.ToInt32(datosExamen[8]));
                    Examen.n++;
                }

                lector.Close();

            }

            catch
            {
                MessageBox.Show("No se encontró el archivo dónde se almacenan los examenes. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }
        }
        public static void cargarPreguntas()
        {
            try
            {
            
                StreamReader lector = new StreamReader("Preguntas.txt");
                lector.ReadLine();

                string pregunta = "";

                while (lector.Peek() != (-1))
                {
                    pregunta = lector.ReadLine();
                    string[] datosPregunta = pregunta.Split(',');
                    //ID_EXAMEN,NUMERO,TIPO,PREGUNTA,OPCION_A,OPCION_B,OPCION_C,OPCION_D

                    for (int i = 0; i < Examen.n; i++)
                    {
                        if (datosPregunta[0] == examenes[i].Id_examen)
                        {
                        try
                        {
                            if (datosPregunta[2] == "OM")
                            {
                                examenes[i].agregarPregunta(Convert.ToInt32(datosPregunta[1]), datosPregunta[3], datosPregunta[4], datosPregunta[5], datosPregunta[6], datosPregunta[7]);

                            }
                            else if (datosPregunta[2] == "L")
                            {
                                examenes[i].agregarPregunta(datosPregunta[3]);
                            }
                        }
                        catch
                        { }  
                        }
                    }
                    
                }

                lector.Close();

            }

            catch
            {
                MessageBox.Show("No se encontró el archivo dónde se almacenan las preguntas. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }
        }

        public static void cargarTodo()
        {
            cargarN();
            cargarContadorExamenes();
            CargarUsuarios();
            cargarExamenes();
            cargarPreguntas();
        }

        public static void sobreescribirusuarios()
        {
            string usuariosTxt = "ID_USUARIO,NOMBRE,APELLIDOS,NOMBRE_DE_USUARIO,CONTRASEÑA,TIPO";

            for (int i = 0; i < Usuario.n; i++)
            {
                usuariosTxt += "\r\n" + usuarios[i].Id_usuario + "," + usuarios[i].Nombre + "," + usuarios[i].Apellidos + "," + usuarios[i].Nombre_de_usuario + "," + usuarios[i].Contraseña + "," + usuarios[i].Tipo;
            }
            File.WriteAllText("Usuarios.txt", usuariosTxt);
        }

        public static void sobreeascribirExamenes()
        {
            string examenTxt = "ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS";

            for (int i = 0; i < Examen.n; i++)
            {
                examenTxt += "\r\n" + examenes[i].Id_examen + "," + examenes[i].Nombre + "," + examenes[i].Id_creador + "," + examenes[i].Curso + "," + examenes[i].Profesor + "," + examenes[i].Grupo + "," + examenes[i].FechaDeCreacion + "," + examenes[i].UltimaFechaDeModificacion + "," + examenes[i].numeroDePreguntas;
            }
            File.WriteAllText("Examenes.txt", examenTxt);
        }

        public static void sobreescribirNumeroDe(string nombre, string n)
        {
            File.WriteAllText(nombre, n);
        }

        public static void sobreescribirPreguntas()
        {
            string preguntasTxt = "ID_EXAMEN,NUMERO,TIPO,PREGUNTA,OPCION_A,OPCION_B,OPCION_C,OPCION_D";
            for (int i = 0; i < Examen.n; i++)
            {
                for(int j=0; j < examenes[i].numeroDePreguntas; j++)
                {
                    Pregunta temp = examenes[i].preguntas[j];
                    if (temp.EsOM)
                    {
                        preguntasTxt += "\r\n" + temp.Id_Examen + "," + temp.Numero + "," + "OM," + temp.PreguntaS + "," + temp.OpcionA + "," + temp.OpcionB + "," + temp.OpcionC + "," + temp.OpcionD;
                    }
                    else
                    {
                        preguntasTxt += "\r\n" + temp.Id_Examen + "," + temp.Numero + "," + "L," + temp.PreguntaS;
                    }
                }
            }
            File.WriteAllText("Preguntas.txt", preguntasTxt);
        }

        public static void sobreescribirTodo()
        {
            sobreescribirNumeroDe("NumeroUsuarios.txt", n.ToString());
            sobreescribirNumeroDe("NumeroExamenes.txt", contadorExamenes.ToString());
            sobreescribirusuarios();
            sobreeascribirExamenes();
            sobreescribirPreguntas();
        }

        public static bool VerificarCuenta(string nombreDeUsuario, string contraseña)
        {
            bool existe = false;
            try
            {

                for(int i = 0; i < Usuario.n; i++)
                {
                    if (nombreDeUsuario == usuarios[i].Nombre_de_usuario && contraseña == usuarios[i].Contraseña)
                    {
                        existe = true;
                        usuarioLogeado = usuarios[i];
                        break;
                    }
                }

            }

            catch
            {
                MessageBox.Show("Error. Si desea solucionar el problema contacte al desarrollador de este software.", "ERROR");
            }

            return existe;
        }


        public static void llenarUsuarios(DataGridView tabla)
        {
            tabla.Rows.Clear();
            for(int i = 0; i < Usuario.n; i ++)
            {
                Usuario us = usuarios[i];

                string[] datosFila = new string[6];

                datosFila[0] = us.Id_usuario;
                datosFila[1] = us.Nombre;
                datosFila[2] = us.Apellidos;
                datosFila[3] = us.Nombre_de_usuario;
                datosFila[4] = us.Contraseña;
                datosFila[5] = us.Tipo;

                tabla.Rows.Add(datosFila);
            }
        }

        public static void llenarExamenes(DataGridView tabla)
        {
            tabla.Rows.Clear();
            for (int i = 0; i < Examen.n; i++)
            {
                Examen ex = examenes[i];

                string[] datosFila = new string[9];

                //ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS
                datosFila[0] = ex.Id_examen;
                datosFila[1] = ex.Nombre;
                datosFila[2] = ex.Id_creador;
                datosFila[3] = ex.Curso;
                datosFila[4] = ex.Profesor;
                datosFila[5] = ex.Grupo;
                datosFila[6] = Convert.ToString(ex.FechaDeCreacion);
                datosFila[7] = Convert.ToString(ex.UltimaFechaDeModificacion);
                datosFila[8] = Convert.ToString(ex.numeroDePreguntas);


                tabla.Rows.Add(datosFila);
            }
        }
        public static void llenarExamenes(DataGridView tabla, Usuario usuario)
        {
            tabla.Rows.Clear();
            for (int i = 0; i < Examen.n; i++)
            {
                Examen ex = examenes[i];
                if (usuario.Id_usuario == ex.Id_creador)
                {

                    string[] datosFila = new string[9];

                    //ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS
                    datosFila[0] = ex.Id_examen;
                    datosFila[1] = ex.Nombre;
                    datosFila[2] = ex.Id_creador;
                    datosFila[3] = ex.Curso;
                    datosFila[4] = ex.Profesor;
                    datosFila[5] = ex.Grupo;
                    datosFila[6] = Convert.ToString(ex.FechaDeCreacion);
                    datosFila[7] = Convert.ToString(ex.UltimaFechaDeModificacion);
                    datosFila[8] = Convert.ToString(ex.numeroDePreguntas);
                    tabla.Rows.Add(datosFila);
                }
            }
        }
        public static void llenarPreguntas(DataGridView tabla, Examen exam)
        {
            tabla.Rows.Clear();
            for (int i = 0; i < exam.numeroDePreguntas; i++)
            {
                Pregunta p = exam.preguntas[i];

                string[] datosFila = new string[6];

                //ID_EXAMEN,NOMBRE,ID_CREADOR,CURSO,PROFESOR,GRUPO,FECHA_CREACION,ULTIMA_FECHA_MODIFICACION,NUMERO_DE_PREGUNTAS
                datosFila[0] = Convert.ToString(p.Numero);
                datosFila[1] = p.PreguntaS;


                tabla.Rows.Add(datosFila);
            }
        }

        public static string cerosOpcionales(int x)
        {
            string cerosOpcionales = "";
            if (Convert.ToString(x + 1).Length < 3)
            {
                if (Convert.ToString(x + 1).Length < 2)
                {
                    cerosOpcionales = "00";
                }
                else
                {
                    cerosOpcionales = "0";
                }
            }
            return cerosOpcionales;
        }
        public static void eliminarExamen(int i)
        {
            string ruta = Directory.GetCurrentDirectory() + @"\examenes\" + examenes[i].Nombre + ".pdf";
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
        }
        public static void abrirPdf(string idExamen)
        {
            Examen e = new Examen();
            for (int i = 0; i <n; i++)
            {
                if (idExamen == examenes[i].Id_examen)
                {
                    e = examenes[i];
                    break;
                }
            }

            object oMissing = System.Reflection.Missing.Value;
            Word._Document oDoc;
            Word._Application oWord;
            oWord = new Word.Application();

            string ruta = Directory.GetCurrentDirectory() + @"\examenes\";

            oDoc = oWord.Documents.Open(ruta + "Examen_plantilla.docx", ref oMissing, ref oMissing, ref oMissing, "09230300");
            oDoc.Bookmarks["nombre"].Select();
            oWord.Selection.TypeText(e.Nombre);
            oDoc.Bookmarks["curso"].Select();
            oWord.Selection.TypeText(e.Curso);
            oDoc.Bookmarks["profesor"].Select();
            oWord.Selection.TypeText(e.Profesor);
            oDoc.Bookmarks["grupo"].Select();
            oWord.Selection.TypeText(e.Grupo);

            string añadir="";
            for (int i =0; i< e.numeroDePreguntas; i++)
            {
                string linea = "_____________________________________________________________________________";
                if (e.preguntas[i].EsOM)
                {
                    añadir += i + 1 + ".- " + e.preguntas[i].PreguntaS + "\r\n\tA) " + e.preguntas[i].OpcionA + "\t\t\tB) " + e.preguntas[i].OpcionB + "\r\n\tC) " + e.preguntas[i].OpcionC + "\t\t\tD) " + e.preguntas[i].OpcionD + "\r\n\r\n";
                }
                else
                {
                    añadir += i + 1 + ".- " + e.preguntas[i].PreguntaS + "\r\n" + linea + "\r\n" + linea + "\r\n" + linea + "\r\n" + linea + "\r\n\r\n";
                }
            }

            oDoc.Bookmarks["añadir"].Select();
            oWord.Selection.TypeText(añadir);

            oDoc.SaveAs2(ruta + e.Nombre + ".pdf", Word.WdSaveFormat.wdFormatPDF);
            
            oWord.Quit(false);

            System.Diagnostics.Process.Start(ruta + e.Nombre + ".pdf");
        }

    }
}
