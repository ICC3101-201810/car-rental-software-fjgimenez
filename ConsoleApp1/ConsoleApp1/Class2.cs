﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Sucursal
    {
        String Nombre;
        String Direccion;
        String Ciudad;
    }
    CrearSucursal()
    {
        Sucursal s1 = new Sucursal(Console.WriteLine("Nombre Sucursal a ingresar"), Console.WriteLine("Dirección de Sucursal a ingresar"),
            Console.WriteLine("Ciudad de Sucursal a ingresar"));
    }
    MainSucursal(AgregarVehiculo, AgregarAccesorio, DatosArriendo)
    {
        Console.WriteLine("Hola, bienvenido a la sucursal virtual. Si desea agregar un vehículo, oprima 1. Si desea agregar un accesorio, oprima 2. " +
               "Si desea ver el estado de un arriendo, oprima 3. Oprima 0 para salir");
        int i = 0;
        if (i==1)
        {
             MainSucursal.AgregarVehiculo;
        }
        if (i==2)
        {
            MainSucursal.AgregarAccesorio;  
        }
        if (i==3)
        {
            MainSucursal.DatosArriendo;
        }
        else
        {
            Console.WriteLine("Adios");
        }
    }
}
