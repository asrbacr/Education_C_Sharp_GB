// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Задача на проверку большего числа среди 3-ух");
Console.Write("Введите первое число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int maxb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int maxc = Convert.ToInt32(Console.ReadLine());

if (max < maxb)
{
    max = maxb;
}
if (max < maxc)
{
    max = maxc;
}
Console.WriteLine("Максимальное число " + max);
