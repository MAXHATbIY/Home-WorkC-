// Напишите программу, которая на вход принимает
// число(N), а на выходе показывает все четные числа от 1 до N

Console.Write("введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int number = int.Parse(userInput);

int count = 1;

while(count < number)
{
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}