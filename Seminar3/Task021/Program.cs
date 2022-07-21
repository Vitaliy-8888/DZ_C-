// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату x1 точки А:");
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y1 точки А:");
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату z1 точки А:");
int z1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите координату x2 точки B:");
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координату y2 точки B:");
int y2 = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите координату z2 точки B:");
int z2 = Convert.ToInt32(Console.ReadLine()); 

// формула: D= √ ((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
// var - автоматически определит тип переменной, которая будет в ответе
// Math.Sqrt – взять корень из числа. 
// Math.Pow – возведение числа в степень. 
var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(Math.Round(result));   // Math.Round – функция округляет до ближайшего целого числа
Console.WriteLine(result);              // выводит значение результата без округления

