// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//___cod

int[,] array = GenerateArray(4, 4, 0, 8);
PrintArray2D(array);

double[] arr = AverColumnArray(array);
System.Console.Write("Средние значения столбцов: ");
PrintArray(arr);

//___func

void PrintArray2D(int[,] array) //вывод
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void PrintArray(double[] array) //вывод
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("####.###") + " ");
    }
}

int[,] GenerateArray(int m, int n, int min, int max) //генерация
{
    int[,] arrNum = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < arrNum.GetLength(0); i++)
    {
        for (int j = 0; j < arrNum.GetLength(1); j++)
        {
            arrNum[i, j] = random.Next(min, max + 1);
        }
    }
    return arrNum;
}

double[] AverColumnArray(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double SredNumbs = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SredNumbs += array[i, j];
        }
        newArray[j] = SredNumbs / (array.GetLength(1));
    }
    return newArray;
}
