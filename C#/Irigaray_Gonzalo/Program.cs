using System;

namespace ejemplo2
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
           int i, N, cp = -99999, cprimo =0, maxpar = 0, cimp = 0, pmin =0  ;
            
            Console.WriteLine("ingrese un numero");
            N = int.Parse(Console.ReadLine());
           
            while (N!=0){  

            for ( i = 1; i <=N; i++){
            
            if ((N % 2 == 0) & (cp == 0)){
            maxpar = N;
            cp++;
            }
            else if ((N % 2 == 0 ) &(N > maxpar)){
            cp++;
            maxpar = N;
            } 
            if (N % 2 != 0 ){
            cimp ++;
            
            }

        if (primo(N)){

            pmin ++;
            
            if (N % i == 0 )
            {
            cprimo = N;  
            }     
    }
            Console.WriteLine("ingrese otro numero: ");
            N = int.Parse(Console.ReadLine());  
            }
}
        Console.WriteLine("El maximo par es: " +maxpar);
        
        Console.WriteLine("la cantidad de impares son: "+cimp);
        
        Console.WriteLine("el menor de los  primos es: " +cprimo); 
        
        }
        static bool primo(int a)
        {

            int con = 0;

            for (int x = 1; x <= a; x++)
            {

                if (a % x == 0)
                    con++;

            }
            if (con == 2)

                return true;

            else
                return false;
        }
    }

    class Program : NewBaseType
    {
    }
}