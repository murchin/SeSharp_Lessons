// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Программа создает массив из 8 двухзначных чисел и выводит их на экран");
Console.WriteLine("Радостное!");

int i =0;

int[]array=new int[8];

Random number = new Random();

while (i<8)
{
    array[i]=number.Next(0,100);
    i++;
}

Console.WriteLine(String.Join( " ", array));
Console.WriteLine("Работает!!! Успокаивает.");