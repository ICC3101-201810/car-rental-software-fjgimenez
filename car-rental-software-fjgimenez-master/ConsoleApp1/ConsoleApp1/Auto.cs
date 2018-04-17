using System;

namespace ConsoleApp1
{
    public class Auto : Vehiculo
    {
        public List<Auto> AutosCreados;
        public CrearAuto()
        {
            base.CrearVehiculo();
            if (Tipo == "Auto")
            {
                AutosCreados.Add(new Auto(Marca, Modelo, Patente, Tipo, Año, Precio));
            }
        }

        public VerAutos()
        {
            Console.WriteLine("Seleccione Auto:");
            AutosCreados;
            string AutoElegido = Console.ReadLine();
        }

        public ArrendarAuto()
        {
            if (Persona.ClaseLicencia == "Sin Licencia")
            {
                Console.WriteLine("Usted no cuenta con la licencia necesaria para arrendar este vehículo");
            }
            else
            {
                base.Arrendar;
            }
        }
    }
}