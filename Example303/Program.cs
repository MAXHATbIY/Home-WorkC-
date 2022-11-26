// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = new int[8];
FillUserArray(array);
PrintArray(array);

// заполняем массив
void FillUserArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");  
    }
}

// Печатаем массив
void PrintArray(int[] col)
{
    //выводим по одному элементу последовательно

    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{col[i]}"); 
    }
    Console.Write(" ]");
}

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