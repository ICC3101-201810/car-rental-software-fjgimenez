using System;

public class Bus : Vehiculo
{
    public CrearBus()
    {
        base.CrearVehiculo();
    }
    ArrendarBus()
    {
        if (Cliente.Tipo == "Empresa" & Empresa.Autorizacion == "Aprobada" & Empresa.Tipo == "Organizacion")
        {
            base.Arrendar;
            Camion.set(Tipo=="Normal");
        }
        else
        {
            Console.WriteLine("Usted no cuenta con la licencia necesaria para arrendar este vehículo");
        }
    }
}
