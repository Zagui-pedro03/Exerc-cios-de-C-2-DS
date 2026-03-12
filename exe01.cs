using System;

namespace atividade
{
    class Exe01
    {
        public static void Executar()
        {
            System.Console.Write("Digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine());

            System.Console.WriteLine("\n-------------------");
            System.Console.WriteLine(@"
==============================
    TIPOS DE TEMPERATURA
==============================
[1] Celsius
[2] Fahrenheit
[3] Kelvin");
            System.Console.Write("Digite o tipo de medição de temperatura: ");
            int escolha = int.Parse(Console.ReadLine());
            if (escolha > 3 || escolha < 1)
            {
                System.Console.WriteLine("Opção inválida");
                return;
            }
            System.Console.WriteLine("\n--------------");
            System.Console.Write("Digite qual medida deseja converter: ");
            int convercao = int.Parse(Console.ReadLine());
            if (convercao > 3 || convercao < 1)
            {
                System.Console.WriteLine("Opção inválida");
                return;
            }
            double temp_final = 0;
            switch(escolha){
                //Celsius
                case 1:

                if (convercao == 2)
                    {
                        temp_final = (temp * 1.8) + 32;
                        System.Console.WriteLine($"{temp}°C em Fahrenheit é: {temp_final}°F");
                    }
                else if (convercao == 3)
                    {
                        temp_final = temp + 273.15;
                        System.Console.WriteLine($"{temp}°C em Kelvin é: {temp_final}°K");
                    }
                else if (convercao == 1)
                    {
                        System.Console.WriteLine($"Você selecionou o mesmo tipo, ou seja, seu valor é {temp}°C");
                    }
                    else
                    {
                        System.Console.WriteLine("Valor inválido");
                    }
                break;
                //Fahrenheit
                case 2:
                if (convercao == 1)
                    {
                        temp_final = (temp - 32) * 5 / 9;
                        System.Console.WriteLine($"{temp}°F em Celsius é: {temp_final}°C");
                    }
                else if (convercao == 3)
                    {
                        temp_final = (5.0/9.0*(temp - 32)) + 273.15;
                        System.Console.WriteLine($"{temp}°F em Kelvin é: {temp_final}°K");
                    }
                else if (convercao == 2)
                    {
                        System.Console.WriteLine($"Você selecionou o mesmo tipo, ou seja, seu valor é {temp}°F");
                    }
                    else
                    {
                        System.Console.WriteLine("Valor inválido");
                    }
                break;
                case 3:
                //Kelvin
                    if (convercao == 1)
                    {
                        temp_final = temp - 273.15;
                        System.Console.WriteLine($"{temp}°K em Celsius é: {temp_final}°C");
                    }
                    else if (convercao == 2)
                    {
                        temp_final = (temp - 273.15)* 9/5 + 32;
                        System.Console.WriteLine($"{temp}°K em Fahrenheit é: {temp_final}°F");
                    }
                    else if (convercao == 3)
                    {
                        System.Console.WriteLine($"Você selecionou o mesmo tipo, ou seja, seu valor é {temp}°K");
                    }
                    else
                    {
                        System.Console.WriteLine("Valor inválido");
                    }
                break;
            }
        }
    }
}