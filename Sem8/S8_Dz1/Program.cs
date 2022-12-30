// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.WriteLine("Программа, которая задаёт двумерный массив из целых чисел,");
Console.WriteLine("затем упорядочивает по убыванию элементы каждой строки двумерного массива.");
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

int temp = 0;

for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {

        for (int Fist = 0; Fist < array.GetLength(1); Fist++)
        {
            for (int Second = Fist + 1; Second < array.GetLength(1); Second++)
                if (array[i, Fist] < array[i, Second])
                {
                    temp = array[i, Second];
                    array[i, Second] = array[i, Fist];
                    array[i, Fist] = temp;
                }
        }


        Console.Write($"{array[i, j]}\t");
    }

    Console.WriteLine(" ");
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
            array[i, j] = rund.Next(1, 100);
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

