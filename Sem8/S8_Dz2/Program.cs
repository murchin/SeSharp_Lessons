// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Программа, которая задаёт двумерный массив из целых чисел,");
Console.WriteLine("затем находит строку с наименьшей суммой элементов и показывает ее номер.");
Console.WriteLine("");
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

int[,] array = RandomTwoDimensionalArray(m, n);
Console.WriteLine(" ");

int i = 0;
int j = 0;

int[] SumOfElements = new int[m];

for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        SumOfElements[i] = SumOfElements[i] + array[i, j];
    }
    //     Console.Write($"{SumOfElements[i]}\t");
    //     Console.WriteLine(" ");
}

int Min = SumOfElements[0];
int MinString = 0;

for (i = 0; i < m; i++)
{
    if (SumOfElements[i] < Min)
    {
        Min = SumOfElements[i];
        MinString = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов {MinString + 1}");
Console.WriteLine(" ");

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
                if (number > 1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число должно быть  больше 1. Попробуйте еще раз.");
                }
            }
            else
            {
                Console.WriteLine("Не получилось распознать число. Ведите число:");

            }
        }
    }
}

int[,] RandomTwoDimensionalArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random rund = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rund.Next(-99, 100);
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

