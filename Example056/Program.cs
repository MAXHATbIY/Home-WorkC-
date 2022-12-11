// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[] minSum = FindRowWithMinElementSum(array, 10);
Console.WriteLine($"Минимальная сумма элементов {minSum[0]} содержится в {minSum[1]}-й строке");

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

int[] FindRowWithMinElementSum(int[,] array, int maxValue)
{
    int[] result = new int[2];   // 0 элемент - значение суммы, 1 элемент - номер строки
    int rowSum = 0;
    result[0] = maxValue * array.GetLength(1);   // в значение минимальной суммы записываем максимально возможное для данного массива число
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < result[0]) 
        {
            result[0] = rowSum;
            result[1] = i;
        }
        rowSum = 0;
    }
    return result;
}