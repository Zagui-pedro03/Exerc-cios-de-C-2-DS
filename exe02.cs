using System;
using System.Formats.Asn1;

namespace atividade
{
    class Exe02
    {
        public static void Executar()
        {
            System.Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a altura do retângulo");
            double altura = double.Parse(Console.ReadLine());

            double area= largura * altura;
            

            if (largura == altura)
            {
                System.Console.WriteLine($"Isso é um quadrado! Sua área é {area}");
            }
            else
            {
                System.Console.WriteLine($"A área do retângulo é {area}");
            }
        }
    }
}