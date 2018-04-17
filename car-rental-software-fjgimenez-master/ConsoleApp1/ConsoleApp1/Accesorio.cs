using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accesorio
    {
        string Nombre;
        string SKU;
        string Descripcion;
        int Stock;
        public List<Accesorio> AccesoriosCreados;
    }

    public CrearAccesorio()
    {
        Console.WriteLine("Necesitamos los siguientes datos:");
        Console.WriteLine("Nombre: ");
        string Nombre = Console.ReadLine();
        Console.WriteLine("SKU: ");
        string SKU = Console.ReadLine();
        Console.WriteLine("Descripcion: ");
        string Descripcion = Console.ReadLine();
        Console.WriteLine("Stock");
        int Stock = Console.ReadLine();

        AccesoriosCreados.Add(new Accesorio(Nombre, SKU, Descripcion, Stock));
    }
    }