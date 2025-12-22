 bool PerguntaContinuar()
{
    Console.Write("Você deseja continuar ou sair? (continuar/sair): ");
    string resposta = Console.ReadLine().ToLower();

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
        Console.WriteLine("Comando inválido. Encerrando programa.");
        return false;
    }


}




double LerNumero(string mensagem)
{
    double numero;
    bool valido;

    do
    {
        Console.Write(mensagem);
        string entrada = Console.ReadLine();

        valido = double.TryParse(entrada, out numero);

        if (!valido)
        {
            Console.WriteLine("Valor inválido. Digite um número válido.");
        }

    } while (!valido);

    return numero;
}




void Programa()
{
   bool continuar = true;
    do
    {
        
    Console.WriteLine("*****************************");
    Console.Write("Bem-vindo a calculadora simples");
    Console.WriteLine("\n***************************");
    
    double a = LerNumero("Digite primeiro numero:");
    double b = LerNumero("Digite segundo numero:");




    Console.Write("Digite operador que deseja (somar,diminuir,multiplicar ou dividir/digite sair para encerrar:)");
    string resposta = Console.ReadLine();
    string validar = resposta.ToLower();

    double soma = a + b;
    double multiplicar = a * b;
    double diminuir = a - b;
    double dividir = a / b;
       

    if(validar == "somar")
    {
        Console.WriteLine("Seu resultado é: "+ soma);
        continuar = PerguntaContinuar();

        }
        
        else if(validar == "multiplicar")
        {
            Console.WriteLine("Seu resultado é: "+ multiplicar);
            continuar  = PerguntaContinuar();

        }
        
        else if(validar == "diminuir")
        {
            Console.WriteLine("Seu resultado é: "+ diminuir);
            continuar = PerguntaContinuar();

        }
        
        else if(validar == "dividir")
        {
            if (a == 0  || b == 0)
            {
            Console.WriteLine("Não é possivel a divisao por 0");
            continuar = PerguntaContinuar();
            }
            else
            {
            Console.WriteLine("Seu resultado é: " + dividir);
            continuar = PerguntaContinuar();
            }
        }
        
        else if(validar == "sair")
        {
            continuar = false;
            Console.WriteLine("Encerrando...");
        }


        else
        {
            Console.WriteLine("\nComando errado!");
            continuar = true;
        }
    }while(continuar);
}
    
Programa();