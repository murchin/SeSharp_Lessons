// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Программа, которая умножает 2 матрицы из целых чисел,");

Console.WriteLine("Сначала зададим размеры матриц m x n, заполненнух случайными вещественными числами.");
Console.WriteLine("Введите количество строк m: ");

int number;
int m;
int n;
int m1;
int n1;
int m2;
int n2;

NewNumber(out number);

m = number;

if (number == 0)
{
    goto Quit;

}

Console.WriteLine("Введите количество столбцов n: ");
NewNumber(out number);

n = number;


m1 = m;
n1 = n;

int[,] array1 = RandomTwoDimensionalArray(m1, n1);
Console.WriteLine(" ");


m2 = n;
n = number;
n2 = n1;




int[,] array2 = RandomTwoDimensionalArray(m2, n2);

int i = 0;
int j = 0;


int[,] result = new int[m1, n2];

Console.WriteLine(" ");

for (i = 0; i < array1.GetLength(0); i++)
{
    for (j = 0; j < array2.GetLength(1); j++)
    {

        result[i, j] = 0;

        for (int k = 0; k < result.GetLength(1); k++)
        {

            result[i, j] +=  (array1[i, k] * array2[k, j]);
        }
        Console.Write($"{result[i, j]}\t");
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
            array[i, j] = rund.Next(-99, 99);
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

