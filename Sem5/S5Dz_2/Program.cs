//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Программа создает массив случайных двухзначных целых чисел  с количеством элементов от 2 до 20.");
Console.WriteLine("Находит сумму элементов массива, имеющих нечетные индексы.");
Console.WriteLine("    ");

const int LBORDER = -99;
const int RBORDER = 100;

//Генератор случайного размера массива от 2 до 20 элементов
Random size1 = new Random();
int size = size1.Next(2, 21);
//

int[] Array = NewArray(size, LBORDER, RBORDER);

Console.WriteLine($"Сгенерирован массив: {string.Join(" ; ", Array)}");
Console.WriteLine("Числа с нечетными индексами:");

int Sum_Of_Odd = 0;

for (int i = 1; i < size; i++)
{
    Sum_Of_Odd = Sum_Of_Odd + Array[i];
    Console.Write($" {Array[i]} ");
    i++;
}

Console.WriteLine($"\nСумма элементов массива с нечетными индексами {Sum_Of_Odd}");
Console.WriteLine("Всё сама программа делает. Лепота! Любо мне такое! Ой, любо! Всегда бы так!");




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



