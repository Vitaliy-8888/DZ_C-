// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)         // проверка на пятизначное число
{
    int firstDigit = number / 10000 % 10;   // находим первую цифру
    int secondDigit = number / 1000 % 10;   // находим вторую цифру
    int fourthDigit = number / 10 % 10;     // находим четвертую цифру
    int fifthDigit = number % 10;           // находим пятую цифру
    if (firstDigit == fifthDigit && secondDigit == fourthDigit)   // сравниваем цифры 1-ю с 5-й и 2-ю с 4-й
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
    Console.WriteLine("Это НЕ пятизначное число");  // выдает ошибку
}
