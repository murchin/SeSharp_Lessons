// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Выясним, является ли обозначенный цифрой день недели выходным");
Console.WriteLine("Введите цифру от 1 до 7");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 | day > 7)
{
    Console.WriteLine("Ошибка! В неделе всего 7 дней!");
}
else
{
    string result = (day < 6) ? "Это будни. Время работать." : "Это выходной. Время отдыхать. Юху!!!";
    Console.WriteLine(result);
}
