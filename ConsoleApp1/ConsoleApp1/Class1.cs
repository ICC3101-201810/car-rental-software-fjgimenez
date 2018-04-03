using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehiculo
    {
        String Nombre;
        String Marca;
        String Modelo;
        String Tipo;
        String Patente;
        int Año;
        int Kilometros;
        int Precio;
    }
    CrearVehiculo(Vehiculo)
    {
        Vehiculo v1 = new Vehiculo(Console.WriteLine("Nombre del Vehículo a ingresar"), Console.WriteLine("Marca del Vehículo a ingresar"),
            Console.WriteLine("Modelo del Vehículo a ingresar"), Console.WriteLine("Tipo de Vehículo a ingresar (Moto, auto, 4x4, etc)"),
            Console.WriteLine("Patente del Vehículo a ingresar"), Console.WriteLine("Año de fabricación del Vehículo a ingresar"),
            Console.WriteLine("Kilometraje del Vehículo a ingresar"), Console.WriteLine("Precio diario de arriendo del Vehículo a ingresar"));
    }
}
