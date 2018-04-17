using System;

namespace ConsoleApp1
{
    public class Bus : Vehiculo
    {
        public List<Bus> BusesCreados;
        public CrearBus()
        {
            base.CrearVehiculo();
            if (Tipo == "Bus")
            {
                BusesCreados.Add(new Bus(Marca, Modelo, Patente, Tipo, Año, Precio));
            }
        }
        ArrendarBus()
        {
            if (Cliente.Tipo == "Empresa" & Empresa.Autorizacion == "Aprobada" & Empresa.Tipo == "Organizacion")
            {
                base.Arrendar;
                Camion.set(Tipo == "Normal");
            }
            else
            {
                Console.WriteLine("Usted no cuenta con la licencia necesaria para arrendar este vehículo");
            }
        }
    }
}