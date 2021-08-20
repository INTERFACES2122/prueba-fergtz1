using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_de_consola
{
    public class Alumno
    {
        public string cve_unica;
        public string nombres;
        public string apellidos;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Alumno() { }

        /// <summary>
        /// Constructor de la clase que asigna información inicial
        /// </summary>
        /// <param name="_cve_unica">la clave</param>
        /// <param name="_nombres">el nombre</param>
        /// <param name="_apellidos">el last name</param>
        public Alumno(string _cve_unica, string _nombres, string _apellidos)
        {
            cve_unica = _cve_unica;
            nombres = _nombres;
            apellidos = _apellidos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ObtenerInformacion()
        {
            string informacion = "";
            informacion = cve_unica + " - " + nombres + " - " + apellidos;

            return informacion;
        }
    }
}
