//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Посчитаем сумму цифр в целом числе");
long number;
int Sum = 0;

number = TextToNumber();
Sum = SumDigit();

Console.WriteLine($"Сумма цифр равна {Sum}");



long TextToNumber()
{
    string? text;

    while (true)
    {
        Console.WriteLine("Введите целое число");
        text = Console.ReadLine();
        if (long.TryParse(text, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Не удалось распознать целое число.");
        }
    }
    return number;
}

int SumDigit()
{
    int i = 10;
    int digit;
    if (number<0)
    {
        number = -number;
    }
    while (number > 0)
    {
        digit = ((int)number) % i;
        Sum = Sum + digit;
        number = number / i;
    }
    return Sum;
}