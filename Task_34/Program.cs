// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.Write("Сколько элементов будет в массиве: ");
int a = UserInput();
int[] arrayNew = GenArray(a, 100, 999); //тут макс указано 999, потому что в функции идёт max+1
int resultSerch = FuncSerch(arrayNew);
Console.Write($"В массиве [");
PrintArray(arrayNew);
Console.Write($"], четный элементов -> {resultSerch}");


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

int FuncSerch(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
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
