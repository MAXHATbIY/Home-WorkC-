//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int num1 = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите второе целое число: ", "Ошибка ввода!");
int result = GetNaturalPowerNumbers(num1, num2);
Console.WriteLine($"{num1}, {num2} -> {result}");

///////////////////////

int GetNaturalPowerNumbers(int num1, int num2)
{
    int product = 1;
    for(int i = 0; i < num2; i++)
    product *= num1;
    return product;
}

///////////////////////////////////////////////

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        else 
            Console.WriteLine(errorMessage);
    }
}