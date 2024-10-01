string[] DiaSemana = { "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sabado", "Domingo" };

string[] VetTarefa = new string[7];

for (int i = 0; i < DiaSemana.Length; i++)

{
    Console.Write($"Digete suas tarefas {DiaSemana[i]}: ");
    VetTarefa[i] = Console.ReadLine();
}

Console.WriteLine("\nTarefas da semana:");
for (int i = 0; i < DiaSemana.Length; i++)
{

    Console.WriteLine($"{DiaSemana[i]}: {VetTarefa[i]}");

}

Console.ReadKey();