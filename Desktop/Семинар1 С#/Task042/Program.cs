// Задача 42: Напишите программу, 
// которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int InsertDigit(string text) //Метод пользовательского ввода
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ParseIn2(int num)
{
    int result = 0;
    while (num  > 0)
    {
        result = num % 2 + result * 10; // *10 чтобы цифры двоичного числа сразу вставали на свое место и не пришлось разворачивать число
        num = num / 2;
    }
    return result;
}

int number = InsertDigit("Введите число: ");
Console.WriteLine(ParseIn2(number));
