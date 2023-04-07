// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = GenerateArray(3, 3, 1, 9);
int[,] array2 = GenerateArray(3, 3, 1, 9);

PrintArray2D(array1);
System.Console.WriteLine();
PrintArray2D(array2);
System.Console.WriteLine();

int[,] productArray = ProductArray(array1, array2);
PrintArray2D(productArray);



//______FUNC

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

int[,] ProductArray(int[,] array1, int[,] array2)
{
    int[,] arraySum = new int[array2.GetLength(0), array2.GetLength(1)];

    if (array1.GetLength(0) == array2.GetLength(1) && array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                arraySum[i, j] = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    arraySum[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    return arraySum;
}
