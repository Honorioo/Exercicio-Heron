using System;

namespace ExercicioHeron {
    
    class Program {
        static void Main(string[] args) {
            double semiperimetro, lado1, lado2, lado3, resultadoarea;

            Console.WriteLine("----- Calcule a area de qualquer triangulo-----");
            Console.WriteLine();

            Console.Write("Digite um numero para o primeiro lado: ");
            lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um numero para o segundo lado: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite um numero para o terceiro lado: ");
            lado3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            semiperimetro = (lado1 + lado2 + lado3) / 2;
            resultadoarea = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));

            Console.WriteLine($"Resultado do Semiperimetro: {semiperimetro}");
            Console.WriteLine($"Resultado do Area: {resultadoarea}");
        }
    }
}
