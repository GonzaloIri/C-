using System;

namespace TpTransporte
{
    class Program
    {
        static void Main(string[] args)
        {

    int i, cargaMaxima, peso, sumaPeso, NumCamion, n;

    Console.WriteLine("ingrese cuantos camiones hay: ");

    n = int.Parse(Console.ReadLine());
    
    for ( i=0 ; i <n; i ++) {

        Console.WriteLine("ingrese el numero del camion: ");
         NumCamion = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese la carga maxima del camion: " );
         cargaMaxima = int.Parse(Console.ReadLine());
        sumaPeso = 0;

        while (sumaPeso < cargaMaxima) {
        
        Console.WriteLine("ingrese el peso del paquete: ");  
        peso = int.Parse(Console.ReadLine());
        sumaPeso += peso;         
    
    }
   Console.WriteLine("El camion se encuentra lleno... ");
} 
   }

    }
    
}
