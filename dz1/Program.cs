﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadTon(int number )
{
    
    if (number ==0)
     {
        return;
     }
     System.Console.Write($" {number}");
      RoadTon(number - 1);

} 

 System.Console.Write("Введите число: " );
 int number = Convert.ToInt32(Console.ReadLine());
 RoadTon( number );