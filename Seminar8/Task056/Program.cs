// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = 4;  
int columns = 3;  

int[,] array = new int[rows, columns]; // создаем матрицу изначально заполнена нулями
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)   
    {
        array[i, j] = new Random().Next(0, 10);  
        Console.Write(array[i, j] + "\t"); 
    }
    System.Console.WriteLine();   
}
Console.WriteLine(); 

int index = 0;  // индекс строки
int minValue = int.MaxValue; // Значение минимального элемента

for (int i = 0; i < array.GetLength(0); i++) // проход по строкам
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) // проходим по столбцам
    {
        sum = sum + array[i, j]; 
    }
    if (sum < minValue)  
    {
        minValue = sum;  
        index = i;    
    }
    Console.WriteLine($"Сумма элементов строки {i} = {sum} "); 
}
Console.WriteLine($"Строка c наименьшей суммой элементов = {minValue} "); 
Console.WriteLine($"Индекс строки с наименьшей суммой = {index} ");





