// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void ThirdDigit(int number)
{
    if (number > -100 && number < 100)
    {
        System.Console.WriteLine($"В числе {number} третьей цифры нет");
        return;
    }
    else
    {
        System.Console.Write($"Третья цифра числа {number}: ");
        while (number > 1000)
        {
            number /= 10;
        }
    }
    System.Console.WriteLine(Math.Abs(number % 100 % 10));
}

System.Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
ThirdDigit(num);