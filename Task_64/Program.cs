// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Введите число до которого будем считать от 1-ого: ");
int n = UserInput();
PrintNumber(1, n);

//____func 

void PrintNumber(int M, int N)
{
    if (M > N)
    {
        PrintNumber(M - 1, N);
        Console.Write($", {M}");
    }
    else if (M < N)
    {
        PrintNumber(M, N - 1);
        Console.Write($", {N}");
    }
    else if (M == N)
    {
        Console.Write($"{M}");
    }
}

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");
    return number;
}
