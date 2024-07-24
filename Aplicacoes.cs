using System;

namespace Aplicacoes
{
    public class HelloWorld
    {
        public static void run()
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
        }
    }


    public class Calculator
    {
        public static void run()
        {
            Console.Clear();

            Console.WriteLine("Digite o 1º número: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação a ser feita (+, -, * ou /): ");
            string op = Console.ReadLine();

            if (op == "+")
                Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            else if (op == "-")
                Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            else if (op == "*")
                Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            else if (op == "/")
                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            else
                Console.WriteLine("Operação inválida");
        }
    }


    public class ParImpar
    {
        public static void run()
        {
            Console.Clear();

            Console.WriteLine("Digite um número inteiro: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"O número {n1} é " + (n1 % 2 == 0 ? "par." : "ímpar."));
        }
    }


    public class Menu
    {
        public static void run()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma aplicação: \n1 - Hello world\n2 - Calculadora\n3 - Par ou ìmpar");
            switch (Console.ReadLine())
            {
                case "1":
                    HelloWorld.run();
                    exit(HelloWorld.run);
                    break;
                case "2":
                    Calculator.run();
                    exit(Calculator.run);
                    break;
                case "3":
                    ParImpar.run();
                    exit(ParImpar.run);
                    break;
                default:
                    run();
                    break;
            }
        }


        public static void exit(Action reRun)
        {
            Console.WriteLine("Digite 1 para sair ou 2 para repetir: ");
            string opt = Console.ReadLine();

            if (opt == "1")
                run();
            else if (opt == "2")
            {
                reRun();
                exit(reRun);
            }
            else
            {
                Console.WriteLine("Opção inválida");
                exit(reRun);
            }
                
        }
    }

        
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu.run();
        }
    }
}
