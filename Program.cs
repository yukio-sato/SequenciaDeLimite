Console.Clear();
Console.WriteLine("Sequência de Limite.");
Console.Write("Escolha um número para iniciar: ");
int begin = Convert.ToInt32(Console.ReadLine());
Console.Write("Escolha um número para finalizar: ");
int end = Convert.ToInt32(Console.ReadLine());
if (begin <= end)
{
while (begin <= end)
{
Console.Write($"{begin} ");
begin = begin + 1;
}
Console.WriteLine();
}
else
{
    Console.WriteLine("O numero inicial é menor que o final, tente novamente.");
}
Console.WriteLine();