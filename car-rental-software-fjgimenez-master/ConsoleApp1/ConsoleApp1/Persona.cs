using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona : Cliente
    {
        public List<Persona> PersonasAgregadas;
    }
    public AgregarPersona()
    {
        base.CrearCliente();

        Console.WriteLine("Clase de Licencia de Persona a Ingresar");
        string ClaseLicencia = Console.ReadLine();

        if (Tipo == "Persona")
        {
            PersonasAgregadas.Add(new Persona(ClaseLicencia));
        }
    }
}