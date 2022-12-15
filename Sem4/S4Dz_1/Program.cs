// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

string? text =" ";
double result = 0; 
char Stop ='q';
int i = 0;
System.Console.WriteLine("Возведение числа в степень");

while (i==0)
{
System.Console.WriteLine("Возведем число A в степень В");
System.Console.WriteLine("Введите число A:");
System.Console.WriteLine("Выход: q+Enter");
text = Console.ReadLine();
if ((text?[0]==Stop)&(text?.Length == 1))
{
    break;
}

int A = TestText(text);

System.Console.WriteLine("Введите число B:");
System.Console.WriteLine("Выход: q+Enter");
text = Console.ReadLine();
if ((text?[0]==Stop)&(text?.Length == 1))
{
    break;
}
int B = TestText(text);

result = Math.Pow(A,B);

System.Console.WriteLine("                                 ");
System.Console.WriteLine($"{A} в степени {B} равно {result}");
System.Console.WriteLine("                                 ");
}
System.Console.WriteLine("                                 ");
Console.WriteLine ("Спасибо за внимание!");

// Функция проверки, являются ли символы числом + преобразование в число.  
// Изобретаю "велосипед" - не так, как показывали в семинаре 4. Не лучший вариант, зато свой, выстраданный.

int TestText (string? text)
{
  EnterText:if (int.TryParse(text, out int number)==false)
    {
    Console.WriteLine("Пожалуйста, введите число");
    text =Console.ReadLine();
    goto EnterText;
    }
else
{
return number;
}
}
