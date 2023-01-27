// Задача 35: 1. Задайте одномерный массив из 123 случайных чисел.
// 2. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> O
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrayRndInt(int size, int min, int max) //создание и заполнение массива
{
    int [] array = new int[size]; // новое место памяти для массива
    Random rnd = new Random(); // новое место памяти для элемента класса Random
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)// вывод массива в консоль
{
    Console.Write("["); //вывод массива на экран в [скобках]
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); // вывод эл-ов массива через запятую
        else Console.Write(array[i]); // обратиться к последнему элементу массива array[^1]
    }
    Console.Write("]");
}

int FindDoubleDigit(int[] array, int findMin, int findMax)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= findMin && array[i] <= findMax) result++;
    }
    return result;
}



int[] arr = CreateArrayRndInt(6, 0, 200);
PrintArray(arr);
int findDigit = FindDoubleDigit(arr, 10, 99);
Console.WriteLine($" -> {findDigit}");
