using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen2
{
    internal class ClsVehiculos
    {

        static int cantidad = 2;

        static public string[] NumeroFactura = new string[cantidad];
        static public string[] NumeroPlaca = new string[cantidad];
        static public string[] Fecha = new string[cantidad];
        static public string[] Hora = new string[cantidad];
        static public int[] TipoVehiculo = new int[cantidad];
        static public string[] NumeroCaseta = new string[cantidad];
        static public int[] MontoPagar = new int[cantidad];
        static public int[] PagaCon = new int[cantidad];
        static public int[] Vuelto = new int[cantidad];


        public static void Inicializar()
        {

            NumeroFactura = Enumerable.Repeat("", cantidad).ToArray();

            NumeroPlaca = Enumerable.Repeat("", cantidad).ToArray();

            Fecha = Enumerable.Repeat("", cantidad).ToArray();

            Hora = Enumerable.Repeat("", cantidad).ToArray();

            TipoVehiculo = Enumerable.Repeat(1, cantidad).ToArray();

            NumeroCaseta = Enumerable.Repeat("", cantidad).ToArray();

            MontoPagar = Enumerable.Repeat(1, cantidad).ToArray();

            PagaCon = Enumerable.Repeat(1, cantidad).ToArray();

            Vuelto = Enumerable.Repeat(1, cantidad).ToArray();


            foreach (var item in MontoPagar)
            {
                Console.WriteLine(item);

            }
            foreach (var item in PagaCon)
            {
                Console.WriteLine(item);

            }

            foreach (var item in Vuelto)
            {
                Console.WriteLine(item);

            }

            foreach (var item in TipoVehiculo)
            {
                Console.WriteLine(item);

            }

        }

        public static void IngresarVehiculos()

        {
            Console.Clear();
            int cont = 1;
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digte el Numero de Factura {0}:  ", cont);
                NumeroFactura[i] = Console.ReadLine();

                Console.WriteLine("Digte el Numero de Placa {0}:  ", cont);
                NumeroPlaca[i] = Console.ReadLine();

                Console.WriteLine("Digte la Fecha de Ingreso {0}:  ", cont);
                Fecha[i] = Console.ReadLine();

                Console.WriteLine("Digte La Hora de Ingreso {0}:  ", cont);
                Hora[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el Numero de Caseta: /1=Caseta 1/  /2=Caseta 2/   /3=Caseta 3/ {0}:  ", cont);
                NumeroCaseta[i] = Console.ReadLine();
                
                Console.WriteLine("Precios por Tipo de Vehiculos: /Moto = 500/  /Vehiculo Liviano = 700/  /Camion o Pesado = 2700/  /AutoBus = 3700 /");

                Console.WriteLine("Ingrese el Tipo De Vehiculo: /1=Moto/  /2=Vehiculo Liviano/  /3=Camion o Pesado/  /4=AutoBus/ {0}:  ", cont);
                int.TryParse(Console.ReadLine(), out TipoVehiculo[i]);

                Console.WriteLine("Ingrese el Monto a Pagar {0}:  ", cont);
                int.TryParse(Console.ReadLine(), out MontoPagar[i]);

                Console.WriteLine("Ingrese la cantidad con la que pago {0}:  ", cont);
                int.TryParse(Console.ReadLine(), out PagaCon[i]);

                if (TipoVehiculo[i] == 1)
                {

                    Vuelto[i] = PagaCon[i] - MontoPagar[i];
                    Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                    int.TryParse(Console.ReadLine(), out Vuelto[i]);


                }
                else if (TipoVehiculo[i] == 2)
                {
                    Vuelto[i] = PagaCon[i] - MontoPagar[i];
                    Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                    int.TryParse(Console.ReadLine(), out Vuelto[i]);

                }
                else if (TipoVehiculo[i] == 3)
                {
                    Vuelto[i] = PagaCon[i] - MontoPagar[i];
                    Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                    int.TryParse(Console.ReadLine(), out Vuelto[i]);

                }
                else if (TipoVehiculo[i] == 4)
                {
                    Vuelto[i] = PagaCon[i] - MontoPagar[i];
                    Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                    int.TryParse(Console.ReadLine(), out Vuelto[i]);

                }

                cont++;
                Console.Clear();

            }
        }

        public static string SolicitarPlaca()
        {
            Console.WriteLine("Digite la Placa del Vehiculo");
            string Plac = Console.ReadLine();
            return Plac;

        }


        public static void ConsultaVehicular(string Plac)
        {

            bool encontrado = false;
            Console.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                if (Plac.Equals(NumeroPlaca[i]))
                {
                    Console.WriteLine($"Numero de la Factura: {NumeroFactura[i]}");
                    Console.WriteLine($"Tipo de Vehiculo: {TipoVehiculo[i]}");
                    Console.WriteLine($"Fue ingresado el: {Fecha[i]} a las: {Hora[i]}");
                    Console.WriteLine($"El vehiculo de tipo: {TipoVehiculo[i]} pago un monto de: {MontoPagar[i]} en la caseta: {NumeroCaseta[i]}");
                    break;
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Vehiuclo no encontrado");
                }

                Console.Clear();
            }

        }

        public static void ModificaVehiculo(string Plac)
        {
           

            bool encontrado = false;
            Console.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                if (Plac.Equals(NumeroPlaca[i]))
                {
                    Console.WriteLine("Digte el Numero de Factura:  ");
                    NumeroFactura[i] = Console.ReadLine();
                   
                    Console.WriteLine("Digte el Numero de Placa:  ");
                    NumeroPlaca[i] = Console.ReadLine();
                    
                    Console.WriteLine("Digte la Fecha de Ingreso:  ");
                    Fecha[i] = Console.ReadLine();
                   
                    Console.WriteLine("Digte La Hora de Ingreso:  ");
                    Hora[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese el Numero de Caseta: /1=Caseta 1/  /2=Caseta 2/   /3=Caseta 3/ {0}:  ");
                    NumeroCaseta[i] = Console.ReadLine();

                    Console.WriteLine("Ingrese el Tipo De Vehiculo: /1=Moto/  /2=Vehiculo Liviano/  /3=Camion o Pesado/  /4=AutoBus/ {0}:  ");
                    int.TryParse(Console.ReadLine(), out TipoVehiculo[i]);
                    
                    Console.WriteLine("Precios por Tipo de Vehiculos: /Moto = 500/  /Vehiculo Liviano = 700/  /Camion o Pesado = 2700/  /AutoBus = 3700 /");
                    Console.ReadLine(); 
                   
                    Console.WriteLine("Ingrese el Monto a Pagar:  ");
                    int.TryParse(Console.ReadLine(), out MontoPagar[i]);


                    Console.WriteLine("Ingrese la cantidad con la que pago:  ");
                    int.TryParse(Console.ReadLine(), out PagaCon[i]);

                    if (TipoVehiculo[i] == 1)
                    {

                        Vuelto[i] = PagaCon[i] - MontoPagar[i];
                        Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                        int.TryParse(Console.ReadLine(), out Vuelto[i]);


                    }
                    else if (TipoVehiculo[i] == 2)
                    {
                        Vuelto[i] = PagaCon[i] - MontoPagar[i];
                        Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                        int.TryParse(Console.ReadLine(), out Vuelto[i]);

                    }
                    else if (TipoVehiculo[i] == 3)
                    {
                        Vuelto[i] = PagaCon[i] - MontoPagar[i];
                        Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                        int.TryParse(Console.ReadLine(), out Vuelto[i]);

                    }
                    else if (TipoVehiculo[i] == 4)
                    {
                        Vuelto[i] =  PagaCon[i] - MontoPagar[i];
                        Console.WriteLine($"Su respectivo vuelto es de: {Vuelto[i]}  ");
                        int.TryParse(Console.ReadLine(), out Vuelto[i]);

                    }

                    break;
                    encontrado = true;
                    break;

                }
                if (!encontrado)
                {
                    Console.WriteLine("Vehiuclo no encontrado");
                }
                Console.Clear();

            }
        }

        public static void ReporteGeneral()
        {
           
            for (int i = 0; i < cantidad; i++)
            {

                Console.WriteLine($"Numero de Factura: {NumeroFactura[i]} xxxxxx Numero de Placa: {NumeroPlaca[i]} xxxxxx Tipo de Vehiculo: {TipoVehiculo[i]} xxxxxx Caseta: {NumeroCaseta[i]} ");
                Console.WriteLine($"Monto a Pagar: {MontoPagar[i]} xxxxxx Pago con: {PagaCon[i]} xxxxxx el vuelto fue de: {Vuelto[i]}");



            }







        }







    }
}
