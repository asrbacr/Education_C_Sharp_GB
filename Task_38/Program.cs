// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.Write("Сколько элементов будет в массиве: ");
int a = UserInput();
// Console.Write("Введите максимальный элемент массива: ");
// int b = UserInput();
// if (b <= 0)
// {
//     Console.WriteLine("Ошибка, число не может быть меньше или равно 0, по условию задачи требуется массив из вещественных чисел.");
//     break;
// }
// int[] array = GenArray(a, 0, b);

int[] array = FillArray(a);
Console.Write("В массиве [");
PrintArray(array);
Console.Write($"] максимальный элемент {SerchMax(array)}, {SerchMin(array)} разница между ними равна {SerchMax(array) - SerchMin(array)}");


// _________Funcs

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

    for (int i = 0; i < count - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    System.Console.Write(arr[arr.Length - 1]);
    // Console.WriteLine();
}

int SerchMax(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

int SerchMin(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}
