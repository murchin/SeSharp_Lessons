// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Программа создает массив случайных вещественных чисел,");
Console.WriteLine("с количеством элементов от 2 до 20.");
Console.WriteLine("Считает разницу между максимальным и минимальным элементами массива");
Console.WriteLine("    ");

const int LBORDER = -99;
const int RBORDER = 100;

//Генератор случайного размера массива от 2 до 20 элементов
Random size1 = new Random();
int size = size1.Next(2, 21);
//

double[] Array = NewArray(size, LBORDER, RBORDER);

Console.WriteLine($"Сгенерирован массив: {string.Join(" ; ", Array)}");

Min_Max_FromArray(Array, out double Min, out double Max);

double Result = Math.Round((Max-Min),3);

Console.WriteLine($"Минимальный элемент массива: {Min}, Максимальный элемент массива: {Max}");
Console.WriteLine($"Разница между ними составляет: {Result}");




double[] NewArray(int size, int LBORDER, int RBORDER)
{
    Random rand = new Random();

    double[] Array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Array[i] = Math.Round(rand.Next(LBORDER, RBORDER) + rand.NextDouble(), 3);

    }
    return Array;
}

void Min_Max_FromArray(double[] Array, out double Min, out double Max)
{
    Min = Array[0];
    Max = Array[0];
    for (int i = 0; i < size; i++)
    {
        if (Array[i] > Max)
        {
            Max = Array[i];
        }
        else
        {
            if (Array[i] < Min)
            {
                Min = Array[i];
            }
        }
    }
}


