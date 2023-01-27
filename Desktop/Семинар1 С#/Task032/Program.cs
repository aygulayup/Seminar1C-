// Задача 32: 
// 1. Напишите программу замена элементов массива: 
// положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// 1-4, -8, 8, 2] -> [4, 8, -8, -2]

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

void ChangeOverNumber(int[] array) // массив передается по ссылке и для работы с ним можно использовать тип данных void
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }
}

int[] arr = CreateArrayRndInt(4, -10, 10); //создание массива
PrintArray(arr); // при типе void вызываем метод просто прописывая
ChangeOverNumber(arr);
PrintArray(arr);



