// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]

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

//Array.Reverse(array); //встроенный метод переворота массива

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; // меняем местами элементы
        arr[i] = arr[arr.Length - 1 - i]; // - i чтобы каждый цикл элемент уменьшался на 1
        arr[arr.Length - 1 - i] = temp;

    }
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
ReverseArray(array);
PrintArray(array);
