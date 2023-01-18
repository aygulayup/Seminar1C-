// Задача 28: Напишите программу, 
// 1. которая принимает на вход число N и 
// 2. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Недоделана задача, если пользователь введет отриц.значение

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int MultipleNumbers(int number) 
{
    int multiple = 1;
    for (int i = 1; i <= number; i++)
    {
        multiple = multiple * i;
    }
    return multiple;
}

int userNumber = InsertDigit("Введите число: ");
int multipleNumbers = MultipleNumbers(userNumber);

Console.WriteLine($"{userNumber} -> {multipleNumbers}");
