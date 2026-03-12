using System;

namespace atividade
{
    class Exe04
    {
        public static void Executar()
        {
            System.Console.Write("Digite o nome do produto: ");
            string produto = Console.ReadLine();

            System.Console.Write("Digite o valor do produto: R$");
            double valor = double.Parse(Console.ReadLine());

            double desconto = valor * 0.70;

            System.Console.WriteLine($"{produto} custará R${desconto:F2}");
    }
    }
}