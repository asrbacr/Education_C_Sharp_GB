// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число, что бы посчитать сумму чисел: ");
int a = UserInput();
Console.Write($"Сумма цифр числа {a} ");
if (a < 0)
    a *= (-1);
Console.Write($"-> {SumNumber(a)}");


// _________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

int SumNumber(int Num)
{
    double res = 0;
    for (int i = 0; Num > 0; i++)
    {
        res += Num % 10;
        Num /= 10;
    }
    return (int)res;
}
