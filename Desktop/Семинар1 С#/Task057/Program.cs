// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] CreateMatrixRndInt(int rows, int colomns, int min, int max) //создание и заполнение массива случайными элементами
{
    int [,] matrix = new int[rows, colomns]; // новое место памяти для массива
    Random rnd = new Random(); // новое место памяти для элемента класса Random
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = rnd.Next(min, max + 1);
    }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)// вывод массива в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
 
    Console.Write("["); //вывод массива на экран в [скобках]
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, "); // вывод эл-ов массива через запятую
        else Console.Write($"{matrix[i, j], 4} "); // обратиться к последнему элементу массива array[^1]
    }
    Console.WriteLine("]");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int [] array = new int[matrix.Length]; //int size = matrix.GetLength(0) * matrix.GetLength(1);
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        } 
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

void CountDictionary(int [] array)
{
    int count = 1;
    int num = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == num) count++;
        else
        {
            Console.WriteLine($"Количество чисел {num} = {count}");
            count = 1; // обнуляем счетчик, чтобы заново начать отсчет чисел
            num = array[i];
        }
    }
    Console.WriteLine($"Количество чисел {num} = {count}");
}

// int[,] CreateDictionaryFromArray(int[] array)
// {
// int[,] dictionary = new int [array.Length, 2];
// int countNumbers = array[0];
// dictionary[0, 0] = countNumbers;
// dictionary[0, 1] = 0;
// int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == countNumbers)
//         {
//             dictionary[count, 1] ++;
//         }
//         else
//         {
//             count ++;
//             dictionary[count, 0] = array[i];
//             dictionary[count, 1] ++;
//             countNumbers = array[i];
//         }
//     }
//     return dictionary;
// }


int[,] arr2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();
int[] arr = MatrixToArray(arr2D);
Array.Sort(arr);
PrintArray(arr);
CountDictionary(arr);
// int[,] dictionaryFromArray = CreateDictionaryFromArray(arr);
// PrintMatrix(dictionaryFromArray);

