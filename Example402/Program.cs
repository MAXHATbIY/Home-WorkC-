// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

// заполнение массива
int[] array = GetArray(15, 1, 10);
Console.Write("[ ");
Console.Write(String.Join(" ", array));
Console.Write(" ]");


// переменная для подсчета элементов
int sum = GetSumOddPositions(array);
Console.WriteLine($" сумма элементов стоящих на нечетных позициях  -> {sum}");


// генерируем массив
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

// считаем элементы стоящие на нечетных позициях
int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
