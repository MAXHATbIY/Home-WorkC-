// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите номер строки: ");
int userRowsNum = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца: ");
int userColumnsNum = int.Parse(Console.ReadLine() ?? "");
FindNumberInArray(array, userRowsNum, userColumnsNum);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumberInArray(int[,] array, int rows, int columns)
{
    if(rows > array.GetLength(0) - 1 || columns > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такой позиции нет в массиве");
        
        if (rows > -1)
        {
            FindNumberInArray(array, rows, columns);
        }
    }
    else Console.WriteLine($"Число на позиции {rows}, {columns} -> {array[rows, columns]}");    
}


