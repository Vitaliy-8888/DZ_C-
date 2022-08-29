// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


int rows = 4;  
int columns = 4; 

int[,] matrix = new int[rows, columns];  // создаем матрицу

int i = 0; 
int j = 0;  
int number = 1;  

while (number <= rows * columns) // заполняем матрицу
{
    matrix[i, j] = number;  
    if (i <= j + 1 && i + j < columns - 1) j = j + 1;
    else if (i < j && i + j >= rows - 1) i = i + 1;
    else if (i >= j && i + j > columns - 1) j = j - 1;
    else i = i - 1;
    number = number + 1;  
}

PrintArray(matrix);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)  // по строкам 
    {
        for (int j = 0; j < array.GetLength(1); j++) // по столбцам
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}