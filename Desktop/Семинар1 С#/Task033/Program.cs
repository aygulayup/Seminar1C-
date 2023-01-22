// Задача 33: 
// 1. Задайте массив. 
// 2. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
    Console.WriteLine("]");
}

bool FindNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Введите искомое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
Console.WriteLine(FindNumber(arr, userNumber) ? "да" : "нет");
