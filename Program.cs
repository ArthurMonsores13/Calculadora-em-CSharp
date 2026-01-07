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
            int res_soma = math.somar
                Console.WriteLine($"Seu resultado é: {res_soma}");
                continuar = PerguntaContinuar();
                break;

            case "-":
                int resl_sub = math.diminuir
                Console.WriteLine($"Seu resultado é:");
                continuar = PerguntaContinuar();
                break;

            case "*":
                int res_mul = math.multiplicar
                Console.WriteLine($"Seu resultado é:");
                continuar = PerguntaContinuar();
                break;

            case "/":
                int res_div = math.dividir
                COnsole.WriteLine($"Seu resultado é:")

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