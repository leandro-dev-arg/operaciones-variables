using System;

namespace U4_programa_4
{
    class Program
    {
        static void Main(string[] args)
        { int n1,n2,n3,suma,producto;
            Console.WriteLine("ingrese un numero por favor");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero por favor");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer y ultimo numero por favor");
            n3=int.Parse(Console.ReadLine());

            suma=n1+n2;
            producto=n2*n3;

            if (suma>producto) {
                Console.WriteLine("la suma del primero y el segundo numero es mayor al producto del segundo por el tercero");  
            }else{
               Console.WriteLine("el producto del segundo por el tercero es mayor a la suma del primero y el segundo numero "); 
            }
        }  
        
         
    }
}
