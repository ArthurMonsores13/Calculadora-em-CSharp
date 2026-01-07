 bool PerguntaContinuar()
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




double LerNumero(string mensagem)
{
    double numero;
    bool valido;

    do
    {
        Console.Write(mensagem);
        string entrada = (Console.ReadLine()??"").Trim();

        valido = double.TryParse(entrada, out numero);

        if (!valido)
        {
            Console.WriteLine("Valor inválido. Digite um número válido.");
        }

    } while (!valido);

    return numero;
}


//Program

void Programa()
{
   bool continuar = true;
    do
    {
        
    Console.WriteLine("*****************************");
    Console.Write("Bem-vindo a calculadora simples");
    Console.WriteLine("\n***************************");
    
    double a = LerNumero("Digite o primeiro numero:");
    double b = LerNumero("Digite o segundo numero:");




    Console.Write("Digite operação (+,-,*,/)ou 'sair' para encerrar:)");
    string resposta = (Console.ReadLine()??"").Trim();
    string validar = resposta.ToLower();

       

    switch (validar)
        {
            case "+":
                Console.WriteLine($"Seu resultado é: {a + b}");
                continuar = PerguntaContinuar();
                break;

            case "-":
                Console.WriteLine($"Seu resultado é: {a - b}");
                continuar = PerguntaContinuar();
                break;

            case "*":
                Console.WriteLine($"Seu resultado é: {a * b}");
                continuar = PerguntaContinuar();
                break;

            case "/":
                if (b == 0)
                    Console.WriteLine("Não é possível dividir por 0.");
                else
                    Console.WriteLine($"Seu resultado é: {a / b}");

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
    }while(continuar);
}
    
Programa();