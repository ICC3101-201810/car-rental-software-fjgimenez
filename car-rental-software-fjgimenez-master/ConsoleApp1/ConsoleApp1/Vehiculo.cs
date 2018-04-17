using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehiculo
    {

        string Marca;
        string Modelo;
        string Patente;
        string Tipo;
        string Año;
        string Precio;
    }

    public CrearVehiculo(string Marca, string Modelo, string Patente, string Tipo
        , string Año, string Precio)
    {
        Console.WriteLine("Necesitamos los siguientes datos:");
        Console.WriteLine("Marca: ");
        string Marca = Console.ReadLine();
        Console.WriteLine("Modelo: ");
        string Modelo = Console.ReadLine();
        Console.WriteLine("Patente: ");
        string Patente = Console.ReadLine();
        Console.WriteLine("Tipo (Auto, Moto, Bus, etc): ");
        string Tipo = Console.ReadLine();
        Console.WriteLine("Año: ");
        string Año = Console.ReadLine();
        Console.WriteLine("Precio: ");
        string Precio = Console.ReadLine();
    }
}

