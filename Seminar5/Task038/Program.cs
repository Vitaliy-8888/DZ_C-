// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double [] array = new double [5]; // создадим массив размером 5 элементов

for (int i = 0; i < array.Length; i++) // проходим по всей длине массива
{
    double test = new Random().NextDouble();  // каждому элементу массива присвоим случайные числа 
    // Console.Write(test + "\t");
    test*= 100;
    System.Console.Write(Math.Round(test,2) + "\t"); // выводим массив
}
//    !!! Не получилось найти min и max в массиве вещественных чисел!!!  

// double different = 0; 
// double min = test[0];
// double max = test[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (min > test [i])
//     {
//         min = test [i]);
//     }
//     else if (max < test [i])
//     {
//         max = test [i]);
//     }
// }
// difference = max – min;
// System.Console.WriteLine($"Разница = {different}");
