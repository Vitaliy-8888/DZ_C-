// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());  
int N = Convert.ToInt32(Console.ReadLine());  
/// M -  начальная точка 
/// N - конечная точка 
// [M;N]  
int Sum(int M, int N)  
{     
    // Базовый случай   
    if (M == N) return M; 
    // Рекурсивный случай     
    return (N + Sum(M, N - 1));  
}  
Console.WriteLine(Sum(M, N));  
