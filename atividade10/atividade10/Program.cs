Console.Write("Escolha um número entre 1 e 12: ");
int numeroMes = int.Parse(Console.ReadLine());

switch (numeroMes)
    {
    case 1:
        Console.WriteLine($"Você escolheu o mês de Janeiro,  a estação é Verão");
        break;

    case 2:
        Console.WriteLine($"Você escolheu o mês de Fevereiro,  a estação é Verão");
        break;
    case 3:
        Console.WriteLine($"Você escolheu o mês de Março,  a estação é Outono");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês de Abril,  a estação é Outono");
        break;
    case 5:
        Console.WriteLine($"Você escolheu o mês de Maio,  a estação é Outono");
        break;
    case 6:
        Console.WriteLine($"Você escolheu o mês de Junho,  a estação é Inverno");
        break;
    case 7:
        Console.WriteLine($"Você escolheu o mês de Julho,  a estação é Inverno");
        break;
    case 8:
        Console.WriteLine($"Você escolheu o mês de Agosto,  a estação é Inverno");
        break;
    case 9:
        Console.WriteLine($"Você escolheu o mês de Setembro,  a estação é Primavera");
        break;
    case 10:
        Console.WriteLine($"Você escolheu o mês de Outubro,  a estação é Primavera");
        break;
    case 11:
        Console.WriteLine($"Você escolheu o mês de Novembri,  a estação é Primavera");
        break;
    case 12:
        Console.WriteLine($"Você escolheu o mês de Dezembro,  a estação é Verão");
        break;

}

Console.ReadKey();