﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Cliente
    {
        String Nombre;
        String RUT;
        String Tipo;
    }

    public CrearCliente()
    {
        Cliente c1 = new Cliente(Console.WriteLine("Nombre de Cliente a ingresar"),
            Console.WriteLine("RUT de Cliente a ingresar"));
    }
}