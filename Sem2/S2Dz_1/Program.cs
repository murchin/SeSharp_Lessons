﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
Console.WriteLine("Внимательно посмотрим на 2-ую цифру трехзначного числа!");
Console.WriteLine("Введите трехзначное число:");
int n = ((Convert.ToInt32(Console.ReadLine())) / 10) % 10;// Пробую писать действия в одну строку
if (n < 0)
{
    System.Console.WriteLine($"Вторая цифра числа это {n * (-1)}");

}
else
{ System.Console.WriteLine($"Вторая цифра числа это {n}"); }