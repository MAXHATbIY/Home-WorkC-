//Получаем стороку, содержащую число
Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

//преобразуем строку в число
int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;

Console.Write("max = ");
Console.WriteLine(max);
