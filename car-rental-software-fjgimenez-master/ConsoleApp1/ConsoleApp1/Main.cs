using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Main
    {
        static void Main(string[] args)
        {
     
        Console.WriteLine("Hola, bienvenido a la sucursal virtual. \n Si es administrador de una Sucursal, oprima 1. \n Si es cliente, oprima 2. \n Oprima 0 para salir"); 
       
        if(i==1)
{
        Console.WriteLine("Si desea agregar un vehículo, oprima 1. \n Si desea agregar un accesorio, oprima 2. " +
               "\n Si desea ver el estado de un arriendo, oprima 3. \n Oprima 0 para salir");
        
        if (i==1)
        {
             Main.AgregarVehiculo;
        }
        if (i==2)
        {
            Main.AgregarAccesorio;  
        }
        if (i==3)
        {
            Main.DatosArriendo;
        }
        else
        {
            Console.WriteLine("Adios");
        }    
}
        if(i==2)
{
            Console.WriteLine("Si desea arendar un vehículo, oprima 1. \n Si desea ver el estado de un arriendo, oprima 2. " +
               "\n Si desea agregar un accesorio a su arriendo, oprima 3. \n Oprima 0 para salir");
}       if(i==1){
           Main.Arrendar;
           Main.AgregarAccesorios;
}
        if(i==2){
            Main.DatosArriendo;
}
        if(i==3){
            Main.AgregarAccesorios;
}
        else{ 
            Console.WriteLine("Adios");
}
}
        }
    

