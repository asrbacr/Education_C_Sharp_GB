// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


//___code

Console.Write("Сколько эл-ов будет в массиве: ");
int M = UserInput();

int[] Array = FillArray(M);

int Res = CountPositiv(Array);

Console.Write("В массиве "); PrintArray(Array);
if (Res > 0)
    Console.Write($" -> {Res} элементов больше 0.");
else
    System.Console.Write(" -> нет элементов больше 0.");



//____funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

int[] FillArray(int a)
{
    int[] AddNumbArrya = new int[a];
    for (int i = 0; i < AddNumbArrya.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент: ");
        AddNumbArrya[i] = UserInput();
    }
    return AddNumbArrya;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    System.Console.Write("[");

    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write(arr[arr.Length - 1]);
    // Console.WriteLine();
    System.Console.Write("]");
}

int CountPositiv(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
