﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите любое положительное трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num % 100) / 10;

if (num > 100 && num < 1000)
{
    Console.WriteLine($"В введном числе {num} вторая цифра: {result}");
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}