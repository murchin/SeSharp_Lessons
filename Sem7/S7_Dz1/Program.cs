// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.WriteLine("Зададим двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.WriteLine("Введите количество строк m: ");
int number;
NewNumber(out number);
int m = number;

Console.WriteLine("Введите количество столбцов n: ");
NewNumber(out number);
int n = number;

RandomTwoDimensionalArray(m, n);


void NewNumber(out int number)
{
    while (true)
    {

        string? text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            if (number > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Число должно быть  больше 0. Попробуйте еще раз.");
            }
        }
        else
        {
            Console.WriteLine("Не получилось распознать число. Ведите число:");

        }
    }
}


double[,] RandomTwoDimensionalArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random rund = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((rund.Next(-99, 100) + rund.NextDouble()), 3);
            if (array[i, j] < 0)
            {
                Console.Write($"{array[i, j]}\t");
            }

            else
            {
                Console.Write($" {array[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
    return array;
}
