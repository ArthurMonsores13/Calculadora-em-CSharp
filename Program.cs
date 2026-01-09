using System;

namespace CalculadoraEmCSharp
{
    public class MathOperations
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Diminuir(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível divisão por 0");
            }
            return a / b;
        }
    }

    class Program
    {
        static bool PerguntaContinuar()
        {
            Console.Write("Você deseja continuar ou sair? (continuar/sair): ");
            string resposta = (Console.ReadLine() ?? "").Trim().ToLower();

            if (resposta == "continuar")
            {
                return true;
            }
            else if (resposta == "sair")
            {
                Console.WriteLine("Programa encerrado..");
                return false;
            }
            else
            {
                Console.WriteLine("Comando inválido. Tente Novamente!.");
                return true;
            }
        }

        static double LerNumero(string mensagem)
        {
            double numero;
            bool valido;

            do
            {
                Console.Write(mensagem);
                string entrada = (Console.ReadLine() ?? "").Trim();

                valido = double.TryParse(entrada, out numero);

                if (!valido)
                {
                    Console.WriteLine("Valor inválido. Digite um número válido.");
                }

            } while (!valido);

            return numero;
        }

        static void Main(string[] args)
        {
            bool continuar = true;
            MathOperations math = new MathOperations();

            do
            {
                Console.WriteLine("*****************************");
                Console.Write("Bem-vindo a calculadora simples");
                Console.WriteLine("\n***************************");

                double a = LerNumero("Digite o primeiro numero:");
                double b = LerNumero("Digite o segundo numero:");

                Console.Write("Digite operação (+,-,*,/)ou 'sair' para encerrar:)");
                string resposta = (Console.ReadLine() ?? "").Trim();
                string validar = resposta.ToLower();

                switch (validar)
                {
                    case "+":
                        double res_soma = math.Somar(a, b);
                        Console.WriteLine($"Seu resultado é: {res_soma}");
                        continuar = PerguntaContinuar();
                        break;

                    case "-":
                        double res_sub = math.Diminuir(a, b);
                        Console.WriteLine($"Seu resultado é: {res_sub}");
                        continuar = PerguntaContinuar();
                        break;

                    case "*":
                        double res_mul = math.Multiplicar(a, b);
                        Console.WriteLine($"Seu resultado é: {res_mul}");
                        continuar = PerguntaContinuar();
                        break;

                    case "/":
                        try
                        {
                            double res_div = math.Dividir(a, b);
                            Console.WriteLine($"Seu resultado é: {res_div}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        continuar = PerguntaContinuar();
                        break;

                    case "sair":
                        continuar = false;
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Comando errado!");
                        continuar = true;
                        break;
                }
            } while (continuar);
        }
    }
}