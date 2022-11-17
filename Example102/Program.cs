// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int number = new Random().Next(10, 1000);
int count = number.ToString().Length; // так определяем длинну числа
int a = number % 10;
if (count == 3)
{
    Console.WriteLine($"В числе: {number} -> третья цифра: {a}");
}
else
{
    Console.WriteLine($"В числе: {number} -> третьей цифры нет");
}
