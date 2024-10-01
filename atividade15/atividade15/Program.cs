Console.Write("digite um numero positivo: ");
int numero = int.Parse(Console.ReadLine());


Console.WriteLine($"\nNumeros de 0 até {numero}");
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{i} x {numero} = {i * numero}");
}

Console.WriteLine("Digite uma tecla para sair! ");
Console.ReadKey();

