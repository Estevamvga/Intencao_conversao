using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            double soma = num1 + num2;
            double multiplicacao = num1 * num2;
            double divisao = num1 / num2;
            double subtracao = num1 - num2;
            double media = soma / 2;


            Console.WriteLine("A soma de " + num1 + " e " + num2 + " = " + soma);
            Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " = " + multiplicacao);
            Console.WriteLine("A divisão de " + num1 + " e " + num2 + " = " + divisao);
            Console.WriteLine("A subitração de " + num1 + " e " + num2 + " = " + subtracao);
            Console.WriteLine("A media de " + num1 + " e " + num2 + " = " + media);

            Console.ReadKey();
        }
    }
}
