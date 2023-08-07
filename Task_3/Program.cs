// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void IsItWeekEnd(int number)
{
    if (0 < number && number < 6)
    {
        System.Console.WriteLine("День недели под введённым номером НЕ является выходным");
    }
    else if (5 < number && number < 8)
    {
        System.Console.WriteLine("День недели по введенным номером выходной");
    }
    else
    {
        System.Console.WriteLine("Введен неправильный номер дня недели");
    }
}

System.Console.Write("Введите номер дня недели: ");
int numberDayOfTheWeek = int.Parse(Console.ReadLine());
IsItWeekEnd(numberDayOfTheWeek);