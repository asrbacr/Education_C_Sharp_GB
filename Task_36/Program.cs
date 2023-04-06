// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.Write("Сколько элементов будет в массиве: ");
int a = UserInput();
Console.Write("Введите минимальное значение массива: ");
int min = UserInput();
Console.Write("Введите максимальное значение массива: ");
int max = UserInput();


int[] arrayNew = GenArray(a, min, max);
Console.Write($"В массиве [");
PrintArray(arrayNew);
Console.Write($"], сумма элементов, стоящих на нечётных позициях -> {FuncSummOdd(arrayNew)}");


// _________Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

int[] GenArray(int a, int min, int max)
{
    if (max < min) //я решил вынести проверку мин и макс в формулу, чтобы не писать её каждый раз
    {
        int b = max;
        max = min;
        min = b;
    }
    int[] RandomArray = new int[a];
    int count = 0;
    for (int i = 0; i < RandomArray.Length; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1);
        if (RandomArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return RandomArray;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write(arr[arr.Length - 1]);
    // Console.WriteLine();
}

int FuncSummOdd(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        res += array[i];
    }
    return res;
}
