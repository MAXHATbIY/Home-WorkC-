
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int num = GetNumberFromUser("Введите длинну массива: ", "Ошибка ввода!");
int posNum = CountPositiveNumbers(num);
Console.WriteLine($"Количество положительных чисел -> {posNum}");


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

int CountPositiveNumbers(int num)
{
    int count = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = GetNumberFromUser("Введите число: ", "Ошибка Ввода!");
        if(array[i] > 0)
        count++;
    }
    Console.Write("[ ");
    Console.Write(string.Join(" ", array));
    Console.Write(" ] ");
    return count;
}