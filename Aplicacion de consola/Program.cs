using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicacion_de_consola.Clases;

namespace Aplicacion_de_consola
{
    class Program
    { 
        static void Main(string[] args)
        {
            /*         
                       //Definir e imprimir valores
                       int x = 1;
                       string texto = "El valor de x es. ";

                       Console.WriteLine(texto + x);
                       Console.WriteLine("El valor de x es: " + x);


                       //Listas
                       List<int> lista = new List<int>();

                       lista.Add(4);
                       lista.Add(19);

                       List<int> lista2 = new List<int> { 4, 19 };

                       lista2.Add(23);


                       //Ciclos
                       for (int i = 0; i < lista.Count; i++)
                       {
                           Console.WriteLine("Posicion " + i + " es: " + lista[i]);
                       }

                       foreach (int i in lista2)
                       {
                           Console.WriteLine("Valor: " + i);
                       }

           */
            Alumno alumno = new Alumno();

            alumno.cve_unica = "311779";
            alumno.nombres = "Arturo";
            alumno.apellidos = "Torres Rivera";

            Alumno alumno2 = new Alumno("54689", "Ramon", "Ortiz");

            Console.WriteLine(alumno.ObtenerInformacion());

            Materia materia = new Materia();

            

            Console.Read();
        }
    }
}
