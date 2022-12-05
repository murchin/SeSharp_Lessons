// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Узнаем наибольшее из трех чисел!");
Console.WriteLine("Введите первое число а:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число с:");
double v = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Числа a={a}, b={b}, v={v}");

double max = a;

if (b > max)
{
    max = b;
}
if (v > max)
{
    max = v;
}

Console.WriteLine($"Максимальное число: {max}");