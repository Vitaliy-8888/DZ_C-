﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 ==0)  // если число делится на два без остатка
{
    Console.WriteLine("Да, число " + number + " является чётным"); 
}
else
{
    Console.WriteLine("Нет, число " + number + " НЕ является чётным");
}