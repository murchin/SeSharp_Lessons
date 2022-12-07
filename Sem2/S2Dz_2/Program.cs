
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.WriteLine("Показываем третью цифру заданного числа! ");
Console.WriteLine("Для чисел меньше нуля тоже!");
Console.WriteLine("Невероятное зрелище!");
Console.WriteLine("Будьте смелыми, введите число:");

//Переводим в целые числа, чтобы избежать игр со string, chr и null.

int n = Convert.ToInt32(Console.ReadLine());
if (n > -100 & n < 100)
{
    Console.WriteLine("Третьей цифры нет!");
}
else
{
    if (n<0){n=-n;}
    string result = Convert.ToString(n);
    Console.WriteLine($"Третья цифра {result[2]}");
}

