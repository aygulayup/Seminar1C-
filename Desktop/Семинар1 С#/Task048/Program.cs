// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0123
// 1234
// 2345

int[,] CreateMatrixRndInt(int rows, int colomns) 
{
    int [,] matrix = new int[rows, colomns]; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i +j;
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
        if(i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, "); // вывод эл-ов массива через запятую
        else Console.Write($"{matrix[i, j], 4} "); // обратиться к последнему элементу массива array[^1]
    }
    Console.WriteLine("]");
    }
}
int[,] arr2D = CreateMatrixRndInt(3, 4);
PrintMatrix(arr2D);