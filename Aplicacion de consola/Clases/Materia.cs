using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola.Clases
{
    public class Materia
    {
        /// <summary>
        /// Variable del nombre de la materia
        /// </summary>
        private string nombre;
        private int noAlumnos;
        public string Codigo { get; set; }

        /// <summary>
        /// Método de acceso a la variable nombre
        /// </summary>
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

        public int NoAlumnos
        {
            get
            {
                return noAlumnos;
            }
            set
            {
                noAlumnos = value;
            }
        }
    }
}
