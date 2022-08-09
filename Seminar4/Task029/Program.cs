// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = GetBinaryArray(8);  // заполняем массив 
Console.Write($"[{String.Join(",", array)}]");  // массив приводим к строчке и выводим на печать
int[] GetBinaryArray(int size) 
{     
    int[] result = new int[size];  // new int[size] - массив размером size элементов     
    
    for (int i = 0; i < result.Length; i++)     
    {         
        result[i] = new Random().Next(1, 100); // [1, 100)         
            
    }     return result; 
}
