﻿int m;
double soma;
double n1, n2;

do
{
    Console.Write("\nDigite um número (1- Exibir um mensagem, 2- Fazer soma, 3- Sair): ");
    m = int.Parse(Console.ReadLine());

    switch (m)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ola amigo :) ");
            Console.ResetColor();
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nInsira o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;
            Console.Write($"\nA soma dos números inseridos é: {soma}");
            Console.ResetColor();
            break;
    }
}

while (m != 3);


Console.WriteLine("Programa foi Encerrado.");
Console.ReadKey();