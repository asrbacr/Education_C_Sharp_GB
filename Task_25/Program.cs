// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число, которое будем возводить в степень: ");
int a = UserInput();
if (a == 0)
{
    Console.WriteLine("Если 0 возводить в степень, то будет получаться всегда 0.");
    Console.WriteLine("Дальнейшее выполнение не целесообразно.");
}
Console.Write($"Введите степерь в которую будем возводить число {a}: ");
int b = UserInput();
if (b < 0)
{
    Console.WriteLine("Я ещё не достиг уровня отображения степени из отрицательного числа, но обязательно буду стараться.");
    Console.WriteLine("Выполнение программы прервано.");
}
Console.WriteLine($"Ответ: {a} ^ {b} = {PowNumber(a, b).ToString("### ### ### ###")}");


// _________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

int PowNumber(int Num, int Degree)
{
    int res = 1;
    for (int i = 1; i <= Degree; i++)
    {
        res *= Num;
    }
    return res;
}
