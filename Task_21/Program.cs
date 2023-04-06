// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1, y1, z1, x2, y2, z2;
Console.Write("Введите значение X для 1 точки: ");
x1 = UserInput();
Console.Write("Введите значение Y для 1 точки: ");
y1 = UserInput();
Console.Write("Введите значение Z для 1 точки: ");
z1 = UserInput();
Console.Write("Введите значение X для 2 точки: ");
x2 = UserInput();
Console.Write("Введите значение Y для 2 точки: ");
y2 = UserInput();
Console.Write("Введите значение Z для 2 точки: ");
z2 = UserInput();
Console.Write($"Расстояние между точками А ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> ");
double res = Distance(x1, y1, z1, x2, y2, z2);
Console.Write(res.ToString("0.##"));

//_____ Funcs

int UserInput()
{
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
        Console.Write("Вы ввели не число. Повторите ввод: ");

    return number;
}

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
