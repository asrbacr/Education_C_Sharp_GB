// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число, а программа выведет таблицу кубов чисел от 1 до введённого вами: ");
int a = UserInput();
Console.Write($"Таблица кубов числа {a}-> ");
TryTable(a);


//_____ Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

void TryTable(int N)
{
    int count = 1;
    if (N < 0)
        N *= (-1);

    while (count <= N - 1)
    {
        Console.Write(count * count * count + ", ");
        count++;
    }
    Console.Write(count * count * count);
}