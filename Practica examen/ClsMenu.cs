using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_examen
{
    internal class ClsMenu
    {

       static int opcion =0;

        public static void Desplegar()
        {
            Console.Clear();
            do 
            {

                Console.WriteLine("1-Inicializar");
                Console.WriteLine("2-Incluir Estudiantes");
                Console.WriteLine("3-Modificar los Estudiantes ");
                Console.WriteLine("4-Consultar los Estudiantes ");
                Console.WriteLine("5-Reporte de Estudiantes ");
                Console.WriteLine("6-Salir");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:ClsEstudiante.inicializar();
                        break;
                    case 2:ClsEstudiante.Agregar();
                        break;
                    case 3: ClsEstudiante.Modificar(ClsEstudiante.solicitarcedula());
                        break;
                    case 4:
                        ClsEstudiante.Consultar(ClsEstudiante.solicitarcedula());
                        break;
                    case 5:   
                        Console.Clear();
                        Submenu();
                        break;
                
                    case 6: break; 
                    default:
                        break;
                    
                }

            



            } while (opcion!=6);




        }


        public static void Submenu() 
        {

            do
            {

                Console.WriteLine("1-Reporte de estudiante por condicion");
                Console.WriteLine("2-Reporte General");
                Console.WriteLine("3-Regresar");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        ClsEstudiante.Reporte1(ClsEstudiante.solicitarcedula());
                        break;
                    case 2:
                        ClsEstudiante.ReporteGeneral();

                        break;
                    case 3:

                        break;
                        
                   default:
                        break;

                }





            } while (opcion != 3);
        }
    }
}
