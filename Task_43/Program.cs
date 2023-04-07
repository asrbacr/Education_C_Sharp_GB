// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//___cod

System.Console.WriteLine("Задача найдёт точку пересечения двух прямых.");
System.Console.Write("Введите значение b1: ");
int b1 = UserInput();
System.Console.Write("Введите значение k1: ");
int k1 = UserInput();
System.Console.Write("Введите значение b2: ");
int b2 = UserInput();
System.Console.Write("Введите значение k2: ");
int k2 = UserInput();

var x = IntersectionValue(b1: b1, k1: k1, b2: b2, k2: k2);

// На семинаре показали как вывести несколько значений из одной функции.
Console.WriteLine($"Точка пересечения имеет координаты ({x.Item1.ToString("0.###")}, {x.Item2.ToString("0.###")})");

//___func

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

// Ну да мне было интересно как это сделать, поэтому я спросил.
(double, double) IntersectionValue(double k1, double k2, double b1, double b2) 
{
    return (((b2 - b1) / (k1 - k2)), (k2 * (b2 - b1) / (k1 - k2) + b2));
}
