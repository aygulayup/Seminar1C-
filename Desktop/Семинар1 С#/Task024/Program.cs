﻿// Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до A.

// 7 -> 28
// 4 - > 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"{number} -> {sumNumbers}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

