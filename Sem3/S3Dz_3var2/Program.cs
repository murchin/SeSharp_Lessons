// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Таблица кубов чисел от 1 (-1) до N.");
Console.WriteLine("Введите целое число N:");

int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int cube = 0;
int N1 = 0;

if (N <= 1 & N >= -1)

{
    N1 = 1;
}
else
{
    if (N > 0)
    {
        N1 = 2;
    }
    else
    {
        N1 = 3;
    }
}

Console.WriteLine("\tn\tn^3");
Console.WriteLine("       ");


switch (N1)
{
    case (1):
    Console.WriteLine($"\t{N}\t{N}");
    break;

    case (2):
        while (i <= N)
        {
            cube = (int)Math.Pow(i, 3);

            Console.WriteLine($"\t{i}\t{cube}");

            i++;
        }
        break;
    case (3):
    i=-i;
        while (i >= N)
        {
            cube = (int)Math.Pow(i, 3);

            Console.WriteLine($"\t{i}\t{cube}");

            i--;
        }
        break;

}