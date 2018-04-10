using System;

public class Camion : Vehiculo
{
    CrearCamion()
    {
        base.CrearVehiculo();
    }
    ArrendarCamion()
    {
        if (Cliente.Tipo=="Persona" & Persona.ClaseLicencia == "A4") {
                base.Arrendar;
            }
        if(Cliente.Tipo=="Empresa" & Empresa.Autorizacion=="Aprobada" & Empresa.Tipo == "Empresa"){
            base.Arrendar;
        }
            else
            {
                Console.WriteLine("Usted no cuenta con la licencia o autorización necesaria para arrendar este vehículo");
            }
        }
    }

