using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsMenu1
    {
            static int opcion = 0;

            public static void Insertar()
            {
                Console.Clear();
                do
                {

                    Console.WriteLine("1-Inicializar Vectores");
                    Console.WriteLine("2-Ingresar Paso Vehicular");
                    Console.WriteLine("3-Consulta de vehiculos por numero de placa");
                    Console.WriteLine("4-Modificar Datos Vehicular por numero de placa");
                    Console.WriteLine("5-Reporte De Todos Los Datos De Los Vectores ");
                    Console.WriteLine("6-Salir");
                    int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        ClsVehiculos.Inicializar();

                        break;
                    case 2:
                        ClsVehiculos.IngresarVehiculos();

                        break;
                    case 3:
                        ClsVehiculos.ConsultaVehicular(ClsVehiculos.SolicitarPlaca());
                        break;
                    case 4:
                        ClsVehiculos.ModificaVehiculo(ClsVehiculos.SolicitarPlaca());

                        break;
                    case 5:ClsVehiculos.ReporteGeneral();


                        break;

                    case 6: break;
                    default:
                        break;

                }

                } while (opcion != 6);

            }

    }
}
