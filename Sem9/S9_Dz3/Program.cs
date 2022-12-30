// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Программа, которая вычисляет функцию Аккермана для двух неотрицательных чисел");

Console.WriteLine("Введите число M:");

NewNumber(out double number);

double m = number;

Console.WriteLine("Введите число N:");

NewNumber(out number);
double n = number;

double Akkerman = 0;

Akkerman = AkkermanFunc(m, n);

double AkkermanFunc(double m, double n)
{
    if (m == 0)
    {
        Akkerman = n + 1;

    }
    if (n == 0)
    {
        Akkerman = AkkermanFunc((m - 1), 1);
    }

    if ((m > 0) & (n > 0))
    {
        Akkerman = AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
    
    return Akkerman;
}

Console.WriteLine($"Функция Аккермана для чисел M={m} и N={n} равна {Akkerman}");

void NewNumber(out double number)
{

    while (true)
    {
        string? text = Console.ReadLine();

        if (double.TryParse(text, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Не получилось распознать число. Ведите число:");

        }
    }
}

