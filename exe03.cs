using System;
using System.Net.Http.Headers;

namespace atividade
{
    class Exe03
    {
        public static void Executar()
        {
            System.Console.Write("Digite a primeira nota: ");
            double primeira_nota = double.Parse(Console.ReadLine());

            System.Console.Write("Digite a segunda nota: ");
            double segunda_nota = double.Parse(Console.ReadLine());

            double media = (primeira_nota + segunda_nota) / 2.0;

            System.Console.WriteLine($"A média é {media}");
        }
    }
}