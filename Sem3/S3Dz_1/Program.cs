// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//Решение для любого целого числа, помещающегося в тип long

Console.WriteLine("Проверим, является ли число палиндромом");
Enter: Console.WriteLine("Введите число:");

long number = Convert.ToInt64(Console.ReadLine());

//Проверка на отрицательное число

if (number < 0)
{
    number = -number;
}
//Проверка на число меньше 10 (цифра не может быть палиндромом)

if (number < 10)
{
    Console.WriteLine("Число должно быть хотя бы двухзначным! Ваш вариант не подходит.");
    goto Enter;
}

//Преобразование введенного числа сначала в строку, а уже ее - в массив символов

string simbols = Convert.ToString(number);
char[] simbols1 = (simbols).ToCharArray();

int i = 0;
int iend = (simbols1.Length)-1;
string result = "Палиндром";

//Цикл проверки символов массива (идет с двух сторон массива)

while (i < iend)
{
    if (simbols1[i] == simbols1[iend])
    {
        i++;
        iend--;
        }
    else
    {
        result = "Не палиндром";
        break;
        
    }
}

 Console.WriteLine(result);
