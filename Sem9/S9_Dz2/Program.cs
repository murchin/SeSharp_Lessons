// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Программа, которая выводит находит сумму натуральных элементов в промежутке от M до N.");


Console.WriteLine("Введите число M:");

NewNumber(out int number);

int m = number;

Console.WriteLine("Введите число N:");

NewNumber(out number);
int n = number;

if (m>n)
{
    int temp =n;
    n=m;
    m=temp;
}

int Summa = 0;

RecursSumma(m, n);


void RecursSumma(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Summa = Summa + m;
    RecursSumma(m + 1, n);
}

Console.Write($"{Summa}");

void NewNumber(out int number)
{

    while (true)
    {
        string? text = Console.ReadLine();

        if (int.TryParse(text, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Не получилось распознать число. Ведите число:");

        }
    }
}

