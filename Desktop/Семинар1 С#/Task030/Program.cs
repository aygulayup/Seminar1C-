﻿// Задача 30: Напишите программу, 
// 1. которая выводит массив из 8 элементов, 
// 2. заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // индексы массива из 8и элементов 0, 1, 2, 3, 4, 5, 6, 7


// как можно обозначить массив
// int[] array1 = new int[4]{1,4,6,7};
// int[] array11 = new int[]{1,4,6,7};
// int[] array2 = {1,4, 6,7};



void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
    collection [i] = new Random (). Next (0, 2);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
    Console.Write($"{collection [i]} ");
    }
}

int[] array = new int[8]; // 0, 1, 2, 3, 4, 5, 6, 7
FillArray (array);
PrintArray (array);