using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Arriendo
    {
        int numero;
        DateTime dat = DateTime.Now;
    }
    DatosArriendo()
    {
        Console.WriteLine("Arriendo Realizado a las" + dat);

        if (Cliente.Equals == "Persona")
        {
            Console.WriteLine("Arrendatario:" + Persona.Nombre);
        }
        if (Cliente.Equals == "Persona")
        {
            Console.WriteLine("Arrendatario:" + Empresa.Nombre + Empresa.Tipo);
        }
        else
        {
            Console.WriteLine("Tipo de cliente no encontrado");
        }
        Console.WriteLine("\n Vehículo Arrendado:" + Vehiculo + "\n Retirar en Sucursal:" + Sucursal);
        Console.WriteLine("\n Accesorios agregados" + Accesorio);
    }

    Arrendar()
    {
        Console.WriteLine("Hola, bienvenido a Arrienda Tu Auto. Ingresa Los Datos Personales Pedidos.");
        Console.WriteLine("Datos Ingresados Correctamente! Elige tu vehículo");
        Console.WriteLine("Vehículo Seleccionado Exitosamente! Elige los Accesorios que desees");
    }

    PrecioTotal()
    {
        Vehiculo.get(Precio) + Accesorio.get(Precio);
    }
}
