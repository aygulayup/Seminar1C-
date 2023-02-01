// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа 
// должна вывести сообщение для пользователя.

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

void ReplaseRowsColomns(int[,] matrix)
{
    int count = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            count = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = count;
        }
    }
}

int[,] arr2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();
if(arr2D.GetLength(0) == arr2D.GetLength(1))
{
    ReplaseRowsColomns(arr2D);
    PrintMatrix(arr2D);
}
else
{
    Console.WriteLine("Замена строк на столбцы невозможна");
}

