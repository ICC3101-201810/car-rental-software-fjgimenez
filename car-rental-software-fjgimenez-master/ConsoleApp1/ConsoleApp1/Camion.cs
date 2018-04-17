using System;

namespace ConsoleApp1
{
    public class Camion : Vehiculo
    {
        public List<Camion> CamionesCreados;
        public CrearCamion()
        {
            base.CrearVehiculo();

            if (Tipo == "Camión")
            {
                CamionesCreados.Add(new Camion(Marca, Modelo, Patente, Tipo, Año, Precio));
            }
        }

        ArrendarCamion()
        {
            if (Cliente.Tipo == "Persona" & Persona.ClaseLicencia == "A4")
            {
                base.Arrendar;
            }
            if (Cliente.Tipo == "Empresa" & Empresa.Autorizacion == "Aprobada" & Empresa.Tipo == "Empresa")
            {
                base.Arrendar;
            }
            else
            {
                Console.WriteLine("Usted no cuenta con la licencia o autorización necesaria para arrendar este vehículo");
            }
        }
    }
}
