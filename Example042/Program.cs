// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double b1 = GetNumberFromUser("Введите Значение b1: ","Ошибка ввода!");
double k1 = GetNumberFromUser("Введите Значение k1: ","Ошибка ввода!");
double b2 = GetNumberFromUser("Введите Значение b2: ","Ошибка ввода!");
double k2 = GetNumberFromUser("Введите Значение k2: ","Ошибка ввода!");

double X = (-b2 + b1)/(-k1 + k2);
double Y = k2 * X + b2;

Console.WriteLine($"Координаты точки пересечения двух прямых: X = {X}, Y = {Y}");

double GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}
