using System;

namespace Exercicio_Heron
{
    class Program
    {
        static void Main(string[] args)
        {
           double semiperimetro, lado1, lado2, lado3, resultadoLados, resultadoarea;

                 Console.WriteLine("-----Calcule a area de qualquer triangulo-----");
                Console.WriteLine();
                
                Console.Write("Digite o perimetro do triangulo: ");
                semiperimetro =Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite um numero para o primeiro lado: ");
                lado1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite um numero para o segundo lado: ");
                lado2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite um numero para o terceiro lado: ");
                lado3 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine();


            resultadoarea = Math.Sqrt (semiperimetro*(semiperimetro-lado1)*(semiperimetro-lado2)*(semiperimetro-lado3)); 
            resultadoLados = (lado1 + lado2 + lado3) / 2;


         Console.WriteLine($"Resultado do Area: {resultadoarea}");
         Console.WriteLine($"Resultado do Semiperimetro: {resultadoLados}");


        

        }
    }
}
