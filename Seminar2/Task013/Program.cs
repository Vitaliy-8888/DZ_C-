// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99)

// Вариант со строкой. 
// Console.Write("Введи число: ");
// string number = Console.ReadLine();

// if (number.Length > 2)
// {
//     Console.Write(number[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// Вариант с делением на 10 и берем остаток от деления на 10
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;                                     // вводим переменную result
if (number > 99)                                    // если число меньше трехзначного
{
    while (number > 100)
    {   
        result = number % 10;                       // берем остаток от деления на 10
        number = number / 10;                       // делим число на 10
    }
    Console.Write(result);                          // печатаем результат
}

else
{ 
        Console.WriteLine("Третьей цифры нет");
}
    
    

         
    
