// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");

int digit = 0;
int sum = 0;
int number = Convert.ToInt32(Console.ReadLine());
int countPositive = 0; 

while (number != 0)  // делим число на 10, пока оно не будет равно 0 (станет меньше 1) 
 {
     digit = number % 10;   // берем остаток от деления на 10
     sum = sum + digit;    // суммируем цифры в числе
     number = number / 10;  // делим число на 10
     countPositive++;       // счетчик количества цифр в числе 
 }
Console.WriteLine($"Сумма цифр: {sum}");