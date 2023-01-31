// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 4 49 2
// 5 9 2 3
// 6 4 4 44

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
        if(i <= matrix.GetLength(1)) Console.Write($"{matrix[i, j], 4}, "); // вывод эл-ов массива через запятую
        //else Console.Write($"{matrix[i, j], 4} "); // обратиться к последнему элементу массива array[^1]
    }
    Console.WriteLine("]");
    }
}

int[,] NewMatrix(int [,] matrix, int rows, int colomns) // копирование массива с заменой элементов
{
    int [,] newMatrix = new int[rows, colomns]; // новое место памяти для массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0) newMatrix[i, j] = matrix[i, j] * matrix[i, j];
        else newMatrix[i, j] = matrix[i, j];
        
    }
    }
    
    return newMatrix;
}

int row = 6;
int clmn = 5;
int[,] arr2D = CreateMatrixRndInt(row, clmn, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();
int[,] newArr = NewMatrix(arr2D, row, clmn);
PrintMatrix(newArr);
