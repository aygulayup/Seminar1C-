// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 51] -> 5 8 3
// [67 3 61] -> 36 21

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
    Console.Write("]");
}

// string ArrayToString(int [] array) // Метод преобразования массива в строку
// {
//     string result = "[";
//     for (int i = 0; i < array. Length; i++)
//     {
//     result = result + $"{array[i]}";
//     result = i < (array.Length - 1) ? result = result + "," : result; // для корректности вывода запятых
//     }
//     return result + "]";
// }


int[] MakeArray(int[] array)
{
    int size = array.Length % 2 != 0 ? array.Length / 2 + 1 : array.Length / 2;
    int[] resArray = new int[size];
    for (int i = 0; i < resArray.Length; i++)
    {
        if (i == resArray.Length - 1 && array.Length % 2 == 1)
        {
            resArray[i] = array[i];
        }
        else
        {
            resArray[i] = array[i] * array[array.Length - i - 1];
        }

    }
    return resArray;
}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
int[] newArray = MakeArray(arr);
PrintArray(newArray);


// int arraysize = 5, arrayMinValue = 0, arrayMaxValue = 10;
// int[] newArray = CreateArrayRndInt(arraysize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
// string strArray = ArrayToString(newArray); // переводим строку в массив для дальнейшего вывода на
// string halfAndDouble = MakeArray(newArray);
// string strHalfAndDouble = ArrayToString(halfAndDouble);
// Console.WriteLine($"{strArray} -> {strHalfAndDouble}");