// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ArrayRowBubbleSort(array);
PrintArray(array);

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

// Пузырьковая сортировка

int[] BubbleSort(int[] array)
{
    int temp;
    int count = 0; // нужно оптимизировать метод, вводим счетчик
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if(array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                count++;
            }
        }
        if(count == 0) break;
        count = 0;
    }
    return array;
}

// пузырьковая сортировка строк внутри двумерного массива

void ArrayRowBubbleSort(int[,] array)
{
   int[] sortedRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedRow[j] = array[i,  j];   // делаем одномерный массив-копию строки
        }
        sortedRow = BubbleSort(sortedRow);   // сортируем одномерный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,  j] = sortedRow[j];   // обновляем строку в исходном массиве
        }
    } 
}
