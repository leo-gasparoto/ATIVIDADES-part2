Console.WriteLine("Informe sua nota para saber sua classificação: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 90 && nota <= 100)
{
    Console.WriteLine($"Sua nota é {nota} e sua classificação foi A");
}

else if (nota >= 80 && nota <= 89) 
{
    Console.WriteLine("A sua classificação é B");
}
else if (nota >= 70 && nota <= 79) 
{
    Console.WriteLine("A sua classificação é C");
}

else if (nota >= 60 && nota <= 69) 
{
    Console.WriteLine("A sua classificação é D");
}

else if (nota < 60)
{
    Console.WriteLine("A sua classificação é F");
}



Console.ReadKey();
