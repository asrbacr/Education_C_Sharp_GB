// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёх-значное число, а программа выведет цифру разряд десятков: ");
if (int.TryParse(Console.ReadLine(), out int ThreeDigitNumber))
    ;
else
    Console.WriteLine("Введено не верное число");

if (ThreeDigitNumber / 1000 == 0 && ThreeDigitNumber / 100 > 0)
{
    int SredNumber = ThreeDigitNumber % 100 / 10;
    Console.WriteLine("Цифра разряда десятков числа " + ThreeDigitNumber + " это: " + SredNumber);
}
else
    Console.WriteLine("Ошибка, число которое вы ввели не трёх-значное.");
