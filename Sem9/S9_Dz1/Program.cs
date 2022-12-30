// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Программа, которая выводит все натуральные числа в промежутке от N до 1");
int n;

Console.WriteLine("Введите число N:");

NewNumber(out int number);

n = number;

RNumber(n);


void RNumber(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write($"{n}; ");
    RNumber(n - 1);
}



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

