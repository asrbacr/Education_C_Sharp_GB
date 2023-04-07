// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int lang = 4;
int[,] array = new int[lang, lang];
ArraySpiral(array, lang);
PrintArray(array);

void ArraySpiral(int[,] array, int n)
{
    /*if (n % 2 != 0) //тут я планирую исправить вывод нечётного числа.
    {
        array[array.GetLength(0) / 2 + 1, array.GetLength(1) / 2 + 1] = n * n;
        Console.WriteLine(array[array.GetLength(0) / 2 + 1, array.GetLength(1) / 2 + 1]);
    }*/
    int i = 0, j = 0;
    int value = 1;
    for (int l = 0; l < n * n; l++)
    {
        int k = 0;
        do { array[i, j++] = value++; }
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
