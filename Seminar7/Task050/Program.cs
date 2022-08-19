// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());  

int rows = 3;  // rows - количество строк (m)
int columns = 4;   // columns - количество столбцов (n)

int[,] array = new int[rows, columns]; // создаем матрицу изначально заполнена нулями
for (int i = 0; i < array.GetLength(0); i++) // строчки: GetLength(1) = m (кол-во строк) 
{
    for (int j = 0; j < array.GetLength(1); j++)// столбцам: GetLength(1) = n(кол-во столбцов)     
    {
       
        array[i, j] = new Random().Next(0, 10); //[)         
        Console.Write(array[i, j] + "\t"); // \t - Tab
    }
    System.Console.WriteLine();     
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++) 
    {
        
        
        if (number == array[i, j])  
        {   
            System.Console.WriteLine((i, j));
        }
        else System.Console.WriteLine(("Такого числа в массиве нет"));
    }
    break;   
}





