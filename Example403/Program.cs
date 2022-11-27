// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int arraySize = new Random().Next(3, 15);
// заполнение массива
double[] array = GetArray(arraySize, 0, 100);
Console.Write("[ ");
Console.Write(String.Join(" ", array));
Console.Write(" ]");


// переменная для вычисления разности между максимальным и минимальным элементом
double diff = GetMaxMinDifference(array);
Console.WriteLine($" -> {diff}");


// генерируем массив случайными числами
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}


// Вычисляем разность между макс и мин
double GetMaxMinDifference(double[] array)
{
    double diff;
    double max = array[0];
    double min = array[0];
    foreach (double el in array)
    {
        if(el >= max) max = el;
        else if (el <= min) min = el;
    }
    diff = max - min;
    return diff;
}







