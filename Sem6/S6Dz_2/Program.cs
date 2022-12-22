// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Найдём точку пересечения двух прямых,");
Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");

Console.WriteLine("Первая прямая: y = k1 * x + b1,");

Console.WriteLine("Введите k1:");
double k1 = TextToNumber(Console.ReadLine());

Console.WriteLine("Введите b1:");
double b1 = TextToNumber(Console.ReadLine());

Console.WriteLine("Первая прямая: y = k1 * x + b1,");

Console.WriteLine("Введите k2:");
double k2 = TextToNumber(Console.ReadLine());

Console.WriteLine("Введите b2:");
double b2 = TextToNumber(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine($"Прямые y = {k1} * x + {b1} и y = {k2} * x + {b2} не пересекаются");
    Console.WriteLine("А значит параллельны");
}
else
{
    CrossPoint(k1, k2, b1, b2, out double x, out double y);

    Console.WriteLine($"Первая прямая y = {k1} * x + {b1} и");
    Console.WriteLine($"Вторая прямая y = {k2} * x + {b2}");
    Console.WriteLine($"Пересекаются в точке с координатами х = {x} и y = {y}");
}

double TextToNumber(string? text)
{
    double number = 0;
    while (true)
        if (double.TryParse(text, out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Не удалось распознать число.");
            Console.WriteLine("Введите число:");
            text = Console.ReadLine();
        }
    return number;
}

void CrossPoint(double k1, double k2, double b1, double b2, out double x, out double y)

{
    x = (b2 - b1) / (k1 - k2);
    y = (k2 * b1 - k1 * b2) / (k2 - k1);
}