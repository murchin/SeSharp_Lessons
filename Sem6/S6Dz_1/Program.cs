// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Подсчитаем, сколько чисел больше 0 вы введете");


string? text;
char Stop = 'q';
int CounterOfPositiv = 0;
int number;
List<int> InputNumbers = new List<int>();

while (true)
{
    Console.WriteLine("Введите целое число");
    Console.WriteLine("Для выхода введите q+Enter");
    text = Console.ReadLine();

    if ((text?[0] == Stop) & (text?.Length == 1))
    {
        break;
    }

    else
    {
        TextToNumber(text, out number);
        InputNumbers.Add(number);
    }

    if (number > 0)
    {
        CounterOfPositiv++;
    }
}
Console.WriteLine($"Вы ввели числа: {String.Join("; ", InputNumbers)}");
Console.WriteLine($"Количество введенных чисел больше 0 равно {CounterOfPositiv}");



void TextToNumber(string? text, out int number)
{ 
while (true)

    if (int.TryParse(text, out number) == false)
    {
        Console.WriteLine("Не удалось распознать число."); 
        Console.WriteLine("Всё-таки введите число. Пожалуйста.");   
        text = Console.ReadLine();    
    }
    else
    {
        break;
    }
}

