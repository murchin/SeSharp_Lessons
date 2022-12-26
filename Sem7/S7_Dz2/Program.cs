
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine ("Программа, которая на вход принимает позиции элемента в двумерном массиве,");
Console.WriteLine ("и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine ("");
Console.WriteLine("Сначала зададим двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.WriteLine("Введите количество строк m: ");

int number;

NewNumber(out number);

int m = number;

if (number == 0)
{
    goto Quit;

}

Console.WriteLine("Введите количество столбцов n: ");
NewNumber(out number);
int n = number;
if (number == 0)
{
    goto Quit;

}

double[,] array = RandomTwoDimensionalArray(m, n);


int x = 0;
int y = 0;

while (true)
{
    Console.WriteLine("Посмотрим  элемент массива.");
    Console.WriteLine("Введите координаты элемента:");
    Console.WriteLine("Строка:");

    NewNumber(out number);
    x = number - 1;

    if (number == 0)
    {
        goto Quit;

    }

    Console.WriteLine("Столбец:");

    NewNumber(out number);
    y = number - 1;

    if (number == 0)
    {
        goto Quit;

    }


    if ((x < m) & (y < n))

    {
        Console.WriteLine($"Это координаты элемента массива: {(array[x, y])}");
    }

    else
    {
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    Console.WriteLine("");
}

Quit: Console.WriteLine("Спасибо за внимание!");




void NewNumber(out int number)
{
    char Exit = 'q';
    while (true)
    {

        Console.WriteLine("Для выхода введите \nq+Enter");
        string? text = Console.ReadLine();
        if ((text?[0] == Exit) & (text?.Length == 1))
        {
            number = 0;
            break;
        }
        else
        {

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

