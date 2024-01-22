using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("");

            Console.WriteLine("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro termo da soma: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo termo da soma: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float soma = primeiroTermo + segundoTermo;

            Console.WriteLine($"{primeiroTermo} + {segundoTermo} = {soma}");
            Console.WriteLine("");
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro termo da subtração: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo termo da subtração: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float subtracao = primeiroTermo - segundoTermo;

            Console.WriteLine($"{primeiroTermo} - {segundoTermo} = {subtracao}");
            Console.WriteLine("");
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o dividendo: ");
            float dividendo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o divisor (diferente de zero): ");
            float divisor = float.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                do
                {
                    Console.WriteLine("Divisão por zero não permitida!");
                    Console.WriteLine("Digite um novo valor para o divisor (diferente de zero): ");
                    divisor = float.Parse(Console.ReadLine());
                }
                while (divisor == 0);
            }

            float divisao = dividendo / divisor;

            Console.WriteLine($"{dividendo} / {divisor} = {divisao}");
            Console.WriteLine("");
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro termo da multiplicação: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo termo da multiplicação: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float multiplicacao = primeiroTermo * segundoTermo;

            Console.WriteLine($"{primeiroTermo} * {segundoTermo} = {multiplicacao}");
            Console.WriteLine("");
            Menu();
        }
    }
}
