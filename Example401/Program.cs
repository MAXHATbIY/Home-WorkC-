// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

// заполнение массива
int[] array = GetArray(15, 100, 1000);
Console.Write("[ ");
Console.Write(String.Join(" ", array));
Console.Write(" ]");


// переменная для подсчета четных чисел
int evenNum = CountEvenNumbers(array);
Console.WriteLine($" количество четных чисел -> {evenNum}");


// генерируем массив случайными числами
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


// Считаем четные числа
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if(el % 2 == 0) count += 1;
    }
    return count;
}








