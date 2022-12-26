//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 

Console.WriteLine("Программа, которая задайет двумерный массив из целых чисел,");
Console.WriteLine("затем находит среднее арифметическое элементов в каждом столбце.");
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

double[,] array = RandomTwoDimensionalArray(m, n);

double Sum = 0;
double AverageOfColumn = 0;
int i = 0;
int j = 0;

for (j = 0; j < array.GetLength(1); j++)
{
    for (i = 0; i < array.GetLength(0); i++)
    {
        Sum = Sum + array[i, j];
    }

    //Console.WriteLine($"Сумма чисел чисел  в {j + 1}-м столбике  равно {Sum}");

    AverageOfColumn = Sum / m;
    Console.WriteLine($"Среднее арифметическое чисел чисел  в {j + 1}-м столбике  равно {Math.Round(AverageOfColumn,3,MidpointRounding.AwayFromZero)}");
    Console.WriteLine("");
    AverageOfColumn = 0;
    Sum = 0;
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

