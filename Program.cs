using System;
using System.Collections;
namespace  atividade
{
    class Program
{
    static void Main()
        {
            System.Console.Write("Qual exercício você quer fazer? ");
            int exe = int.Parse(Console.ReadLine());

            switch(exe){
            case 1:
            Exe01.Executar();
            break;
            case 2:
            Exe02.Executar();
            break;
            case 3:
            Exe03.Executar();
            break;
            case 4:
            Exe04.Executar();
            break;
            case 5:
            Exe05.Executar();
            break;
        }
        }
}
}