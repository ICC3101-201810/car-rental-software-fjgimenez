using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Main
    {
        static void Main(string[] args)
        {
            int resultado;
            int accion;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hola, bienvenido a la sucursal virtual.");
                Console.WriteLine("1) Crear Vehículo");
                Console.WriteLine("2) Crear Sucursal");
                Console.WriteLine("3) Crear Accesorio");
                Console.WriteLine("4) Ingresar a una Sucursal");
                Console.WriteLine("5) Crear Cliente");
                Console.WriteLine("6) Arrendar Vehículo");
                Console.WriteLine("0) Salir");
                string resultadoS = Console.ReadLine();

                while (resultadoS != "1" & resultadoS != "2" & resultadoS != "3" & resultadoS != "4"
                    & resultadoS != "5" & resultadoS != "6" & resultadoS != "0")
                {
                    Console.WriteLine("Comando Inválido");
                    Console.WriteLine("1) Crear Vehículo");
                    Console.WriteLine("2) Crear Sucursal");
                    Console.WriteLine("3) Crear Accesorio");
                    Console.WriteLine("4) Ingresar a una Sucursal");
                    Console.WriteLine("5) Crear Cliente");
                    Console.WriteLine("6) Arrendar Vehículo");
                    Console.WriteLine("0) Salir");

                    int.TryParse(Console.ReadLine(), out resultado);

                    if (resultado == 1)
                    {
                        Auto.CrearAuto;
                        Camion.CrearCamion;
                        Bus.CrearBus;
                        Motocicleta.CrearMotocicleta;
                    }

                    else if (resultado == 2)
                    {
                        Sucursal.CrearSucursal;
                    }
                    else if (resultado==3)
                    {
                        Accesorio.CrearAccesorio;
                    }
                    else if (resultado == 4)
                    {
                        Sucursal.VerSucursales;
                    }
                    else if (resultado == 5)
                    {
                        Empresa.AgregarEmpresa;
                        Persona.AgregarPersona;
                    }
                    else if (resultado == 6)
                    {
                        Arriendo.Arrendar;
                        Arriendo.AgregarAccesorios;
                        Arriendo.PrecioTotal;
                        Arriendo.DatosArriendo;
                    }

                    else if (resultado == 0)
                    {
                        Console.WriteLine("Adiós y Gracias por preferir Sucursal Virtual");
                        break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}


                
               
    

