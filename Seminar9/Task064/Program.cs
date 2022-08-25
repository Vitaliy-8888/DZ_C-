// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int M = Convert.ToInt32(Console.ReadLine()); 
int N = Convert.ToInt32(Console.ReadLine()); 
/// start = M -  начальная точка 
/// end - N - конечная точка 
// [M;N]  
string PrintNumbers (int start, int end)  
{     
    // Базовый случай идем от M до N. 
    if (start == end) return start.ToString(); 
    // Рекурсивный случай     
    return (start + ", " + PrintNumbers(start+1, end)); // PrintNumbers возвращает от start+1 до end
}  
Console.WriteLine(PrintNumbers(M, N)); 
