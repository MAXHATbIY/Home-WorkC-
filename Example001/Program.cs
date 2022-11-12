//Получаем стороку, содержащую число
Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

//преобразуем строку в число
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

if(number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else if (number1 < number2)
{
    Console.WriteLine($"max = {number2}");
}
else
{
    Console.WriteLine($"Число {number1} равно числу {number2}");
}