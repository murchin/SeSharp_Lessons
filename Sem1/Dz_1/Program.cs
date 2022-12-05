// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Узнаем наибольшее из двух чисел!");
Console.WriteLine("Введите первое число а:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число b:");
double b = Convert.ToDouble(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("Эти числа равны!!!");
}
else
{
    if (a > b)
    {
        Console.WriteLine($"Число a = {a}, число b = {b}");
        Console.WriteLine($"{a} > {b}");
        Console.WriteLine("a > b");
        Console.WriteLine($"Max a = {a}");
    }
    else
    {
        Console.WriteLine($"Число a = {a}, число b = {b}");
        Console.WriteLine($"{b} > {a}");
        Console.WriteLine("b > a");
        Console.WriteLine($"Max b = {b}");
    }

}


