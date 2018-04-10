using System;

public class Auto : Vehiculo
{
    public CrearAuto()
    {
        base.CrearVehiculo();
    }

    ArrendarAuto()
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
