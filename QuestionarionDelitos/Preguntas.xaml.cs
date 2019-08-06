using System;
using System.Windows;

namespace QuestionarionDelitos
{
    public partial class Preguntas : Window
    {
        public Preguntas()
        {
            InitializeComponent();
            CambiarPreguntas();
        }

        
        int iPosicionPregunta = 0;
        int iPuntaje = 0;

        #region Preguntas y respuestas

        public string[] arPreguntas = new string[] 
        {
            "¿Cuáles son los tipos de licencia de software?",
            "¿Cuál es la importancia de la licencia en el software?",
            "¿Qué es el software libre?",
            "¿Cuál es la diferencia entre software libre y software propietario?",
            "¿Que significa CC BY SA?",
            "¿Qué es software semi-libre?",
            "¿Cuáles son los Tipos de licencias de Creative Commons?",
            "¿Qué permite el uso de la licencia CC BY ND?",
            "¿Qué significa la licencia GPL?",
            "¿Qué es shareware?"
        };
        public string[] delitoInfomatico = new string[]
        {
            "a) Software Libre o Free Software, Copyleft,GPL, Opensource.",
            "b) Windows, Linux, Ubuntu",
            "c) Microsoft Office, Adobe, Visual Studio",
            "d) Todas las anteriores"
        };

        public string[] hacker = new string[]
        {
            "a) Mejora la interacción con el usuario",
            "b) Proporciona garantías al usuario y permite que aumenten las oportunidades de competitividad.",
            "c) Costo - beneficio con el usuario",
            "d) Mejora el funcionamiento del equipo"
        };

        public string[] cracker = new string[]
        {
            "a) Programa informático cuyo código fuente no puede ser modificado y utilizado libremente",
            "b) Programa informático cuyo código fuente no puede ser distribuido",
            "c) Programa informático cuyo código fuente puede ser modificado, y utilizado libremente.",
            "d) Ninguna de las anteriores"
        };

        public string[] cualesDelitoInfomatico = new string[]
        {
            "a) El cosoto de la licencia",
            "b) Los programas que se ejecutan en la plataforma",
            "c) El programador que lo diseño",
            "d) Software Libre permite su modificación del código fuente, el software propietario no."
        };

        public string[] violaciónIntimidad = new string[]
        {
            "a) Atribución-CompartirIgual.",
            "b) Atribución-SinDerivadas",
            "c) Atribución-NoComercial-CompartirIgual",
            "d) Atribución-NoComercial-SinDerivadas"
        };

        public string[] respuestas6 = new string[]
        {
            "a) Es un software libre que permite que otros individuos lo usen, lo copien y no lo distribuyan",
            "b) Es un software con la mitad de permisos del fabricante",
            "c) Es un software que no permite que otros individuos lo usen, lo copien, lo distribuyan",
            "d) Es un software que no es libre pero permite que otros individuos lo usen, lo copien, lo distribuyan."
        };

        public string[] respuestas7 = new string[]
        {
            "a) CC BYP, CC BY SE, CC BY-ND, CC BY-NC, CC BY-NC-SA, CC BY-NC-ND",
            "b) CC BY, CC BY SA, CC BY-ND, CC BY-NC, CC BY-NC-SA, CC BY-NC-ND.",
            "c) CC BY, CC BY SA, CC BY-ND, CC BY-NC, CC BY-NC-SE, CC BY-NC-NA",
            "d) Todas las anteriores"
        };

        public string[] respuestas8 = new string[]
        {
            "a) Permite el uso comercial de la obra, pero no la generación de obras derivadas.",
            "b) Permite la genereción de obras derivadas",
            "c) Permite la libre comercialización del software",
            "d) Ninguna de las anteriores"
        };

        public string[] respuestas9 = new string[]
        {
            "a) Licencia Privada General",
            "b) Licencia Pública General Reducida de GNU.",
            "c) Licencia Poderosa Gamer",
            "d) Licencia Para Logueo"
        };

        public string[] respuestas10 = new string[]
        {
            "a) software en el que el usuario puede evaluar el producto sin limitaciones en el tiempo de uso",
            "b) software en el que el usuario no puede evaluar de forma gratuita el producto",
            "c) software en el que el usuario puede evaluar de forma gratuita, pero con limitaciones en el tiempo.",
            "d) Todas las anteriores"
        };

        #endregion

        //mostrar preguntas 
        public string MostrarPregunta()
        {
            string strPreguntaRetornada = arPreguntas[iPosicionPregunta];
            txtPregunta.Text = arPreguntas[iPosicionPregunta];
            return strPreguntaRetornada;
        }

