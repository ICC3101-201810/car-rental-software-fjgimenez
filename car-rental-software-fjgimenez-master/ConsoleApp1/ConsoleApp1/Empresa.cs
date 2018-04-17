using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa: Cliente
    {
        string Tipo;
        string Autorizacion;
        public List<Empresa> EmpresasAgregadas;
    }
    AgregarEmpresa()
    {
        base.CrearCliente();
        Console.WriteLine("Tipo de Empresa a Ingresar (Empresa, Organización u Institución)"); 
        Console.WriteLine("Estado de Autorización (Autorizada, Rechazada, Pendiente)");
        string ClaseLicencia = Console.ReadLine();

        if (Tipo == "Emrpresa")
        {
            EmpresasAgregadas.Add(new Empresa(Tipo,Autorizacion));
        }
    }
}
