// Задача 45: Напишите программу, 
// которая будет создавать копию заданного массива 
// с помошью поэлементного копирования.

int[] CreateArrayRndInt(int size, int min, int max) //создание и заполнение массива случайными элементами
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

int[] CopyArray(int[] array) // копирование элементов массива
{
    int [] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

int[] arr = CreateArrayRndInt(5, 1, 10);
PrintArray(arr);
int[] arr1 = CopyArray(arr);
PrintArray(arr1);

