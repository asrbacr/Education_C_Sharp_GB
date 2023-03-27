// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Задача для проверки является ли число чётным");
Console.Write("Введите число для проверки: ");
int ValueToCheck = Convert.ToInt32(Console.ReadLine());

if (ValueToCheck % 2 == 0)
{
    Console.WriteLine("Да, " + ValueToCheck + " - число чётное.");
}
else
{
    Console.WriteLine("Нет, " + ValueToCheck + " - число нечётное.");
}
