// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8


Console.Write("Количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine()); 

int[,] GetArray(int rows, int columns, int minRandom, int maxRandom) 
{
    int[,] result = new int[rows, columns]; 
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return result; 
}

void PrintArray(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i, j] + "\t"); 
        }
        Console.WriteLine(); 
    }
}
// SelectionSort - метод, который отсортирует элементы по убыванию
void SelectionSort(int[,] inputMatrix) 
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        // длина массива будет "inputMatrix.GetLength(1) - 1", т.к., поиск неотсортированных элементов будет с i + 1 
        for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++) 
        {
            int maxIndexRows = i;  
            int maxIndexColumns = j; 

            // найдем минимальный элемент 
            for (int k = j + 1; k < inputMatrix.GetLength(1); k++)
            {
                if (inputMatrix[i, k] > inputMatrix[maxIndexRows, maxIndexColumns])
                {
                    maxIndexRows = i;
                    maxIndexColumns = k;
                }
            }
            // обмен двух переменных местами через временную переменную (temp):
            int temp = inputMatrix[i, j]; 
            inputMatrix[i, j] = inputMatrix[maxIndexRows, maxIndexColumns];  
            inputMatrix[maxIndexRows, maxIndexColumns] = temp;
        }
    }
}
int[,] resultMatrix = GetArray(rows, columns, 0, 9);

PrintArray(resultMatrix); 
System.Console.WriteLine("Упорядоченные по убыванию элементы:");
SelectionSort(resultMatrix);
PrintArray(resultMatrix); 




