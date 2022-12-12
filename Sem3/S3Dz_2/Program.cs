// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.


Console.WriteLine("Найдем длину отрезка в трехмерном пространстве");
Console.WriteLine("Результат будет округлен до сотых");
int[] point1 = new int[3];
int[] point2 = new int[3];

Console.WriteLine("Введите координаты первой точки:");
System.Console.WriteLine("X1:");
point1[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y1:");
point1[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Z1:");
point1[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
System.Console.WriteLine("X2:");
point2[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y2:");
point2[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Z2:");
point2[2] = Convert.ToInt32(Console.ReadLine());

double segment = Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) + Math.Pow((point2[1] - point1[1]), 2) + Math.Pow((point2[2] - point1[2]), 2));
// Округлим результат до второго знака после запятой
Console.WriteLine($"Длина отрезка с заданными координатами: {Math.Round(segment, 2, MidpointRounding.AwayFromZero)}");