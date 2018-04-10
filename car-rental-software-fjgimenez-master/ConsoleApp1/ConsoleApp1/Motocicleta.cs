﻿using System;

public class Motocicleta : Vehiculo
{
    public CrearMotocicleta()
    {
        base.CrearVehiculo();
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