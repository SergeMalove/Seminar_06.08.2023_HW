// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int number)
{
    return number % 100 / 10;
}

System.Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Вторая цифра числа {num}: {SecondDigit(num)}");