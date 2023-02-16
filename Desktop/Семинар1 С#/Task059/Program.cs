// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая 
// удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.
// Например, задан массив: Наименьший элемент - 1, на выходе получим следующий массив:
// 1 4 7 2                     9 2 3
// 5 9 2 3                     4 2 4
// 8 4 2 4                     2 6 7
// 5 2 6 7





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

(int row, int column, int minValue) IndexMinValue(int[,] matrix) //кортежи
{
    int minValueRow = 0;
    int minValueColumn = 0;
    int minValue = matrix[0,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(minValue > matrix[i, j])
            {
                minValue = matrix[i, j];
                minValueRow = i;
                minValueColumn = j;

            }
        }
    }
    return (minValueRow, minValueColumn, minValue);
}

int[,] RemoveCrossRowColumn(int[,] matrix, int iMin, int jMin)
{
    int[,] resultMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1) - 1];
    int m = 0; //счетчики для прохождения по строкам и столбцам исходного массива
    int n = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        if(m == iMin) m++;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if(n == jMin) n++;
            resultMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0; //обнуляем n для новой матрицы, чтобы проходить по всем m n
    }
    return resultMatrix;
}

int[,] arr2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(arr2D);
Console.WriteLine();
var indexMinValue = IndexMinValue(arr2D);
Console.WriteLine(indexMinValue.row + "\n" + indexMinValue.column + "\n" + indexMinValue.minValue);// "\n" перевод на след.строку
int[,] resMatrix = RemoveCrossRowColumn(arr2D,  indexMinValue.row, indexMinValue.column);
PrintMatrix(resMatrix);