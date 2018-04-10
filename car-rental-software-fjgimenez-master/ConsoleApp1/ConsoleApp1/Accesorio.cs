using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Accesorio
    {
        String Nombre;
        String SKU;
        String Descripcion;
        int Stock;
    }

    CrearAccesorio()
    {
        Accesorio a1 = new Accesorio(Console.WriteLine("Nombre de Accesorio a ingresar"), Console.WriteLine("SKU de Accesorio a ingresar"),
               Console.WriteLine("Precio de Accesorio a Ingresar"));
    }
