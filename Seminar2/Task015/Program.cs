// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine()); 

if (dayNumber >= 1 && dayNumber <= 7) //[1;7]. Проверка числа 
{
    if (dayNumber == 6)
    {
        Console.WriteLine("Да");
    }
    else if (dayNumber == 7) 
    {
        Console.WriteLine("Да"); 
    }
    else
    {
        Console.WriteLine("Нет"); 
    }
}
else
{
    Console.WriteLine("Error 404, day not found");
}

