// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double x1 , x2, y1, y2, z1, z2;
 
x1 = UserCoord("Введите координату x1: ");   //UserCoord();
x2 = UserCoord("Введите координату x2: ");
y1 = UserCoord("Введите координату y1: ");
y2 = UserCoord("Введите координату y2: ");
z1 = UserCoord("Введите координату z1: ");
z2 = UserCoord("Введите координату z2: ");
 
Double distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2)); // Math.Sqrt () – математическая функция которая извлекает квадратный корень.
// В аргументных скобках указывается значение числа, из которого нужно извлечь квадратный корень. 
//Math.Pow () – возведения числа в степень. В аргументных скобках через запятую указываются два аргумента
// (1-ый аргумент - число, которое возводим в степень, 2-ой – степень, в которую возводим число).
distance = Math.Round(distance, 2); // Округление числа, Math.Round(число, количество знаков после запятой);
Console.WriteLine($"Расстояние = {distance}");
 
static double UserCoord (string message)
{
    Console.Write(message);
    try
    {
        return double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}
