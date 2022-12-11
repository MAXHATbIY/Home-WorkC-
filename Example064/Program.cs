// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int start = UserInput("Введите целое число  N: ", "Ошибка!");

string result  = Numbers(start, 1);

Console.WriteLine(result);

//==============Методы
 //Ввод данных
int UserInput(string message, string errorMessage)
{    
     while(true)
    {
        Console.Write(message);
        if( (int.TryParse(Console.ReadLine(), out int userNumber))&& userNumber>0)

            return userNumber;
        Console.WriteLine(errorMessage);
     } 
}

//Вывод чисел рекурсией
string Numbers(int start, int finish)
{
    if (start==finish)
    return start.ToString();

    return start + " " + Numbers(start - 1, finish);

}