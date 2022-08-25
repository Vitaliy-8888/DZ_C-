// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29. !!! Должно быть 9 !!!



int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int Akkerman = Ack(m, n);

int Ack(int m, int n)
{
    // Базовый случай
    if (m == 0) return n + 1;
    // Рекурсивный случай     
    else if (n == 0 && m > 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
Console.Write($"Результат = {Akkerman} ");