try
{
    Console.Write("Digite o Primeiro Numero: "); 
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o Segundo Numero: ");
    int numero2 = int.Parse(Console.ReadLine());

    int resultado = numero1 + numero2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("Erro: Por Favor, digite um numeros válidos!!!");
}

Console.ReadKey();