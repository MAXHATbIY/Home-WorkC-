// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int digitsSum = GetDigitsSum(num);
Console.WriteLine($"{num} -> {digitsSum}");

/////////////////////////////////

int GetDigitsSum(int num)
{
    int total = 0;
    do
    {
        total += num % 10;
        num /= 10;
    }
    while(num != 0);
    return total;
}





///////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}