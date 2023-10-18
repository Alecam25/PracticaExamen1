using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Practica_examen
{
    internal class ClsEstudiante
    {
        static int cantidad = 2;
      
        static public string[] Cedula = new string[cantidad];
       
        static string[] nombre = new string[cantidad];

        static public int[] nota = new int[cantidad];  


        // metodos

          static public void inicializar()
        {
         
           Cedula = Enumerable.Repeat("",cantidad).ToArray();
           nombre = Enumerable.Repeat("", cantidad).ToArray();
           nota = Enumerable.Repeat(1, cantidad).ToArray();

           foreach (var item in nota)
            {
                Console.WriteLine(item);

            }





        }


       static public void Agregar ( )
        {
            Console.Clear();
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digte la cedula {0}:  ",cont);
                Cedula[i]=Console.ReadLine();
                Console.WriteLine("Digte el nombre {0}:  ",cont);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Digte la nota {0}:  ",cont);
                int.TryParse(Console.ReadLine(), out nota[i]);
                cont++;
                Console.Clear();

            }

        }

     public static string solicitarcedula()
        {
            Console.WriteLine("Digite la cedula");
            string ced = Console.ReadLine();
            return ced;

        }
        public static string solicitarnota()
        {
            Console.WriteLine("Digite la nota");

            string not = Console.ReadLine();
            return not;

        }






        public static void Modificar(string ced) 
        {
        
            bool encontrado=false;  
          
             for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine("Digte el nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Digte la nota: ");
                    int.TryParse(Console.ReadLine(), out nota[i]);
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Estudiante no encontrado");
             

                }
                Console.Clear();


            }





        }






        public static void Consultar(string ced)
        {

            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]} y la nota: {nota[i]}");
                    break;
                    encontrado = true; 
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Estudiante no encontrado");
                }


            }
        }
        public static void Reporte1(string ced)
        {

            bool encontrado = false;

            for (int i = 0; i < cantidad; i++)

            {
                if (ced.Equals(Cedula[i]))
                {
                    Console.WriteLine($"Nombre: {nombre[i]} y la nota: {nota[i]}");
                    encontrado = true;
             

                }
                if (nota[i] > 70)
                {

                    Console.WriteLine($"El estudiante: {nombre[i]} de cedula: {ced} esta aprobado");


                }
                else if (nota[i] < 70 || nota[i] > 60)
                {
                    Console.WriteLine($"El estudiante: {nombre[i]} de cedula: {ced} esta aplazado");


                }
                else if (nota[i] < 60)
                {
                    Console.WriteLine($"El estudiante: {nombre[i]} de cedula: {ced} esta reprobado");

                }
                else if (!encontrado)
                {
                    Console.WriteLine("Estudiante no encontrado");
                }
            }


        }

        public static void ReporteGeneral()
        {

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("==================================================================================================================================");

                if (nota[i] > 70)
                {
                    Console.WriteLine($"La cedula es:{Cedula[i]}------El nombre es:{nombre[i]}------La nota es:{nota[i]}-----Aprobado");

                }
                else if (nota[i] < 70 || nota[i] > 60)
                {

                    Console.WriteLine($"La cedula es:{Cedula[i]}------El nombre es:{nombre[i]}------La nota es:{nota[i]}-----Aplazado");

                }
                else if (nota[i] < 60)
                {
                    Console.WriteLine($"La cedula es:{Cedula[i]}------El nombre es:{nombre[i]}------La nota es:{nota[i]}------Reprobado");

                }
                Console.WriteLine("==================================================================================================================================");






            }





        }





    }
}
