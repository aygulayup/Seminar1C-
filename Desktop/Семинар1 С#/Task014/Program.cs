// Напишите программу, которая принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 8 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"{number} -> да");
// }
// else
// {
//     Console.WriteLine($"{number} -> нет");
// }

Console.WriteLine(DevTwoNum(number) ? "да" : "нет");
bool DevTwoNum(int num)
{
    num % 7 == 0 && num % 23 == 0;

}

