// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());  // rows - количество строк (m)
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());   // columns - количество столбцов (n)

int[,] array = new int[rows, columns]; // создаем матрицу изначально заполнена нулями
for (int i = 0; i < array.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк) 
{
    for (int j = 0; j < array.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)     
    {
        array[i, j] = new Random().Next(0, 10);          
        Console.Write(array[i, j] + "\t"); // \t - Tab
    }
    System.Console.WriteLine();   
}
double result = 0;
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++) // проходим по всем столбцам
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) // проход по всем строкам
    {
        sum = sum + array[i, j];      
    }
    result = sum / rows; 
    Console.WriteLine($"Среднее арифметическое столбца {j} = {(Math.Round(result,1))} ");
}



