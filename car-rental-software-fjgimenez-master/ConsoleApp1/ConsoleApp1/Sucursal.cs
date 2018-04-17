using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Sucursal
    {
        string Nombre;
        string Direccion;
        string Ciudad;
        public List<Sucursal> SucursalesCreadas;
    }
    public CrearSucursal(string Nombre, string Direccion, string Ciudad)
    {
        Console.WriteLine("Necesitamos los siguientes datos:");
        Console.WriteLine("Nombre Sucursal: ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Direccion Sucursal: ");
        string Direccion = Console.ReadLine();
        Console.WriteLine("Ciudad: ");
        string Ciudad = Console.ReadLine();

        SucursalesCreadas.Add(new Sucursal(Nombre, Direccion, Ciudad));
    }
    public VerSucursales(string Nombre)
    {
        Console.WriteLine("Seleccione Sucursal:");
        SucursalesCreadas.get(Nombre);
        string SucursalElegida = Console.ReadLine();
    }
}