// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray (int size, int minRandom, int maxRandom) 
{    
    int [] result = new int[size]; // Создаем массив result из size элементов заполненный нулями    

    for (int i = 0; i < result.Length; i++) // Заполняем массив пройдясь по всей длине массива      
    {        
        result[i] = new Random().Next(minRandom,maxRandom + 1); // заполняем случайными числами [-99;99]     
    }     
    return result; // return - возвращает массив с именем result
}
int [] array = GetArray (10,-99,99); // массив из 10 элементов [-99;99]      

// массив array переводим в строчку и выводим на печать  
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");  
int sum = 0;   // сумма элементов

for (int i = 1; i < array.Length; i+=2)  // проходим по всему массиву с шагом 2
{   
    sum = sum + array[i];   // считаем сумму элементов 
}
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}"); 
