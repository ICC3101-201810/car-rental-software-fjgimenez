using System;

namespace ConsoleApp1
{
    public class Motocicleta : Vehiculo
    {
        public CrearMotocicleta()
        {
            base.CrearVehiculo();
            if (Tipo == "Motocicleta")
            {
                CrearVehiculo.Add(new Motocicleta(Marca, Modelo, Patente, Tipo, Año, Precio));
            }
        }

        ArrendarMotocicleta()
        {
            if (Persona.ClaseLicencia == "C")
            {
                base.Arrendar;
            }
            else
            {
                Console.WriteLine("Usted no cuenta con la licencia necesaria para arrendar este vehículo");
            }
        }
    }
}