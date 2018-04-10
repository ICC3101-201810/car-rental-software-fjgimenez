using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    abstract class Arriendo
    {
        int numero;
        DateTime dat = DateTime.Now;
    }
    DatosArriendo()
    {
       Console.WriteLine("Arriendo Realizado a las" + dat);

        if(Cliente.Equals=="Persona"){
            Console.WriteLine("Arrendatario:" + Persona.Nombre);
}
        if(Cliente.Equals=="Persona"){
            Console.WriteLine("Arrendatario:" + Empresa.Nombre + Empresa.Tipo);
}
        else{
            Console.WriteLine("Tipo de cliente no encontrado");
}           
        Console.WriteLine("\n Vehículo Arrendado:" + Vehiculo + "\n Retirar en Sucursal:"+ Sucursal);
        Console.WriteLine("\n Accesorios agregados" + Accesorio);
    }

    Arrendar()
    {
        Console.WriteLine("Hola, bienvenido a Arrienda Tu Auto. Ingresa Los Datos Personales Pedidos.");
        Console.WriteLine("Datos Ingresados Correctamente! Elige tu vehículo");
        Console.WriteLine("Vehículo Seleccionado Exitosamente! Elige los Accesorios que desees");
    }

    AgregarAccesorios()
    {
        Console.WriteLine("Accesorios Seleccionados Exitosamente! El total es de" + PrecioTotal + 
            "Elige medio de pago");
        Console.WriteLine("Pago realizado con Exito! Resumen de su arriendo:" + DatosArriendo);
    }

     PrecioTotal()
    {
        Arrendar.get(Precio) + AgregarAccesorios.get(Precio); 
    }
