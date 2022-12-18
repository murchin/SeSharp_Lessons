// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Программа создает массив случайных трехзначных целых чисел больше 0,  ");
Console.WriteLine("с количеством элементов от 2 до 20.");
Console.WriteLine("Считает количество четных чисел в массиве");
Console.WriteLine("    ");

const int LBORDER = 100;
const int RBORDER = 1000;

//Генератор случайного размера массива от 2 до 20 элементов
Random size1 = new Random();
int size = size1.Next(2, 21);
//

int[] Array = NewArray(size, LBORDER, RBORDER);

Console.WriteLine($"Сгенерирован массив: {string.Join(" ", Array)}");
Console.WriteLine("Четные числа массива:");

int Number_Of_even = 0;

for (int i = 0; i < size; i++)
{
    if (Array[i] % 2 == 0)
    {
        Number_Of_even++;
        Console.Write($" {Array[i]} ");
    }
}

Console.WriteLine($"\nКоличество чётных чисел в массиве {Number_Of_even}");




int[] NewArray(int size, int LBORDER, int RBORDER)
{
    Random rand = new Random();

    int[] Array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Array[i] = rand.Next(LBORDER, RBORDER);

    }
    return Array;
}



