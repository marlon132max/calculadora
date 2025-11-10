using System;

class Calculadora
{
    static void Main()
    {
        string continuar = "sim";

        while (continuar.ToLower() == "sim")
        {
            Console.Clear();
            Console.WriteLine(" CALCULADORA ");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - RAIZ QUADRADA");
            Console.WriteLine("6 - SAIR");
            Console.Write("Escolha uma operação: ");
            string operacao = Console.ReadLine();

            double numero1 = 0, numero2 = 0, resultado = 0;

            if (operacao != "5" && operacao != "6")
            {
                Console.Write("Digite o primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
            }

            switch (operacao)
            {
                case "1":
                    resultado = numero1 + numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case "2":
                    resultado = numero1 - numero2;
                    Console.WriteLine("Resultado: " + resultado);
                    break;

                case "3":
                    resultado = numero1 * numero2;
                    Console.WriteLine("Resultado:" + resultado);
                    break;

                case "4":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("Resultado: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("erro: divisão por zero!");
                    }
                    break;

                case "5":
                    Console.Write("Digite o número para calcular a raiz: ");
                    numero1 = double.Parse(Console.ReadLine());
                    resultado = Math.Sqrt(numero1);
                    Console.WriteLine("A raiz quadrada e : " + resultado);
                    break;

                case "6":
                    Console.WriteLine("encerrando...");
                    return; 

                default:
                    Console.WriteLine("Operação invalida!");
                    break;
            }

            Console.Write("\nDeseja continuar? (sim/não): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("encerrado.");
    }
}
