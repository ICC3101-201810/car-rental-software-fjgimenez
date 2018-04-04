using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa: Cliente
    {
        String Tipo;
        String Autorizacion;
    }
    AgregarEmpresa()
    {
       Empresa e1 = new Empresa(Console.WriteLine("Nombre de Empresa a ingresar"), Console.WriteLine("RUT de Empresa a ingresar"),
               Console.WriteLine("Tipo de Empresa a Ingresar (Empresa, Organización u Institución)"), 
               Console.WriteLine("Estado de Autorización (Autorizada, Rechazada, Pendiente)"));
    }
}
