// Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Программа, которая задаёт трехмерный массив из целых чисел, заполненный случайными двузначными числами.");
Console.WriteLine("затем выводит его элементы с индексами на печать.");
Console.WriteLine("");
Console.WriteLine("Сначала зададим трехмерный массив размером m x n x k.");
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

Console.WriteLine("Введите количество столбцов k: ");
NewNumber(out number);
int b = number;
if (number == 0)
{
    goto Quit;

}


int[,,] array = new int[m, n, b];
Console.WriteLine(" ");

Random rund = new Random();

for (int k = 0; k < b; k++)
{
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            TwoDigit:array[i, j, k] = rund.Next(-99, 100);
            if  ((array[i, j, k]<10)&(array[i, j, k]>-10))
            {
                goto TwoDigit;
            }

            if (array[i, j, k] < 0)

            {
                Console.Write($"{array[i, j, k]}");
                Console.Write($"({i}, {j}, {k})\t");
            }

            else
            {
                Console.Write($" {array[i, j, k]}");
                Console.Write($"({i}, {j}, {k})\t");
            }
        }
        Console.WriteLine();
    }

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
