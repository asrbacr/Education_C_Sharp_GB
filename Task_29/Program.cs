// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]

Console.Write("Введите значение сколько элементов будет в массиве: ");
int N = UserInput();
if (N < 0)
{
    Console.WriteLine("Нельзя чтобы значение было отрицательным");
}
else if (N == 0)
{
    Console.WriteLine("Ну тогда массив будет выглядеть []");
}

int[] array = new int[N];
Console.Write("Введите нижнее значение массива: ");
int min = UserInput();
Console.Write("Введите верхнее значение массива: ");
int max = UserInput();
if (max < min)
{
    int i = max;
    max = min;
    min = i;
}
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(min, max + 1);
}
Console.Write($"[{String.Join(",", array)}]\n");


// _________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}