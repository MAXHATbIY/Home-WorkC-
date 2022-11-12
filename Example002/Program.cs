// Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел

Console.Write("введите первое целое число: ");
string userInput1 = Console.ReadLine() ?? "";

Console.Write("введите второе целое число: ");
string userInput2 = Console.ReadLine() ?? "";

Console.Write("введите третье целое число: ");
string userInput3 = Console.ReadLine() ?? "";

int number1 = int.Parse(userInput1);
int number2 = int.Parse(userInput2);
int number3 = int.Parse(userInput3);

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"{number1}, {number2}, {number3} -> max = {max}");