        //cambio de preguntas y respuestas
        public string CambiarPreguntas()
        {
            string respuesta = "";

            if (iPosicionPregunta >= arPreguntas.Length)
            {
                return "";
            }

            if (MostrarPregunta() == arPreguntas[0])
            {
                CambiarRespuestas(delitoInfomatico);
                respuesta = delitoInfomatico[0];
            }
            else if (MostrarPregunta() == arPreguntas[1])
            {
                CambiarRespuestas(hacker);
                respuesta = hacker[1];
            }
            else if (MostrarPregunta() == arPreguntas[2])
            {
                CambiarRespuestas(cracker);
                respuesta = cracker[2];
            }
            else if (MostrarPregunta() == arPreguntas[3])
            {
                CambiarRespuestas(cualesDelitoInfomatico);
                respuesta = cualesDelitoInfomatico[3];
            }
            else if (MostrarPregunta() == arPreguntas[4])
            {
                CambiarRespuestas(violaciónIntimidad);
                respuesta = violaciónIntimidad[0]; 
            }
            else if (MostrarPregunta() == arPreguntas[5])
            {
                CambiarRespuestas(respuestas6);
                respuesta = cracker[3];
            }
            else if (MostrarPregunta() == arPreguntas[6])
            {
                CambiarRespuestas(respuestas7);
                respuesta = cracker[1];
            }
            else if (MostrarPregunta() == arPreguntas[7])
            {
                CambiarRespuestas(respuestas8);
                respuesta = cracker[0];
            }
            else if (MostrarPregunta() == arPreguntas[8])
            {
                CambiarRespuestas(respuestas9);
                respuesta = cracker[1];
            }
            else if (MostrarPregunta() == arPreguntas[9])
            {
                CambiarRespuestas(respuestas10);
                respuesta = cracker[2];
            }

            return respuesta;
        }

        //cambiar solo respuestas 
        public void CambiarRespuestas(string[] arrRespuestas)
        {
            int iPosicionDeRespuesta = 0;
            btnRespuesta1.Content = arrRespuestas[iPosicionDeRespuesta];
            iPosicionDeRespuesta++;
            btnRespuesta2.Content = arrRespuestas[iPosicionDeRespuesta];
            iPosicionDeRespuesta++;
            btnRespuesta3.Content = arrRespuestas[iPosicionDeRespuesta];
            iPosicionDeRespuesta++;
            btnRespuesta4.Content = arrRespuestas[iPosicionDeRespuesta];
        }

        void btnRespuesta1_Click(object sender, RoutedEventArgs e)
        {
            //Aquí se comprueba si la respuesta es correcta (linea 134)
            if (CambiarPreguntas() == Convert.ToString(btnRespuesta1.Content))
            {
                MessageBox.Show("Correcto");
                iPosicionPregunta++;
                iPuntaje++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
            else
            {
                MessageBox.Show("Mal");
                iPosicionPregunta++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
        }

        void btnRespuesta2_Click(object sender, RoutedEventArgs e)
        {
            if (CambiarPreguntas() == Convert.ToString(btnRespuesta2.Content))
            {
                MessageBox.Show("Correcto");
                iPosicionPregunta++;
                iPuntaje++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
            else
            {
                MessageBox.Show("Mal");
                iPosicionPregunta++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
        }

        void btnRespuesta3_Click(object sender, RoutedEventArgs e)
        {
            if (CambiarPreguntas() == Convert.ToString(btnRespuesta3.Content))
            {
                MessageBox.Show("Correcto");
                iPosicionPregunta++;
                iPuntaje++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
            else
            {
                MessageBox.Show("Mal");
                iPosicionPregunta++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
        }

        void btnRespuesta4_Click(object sender, RoutedEventArgs e)
        {
            
            if (CambiarPreguntas() == Convert.ToString(btnRespuesta4.Content))
            {
                MessageBox.Show("Correcto");
                iPosicionPregunta++;
                iPuntaje++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
            }
            else
            {
                MessageBox.Show("Mal");
                iPosicionPregunta++;
                if (iPosicionPregunta == arPreguntas.Length)
                {
                    int iPuntajeTotal = mostrarPuntaje();
                    MessageBox.Show(Convert.ToString(iPuntajeTotal));
                    this.Close();
                }
                else
                {
                    CambiarPreguntas();
                }
                
            }
        }

        int mostrarPuntaje()
        {
            int iReglaTres = 0 ;

            iReglaTres = iPuntaje * 100 / arPreguntas.Length;
            return iReglaTres;

        }
    }
}
