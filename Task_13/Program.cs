// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число для определения 3 символа: ");
if (int.TryParse(Console.ReadLine(), out int NumericForNumber))
    ;
else
    Console.WriteLine("Введено не число");

if (NumericForNumber / 100 <= 0)
    Console.WriteLine("Третьей цифры нет.");
else
{
    Console.WriteLine(
        "Третий символ числа "
            + NumericForNumber
            + " это: "
            + (int)(
                (NumericForNumber) / (Math.Pow(10, (NumericForNumber.ToString().Count()) - 3)) % 10
            )
    );
}
