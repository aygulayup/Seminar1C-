// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 01123
// Если N = 3 -> 011
// Если N = 7 -> 0112358

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FibArray(int size) // создание нового массива
{
    int [] array = new int[size]; // новое место памяти для массива
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

int number = InsertDigit("Введите число: ");
int[] arr = FibArray(number);
PrintArray(arr);