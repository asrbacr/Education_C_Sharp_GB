// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели для определения является ли это день выходным: ");
if (int.TryParse(Console.ReadLine(), out int NumDayWeek))
    ;
else
    Console.WriteLine("Введено не число");

if (NumDayWeek <= 7)
{
    if (NumDayWeek == 6 || NumDayWeek == 7)
        Console.WriteLine("Да, это выходной день.");
    else
        Console.WriteLine("Нет, это не выходной.");
}
else
    Console.WriteLine("К сожалению, на неделе всего 7 дней.");
